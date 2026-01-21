namespace RMS
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Label label5;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            label2 = new Label();
            Name_textbox = new TextBox();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            label4 = new Label();
            panel1 = new Panel();
            PBeye = new PictureBox();
            password_box = new TextBox();
            panel2 = new Panel();
            label5 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PBeye).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("THE BOLD FONT (FREE VERSION)", 30F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(9, 0);
            label5.Name = "label5";
            label5.Size = new Size(249, 48);
            label5.TabIndex = 11;
            label5.Text = "LOGIN FORM";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(299, 190);
            label2.Name = "label2";
            label2.Size = new Size(74, 25);
            label2.TabIndex = 2;
            label2.Text = "NAME";
            // 
            // Name_textbox
            // 
            Name_textbox.Anchor = AnchorStyles.None;
            Name_textbox.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name_textbox.Location = new Point(458, 187);
            Name_textbox.Name = "Name_textbox";
            Name_textbox.Size = new Size(148, 22);
            Name_textbox.TabIndex = 3;
            Name_textbox.TextChanged += Name_textbox_TextChanged;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(299, 246);
            label3.Name = "label3";
            label3.Size = new Size(138, 25);
            label3.TabIndex = 4;
            label3.Text = "PASSWORD";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.DimGray;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Calibri", 20F, FontStyle.Bold);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(312, 320);
            button1.Name = "button1";
            button1.Size = new Size(101, 43);
            button1.TabIndex = 6;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.BackColor = Color.DimGray;
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Calibri", 20F, FontStyle.Bold);
            button2.ForeColor = SystemColors.Control;
            button2.Location = new Point(492, 320);
            button2.Name = "button2";
            button2.Size = new Size(101, 43);
            button2.TabIndex = 8;
            button2.Text = "Signup";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Calibri", 9F);
            label4.ForeColor = Color.White;
            label4.Location = new Point(492, 303);
            label4.Name = "label4";
            label4.Size = new Size(73, 14);
            label4.TabIndex = 9;
            label4.Text = "No account?";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(PBeye);
            panel1.Controls.Add(password_box);
            panel1.Location = new Point(458, 249);
            panel1.Name = "panel1";
            panel1.Size = new Size(148, 22);
            panel1.TabIndex = 11;
            // 
            // PBeye
            // 
            PBeye.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            PBeye.BackColor = Color.WhiteSmoke;
            PBeye.BackgroundImageLayout = ImageLayout.Zoom;
            PBeye.Cursor = Cursors.Hand;
            PBeye.InitialImage = null;
            PBeye.Location = new Point(127, 0);
            PBeye.Name = "PBeye";
            PBeye.Size = new Size(22, 22);
            PBeye.SizeMode = PictureBoxSizeMode.Zoom;
            PBeye.TabIndex = 8;
            PBeye.TabStop = false;
            PBeye.Click += PBeye_Click_1;
            // 
            // password_box
            // 
            password_box.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            password_box.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            password_box.Location = new Point(1, 0);
            password_box.Name = "password_box";
            password_box.Size = new Size(135, 22);
            password_box.TabIndex = 6;
            password_box.TextChanged += password_box_TextChanged_1;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(label5);
            panel2.Location = new Point(312, 40);
            panel2.Name = "panel2";
            panel2.Size = new Size(266, 48);
            panel2.TabIndex = 12;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(849, 497);
            Controls.Add(panel1);
            Controls.Add(label4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(Name_textbox);
            Controls.Add(label2);
            Controls.Add(panel2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Login";
            Text = "LoginForm";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PBeye).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private TextBox Name_textbox;
        private Label label3;
        private Button button1;
        private Button button2;
        private Label label4;
        private Panel panel1;
        private PictureBox PBeye;
        private TextBox password_box;
        private Panel panel2;
    }
}
