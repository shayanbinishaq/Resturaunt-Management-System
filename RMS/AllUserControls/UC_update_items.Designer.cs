namespace RMS.AllUserControls
{
    partial class UC_update_items
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
            label1 = new Label();
            label3 = new Label();
            item_name = new TextBox();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            price = new TextBox();
            item = new TextBox();
            Combo_category = new ComboBox();
            label4 = new Label();
            label2 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(339, 11);
            label1.Name = "label1";
            label1.Size = new Size(143, 30);
            label1.TabIndex = 3;
            label1.Text = "Update items";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.LightSteelBlue;
            label3.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(85, 32);
            label3.Name = "label3";
            label3.Size = new Size(120, 30);
            label3.TabIndex = 13;
            label3.Text = "Item Name";
            // 
            // item_name
            // 
            item_name.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            item_name.Location = new Point(87, 65);
            item_name.Name = "item_name";
            item_name.PlaceholderText = "Filter...";
            item_name.Size = new Size(149, 27);
            item_name.TabIndex = 14;
            item_name.TextChanged += item_name_TextChanged_1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(85, 98);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(662, 249);
            dataGridView1.TabIndex = 15;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaptionText;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(532, 437);
            button1.Name = "button1";
            button1.Size = new Size(150, 47);
            button1.TabIndex = 22;
            button1.Text = "Update item";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // price
            // 
            price.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            price.Location = new Point(313, 455);
            price.Name = "price";
            price.Size = new Size(169, 29);
            price.TabIndex = 21;
            // 
            // item
            // 
            item.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            item.Location = new Point(96, 455);
            item.Name = "item";
            item.Size = new Size(169, 29);
            item.TabIndex = 20;
            // 
            // Combo_category
            // 
            Combo_category.DropDownStyle = ComboBoxStyle.DropDownList;
            Combo_category.FlatStyle = FlatStyle.Flat;
            Combo_category.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            Combo_category.FormattingEnabled = true;
            Combo_category.Items.AddRange(new object[] { "Burger", "Sandwich", "Pizza" });
            Combo_category.Location = new Point(96, 378);
            Combo_category.Name = "Combo_category";
            Combo_category.Size = new Size(169, 29);
            Combo_category.TabIndex = 19;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(313, 425);
            label4.Name = "label4";
            label4.Size = new Size(54, 25);
            label4.TabIndex = 18;
            label4.Text = "Price";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(96, 425);
            label2.Name = "label2";
            label2.Size = new Size(109, 25);
            label2.TabIndex = 17;
            label2.Text = "Item Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(96, 350);
            label5.Name = "label5";
            label5.Size = new Size(91, 25);
            label5.TabIndex = 16;
            label5.Text = "Category";
            // 
            // UC_update_items
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            Controls.Add(button1);
            Controls.Add(price);
            Controls.Add(item);
            Controls.Add(Combo_category);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(dataGridView1);
            Controls.Add(label3);
            Controls.Add(item_name);
            Controls.Add(label1);
            Name = "UC_update_items";
            Size = new Size(834, 501);
            Load += UC_update_items_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private TextBox item_name;
        private DataGridView dataGridView1;
        private Button button1;
        private TextBox price;
        private TextBox item;
        private ComboBox Combo_category;
        private Label label4;
        private Label label2;
        private Label label5;
    }
}
