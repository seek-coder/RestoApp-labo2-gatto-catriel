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
            ID = new DataGridViewTextBoxColumn();
            capacidad = new DataGridViewTextBoxColumn();
            mesero = new DataGridViewTextBoxColumn();
            platosAsignados = new DataGridViewTextBoxColumn();
            ocupada = new DataGridViewCheckBoxColumn();
            pago = new DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID, capacidad, mesero, platosAsignados, ocupada, pago });
            dataGridView1.Location = new Point(12, 11);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(644, 251);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.CellEndEdit += dataGridView1_CellEndEdit;
            dataGridView1.CellValueChanged += DataGridView1_CellValueChanged;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.Name = "ID";
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
            // platosAsignados
            // 
            platosAsignados.HeaderText = "PLATOS ASIGNADOS";
            platosAsignados.Name = "platosAsignados";
            // 
            // ocupada
            // 
            ocupada.HeaderText = "OCUPADA";
            ocupada.Name = "ocupada";
            // 
            // pago
            // 
            pago.HeaderText = "CERRADA";
            pago.Name = "pago";
            // 
            // menu_mesero_mesas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(666, 274);
            Controls.Add(dataGridView1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "menu_mesero_mesas";
            Text = "Mesas";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn capacidad;
        private DataGridViewTextBoxColumn mesero;
        private DataGridViewTextBoxColumn platosAsignados;
        private DataGridViewCheckBoxColumn ocupada;
        private DataGridViewCheckBoxColumn pago;
    }
}