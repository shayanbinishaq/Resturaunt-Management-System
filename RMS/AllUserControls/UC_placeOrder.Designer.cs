namespace RMS.AllUserControls
{
    partial class UC_placeOrder
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label2 = new Label();
            label1 = new Label();
            combo = new ComboBox();
            listBox1 = new ListBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            item_name = new TextBox();
            Price = new TextBox();
            Total = new TextBox();
            Quantity = new NumericUpDown();
            Add_cart = new Button();
            panel1 = new Panel();
            button2 = new Button();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            label7 = new Label();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)Quantity).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(26, 68);
            label2.Name = "label2";
            label2.Size = new Size(102, 30);
            label2.TabIndex = 4;
            label2.Text = "Category";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(23, 24, 31);
            label1.Location = new Point(26, 15);
            label1.Name = "label1";
            label1.Size = new Size(123, 30);
            label1.TabIndex = 3;
            label1.Text = "Place order";
            // 
            // combo
            // 
            combo.Cursor = Cursors.Hand;
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
            combo.FlatStyle = FlatStyle.Flat;
            combo.FormattingEnabled = true;
            combo.Items.AddRange(new object[] { "Burger", "Sandwich", "Pizza" });
            combo.Location = new Point(26, 101);
            combo.Name = "combo";
            combo.Size = new Size(158, 23);
            combo.TabIndex = 5;
            combo.SelectedIndexChanged += Combo_Category;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(26, 135);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(158, 349);
            listBox1.TabIndex = 7;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Teal;
            label3.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(28, 11);
            label3.Name = "label3";
            label3.Size = new Size(120, 30);
            label3.TabIndex = 8;
            label3.Text = "Item Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Teal;
            label4.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(28, 86);
            label4.Name = "label4";
            label4.Size = new Size(96, 30);
            label4.TabIndex = 9;
            label4.Text = "Quantity";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Teal;
            label5.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(230, 11);
            label5.Name = "label5";
            label5.Size = new Size(59, 30);
            label5.TabIndex = 10;
            label5.Text = "Price";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Teal;
            label6.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(230, 86);
            label6.Name = "label6";
            label6.Size = new Size(60, 30);
            label6.TabIndex = 11;
            label6.Text = "Total";
            // 
            // item_name
            // 
            item_name.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            item_name.Location = new Point(28, 44);
            item_name.Name = "item_name";
            item_name.Size = new Size(149, 27);
            item_name.TabIndex = 12;
            // 
            // Price
            // 
            Price.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            Price.Location = new Point(230, 44);
            Price.Name = "Price";
            Price.Size = new Size(149, 27);
            Price.TabIndex = 13;
            // 
            // Total
            // 
            Total.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            Total.Location = new Point(230, 119);
            Total.Name = "Total";
            Total.Size = new Size(149, 27);
            Total.TabIndex = 15;
            // 
            // Quantity
            // 
            Quantity.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            Quantity.Hexadecimal = true;
            Quantity.Location = new Point(28, 119);
            Quantity.Name = "Quantity";
            Quantity.Size = new Size(149, 27);
            Quantity.TabIndex = 16;
            // 
            // Add_cart
            // 
            Add_cart.BackColor = Color.Black;
            Add_cart.FlatAppearance.BorderSize = 0;
            Add_cart.FlatStyle = FlatStyle.Flat;
            Add_cart.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Add_cart.ForeColor = SystemColors.ButtonFace;
            Add_cart.Location = new Point(230, 154);
            Add_cart.Name = "Add_cart";
            Add_cart.Size = new Size(142, 39);
            Add_cart.TabIndex = 17;
            Add_cart.Text = "Add to cart";
            Add_cart.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(Total);
            panel1.Controls.Add(Quantity);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(Price);
            panel1.Controls.Add(Add_cart);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(item_name);
            panel1.Location = new Point(227, 15);
            panel1.Name = "panel1";
            panel1.Size = new Size(418, 209);
            panel1.TabIndex = 18;
            // 
            // button2
            // 
            button2.BackColor = Color.Black;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold);
            button2.ForeColor = SystemColors.ButtonFace;
            button2.Location = new Point(48, 154);
            button2.Name = "button2";
            button2.Size = new Size(112, 41);
            button2.TabIndex = 19;
            button2.Text = "Remove";
            button2.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dataGridView1.Location = new Point(227, 300);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(486, 181);
            dataGridView1.TabIndex = 19;
            // 
            // Column1
            // 
            Column1.HeaderText = "Item_name";
            Column1.Name = "Column1";
            Column1.Width = 115;
            // 
            // Column2
            // 
            Column2.HeaderText = "Item_price";
            Column2.Name = "Column2";
            Column2.Width = 110;
            // 
            // Column3
            // 
            Column3.HeaderText = "Quantity";
            Column3.Name = "Column3";
            Column3.Width = 110;
            // 
            // Column4
            // 
            Column4.HeaderText = "Total_price";
            Column4.Name = "Column4";
            Column4.Width = 110;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.LightSteelBlue;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ActiveCaptionText;
            label7.Location = new Point(394, 238);
            label7.Name = "label7";
            label7.Size = new Size(93, 21);
            label7.TabIndex = 18;
            label7.Text = "Grand Total";
            // 
            // label8
            // 
            label8.BackColor = Color.FromArgb(255, 128, 128);
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ActiveCaptionText;
            label8.Location = new Point(394, 261);
            label8.Name = "label8";
            label8.Size = new Size(93, 36);
            label8.TabIndex = 20;
            label8.Text = "Rs: 00";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // UC_placeOrder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(dataGridView1);
            Controls.Add(listBox1);
            Controls.Add(combo);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "UC_placeOrder";
            Size = new Size(834, 501);
            Load += UC_placeOrder_Load;
            ((System.ComponentModel.ISupportInitialize)Quantity).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private ComboBox combo;
        private ListBox listBox1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox item_name;
        private TextBox Price;
        private TextBox Total;
        private NumericUpDown Quantity;
        private Button Add_cart;
        private Panel panel1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private Button button2;
        private Label label7;
        private Label label8;
    }
}
