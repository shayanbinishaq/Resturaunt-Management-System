using System;
using System.Data;
using System.Windows.Forms;
using System.ComponentModel;
using Microsoft.Data.Sqlite;

namespace RMS.AllUserControls
{
    public partial class UC_update_items : UserControl
    {
        private readonly string connectionString = DatabaseHelper.ConnectionString;

        private string? idColumnName;
        private string? nameColumnName;

        public UC_update_items()
        {
            InitializeComponent();

            this.Load += UC_update_items_Load;
            item_name.TextChanged += item_name_TextChanged;
            dataGridView1.CellClick += dataGridView1_CellClick;
            button1.Click += button1_Click;
        }

        private void UC_update_items_Load(object sender, EventArgs e)
        {
            LoadItems();
        }

        private void LoadItems(string nameFilter = "")
        {
            // Prevent DB work when in the Visual Studio designer
            if (DatabaseHelper.IsDesignMode) return;

            try
            {
                using (var con = new SqliteConnection(connectionString))
                {
                    con.Open();

                    string baseQuery = "SELECT * FROM items";
                    DataTable dt = new DataTable();

                    if (!string.IsNullOrWhiteSpace(nameFilter))
                    {
                        using (var schemaCmd = new SqliteCommand("SELECT * FROM items LIMIT 0", con))
                        using (var reader = schemaCmd.ExecuteReader())
                        {
                            dt.Load(reader);
                        }

                        nameColumnName = DetectNameColumn(dt);

                        if (!string.IsNullOrEmpty(nameColumnName))
                        {
                            string query = $"SELECT * FROM items WHERE \"{nameColumnName}\" LIKE @search";
                            using (var cmd = new SqliteCommand(query, con))
                            {
                                cmd.Parameters.AddWithValue("@search", "%" + nameFilter + "%");
                                using (var reader = cmd.ExecuteReader())
                                {
                                    dt = new DataTable();
                                    dt.Load(reader);
                                }
                            }
                        }
                        else
                        {
                            using (var cmd = new SqliteCommand(baseQuery, con))
                            using (var reader = cmd.ExecuteReader())
                            {
                                dt = new DataTable();
                                dt.Load(reader);
                            }
                        }
                    }
                    else
                    {
                        using (var cmd = new SqliteCommand(baseQuery, con))
                        using (var reader = cmd.ExecuteReader())
                        {
                            dt = new DataTable();
                            dt.Load(reader);
                        }
                    }

                    dataGridView1.DataSource = dt;

                    idColumnName = DetectIdColumn(dt);

                    if (!string.IsNullOrEmpty(idColumnName) && dataGridView1.Columns.Contains(idColumnName))
                    {
                        dataGridView1.Columns[idColumnName].Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static string? DetectIdColumn(DataTable dt)
        {
            if (dt == null) return null;

            foreach (DataColumn col in dt.Columns)
            {
                string name = col.ColumnName.ToLower();
                if (name == "id") return col.ColumnName;
            }

            foreach (DataColumn col in dt.Columns)
            {
                string name = col.ColumnName.ToLower();
                if (name.EndsWith("id") || name.Contains("_id") || name.Contains("id"))
                {
                    if (col.DataType == typeof(int) || col.DataType == typeof(long) || col.DataType == typeof(short))
                        return col.ColumnName;
                }
            }

            foreach (DataColumn col in dt.Columns)
            {
                if (col.DataType == typeof(int) || col.DataType == typeof(long) || col.DataType == typeof(short))
                    return col.ColumnName;
            }

            return null;
        }

        private static string? DetectNameColumn(DataTable dt)
        {
            if (dt == null) return null;

            string[] candidates = { "i_name", "name", "itemname", "item_name", "title" };
            foreach (var c in candidates)
            {
                foreach (DataColumn col in dt.Columns)
                {
                    if (string.Equals(col.ColumnName, c, StringComparison.OrdinalIgnoreCase))
                        return col.ColumnName;
                }
            }

            foreach (DataColumn col in dt.Columns)
            {
                if (col.DataType == typeof(string))
                    return col.ColumnName;
            }

            return null;
        }

        private void item_name_TextChanged(object sender, EventArgs e)
        {
            LoadItems(item_name.Text.Trim());
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var row = dataGridView1.Rows[e.RowIndex];
            if (row == null) return;

            try
            {
                if (!string.IsNullOrEmpty(nameColumnName) && dataGridView1.Columns.Contains(nameColumnName))
                {
                    var idx = dataGridView1.Columns[nameColumnName].Index;
                    if (row.Cells[idx].Value != null)
                        item.Text = row.Cells[idx].Value.ToString();
                }
                else if (row.Cells.Count >= 2 && row.Cells[1].Value != null)
                {
                    item.Text = row.Cells[1].Value.ToString();
                }

                if (dataGridView1.Columns.Contains("Category"))
                {
                    var idxCat = dataGridView1.Columns["Category"].Index;
                    if (row.Cells[idxCat].Value != null)
                    {
                        var cat = row.Cells[idxCat].Value.ToString();
                        if (!string.IsNullOrEmpty(cat) && Combo_category.Items.Contains(cat))
                            Combo_category.Text = cat;
                        else
                            Combo_category.SelectedIndex = -1;
                    }
                }

                if (dataGridView1.Columns.Contains("Price"))
                {
                    var idxPrice = dataGridView1.Columns["Price"].Index;
                    if (row.Cells[idxPrice].Value != null)
                        price.Text = row.Cells[idxPrice].Value.ToString();
                }
                else if (row.Cells.Count >= 4 && row.Cells[3].Value != null)
                    price.Text = row.Cells[3].Value.ToString();
            }
            catch
            {
                // ignore
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(item.Text) ||
                string.IsNullOrWhiteSpace(price.Text) ||
                Combo_category.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill in all fields.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(price.Text.Trim(), out int parsedPrice) || parsedPrice < 0)
            {
                MessageBox.Show("Please enter a valid non-negative integer for price.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Please select an item from the list to update.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(idColumnName) || !dataGridView1.Columns.Contains(idColumnName))
            {
                MessageBox.Show("Cannot determine a primary key column for the items table. Update is not possible.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var idIdx = dataGridView1.Columns[idColumnName].Index;
            var idObj = dataGridView1.CurrentRow.Cells[idIdx].Value;
            if (idObj == null)
            {
                MessageBox.Show("Selected item does not have a valid id.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (var con = new SqliteConnection(connectionString))
                {
                    con.Open();
                    string query = $"UPDATE items SET i_name = @name, Category = @category, Price = @price WHERE \"{idColumnName}\" = @id";
                    using (var cmd = new SqliteCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@name", item.Text.Trim());
                        cmd.Parameters.AddWithValue("@category", Combo_category.Text);
                        cmd.Parameters.AddWithValue("@price", parsedPrice);
                        cmd.Parameters.AddWithValue("@id", idObj);

                        int affected = cmd.ExecuteNonQuery();
                        if (affected > 0)
                        {
                            MessageBox.Show("Item updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadItems();
                            item.Clear();
                            price.Clear();
                            Combo_category.SelectedIndex = -1;
                        }
                        else
                        {
                            MessageBox.Show("No rows updated.", "Update", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void item_name_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
