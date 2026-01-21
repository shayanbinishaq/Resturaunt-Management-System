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
    public partial class UC_Add_items : UserControl
    {
        // Use centralized DatabaseHelper connection string
        string connectionString = DatabaseHelper.ConnectionString;
        public UC_Add_items()
        {
            InitializeComponent();
        }

        private void Add_items_Load(object sender, EventArgs e)
        {

        }
        private void Add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(item.Text) ||
                string.IsNullOrWhiteSpace(price.Text) ||
                Combo_category.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            try
            {
                using (SqliteConnection con = new SqliteConnection(connectionString))
                {
                    con.Open();

                    string query = @"INSERT INTO items (i_name, Category, Price)
                                     VALUES (@name, @category, @price)";

                    using (SqliteCommand cmd = new SqliteCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@name", item.Text);
                        cmd.Parameters.AddWithValue("@category", Combo_category.Text);
                        cmd.Parameters.AddWithValue("@price", int.Parse(price.Text));
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Item added successfully!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                item.Clear();
                price.Clear();
                Combo_category.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Database Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

