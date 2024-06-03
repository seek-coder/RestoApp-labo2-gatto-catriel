namespace RestoApp
{
    partial class menu_login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menu_login));
            label1 = new Label();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            username = new TextBox();
            password = new TextBox();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AccessibleName = "lb_login_info";
            label1.AutoSize = true;
            label1.Font = new Font("JetBrains Mono", 35.9999962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.InfoText;
            label1.Location = new Point(85, 27);
            label1.Name = "label1";
            label1.Size = new Size(230, 63);
            label1.TabIndex = 0;
            label1.Text = "INGRESO";
            // 
            // label2
            // 
            label2.AccessibleName = "lb_login_info";
            label2.AutoSize = true;
            label2.Font = new Font("JetBrains Mono", 35.9999962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.InfoText;
            label2.Location = new Point(44, 90);
            label2.Name = "label2";
            label2.Size = new Size(317, 63);
            label2.TabIndex = 1;
            label2.Text = "DE USUARIO";
            // 
            // pictureBox2
            // 
            pictureBox2.AccessibleName = "pb_user";
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(28, 271);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(34, 33);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // username
            // 
            username.AccessibleName = "tb_username";
            username.BackColor = Color.Gainsboro;
            username.BorderStyle = BorderStyle.None;
            username.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            username.Location = new Point(68, 271);
            username.MaxLength = 15;
            username.Name = "username";
            username.PlaceholderText = " Escriba aquí su usuario...";
            username.Size = new Size(309, 32);
            username.TabIndex = 5;
            username.TextChanged += textBox1_TextChanged;
            // 
            // password
            // 
            password.AccessibleName = "tb_passwd";
            password.BackColor = Color.Gainsboro;
            password.BorderStyle = BorderStyle.None;
            password.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            password.Location = new Point(68, 332);
            password.MaxLength = 15;
            password.Name = "password";
            password.PasswordChar = '•';
            password.PlaceholderText = " Escriba aquí su contraseña...";
            password.Size = new Size(309, 32);
            password.TabIndex = 7;
            // 
            // pictureBox1
            // 
            pictureBox1.AccessibleName = "pb_user";
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(28, 332);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(34, 33);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Font = new Font("JetBrains Mono", 9.75F);
            button1.Location = new Point(114, 443);
            button1.Name = "button1";
            button1.Size = new Size(167, 44);
            button1.TabIndex = 8;
            button1.Text = "Ingresar    ";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("JetBrains Mono", 9.75F);
            button2.Location = new Point(114, 493);
            button2.Name = "button2";
            button2.Size = new Size(167, 44);
            button2.TabIndex = 9;
            button2.Text = "Atrás     ";
            button2.TextAlign = ContentAlignment.MiddleRight;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.AccessibleName = "pb_exit";
            pictureBox3.BackColor = SystemColors.ControlLight;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(125, 499);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(32, 31);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 10;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.AccessibleName = "pb_exit";
            pictureBox4.BackColor = SystemColors.ControlLight;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(125, 449);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(32, 31);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 11;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(160, 167);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(86, 80);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 12;
            pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(0, 458);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(401, 143);
            pictureBox6.TabIndex = 13;
            pictureBox6.TabStop = false;
            // 
            // menu_login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(400, 600);
            ControlBox = false;
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(password);
            Controls.Add(pictureBox1);
            Controls.Add(username);
            Controls.Add(pictureBox2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox6);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "menu_login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " ";
            Load += menu_login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private PictureBox pictureBox2;
        private TextBox username;
        private TextBox password;
        private PictureBox pictureBox1;
        private Button button1;
        private Button button2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
    }
}