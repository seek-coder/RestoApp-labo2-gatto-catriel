using administracion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestoApp
{
    public partial class menu_mesero_mesas : Form
    {
        private List<Mesa> _listaMesas;
        private List<Plato> _listaPlatos;
        private double _recaudacionMesa;
        private Arca _arca;
        public menu_mesero_mesas(List<Mesa> listaMesas, Arca arca, List<Plato> listaPlatos)

        {
            InitializeComponent();
            this._recaudacionMesa = 0;
            this._listaMesas = listaMesas;
            this._arca = arca;
            this._listaPlatos = listaPlatos;

            foreach (Mesa mesa in _listaMesas)
            {
                string[] fila = new string[] { mesa.obtenerDatos("id").ToString(),
                    mesa.obtenerDatos("capacidad").ToString(),
                    mesa.obtenerDatos("mesero").ToString(),
                    mesa.obtenerDatos("platos").ToString() };
                dataGridView1.Rows.Add(fila);

            }
            dataGridView1.CellValueChanged += DataGridView1_CellValueChanged;

        }

        private void DataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5 && e.RowIndex >= 0)
            {
                DataGridViewCheckBoxCell chkCell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex] as DataGridViewCheckBoxCell;
                if ((bool)chkCell.Value)
                {
                    Plato plato = _listaPlatos[e.RowIndex];
                    double precioPlato = Convert.ToDouble(plato.obtenerDatos("precio"));

                    _arca.agregarSaldo(precioPlato);
                    MessageBox.Show($"Saldo agregado: {precioPlato}");
                    MessageBox.Show($"Nuevo saldo en arca: {_arca.obtenerSaldo().ToString()}");
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
