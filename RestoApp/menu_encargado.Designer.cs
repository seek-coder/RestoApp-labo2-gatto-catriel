namespace RestoApp
{
    partial class menu_encargado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menu_encargado));
            splitContainer1 = new SplitContainer();
            pictureBox3 = new PictureBox();
            button1 = new Button();
            pictureBox4 = new PictureBox();
            panel1 = new Panel();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            pictureBox5 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
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
            splitContainer1.Panel1.BackColor = SystemColors.ControlText;
            splitContainer1.Panel1.Controls.Add(pictureBox3);
            splitContainer1.Panel1.Controls.Add(button1);
            splitContainer1.Panel1.Controls.Add(pictureBox4);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = SystemColors.HighlightText;
            splitContainer1.Panel2.Controls.Add(panel1);
            splitContainer1.Panel2.Controls.Add(label3);
            splitContainer1.Panel2.Controls.Add(label1);
            splitContainer1.Panel2.Controls.Add(label2);
            splitContainer1.Panel2.Controls.Add(pictureBox5);
            splitContainer1.Size = new Size(900, 600);
            splitContainer1.SplitterDistance = 150;
            splitContainer1.SplitterWidth = 1;
            splitContainer1.TabIndex = 0;
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
            pictureBox3.TabIndex = 11;
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
            button1.TabIndex = 10;
            button1.Text = "Salir";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(12, 12);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(128, 128);
            pictureBox4.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox4.TabIndex = 9;
            pictureBox4.TabStop = false;
            // 
            // panel1
            // 
            panel1.Location = new Point(24, 82);
            panel1.Name = "panel1";
            panel1.Size = new Size(693, 121);
            panel1.TabIndex = 15;
            panel1.Paint += panel1_Paint;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 52);
            label3.Name = "label3";
            label3.Size = new Size(442, 15);
            label3.TabIndex = 14;
            label3.Text = "_______________________________________________________________________________________";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("JetBrains Mono", 27.7499962F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(13, 12);
            label1.Name = "label1";
            label1.Size = new Size(396, 49);
            label1.TabIndex = 1;
            label1.Text = "Menú de encargado";
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
            label2.TabIndex = 13;
            label2.Text = "© 2024, \"RestoApp\" por Catriel Gatto. Todos los derechos reservados";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(-1, 363);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(747, 237);
            pictureBox5.TabIndex = 12;
            pictureBox5.TabStop = false;
            // 
            // menu_encargado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 600);
            Controls.Add(splitContainer1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "menu_encargado";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private Button button1;
        private PictureBox pictureBox5;
        protected Label label2;
        private Label label1;
        private Label label3;
        private Panel panel1;
    }
}