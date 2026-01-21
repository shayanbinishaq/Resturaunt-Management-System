using System;
using System.Data;
using System.Windows.Forms;
using System.ComponentModel;
using Microsoft.Data.Sqlite;

namespace RMS.AllUserControls
{
    public partial class UC_delete : UserControl
    {
        private readonly string connectionString = DatabaseHelper.ConnectionString;

        private string? idColumnName;
        private string? nameColumnName;

        public UC_delete()
        {
            InitializeComponent();

            this.Load += UC_delete_Load;
            item_name.TextChanged += item_name_TextChanged;
            dataGridView1.CellClick += dataGridView1_CellClick;
            button1.Click += button1_Click;
        }

        private void UC_delete_Load(object sender, EventArgs e)
        {
            LoadItems();
        }

        private void LoadItems(string filter = "")
        {
            // Guard against design-time execution
            if (DatabaseHelper.IsDesignMode) return;

            try
            {
                using var con = new SqliteConnection(connectionString);
                con.Open();

                DataTable dt = new DataTable();

                if (!string.IsNullOrWhiteSpace(filter))
                {
                    using (var schemaCmd = new SqliteCommand("SELECT * FROM items LIMIT 0", con))
                    using (var reader = schemaCmd.ExecuteReader())
                        dt.Load(reader);

                    nameColumnName = DetectNameColumn(dt);

                    if (!string.IsNullOrEmpty(nameColumnName))
                    {
                        string q = $"SELECT * FROM items WHERE \"{nameColumnName}\" LIKE @search";
                        using var cmd = new SqliteCommand(q, con);
                        cmd.Parameters.AddWithValue("@search", "%" + filter + "%");
                        using var reader2 = cmd.ExecuteReader();
                        dt = new DataTable();
                        dt.Load(reader2);
                    }
                    else
                    {
                        using var cmd = new SqliteCommand("SELECT * FROM items", con);
                        using var reader2 = cmd.ExecuteReader();
                        dt = new DataTable();
                        dt.Load(reader2);
                    }
                }
                else
                {
                    using var cmd = new SqliteCommand("SELECT * FROM items", con);
                    using var reader = cmd.ExecuteReader();
                    dt.Load(reader);
                }

                dataGridView1.DataSource = dt;

                idColumnName = DetectIdColumn(dt);
                if (!string.IsNullOrEmpty(idColumnName) && dataGridView1.Columns.Contains(idColumnName))
                    dataGridView1.Columns[idColumnName].Visible = false;
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
                var name = col.ColumnName.ToLower();
                if (name == "id") return col.ColumnName;
            }

            foreach (DataColumn col in dt.Columns)
            {
                var name = col.ColumnName.ToLower();
                if ((name.EndsWith("id") || name.Contains("_id") || name.Contains("id")) &&
                    (col.DataType == typeof(int) || col.DataType == typeof(long) || col.DataType == typeof(short)))
                    return col.ColumnName;
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
            foreach (var cand in candidates)
            {
                foreach (DataColumn col in dt.Columns)
                {
                    if (string.Equals(col.ColumnName, cand, StringComparison.OrdinalIgnoreCase))
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
                        item_name.Text = row.Cells[idx].Value.ToString();
                }
                else if (row.Cells.Count >= 2 && row.Cells[1].Value != null)
                {
                    item_name.Text = row.Cells[1].Value.ToString();
                }
            }
            catch
            {
                // ignore
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Please select an item to delete.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(idColumnName) || !dataGridView1.Columns.Contains(idColumnName))
            {
                MessageBox.Show("Cannot determine primary key column for items table. Delete not possible.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var idIdx = dataGridView1.Columns[idColumnName].Index;
            var idObj = dataGridView1.CurrentRow.Cells[idIdx].Value;
            if (idObj == null)
            {
                MessageBox.Show("Selected item does not have a valid id.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var confirm = MessageBox.Show("Are you sure you want to delete the selected item?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;

            try
            {
                using var con = new SqliteConnection(connectionString);
                con.Open();
                string q = $"DELETE FROM items WHERE \"{idColumnName}\" = @id";
                using var cmd = new SqliteCommand(q, con);
                cmd.Parameters.AddWithValue("@id", idObj);
                int affected = cmd.ExecuteNonQuery();

                if (affected > 0)
                {
                    MessageBox.Show("Item deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadItems();
                }
                else
                {
                    MessageBox.Show("No rows deleted. Item may have been removed already.", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
