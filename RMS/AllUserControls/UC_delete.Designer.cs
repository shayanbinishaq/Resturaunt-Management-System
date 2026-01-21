namespace RMS.AllUserControls
{
    partial class UC_delete
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
            dataGridView1 = new DataGridView();
            label3 = new Label();
            item_name = new TextBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(336, 14);
            label1.Name = "label1";
            label1.Size = new Size(134, 30);
            label1.TabIndex = 4;
            label1.Text = "Delete items";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(72, 129);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(693, 286);
            dataGridView1.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.LightSteelBlue;
            label3.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(72, 63);
            label3.Name = "label3";
            label3.Size = new Size(120, 30);
            label3.TabIndex = 15;
            label3.Text = "Item Name";
            // 
            // item_name
            // 
            item_name.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            item_name.Location = new Point(72, 96);
            item_name.Name = "item_name";
            item_name.PlaceholderText = "Filter...";
            item_name.Size = new Size(149, 27);
            item_name.TabIndex = 16;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaptionText;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(454, 431);
            button1.Name = "button1";
            button1.Size = new Size(150, 47);
            button1.TabIndex = 23;
            button1.Text = "Delete item";
            button1.UseVisualStyleBackColor = false;
            // 
            // UC_delete
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(item_name);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "UC_delete";
            Size = new Size(834, 501);
            Load += UC_delete_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private Label label3;
        private TextBox item_name;
        private Button button1;
    }
}
