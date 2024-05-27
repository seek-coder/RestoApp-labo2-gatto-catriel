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
            pictureBox5 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.BackColor = SystemColors.ButtonFace;
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.AccessibleName = "sc_left_login";
            splitContainer1.Panel1.BackColor = SystemColors.InfoText;
            splitContainer1.Panel1.Controls.Add(pictureBox4);
            splitContainer1.Panel1.Controls.Add(pictureBox1);
            splitContainer1.Panel1.Controls.Add(button2);
            splitContainer1.Panel1.Controls.Add(pictureBox3);
            splitContainer1.Panel1.Controls.Add(button1);
            splitContainer1.Panel1.Controls.Add(pictureBox2);
            splitContainer1.Panel1.Controls.Add(btn_sc_);
            splitContainer1.Panel1.Paint += splitContainer1_Panel1_Paint_1;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.AccessibleName = "sc_right";
            splitContainer1.Panel2.BackColor = SystemColors.HighlightText;
            splitContainer1.Panel2.Controls.Add(label5);
            splitContainer1.Panel2.Controls.Add(label4);
            splitContainer1.Panel2.Controls.Add(label2);
            splitContainer1.Panel2.Controls.Add(label3);
            splitContainer1.Panel2.Controls.Add(label1);
            splitContainer1.Panel2.Controls.Add(pictureBox5);
            splitContainer1.Panel2.Paint += splitContainer1_Panel2_Paint;
            splitContainer1.Size = new Size(900, 600);
            splitContainer1.SplitterDistance = 150;
            splitContainer1.SplitterWidth = 1;
            splitContainer1.TabIndex = 0;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(12, 12);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(128, 128);
            pictureBox4.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox4.TabIndex = 8;
            pictureBox4.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.AccessibleName = "pb_exit";
            pictureBox1.BackColor = SystemColors.ControlLight;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 496);
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
            button2.Font = new Font("JetBrains Mono", 11.9999981F);
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(3, 490);
            button2.Name = "button2";
            button2.Size = new Size(144, 43);
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
            pictureBox3.Location = new Point(12, 550);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(32, 31);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("JetBrains Mono", 11.9999981F);
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(3, 545);
            button1.Name = "button1";
            button1.Size = new Size(144, 43);
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
            pictureBox2.Location = new Point(12, 158);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(32, 31);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click_1;
            // 
            // btn_sc_
            // 
            btn_sc_.Cursor = Cursors.Hand;
            btn_sc_.Font = new Font("JetBrains Mono", 11.9999981F);
            btn_sc_.ImageAlign = ContentAlignment.MiddleLeft;
            btn_sc_.Location = new Point(3, 152);
            btn_sc_.Name = "btn_sc_";
            btn_sc_.Size = new Size(144, 43);
            btn_sc_.TabIndex = 2;
            btn_sc_.Text = "Ingreso";
            btn_sc_.TextAlign = ContentAlignment.MiddleRight;
            btn_sc_.UseVisualStyleBackColor = true;
            btn_sc_.Click += btn_sc__Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("JetBrains Mono", 15.75F);
            label5.Location = new Point(175, 295);
            label5.Name = "label5";
            label5.Size = new Size(402, 27);
            label5.TabIndex = 5;
            label5.Text = "Por favor, ingrese al sistema ";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("JetBrains Mono", 15.75F);
            label4.Location = new Point(198, 333);
            label4.Name = "label4";
            label4.Size = new Size(337, 27);
            label4.TabIndex = 4;
            label4.Text = "con usuario y contraseña.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.HighlightText;
            label2.Font = new Font("JetBrains Mono", 8.249999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(128, 586);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.No;
            label2.Size = new Size(476, 14);
            label2.TabIndex = 3;
            label2.Text = "© 2024, \"RestoApp\" por Catriel Gatto. Todos los derechos reservados";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("JetBrains Mono", 50.2499924F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(154, 178);
            label3.Name = "label3";
            label3.Size = new Size(437, 88);
            label3.TabIndex = 2;
            label3.Text = "\"RestoApp\"";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("JetBrains Mono", 27.7499962F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(237, 91);
            label1.Name = "label1";
            label1.Size = new Size(286, 49);
            label1.TabIndex = 0;
            label1.Text = "Bienvenido a";
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(-1, 363);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(747, 237);
            pictureBox5.TabIndex = 6;
            pictureBox5.TabStop = false;
            // 
            // menu_bienvenida
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(900, 600);
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
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
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
        private Label label3;
        private Label label5;
        private Label label4;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        protected Label label2;
    }
}
