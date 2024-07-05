namespace RestoApp
{
    partial class menu_delivery_pedidos
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
            listBox1 = new ListBox();
            label5 = new Label();
            comboBox1 = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            repartidos = new DataGridViewTextBoxColumn();
            platos = new DataGridViewTextBoxColumn();
            entregado = new DataGridViewCheckBoxColumn();
            button2 = new Button();
            comboBox2 = new ComboBox();
            label3 = new Label();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(12, 233);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(402, 94);
            listBox1.TabIndex = 38;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(107, 215);
            label5.Name = "label5";
            label5.Size = new Size(199, 15);
            label5.TabIndex = 37;
            label5.Text = "Platos agregados hasta el momento:";
            // 
            // comboBox1
            // 
            comboBox1.AccessibleName = "txt_platos";
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Milanesas de pollo con puré de papas", "Ñoquis", "Polenta con tuco" });
            comboBox1.Location = new Point(125, 177);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(153, 23);
            comboBox1.TabIndex = 33;
            // 
            // label2
            // 
            label2.AccessibleName = "lb_ingredientesPlato";
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(13, 179);
            label2.Name = "label2";
            label2.Size = new Size(55, 21);
            label2.TabIndex = 31;
            label2.Text = "Platos:";
            // 
            // label1
            // 
            label1.AccessibleName = "lb_nombrePlato";
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(13, 150);
            label1.Name = "label1";
            label1.Size = new Size(87, 21);
            label1.TabIndex = 30;
            label1.Text = "Repartidor:";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14F);
            button1.Location = new Point(421, 150);
            button1.Name = "button1";
            button1.Size = new Size(243, 177);
            button1.TabIndex = 29;
            button1.Text = "Agregar pedido";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { repartidos, platos, entregado });
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(653, 130);
            dataGridView1.TabIndex = 28;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_2;
            dataGridView1.CellValueChanged += dataGridView1_CellValueChanged;
            // 
            // repartidos
            // 
            repartidos.HeaderText = "REPARTIDOR";
            repartidos.Name = "repartidos";
            // 
            // platos
            // 
            platos.HeaderText = "PLATOS";
            platos.Name = "platos";
            // 
            // entregado
            // 
            entregado.HeaderText = "ENTREGADO";
            entregado.Name = "entregado";
            // 
            // button2
            // 
            button2.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ImageAlign = ContentAlignment.TopCenter;
            button2.Location = new Point(284, 177);
            button2.Name = "button2";
            button2.Size = new Size(22, 23);
            button2.TabIndex = 39;
            button2.Text = "+";
            button2.TextAlign = ContentAlignment.TopCenter;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // comboBox2
            // 
            comboBox2.AccessibleName = "txt_platos";
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Tomás", "Joaquín", "Kant", "Nietzsche", "Leibniz" });
            comboBox2.Location = new Point(125, 148);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(153, 23);
            comboBox2.TabIndex = 40;
            // 
            // label3
            // 
            label3.AccessibleName = "lb_ingredientesPlato";
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(13, 387);
            label3.Name = "label3";
            label3.Size = new Size(219, 21);
            label3.TabIndex = 41;
            label3.Text = "Consumo total de los delivery:";
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 14F);
            button3.Location = new Point(420, 333);
            button3.Name = "button3";
            button3.Size = new Size(243, 126);
            button3.TabIndex = 42;
            button3.Text = "Ver TOP 3 VENTAS";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // menu_delivery_pedidos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(675, 466);
            Controls.Add(button3);
            Controls.Add(label3);
            Controls.Add(comboBox2);
            Controls.Add(button2);
            Controls.Add(listBox1);
            Controls.Add(label5);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "menu_delivery_pedidos";
            Text = "Form1";
            Load += menu_delivery_pedidos_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Label label5;
        private ComboBox comboBox1;
        private Label label2;
        private Label label1;
        private Button button1;
        private DataGridView dataGridView1;
        private Button button2;
        private DataGridViewTextBoxColumn repartidos;
        private DataGridViewTextBoxColumn platos;
        private DataGridViewCheckBoxColumn entregado;
        private ComboBox comboBox2;
        private Label label3;
        private Button button3;
    }
}