namespace RestoApp
{
    partial class menu_bienvenida
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menu_bienvenida));
            splitContainer1 = new SplitContainer();
            pictureBox4 = new PictureBox();
            pictureBox1 = new PictureBox();
            button2 = new Button();
            pictureBox3 = new PictureBox();
            button1 = new Button();
            pictureBox2 = new PictureBox();
            btn_sc_ = new Button();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            label3 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.AccessibleName = "sc_left_login";
            splitContainer1.Panel1.BackColor = Color.LightCoral;
            splitContainer1.Panel1.Controls.Add(pictureBox4);
            splitContainer1.Panel1.Controls.Add(pictureBox1);
            splitContainer1.Panel1.Controls.Add(button2);
            splitContainer1.Panel1.Controls.Add(pictureBox3);
            splitContainer1.Panel1.Controls.Add(button1);
            splitContainer1.Panel1.Controls.Add(pictureBox2);
            splitContainer1.Panel1.Controls.Add(btn_sc_);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.AccessibleName = "sc_right";
            splitContainer1.Panel2.Controls.Add(label5);
            splitContainer1.Panel2.Controls.Add(label4);
            splitContainer1.Panel2.Controls.Add(label2);
            splitContainer1.Panel2.Controls.Add(label3);
            splitContainer1.Panel2.Controls.Add(label1);
            splitContainer1.Panel2.Paint += splitContainer1_Panel2_Paint;
            splitContainer1.Size = new Size(1004, 677);
            splitContainer1.SplitterDistance = 222;
            splitContainer1.TabIndex = 0;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(3, 3);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(216, 220);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 8;
            pictureBox4.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.AccessibleName = "pb_exit";
            pictureBox1.BackColor = SystemColors.ControlLight;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(24, 575);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(32, 31);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // button2
            // 
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("Segoe UI", 12F);
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(3, 569);
            button2.Name = "button2";
            button2.Padding = new Padding(0, 0, 30, 0);
            button2.Size = new Size(216, 43);
            button2.TabIndex = 6;
            button2.Text = "Ayuda";
            button2.TextAlign = ContentAlignment.MiddleRight;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.AccessibleName = "pb_exit";
            pictureBox3.BackColor = SystemColors.ControlLight;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(24, 625);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(32, 31);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Segoe UI", 12F);
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(3, 618);
            button1.Name = "button1";
            button1.Padding = new Padding(0, 0, 30, 0);
            button1.Size = new Size(216, 43);
            button1.TabIndex = 4;
            button1.Text = "Salir";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // pictureBox2
            // 
            pictureBox2.AccessibleName = "pb_user";
            pictureBox2.BackColor = SystemColors.ControlLight;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(24, 229);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(32, 31);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // btn_sc_
            // 
            btn_sc_.Cursor = Cursors.Hand;
            btn_sc_.Font = new Font("Segoe UI", 12F);
            btn_sc_.ImageAlign = ContentAlignment.MiddleLeft;
            btn_sc_.Location = new Point(3, 225);
            btn_sc_.Name = "btn_sc_";
            btn_sc_.Padding = new Padding(0, 0, 30, 0);
            btn_sc_.Size = new Size(216, 43);
            btn_sc_.TabIndex = 2;
            btn_sc_.Text = "Ingreso";
            btn_sc_.TextAlign = ContentAlignment.MiddleRight;
            btn_sc_.UseVisualStyleBackColor = true;
            btn_sc_.Click += btn_sc__Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(265, 403);
            label5.Name = "label5";
            label5.Size = new Size(278, 30);
            label5.TabIndex = 5;
            label5.Text = "Por favor, ingrese al sistema ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(275, 443);
            label4.Name = "label4";
            label4.Size = new Size(250, 30);
            label4.TabIndex = 4;
            label4.Text = "con usuario y contraseña.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(221, 655);
            label2.Name = "label2";
            label2.Size = new Size(360, 13);
            label2.TabIndex = 3;
            label2.Text = "© 2024, \"RestoApp\" por Catriel Gatto. Todos los derechos reservados";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("JetBrains Mono", 47.9999924F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(138, 202);
            label3.Name = "label3";
            label3.Size = new Size(529, 84);
            label3.TabIndex = 2;
            label3.Text = "\"El Banquete\"";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(278, 93);
            label1.Name = "label1";
            label1.Size = new Size(232, 50);
            label1.TabIndex = 0;
            label1.Text = "Bienvenido a";
            // 
            // menu_bienvenida
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1004, 677);
            Controls.Add(splitContainer1);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "menu_bienvenida";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " ";
            Load += Form1_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Button btn_sc_;
        private PictureBox pictureBox2;
        private Button button1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox1;
        private Button button2;
        private Label label1;
        private PictureBox pictureBox4;
        private Label label3;
        private Label label2;
        private Label label5;
        private Label label4;
    }
}
