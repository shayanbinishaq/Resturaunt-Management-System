namespace RMS
{
    partial class Logout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Logout));
            label1 = new Label();
            label2 = new Label();
            yes = new Button();
            No = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(295, 115);
            label1.Name = "label1";
            label1.Size = new Size(307, 30);
            label1.TabIndex = 0;
            label1.Text = "You are attempting to logout ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(360, 153);
            label2.Name = "label2";
            label2.Size = new Size(146, 30);
            label2.TabIndex = 2;
            label2.Text = "Are you sure?";
            // 
            // yes
            // 
            yes.BackColor = Color.DimGray;
            yes.Cursor = Cursors.Hand;
            yes.FlatStyle = FlatStyle.Flat;
            yes.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            yes.ForeColor = SystemColors.ButtonFace;
            yes.Location = new Point(287, 225);
            yes.Name = "yes";
            yes.Size = new Size(107, 45);
            yes.TabIndex = 4;
            yes.Text = "Logout";
            yes.UseVisualStyleBackColor = false;
            yes.Click += Yes_Click;
            // 
            // No
            // 
            No.BackColor = Color.DimGray;
            No.Cursor = Cursors.Hand;
            No.FlatStyle = FlatStyle.Flat;
            No.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            No.ForeColor = SystemColors.ButtonFace;
            No.Location = new Point(465, 225);
            No.Name = "No";
            No.Size = new Size(107, 45);
            No.TabIndex = 5;
            No.Text = "No";
            No.UseVisualStyleBackColor = false;
            No.Click += No_Click;
            // 
            // Logout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(23, 24, 26);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(800, 450);
            Controls.Add(No);
            Controls.Add(yes);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Logout";
            Text = "Logout";
            Load += Logout_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button yes;
        private Button No;
    }
}