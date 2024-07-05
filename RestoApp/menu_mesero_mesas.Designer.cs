namespace RestoApp
{
    partial class menu_mesero_mesas
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
            dataGridView1 = new DataGridView();
            capacidad = new DataGridViewTextBoxColumn();
            mesero = new DataGridViewTextBoxColumn();
            platos = new DataGridViewTextBoxColumn();
            ocupada = new DataGridViewTextBoxColumn();
            liberada = new DataGridViewCheckBoxColumn();
            numero = new DataGridViewTextBoxColumn();
            label3 = new Label();
            textBox2 = new TextBox();
            button2 = new Button();
            comboBox1 = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            listBox1 = new ListBox();
            label5 = new Label();
            label4 = new Label();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            label6 = new Label();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { capacidad, mesero, platos, ocupada, liberada, numero });
            dataGridView1.Location = new Point(12, 11);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(653, 130);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.CellEndEdit += dataGridView1_CellEndEdit;
            dataGridView1.CellValueChanged += DataGridView1_CellValueChanged;
            // 
            // capacidad
            // 
            capacidad.HeaderText = "CAPACIDAD";
            capacidad.Name = "capacidad";
            // 
            // mesero
            // 
            mesero.HeaderText = "MESERO";
            mesero.Name = "mesero";
            // 
            // platos
            // 
            platos.HeaderText = "PLATOS";
            platos.Name = "platos";
            // 
            // ocupada
            // 
            ocupada.HeaderText = "OCUPADA";
            ocupada.Name = "ocupada";
            // 
            // liberada
            // 
            liberada.HeaderText = "LIBERADA";
            liberada.Name = "liberada";
            // 
            // numero
            // 
            numero.HeaderText = "N°";
            numero.Name = "numero";
            // 
            // label3
            // 
            label3.AccessibleName = "lb_tiempoPlato";
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(13, 236);
            label3.Name = "label3";
            label3.Size = new Size(89, 21);
            label3.TabIndex = 23;
            label3.Text = "¿Ocupada?:";
            // 
            // textBox2
            // 
            textBox2.AccessibleName = "txt_capacidad";
            textBox2.Location = new Point(125, 205);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(42, 23);
            textBox2.TabIndex = 22;
            // 
            // button2
            // 
            button2.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ImageAlign = ContentAlignment.TopCenter;
            button2.Location = new Point(284, 176);
            button2.Name = "button2";
            button2.Size = new Size(22, 23);
            button2.TabIndex = 21;
            button2.Text = "+";
            button2.TextAlign = ContentAlignment.TopCenter;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // comboBox1
            // 
            comboBox1.AccessibleName = "txt_platos";
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Milanesas de pollo con puré de papas", "Ñoquis", "Polenta con tuco" });
            comboBox1.Location = new Point(125, 176);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(153, 23);
            comboBox1.TabIndex = 20;
            // 
            // label2
            // 
            label2.AccessibleName = "lb_ingredientesPlato";
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(13, 178);
            label2.Name = "label2";
            label2.Size = new Size(55, 21);
            label2.TabIndex = 18;
            label2.Text = "Platos:";
            // 
            // label1
            // 
            label1.AccessibleName = "lb_nombrePlato";
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(13, 149);
            label1.Name = "label1";
            label1.Size = new Size(65, 21);
            label1.TabIndex = 17;
            label1.Text = "Mesero:";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14F);
            button1.Location = new Point(421, 149);
            button1.Name = "button1";
            button1.Size = new Size(243, 219);
            button1.TabIndex = 16;
            button1.Text = "Agregar mesa";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(12, 288);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(402, 79);
            listBox1.TabIndex = 26;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(113, 270);
            label5.Name = "label5";
            label5.Size = new Size(199, 15);
            label5.TabIndex = 25;
            label5.Text = "Platos agregados hasta el momento:";
            // 
            // label4
            // 
            label4.AccessibleName = "lb_ingredientesPlato";
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(13, 207);
            label4.Name = "label4";
            label4.Size = new Size(85, 21);
            label4.TabIndex = 27;
            label4.Text = "Capacidad:";
            // 
            // comboBox2
            // 
            comboBox2.AccessibleName = "txt_platos";
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "NO", "SI" });
            comboBox2.Location = new Point(125, 234);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(42, 23);
            comboBox2.TabIndex = 24;
            // 
            // comboBox3
            // 
            comboBox3.AccessibleName = "txt_platos";
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "Raúl", "Ignacio", "Juan", "Sócrates", "Platón" });
            comboBox3.Location = new Point(125, 147);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(153, 23);
            comboBox3.TabIndex = 28;
            // 
            // label6
            // 
            label6.AccessibleName = "lb_ingredientesPlato";
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(13, 432);
            label6.Name = "label6";
            label6.Size = new Size(223, 21);
            label6.TabIndex = 29;
            label6.Text = "Consumo total de los meseros:";
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 14F);
            button3.Location = new Point(422, 374);
            button3.Name = "button3";
            button3.Size = new Size(243, 126);
            button3.TabIndex = 30;
            button3.Text = "Ver TOP 3 VENTAS";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // menu_mesero_mesas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(675, 512);
            Controls.Add(button3);
            Controls.Add(label6);
            Controls.Add(comboBox3);
            Controls.Add(label4);
            Controls.Add(listBox1);
            Controls.Add(label5);
            Controls.Add(comboBox2);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(button2);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "menu_mesero_mesas";
            Text = "Mesas";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label3;
        private TextBox textBox2;
        private Button button2;
        private ComboBox comboBox1;
        private Label label2;
        private Label label1;
        private Button button1;
        private ListBox listBox1;
        private Label label5;
        private Label label4;
        private ComboBox comboBox2;
        private DataGridViewTextBoxColumn capacidad;
        private DataGridViewTextBoxColumn mesero;
        private DataGridViewTextBoxColumn platos;
        private DataGridViewTextBoxColumn ocupada;
        private DataGridViewCheckBoxColumn liberada;
        private DataGridViewTextBoxColumn numero;
        private ComboBox comboBox3;
        private Label label6;
        private Button button3;
    }
}