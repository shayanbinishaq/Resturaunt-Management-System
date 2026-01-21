using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace RMS.AllUserControls
{
    // Partial class extension to add DB connectivity, validation and update logic
    public partial class UC_update_items
    {
        // Use same connection string as UC_Add_items
        private readonly string connectionString = "Server=localhost;Database=RMS;Uid=root;Pwd=shayan@123457";

        private void WireUpEvents()
        {
            this.Load += UC_update_items_Load;
            item_name.TextChanged += item_name_TextChanged;
            dataGridView1.CellClick += dataGridView1_CellClick;
            button1.Click += button1_Click;
        }

        private void UC_update_items_Load(object? sender, EventArgs e)
        {
            LoadItems();
        }

        private void LoadItems(string nameFilter = "")
        {
            try
            {
                using (var con = new MySqlConnection(connectionString))
                {
                    con.Open();
                    string query = "SELECT id, i_name AS ItemName, Category, Price FROM items";
                    if (!string.IsNullOrWhiteSpace(nameFilter))
                        query += " WHERE i_name LIKE @search";

                    using (var cmd = new MySqlCommand(query, con))
                    {
                        if (!string.IsNullOrWhiteSpace(nameFilter))
                            cmd.Parameters.AddWithValue("@search", "%" + nameFilter + "%");

                        using (var adapter = new MySqlDataAdapter(cmd))
                        {
                            var dt = new DataTable();
                            adapter.Fill(dt);
                            dataGridView1.DataSource = dt;

                            if (dataGridView1.Columns.Count > 0)
                                dataGridView1.Columns[0].Visible = false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void item_name_TextChanged(object? sender, EventArgs e)
        {
            LoadItems(item_name.Text.Trim());
        }

        private void dataGridView1_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var row = dataGridView1.Rows[e.RowIndex];
            if (row == null) return;

            try
            {
                if (row.Cells.Count >= 4)
                {
                    if (row.Cells[1].Value != null)
                        item.Text = row.Cells[1].Value.ToString();

                    if (row.Cells[2].Value != null)
                    {
                        var cat = row.Cells[2].Value.ToString();
                        if (!string.IsNullOrEmpty(cat) && Combo_category.Items.Contains(cat))
                            Combo_category.Text = cat;
                        else
                            Combo_category.SelectedIndex = -1;
                    }

                    if (row.Cells[3].Value != null)
                        price.Text = row.Cells[3].Value.ToString();
                }
            }
            catch
            {
                // ignore
            }
        }

        private void button1_Click(object? sender, EventArgs e)
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

            var idObj = dataGridView1.CurrentRow.Cells[0].Value;
            if (idObj == null || !int.TryParse(idObj.ToString(), out int id))
            {
                MessageBox.Show("Selected item does not have a valid id.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (var con = new MySqlConnection(connectionString))
                {
                    con.Open();
                    string query = "UPDATE items SET i_name = @name, Category = @category, Price = @price WHERE id = @id";
                    using (var cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@name", item.Text.Trim());
                        cmd.Parameters.AddWithValue("@category", Combo_category.Text);
                        cmd.Parameters.AddWithValue("@price", parsedPrice);
                        cmd.Parameters.AddWithValue("@id", id);

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
    }
}
