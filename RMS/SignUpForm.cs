using Microsoft.Data.Sqlite;

namespace RMS
{
    public partial class SignUpForm : Form
    {
        private bool passwordVisible = false;
        string connectionString = "Data Source=rms.db";
        public SignUpForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            password_box.UseSystemPasswordChar = true;
            passwordVisible = false;
            PBeye.Image = Properties.Resources.eye_closed;
            this.AcceptButton = button2;

            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.AllPaintingInWmPaint |
                          ControlStyles.UserPaint |
                          ControlStyles.OptimizedDoubleBuffer, true);
            this.UpdateStyles();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void password_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void Name_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login loginform = new Login();
            loginform.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void PBeye_Click(object sender, EventArgs e)
        {
            password_box.UseSystemPasswordChar = !password_box.UseSystemPasswordChar;

            if (password_box.UseSystemPasswordChar)
            {
                PBeye.Image = Properties.Resources.eye_closed;
            }
            else
            {
                PBeye.Image = Properties.Resources.eye_open;
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            string username = Name_textbox.Text;
            string password = password_box.Text;
            string confirmPassword = confirm_pass.Text;
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("Please enter both username and password.");
                return;
            }
            else if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match.");
                return;
            }

            using (SqliteConnection conn = new SqliteConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO Users (Username, Password) VALUES (@username, @password)";
                    SqliteCommand cmd = new SqliteCommand(query, conn);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    MessageBox.Show("Account Registered!! Go to login page");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(confirm_pass.Text))
            {
                label7.Visible = false;
            }
            else if (confirm_pass.Text == password_box.Text)
            {
                label7.Visible = true;
                label7.Text = "Password matched";
            }
            else
            {
                label7.Visible = true;
                label7.Text = "Password doesn't match";
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void password_box_TextChanged_1(object sender, EventArgs e)
        {

        }
        private void PBeye_Click_1(object sender, EventArgs e)
        {
            if (passwordVisible)
            {
                password_box.UseSystemPasswordChar = true;
                PBeye.Image = Properties.Resources.eye_closed;
                passwordVisible = false;
            }
            else
            {
                password_box.UseSystemPasswordChar = false;
                PBeye.Image = Properties.Resources.eye_open;
                passwordVisible = true;
            }
        }
    }
}

