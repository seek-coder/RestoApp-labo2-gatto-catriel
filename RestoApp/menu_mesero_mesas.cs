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
using usuarios;

namespace RestoApp
{
    public partial class menu_mesero_mesas : Form
    {
        private List<Mesa> _listaMesas;
        private List<Plato> _listaPlatos;
        private List<Stock> _listaProductos;

        private double _recaudacionMesa;
        private Arca _arca;
        public menu_mesero_mesas(List<Mesa> listaMesas, Arca arca, List<Plato> listaPlatos, List<Stock> listaProductos)

        {
            InitializeComponent();
            this._recaudacionMesa = 0;
            this._listaMesas = listaMesas;
            this._arca = arca;
            this._listaPlatos = listaPlatos;
            this._listaProductos = listaProductos;

            foreach (Mesa mesa in _listaMesas)
            {
                DataGridViewRow fila = new DataGridViewRow();
                fila.CreateCells(dataGridView1);

                fila.Cells[0].Value = mesa.obtenerDatos("id").ToString();
                fila.Cells[1].Value = mesa.obtenerDatos("capacidad").ToString();
                fila.Cells[2].Value = mesa.obtenerDatos("mesero").ToString();
                fila.Cells[3].Value = mesa.obtenerDatos("platos");

                dataGridView1.Rows.Add(fila);

            }

        }

        private void DataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == 5 && e.RowIndex >= 0)
            {
                DataGridViewCheckBoxCell chkCell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex] as DataGridViewCheckBoxCell;
                bool boolValue = (bool)chkCell.Value;
                if (boolValue)
                {
                    Plato plato = _listaPlatos[e.RowIndex];
                    double precioPlato = Convert.ToDouble(plato.obtenerDatos("precio"));

                    _arca.agregarSaldo(precioPlato);
                    MessageBox.Show($"Consumo agregado de la mesa: ${precioPlato}");
                    MessageBox.Show($"Nuevo saldo en arca: ${_arca.obtenerSaldo().ToString()}");

                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
