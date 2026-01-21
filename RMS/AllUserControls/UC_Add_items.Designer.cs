namespace RMS.AllUserControls
{
    partial class UC_Add_items
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
            label3 = new Label();
            label4 = new Label();
            Combo_category = new ComboBox();
            item = new TextBox();
            price = new TextBox();
            button1 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(66, 80);
            label2.Name = "label2";
            label2.Size = new Size(91, 25);
            label2.TabIndex = 3;
            label2.Text = "Category";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(66, 167);
            label3.Name = "label3";
            label3.Size = new Size(109, 25);
            label3.TabIndex = 4;
            label3.Text = "Item Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(66, 271);
            label4.Name = "label4";
            label4.Size = new Size(54, 25);
            label4.TabIndex = 5;
            label4.Text = "Price";
            // 
            // Combo_category
            // 
            Combo_category.DropDownStyle = ComboBoxStyle.DropDownList;
            Combo_category.FlatStyle = FlatStyle.Flat;
            Combo_category.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            Combo_category.FormattingEnabled = true;
            Combo_category.Items.AddRange(new object[] { "Burger", "Sandwich", "Pizza" });
            Combo_category.Location = new Point(66, 108);
            Combo_category.Name = "Combo_category";
            Combo_category.Size = new Size(169, 29);
            Combo_category.TabIndex = 6;
            // 
            // item
            // 
            item.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            item.Location = new Point(66, 211);
            item.Name = "item";
            item.Size = new Size(169, 29);
            item.TabIndex = 7;
            // 
            // price
            // 
            price.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            price.Location = new Point(66, 324);
            price.Name = "price";
            price.Size = new Size(169, 29);
            price.TabIndex = 8;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaptionText;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(206, 410);
            button1.Name = "button1";
            button1.Size = new Size(150, 47);
            button1.TabIndex = 9;
            button1.Text = "Add item";
            button1.UseVisualStyleBackColor = false;
            button1.Click += Add_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(206, 17);
            label1.Name = "label1";
            label1.Size = new Size(151, 30);
            label1.TabIndex = 2;
            label1.Text = "Add new item";
            // 
            // UC_Add_items
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            Controls.Add(button1);
            Controls.Add(price);
            Controls.Add(item);
            Controls.Add(Combo_category);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UC_Add_items";
            Size = new Size(569, 501);
            Load += Add_items_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox Combo_category;
        private TextBox item;
        private TextBox price;
        private Button button1;
        private Label label1;
    }
}
