namespace RestoApp
{
    partial class menu_encargado_proveedores
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
            product_type = new DataGridViewTextBoxColumn();
            payment_method = new DataGridViewTextBoxColumn();
            nombre = new DataGridViewTextBoxColumn();
            cuit = new DataGridViewTextBoxColumn();
            direccion = new DataGridViewTextBoxColumn();
            pago = new DataGridViewCheckBoxColumn();
            monto = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { product_type, payment_method, nombre, cuit, direccion, pago, monto });
            dataGridView1.Location = new Point(11, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(744, 251);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.CellValueChanged += dataGridView1_CellValueChanged;
            // 
            // product_type
            // 
            product_type.HeaderText = "TIPO DE PRODUCTO QUE PROVEE";
            product_type.Name = "product_type";
            // 
            // payment_method
            // 
            payment_method.HeaderText = "MEDIO DE PAGO";
            payment_method.Name = "payment_method";
            // 
            // nombre
            // 
            nombre.HeaderText = "NOMBRE";
            nombre.Name = "nombre";
            // 
            // cuit
            // 
            cuit.HeaderText = "CUIT";
            cuit.Name = "cuit";
            // 
            // direccion
            // 
            direccion.HeaderText = "DIRECCIÓN";
            direccion.Name = "direccion";
            // 
            // pago
            // 
            pago.HeaderText = "¿PAGAR?";
            pago.Name = "pago";
            // 
            // monto
            // 
            monto.HeaderText = "MONTO A PAGAR";
            monto.Name = "monto";
            // 
            // menu_encargado_proveedores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(765, 274);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "menu_encargado_proveedores";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn product_type;
        private DataGridViewTextBoxColumn payment_method;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn cuit;
        private DataGridViewTextBoxColumn direccion;
        private DataGridViewCheckBoxColumn pago;
        private DataGridViewTextBoxColumn monto;
    }
}