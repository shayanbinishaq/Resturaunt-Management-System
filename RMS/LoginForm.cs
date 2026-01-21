using Microsoft.Data.Sqlite;

namespace RMS
{
    public partial class Login : Form
    {
        private bool passwordVisible = false;
        string connectionString = "Data Source=rms.db";
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.AcceptButton = button1;
            password_box.UseSystemPasswordChar = true;
            passwordVisible = false;
            PBeye.Image = Properties.Resources.eye_closed;
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
            string username = Name_textbox.Text;
            string password = password_box.Text;
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.");
                return;
            }
            using (SqliteConnection conn = new SqliteConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM Users WHERE Username = @username AND Password = @password";
                    SqliteCommand cmd = new SqliteCommand(query, conn);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    SqliteDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        Dashboard dashboardForm = new Dashboard();
                        dashboardForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void PBeye_Click(object sender, EventArgs e)
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

        private void button2_Click_1(object sender, EventArgs e)
        {
            SignUpForm signupForm = new SignUpForm();
            signupForm.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void PBeye_Click_1(object sender, EventArgs e)
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

        private void password_box_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}

