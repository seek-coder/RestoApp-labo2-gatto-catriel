using administracion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestoApp
{
    public partial class menu_encargado_proveedores : Form
    {
        private List<Proveedor> _listaProveedores;
        private List<Arca> _listaArcas;
        public int contadoCount = 0;
        public int tarjetaCount = 0;
        public int transferenciaCount = 0;
        public menu_encargado_proveedores(List<Proveedor> listaProveedores, List<Arca> listaArcas)
        {
            InitializeComponent();
            this._listaProveedores = listaProveedores;
            this._listaArcas = listaArcas;

            foreach (Proveedor prov in _listaProveedores)
            {
                DataGridViewRow fila = new DataGridViewRow();
                fila.CreateCells(dataGridView1);

                fila.Cells[0].Value = prov.obtenerDatos("tipo de producto").ToString();
                fila.Cells[1].Value = prov.obtenerDatos("medio de pago").ToString();
                fila.Cells[2].Value = prov.obtenerDatos("nombre").ToString();
                fila.Cells[3].Value = prov.obtenerDatos("CUIT").ToString();
                fila.Cells[4].Value = prov.obtenerDatos("dirección").ToString();
                fila.Cells[6].Value = prov.obtenerDatos("cuenta corriente").ToString();

                dataGridView1.Rows.Add(fila);
            }
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == 5 && e.RowIndex >= 0)
            {
                DataGridViewCheckBoxCell chkCell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex] as DataGridViewCheckBoxCell;
                bool boolValue = (bool)chkCell.Value;

                if (boolValue)
                {
                    DataGridViewCell cell = dataGridView1.Rows[e.RowIndex].Cells[1];
                    double monto = Convert.ToDouble(dataGridView1.Rows[e.RowIndex].Cells[6].Value);

                    if (cell.Value != null)
                    {
                        string medioDePago = cell.Value.ToString();

                        switch (medioDePago)
                        {
                            case "Contado":
                                contadoCount++;
                                break;
                            case "Tarjeta":
                                tarjetaCount++;
                                break;
                            case "Transferencia":
                                transferenciaCount++;
                                break;
                        }
                        _listaArcas[0].restarSaldo(monto);
                        MessageBox.Show($"Monto restado del arca para pagar al proveedor: ${monto}");
                        MessageBox.Show($"Medios de pago utilizados. Contado: {contadoCount}, Tarjeta: {tarjetaCount}, Transferencia: {transferenciaCount}");
                    }
                }
            }


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
