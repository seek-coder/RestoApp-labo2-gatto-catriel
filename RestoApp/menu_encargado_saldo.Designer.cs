namespace RestoApp
{
    partial class menu_encargado_saldo
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
            label1 = new Label();
            button4 = new Button();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("JetBrains Mono", 8.249999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(157, 44);
            label1.Name = "label1";
            label1.Size = new Size(84, 14);
            label1.TabIndex = 21;
            label1.Text = "Elegir arca";
            // 
            // button4
            // 
            button4.Cursor = Cursors.Hand;
            button4.Font = new Font("JetBrains Mono", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.Location = new Point(247, 10);
            button4.Name = "button4";
            button4.Size = new Size(144, 29);
            button4.TabIndex = 20;
            button4.Text = "Consultar";
            button4.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("JetBrains Mono", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.ItemHeight = 21;
            comboBox1.Items.AddRange(new object[] { "Arca1" });
            comboBox1.Location = new Point(9, 10);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(232, 29);
            comboBox1.TabIndex = 19;
            // 
            // menu_encargado_saldo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(396, 63);
            Controls.Add(label1);
            Controls.Add(button4);
            Controls.Add(comboBox1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "menu_encargado_saldo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Saldo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button4;
        private ComboBox comboBox1;
    }
}