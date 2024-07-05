namespace RestoApp
{
    partial class menu_cocinero_platos
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
            nombre = new DataGridViewTextBoxColumn();
            ingredientes = new DataGridViewTextBoxColumn();
            gramos = new DataGridViewTextBoxColumn();
            tiempoDePreparacion = new DataGridViewTextBoxColumn();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            button2 = new Button();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            label5 = new Label();
            listBox1 = new ListBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { nombre, ingredientes, gramos, tiempoDePreparacion });
            dataGridView1.Location = new Point(11, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(553, 251);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // nombre
            // 
            nombre.HeaderText = "NOMBRE";
            nombre.Name = "nombre";
            nombre.ReadOnly = true;
            // 
            // ingredientes
            // 
            ingredientes.HeaderText = "INGREDIENTES";
            ingredientes.Name = "ingredientes";
            ingredientes.ReadOnly = true;
            ingredientes.Width = 180;
            // 
            // gramos
            // 
            gramos.HeaderText = "GRAMOS";
            gramos.Name = "gramos";
            gramos.ReadOnly = true;
            // 
            // tiempoDePreparacion
            // 
            tiempoDePreparacion.HeaderText = "TIEMPO DE PREPARACIÓN (MIN)";
            tiempoDePreparacion.Name = "tiempoDePreparacion";
            tiempoDePreparacion.ReadOnly = true;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14F);
            button1.Location = new Point(421, 273);
            button1.Name = "button1";
            button1.Size = new Size(143, 222);
            button1.TabIndex = 3;
            button1.Text = "Agregar plato";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AccessibleName = "lb_nombrePlato";
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(13, 273);
            label1.Name = "label1";
            label1.Size = new Size(71, 21);
            label1.TabIndex = 4;
            label1.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AccessibleName = "lb_ingredientesPlato";
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 302);
            label2.Name = "label2";
            label2.Size = new Size(168, 21);
            label2.TabIndex = 5;
            label2.Text = "Ingredientes y gramos:";
            label2.Click += label2_Click;
            // 
            // textBox1
            // 
            textBox1.AccessibleName = "txt_nombrePlato";
            textBox1.Location = new Point(125, 273);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(290, 23);
            textBox1.TabIndex = 6;
            // 
            // comboBox1
            // 
            comboBox1.AccessibleName = "txt_ingredientes";
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Milanesas", "Harina de trigo", "Harina de maíz" });
            comboBox1.Location = new Point(186, 302);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(153, 23);
            comboBox1.TabIndex = 7;
            // 
            // button2
            // 
            button2.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ImageAlign = ContentAlignment.TopCenter;
            button2.Location = new Point(393, 302);
            button2.Name = "button2";
            button2.Size = new Size(22, 23);
            button2.TabIndex = 8;
            button2.Text = "+";
            button2.TextAlign = ContentAlignment.TopCenter;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox2
            // 
            textBox2.AccessibleName = "txt_gramos";
            textBox2.Location = new Point(345, 302);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(42, 23);
            textBox2.TabIndex = 10;
            // 
            // label3
            // 
            label3.AccessibleName = "lb_tiempoPlato";
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 332);
            label3.Name = "label3";
            label3.Size = new Size(228, 21);
            label3.TabIndex = 11;
            label3.Text = "Tiempo de preparación en MIN:";
            // 
            // textBox3
            // 
            textBox3.AccessibleName = "txt_tiempoPlatos";
            textBox3.Location = new Point(246, 332);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(42, 23);
            textBox3.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(98, 383);
            label5.Name = "label5";
            label5.Size = new Size(232, 15);
            label5.TabIndex = 14;
            label5.Text = "Ingredientes agregados hasta el momento:";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(13, 401);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(402, 94);
            listBox1.TabIndex = 15;
            // 
            // menu_cocinero_platos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(567, 500);
            Controls.Add(listBox1);
            Controls.Add(label5);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(button2);
            Controls.Add(comboBox1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "menu_cocinero_platos";
            Text = "Platos";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private Button button2;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox3;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn ingredientes;
        private DataGridViewTextBoxColumn gramos;
        private DataGridViewTextBoxColumn tiempoDePreparacion;
        private Label label5;
        private ListBox listBox1;
    }
}