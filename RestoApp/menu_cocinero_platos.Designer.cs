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
            dataGridView1.Size = new Size(539, 251);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // nombre
            // 
            nombre.HeaderText = "NOMBRE";
            nombre.Name = "nombre";
            // 
            // ingredientes
            // 
            ingredientes.HeaderText = "INGREDIENTES";
            ingredientes.Name = "ingredientes";
            // 
            // gramos
            // 
            gramos.HeaderText = "GRAMOS";
            gramos.Name = "gramos";
            // 
            // tiempoDePreparacion
            // 
            tiempoDePreparacion.HeaderText = "TIEMPO DE PREPARACIÓN (MIN)";
            tiempoDePreparacion.Name = "tiempoDePreparacion";
            // 
            // menu_cocinero_platos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(562, 274);
            Controls.Add(dataGridView1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "menu_cocinero_platos";
            Text = "Platos";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn ingredientes;
        private DataGridViewTextBoxColumn gramos;
        private DataGridViewTextBoxColumn tiempoDePreparacion;
    }
}