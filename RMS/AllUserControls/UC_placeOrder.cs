using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.Sqlite;

namespace RMS.AllUserControls
{
    public partial class UC_placeOrder : UserControl
    {
        string connectionString = DatabaseHelper.ConnectionString;

        // Cache items loaded for the current category
        private List<string> itemsCache = new List<string>();
        private Dictionary<string, int> priceCache = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);

        public UC_placeOrder()
        {
            InitializeComponent();

            // Wire events not set in designer
            listBox1.SelectedIndexChanged += ListBox1_SelectedIndexChanged;
            Quantity.ValueChanged += Quantity_ValueChanged;
            Add_cart.Click += Add_cart_Click;
            button2.Click += Remove_Click;
            // Print option removed: do not wire button1.Click
        }

        private void UC_placeOrder_Load(object sender, EventArgs e)
        {
            // Optionally load default category items if combo has a selection
            if (combo.Items.Count > 0 && combo.SelectedIndex == -1)
            {
                combo.SelectedIndex = 0;
            }

            // If a category is selected, load its items
            if (combo.SelectedItem != null)
            {
                LoadItemsForCategory(combo.SelectedItem.ToString());
            }
        }

        private void Combo_Category(object sender, EventArgs e)
        {
            if (combo.SelectedItem == null)
                return;

            string category = combo.SelectedItem.ToString();
            LoadItemsForCategory(category);
        }

        private void LoadItemsForCategory(string category)
        {
            // Guard against design-time execution
            if (DatabaseHelper.IsDesignMode) return;

            itemsCache.Clear();
            priceCache.Clear();
            listBox1.Items.Clear();

            try
            {
                using SqliteConnection con = new SqliteConnection(connectionString);
                con.Open();
                using SqliteCommand cmd = new SqliteCommand("SELECT i_name, Price FROM items WHERE Category = @cat", con);
                cmd.Parameters.AddWithValue("@cat", category);
                using SqliteDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string name = reader.GetString(0);
                    int price = 0;
                    try { price = reader.GetInt32(1); } catch { int.TryParse(reader["Price"].ToString(), out price); }
                    itemsCache.Add(name);
                    priceCache[name] = price;
                    listBox1.Items.Add(name);
                }
            }
            catch (Exception ex)
            {
                // If DB fails, keep UI usable and inform developer minimally
                MessageBox.Show("Failed to load items: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void TextBox1_TextChanged(object? sender, EventArgs e)
        {
            // Search feature removed — no-op handler to avoid references to removed control
        }

        private void ListBox1_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null)
                return;

            string name = listBox1.SelectedItem.ToString();
            item_name.Text = name;

            if (priceCache.TryGetValue(name, out int p))
            {
                Price.Text = p.ToString();
            }
            else
            {
                // Fallback: try to query just in case
                try
                {
                    using SqliteConnection con = new SqliteConnection(connectionString);
                    con.Open();
                    using SqliteCommand cmd = new SqliteCommand("SELECT Price FROM items WHERE i_name = @n LIMIT 1", con);
                    cmd.Parameters.AddWithValue("@n", name);
                    object res = cmd.ExecuteScalar();
                    if (res != null && int.TryParse(res.ToString(), out int val))
                    {
                        Price.Text = val.ToString();
                        priceCache[name] = val;
                    }
                }
                catch
                {
                    // ignore
                }
            }

            Quantity.Value = 1;
            UpdateTotal();
        }

        private void Quantity_ValueChanged(object? sender, EventArgs e)
        {
            UpdateTotal();
        }

        private void UpdateTotal()
        {
            if (int.TryParse(Price.Text, out int price))
            {
                int total = price * (int)Quantity.Value;
                Total.Text = total.ToString();
            }
            else
            {
                Total.Text = "0";
            }
        }

        private void Add_cart_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(item_name.Text))
            {
                MessageBox.Show("Please select an item to add.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!int.TryParse(Price.Text, out int price))
            {
                MessageBox.Show("Invalid price value.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int qty = (int)Quantity.Value;
            int total = price * qty;

            dataGridView1.Rows.Add(item_name.Text, price.ToString(), qty.ToString(), total.ToString());
            UpdateGrandTotal();

            // Optionally clear selection
            listBox1.ClearSelected();
            item_name.Clear();
            Price.Clear();
            Quantity.Value = 1;
            Total.Clear();
        }

        private void Remove_Click(object? sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                        dataGridView1.Rows.Remove(row);
                }
                else if (dataGridView1.SelectedCells.Count > 0)
                {
                    int idx = dataGridView1.SelectedCells[0].RowIndex;
                    if (idx >= 0 && idx < dataGridView1.Rows.Count)
                        dataGridView1.Rows.RemoveAt(idx);
                }

                UpdateGrandTotal();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to remove item: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateGrandTotal()
        {
            int grand = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow) continue;
                if (row.Cells.Count >= 4)
                {
                    if (int.TryParse(row.Cells[3].Value?.ToString(), out int r))
                        grand += r;
                }
            }

            label8.Text = "Rs: " + grand.ToString();
        }

        private bool CartHasData()
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (!row.IsNewRow)
                    return true;
            }
            MessageBox.Show(
                "Please add items to cart before printing.",
                "Print Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            );
            return false;
        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
