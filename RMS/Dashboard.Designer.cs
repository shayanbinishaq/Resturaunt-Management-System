namespace RMS
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            panel1 = new Panel();
            label1 = new Label();
            place_order = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel2 = new Panel();
            pnDashboard = new Panel();
            panel3 = new Panel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            Add_item = new Button();
            panel4 = new Panel();
            flowLayoutPanel3 = new FlowLayoutPanel();
            update_item = new Button();
            panel5 = new Panel();
            flowLayoutPanel4 = new FlowLayoutPanel();
            Remove_item = new Button();
            panel6 = new Panel();
            flowLayoutPanel5 = new FlowLayoutPanel();
            logout = new Button();
            uC_Add_items1 = new RMS.AllUserControls.UC_Add_items();
            uC_placeOrder1 = new RMS.AllUserControls.UC_placeOrder();
            uC_update_items1 = new RMS.AllUserControls.UC_update_items();
            uC_delete1 = new RMS.AllUserControls.UC_delete();
            panel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            pnDashboard.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            flowLayoutPanel4.SuspendLayout();
            flowLayoutPanel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(23, 24, 31);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(964, 43);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(359, 9);
            label1.Name = "label1";
            label1.Size = new Size(301, 25);
            label1.TabIndex = 1;
            label1.Text = "Resturaunt Management System";
            // 
            // place_order
            // 
            place_order.BackColor = Color.FromArgb(23, 24, 31);
            place_order.BackgroundImage = (Image)resources.GetObject("place_order.BackgroundImage");
            place_order.BackgroundImageLayout = ImageLayout.Zoom;
            place_order.Cursor = Cursors.Hand;
            place_order.FlatAppearance.BorderSize = 0;
            place_order.FlatStyle = FlatStyle.Flat;
            place_order.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            place_order.ForeColor = Color.White;
            place_order.ImageAlign = ContentAlignment.MiddleLeft;
            place_order.Location = new Point(-3, 3);
            place_order.Name = "place_order";
            place_order.Size = new Size(182, 29);
            place_order.TabIndex = 3;
            place_order.Text = "Place order";
            place_order.TextAlign = ContentAlignment.MiddleLeft;
            place_order.UseVisualStyleBackColor = false;
            place_order.Click += Menu_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(23, 24, 31);
            flowLayoutPanel1.Controls.Add(panel2);
            flowLayoutPanel1.Controls.Add(pnDashboard);
            flowLayoutPanel1.Controls.Add(panel3);
            flowLayoutPanel1.Controls.Add(flowLayoutPanel2);
            flowLayoutPanel1.Controls.Add(panel4);
            flowLayoutPanel1.Controls.Add(flowLayoutPanel3);
            flowLayoutPanel1.Controls.Add(panel5);
            flowLayoutPanel1.Controls.Add(flowLayoutPanel4);
            flowLayoutPanel1.Controls.Add(panel6);
            flowLayoutPanel1.Controls.Add(flowLayoutPanel5);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(0, 43);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(128, 514);
            flowLayoutPanel1.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(184, 31);
            panel2.TabIndex = 5;
            // 
            // pnDashboard
            // 
            pnDashboard.Controls.Add(place_order);
            pnDashboard.Location = new Point(3, 40);
            pnDashboard.Name = "pnDashboard";
            pnDashboard.Size = new Size(182, 30);
            pnDashboard.TabIndex = 6;
            // 
            // panel3
            // 
            panel3.Location = new Point(3, 76);
            panel3.Name = "panel3";
            panel3.Size = new Size(182, 30);
            panel3.TabIndex = 9;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.AccessibleName = "Menu container";
            flowLayoutPanel2.BackColor = Color.FromArgb(23, 24, 31);
            flowLayoutPanel2.Controls.Add(Add_item);
            flowLayoutPanel2.Location = new Point(3, 112);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(182, 30);
            flowLayoutPanel2.TabIndex = 7;
            flowLayoutPanel2.Paint += flowLayoutPanel2_Paint;
            // 
            // Add_item
            // 
            Add_item.BackColor = Color.FromArgb(23, 24, 31);
            Add_item.BackgroundImage = (Image)resources.GetObject("Add_item.BackgroundImage");
            Add_item.BackgroundImageLayout = ImageLayout.Zoom;
            Add_item.Cursor = Cursors.Hand;
            Add_item.FlatAppearance.BorderSize = 0;
            Add_item.FlatStyle = FlatStyle.Flat;
            Add_item.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Add_item.ForeColor = Color.White;
            Add_item.ImageAlign = ContentAlignment.MiddleLeft;
            Add_item.Location = new Point(3, 3);
            Add_item.Name = "Add_item";
            Add_item.Size = new Size(206, 29);
            Add_item.TabIndex = 3;
            Add_item.Text = "Add item";
            Add_item.TextAlign = ContentAlignment.MiddleLeft;
            Add_item.UseVisualStyleBackColor = false;
            Add_item.Click += Add_item_Click;
            // 
            // panel4
            // 
            panel4.Location = new Point(3, 148);
            panel4.Name = "panel4";
            panel4.Size = new Size(182, 30);
            panel4.TabIndex = 9;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.AccessibleName = "Menu container";
            flowLayoutPanel3.BackColor = Color.FromArgb(23, 24, 31);
            flowLayoutPanel3.Controls.Add(update_item);
            flowLayoutPanel3.Location = new Point(3, 184);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(182, 30);
            flowLayoutPanel3.TabIndex = 10;
            // 
            // update_item
            // 
            update_item.BackColor = Color.FromArgb(23, 24, 31);
            update_item.BackgroundImage = (Image)resources.GetObject("update_item.BackgroundImage");
            update_item.BackgroundImageLayout = ImageLayout.Zoom;
            update_item.Cursor = Cursors.Hand;
            update_item.FlatAppearance.BorderSize = 0;
            update_item.FlatStyle = FlatStyle.Flat;
            update_item.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            update_item.ForeColor = Color.White;
            update_item.ImageAlign = ContentAlignment.MiddleLeft;
            update_item.Location = new Point(3, 3);
            update_item.Name = "update_item";
            update_item.Size = new Size(206, 29);
            update_item.TabIndex = 3;
            update_item.Text = "Update item";
            update_item.TextAlign = ContentAlignment.MiddleLeft;
            update_item.UseVisualStyleBackColor = false;
            update_item.Click += update_item_Click;
            // 
            // panel5
            // 
            panel5.Location = new Point(3, 220);
            panel5.Name = "panel5";
            panel5.Size = new Size(182, 30);
            panel5.TabIndex = 11;
            // 
            // flowLayoutPanel4
            // 
            flowLayoutPanel4.AccessibleName = "Menu container";
            flowLayoutPanel4.BackColor = Color.FromArgb(23, 24, 31);
            flowLayoutPanel4.Controls.Add(Remove_item);
            flowLayoutPanel4.Location = new Point(3, 256);
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            flowLayoutPanel4.Size = new Size(182, 30);
            flowLayoutPanel4.TabIndex = 10;
            // 
            // Remove_item
            // 
            Remove_item.BackColor = Color.FromArgb(23, 24, 31);
            Remove_item.BackgroundImage = (Image)resources.GetObject("Remove_item.BackgroundImage");
            Remove_item.BackgroundImageLayout = ImageLayout.Zoom;
            Remove_item.Cursor = Cursors.Hand;
            Remove_item.FlatAppearance.BorderSize = 0;
            Remove_item.FlatStyle = FlatStyle.Flat;
            Remove_item.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Remove_item.ForeColor = Color.White;
            Remove_item.ImageAlign = ContentAlignment.MiddleLeft;
            Remove_item.Location = new Point(3, 3);
            Remove_item.Name = "Remove_item";
            Remove_item.Size = new Size(206, 29);
            Remove_item.TabIndex = 3;
            Remove_item.Text = "Remove item";
            Remove_item.TextAlign = ContentAlignment.MiddleLeft;
            Remove_item.UseVisualStyleBackColor = false;
            Remove_item.Click += Remove_item_Click;
            // 
            // panel6
            // 
            panel6.Location = new Point(3, 292);
            panel6.Name = "panel6";
            panel6.Size = new Size(182, 30);
            panel6.TabIndex = 11;
            // 
            // flowLayoutPanel5
            // 
            flowLayoutPanel5.AccessibleName = "Menu container";
            flowLayoutPanel5.BackColor = Color.FromArgb(23, 24, 31);
            flowLayoutPanel5.Controls.Add(logout);
            flowLayoutPanel5.Location = new Point(3, 328);
            flowLayoutPanel5.Name = "flowLayoutPanel5";
            flowLayoutPanel5.Size = new Size(182, 30);
            flowLayoutPanel5.TabIndex = 12;
            // 
            // logout
            // 
            logout.BackColor = Color.FromArgb(23, 24, 31);
            logout.BackgroundImage = (Image)resources.GetObject("logout.BackgroundImage");
            logout.BackgroundImageLayout = ImageLayout.Zoom;
            logout.Cursor = Cursors.Hand;
            logout.FlatAppearance.BorderSize = 0;
            logout.FlatStyle = FlatStyle.Flat;
            logout.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            logout.ForeColor = Color.White;
            logout.ImageAlign = ContentAlignment.MiddleLeft;
            logout.Location = new Point(3, 3);
            logout.Name = "logout";
            logout.Size = new Size(185, 31);
            logout.TabIndex = 5;
            logout.Text = "Logout";
            logout.TextAlign = ContentAlignment.MiddleLeft;
            logout.UseVisualStyleBackColor = false;
            logout.Click += logout_Click;
            // 
            // uC_Add_items1
            // 
            uC_Add_items1.BackColor = Color.LightSteelBlue;
            uC_Add_items1.Location = new Point(127, 43);
            uC_Add_items1.Name = "uC_Add_items1";
            uC_Add_items1.Size = new Size(837, 514);
            uC_Add_items1.TabIndex = 5;
            // 
            // uC_placeOrder1
            // 
            uC_placeOrder1.BackColor = Color.LightSteelBlue;
            uC_placeOrder1.Location = new Point(127, 43);
            uC_placeOrder1.Name = "uC_placeOrder1";
            uC_placeOrder1.Size = new Size(834, 501);
            uC_placeOrder1.TabIndex = 6;
            uC_placeOrder1.Load += uC_placeOrder1_Load;
            // 
            // uC_update_items1
            // 
            uC_update_items1.BackColor = Color.LightSteelBlue;
            uC_update_items1.Location = new Point(127, 43);
            uC_update_items1.Name = "uC_update_items1";
            uC_update_items1.Size = new Size(846, 520);
            uC_update_items1.TabIndex = 2;
            // 
            // uC_delete1
            // 
            uC_delete1.BackColor = Color.LightSteelBlue;
            uC_delete1.Location = new Point(127, 43);
            uC_delete1.Name = "uC_delete1";
            uC_delete1.Size = new Size(846, 514);
            uC_delete1.TabIndex = 2;
            uC_delete1.Load += uC_delete1_Load;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(964, 557);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel1);
            Controls.Add(uC_placeOrder1);
            Controls.Add(uC_delete1);
            Controls.Add(uC_update_items1);
            Controls.Add(uC_Add_items1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Dashboard";
            Text = "Dashboard";
            Load += Dashboard_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            pnDashboard.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel4.ResumeLayout(false);
            flowLayoutPanel5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button place_order;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel2;
        private FlowLayoutPanel flowLayoutPanel2;
        private Panel pnDashboard;
        private Button logout;
        private Panel panel3;
        private Panel panel4;
        private FlowLayoutPanel flowLayoutPanel3;
        private Button Add_item;
        private Panel panel5;
        private Button Remove_item;
        private FlowLayoutPanel flowLayoutPanel4;
        private Panel panel6;
        private FlowLayoutPanel flowLayoutPanel5;
        private Button update_item;
        private AllUserControls.UC_Add_items uC_Add_items1;
        private AllUserControls.UC_placeOrder uC_placeOrder1;
        private AllUserControls.UC_update_items uC_update_items1;
        private AllUserControls.UC_delete uC_delete1;
    }
}