namespace RestoApp
{
    partial class menu_encargado_pagar
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
            comboBox1 = new ComboBox();
            button4 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Catriel", "Denise", "Raúl", "Damián", "Tomás" });
            comboBox1.Location = new Point(12, 12);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(232, 29);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // button4
            // 
            button4.Cursor = Cursors.Hand;
            button4.Font = new Font("JetBrains Mono", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.Location = new Point(250, 12);
            button4.Name = "button4";
            button4.Size = new Size(144, 29);
            button4.TabIndex = 17;
            button4.Text = "Pagar";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("JetBrains Mono", 8.249999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(62, 44);
            label1.Name = "label1";
            label1.Size = new Size(182, 14);
            label1.TabIndex = 18;
            label1.Text = "Elegir nombre de empleado";
            // 
            // menu_encargado_pagar
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(396, 63);
            Controls.Add(label1);
            Controls.Add(button4);
            Controls.Add(comboBox1);
            Font = new Font("JetBrains Mono", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "menu_encargado_pagar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pago de sueldo";
            Load += menu_encargado_pagar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Button button4;
        private Label label1;
    }
}