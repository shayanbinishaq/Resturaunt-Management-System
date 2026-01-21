namespace RMS
{
    partial class SignUpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUpForm));
            label2 = new Label();
            Name_textbox = new TextBox();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            confirm_pass = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            panel1 = new Panel();
            PBeye = new PictureBox();
            password_box = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PBeye).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(289, 137);
            label2.Name = "label2";
            label2.Size = new Size(74, 25);
            label2.TabIndex = 2;
            label2.Text = "NAME";
            // 
            // Name_textbox
            // 
            Name_textbox.Anchor = AnchorStyles.None;
            Name_textbox.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name_textbox.Location = new Point(462, 134);
            Name_textbox.Name = "Name_textbox";
            Name_textbox.Size = new Size(142, 22);
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
            label3.Location = new Point(289, 193);
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
            button1.Location = new Point(316, 321);
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
            button2.Location = new Point(496, 321);
            button2.Name = "button2";
            button2.Size = new Size(101, 43);
            button2.TabIndex = 8;
            button2.Text = "Signup";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // confirm_pass
            // 
            confirm_pass.Anchor = AnchorStyles.None;
            confirm_pass.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            confirm_pass.Location = new Point(462, 241);
            confirm_pass.Name = "confirm_pass";
            confirm_pass.PasswordChar = '●';
            confirm_pass.Size = new Size(142, 22);
            confirm_pass.TabIndex = 10;
            confirm_pass.TextChanged += textBox1_TextChanged;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(289, 241);
            label4.Name = "label4";
            label4.Size = new Size(176, 25);
            label4.TabIndex = 9;
            label4.Text = "CONFIRM PASS";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Calibri", 9F);
            label5.ForeColor = Color.White;
            label5.Location = new Point(316, 299);
            label5.Name = "label5";
            label5.Size = new Size(148, 14);
            label5.TabIndex = 12;
            label5.Text = "Already have an  account?";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("THE BOLD FONT (FREE VERSION)", 30F, FontStyle.Bold);
            label6.ForeColor = Color.White;
            label6.Location = new Point(316, 56);
            label6.Name = "label6";
            label6.Size = new Size(265, 48);
            label6.TabIndex = 13;
            label6.Text = "SIGNUP FORM";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Calibri", 9F);
            label7.ForeColor = Color.White;
            label7.Location = new Point(463, 223);
            label7.Name = "label7";
            label7.Size = new Size(0, 14);
            label7.TabIndex = 14;
            label7.Click += label7_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(PBeye);
            panel1.Controls.Add(password_box);
            panel1.Location = new Point(458, 180);
            panel1.Name = "panel1";
            panel1.Size = new Size(149, 28);
            panel1.TabIndex = 15;
            panel1.Paint += panel1_Paint;
            // 
            // PBeye
            // 
            PBeye.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            PBeye.BackColor = Color.WhiteSmoke;
            PBeye.BackgroundImageLayout = ImageLayout.Zoom;
            PBeye.Cursor = Cursors.Hand;
            PBeye.InitialImage = null;
            PBeye.Location = new Point(124, 3);
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
            password_box.Location = new Point(3, 3);
            password_box.Name = "password_box";
            password_box.Size = new Size(135, 22);
            password_box.TabIndex = 9;
            password_box.TextChanged += password_box_TextChanged_1;
            // 
            // SignUpForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(857, 498);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(confirm_pass);
            Controls.Add(label4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(Name_textbox);
            Controls.Add(label2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "SignUpForm";
            Text = "Signup";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PBeye).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private TextBox Name_textbox;
        private Label label3;
        private Button button1;
        private Button button2;
        private TextBox confirm_pass;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Panel panel1;
        private PictureBox PBeye;
        private TextBox password_box;
    }
}
