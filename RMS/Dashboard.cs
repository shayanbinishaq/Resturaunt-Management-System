namespace RMS
{
    public partial class Dashboard : Form
    {

        public Dashboard()
        {
           InitializeComponent();   
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            uC_Add_items1.Visible = false;
            uC_placeOrder1.Visible = false;
            uC_update_items1.Visible = false;
            uC_delete1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void MenuTransition_Tick(object sender, EventArgs e)
        {



        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Menu_Click(object sender, EventArgs e)
        {
            uC_placeOrder1.Visible = true;
            uC_placeOrder1.BringToFront();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            Logout logoutform = new Logout();
            logoutform.Show();
            this.Hide();
        }

        private void Add_item_Click(object sender, EventArgs e)
        {
            uC_Add_items1.Visible = true;
            uC_Add_items1.BringToFront();
        }

        private void update_item_Click(object sender, EventArgs e)
        {
            uC_update_items1.Visible = true;
            uC_update_items1.BringToFront();
        }

        private void Remove_item_Click(object sender, EventArgs e)
        {
            uC_delete1.Visible = true;
            uC_delete1.BringToFront();
        }

        private void uC_delete1_Load(object sender, EventArgs e)
        {

        }

        private void uC_placeOrder1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
