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
    public partial class menu_delivery_pedidos : Form
    {
        private List<Pedido> _listaPedidos;
        private List<string> _listaDelivery;
        private Arca _arca;
        public menu_delivery_pedidos(List<Pedido> listaPedidos, Arca arca, List<string> listaDelivery)
        {
            InitializeComponent();


            this._listaPedidos = listaPedidos;
            this._arca = arca;
            this._listaDelivery = listaDelivery;

            foreach (Pedido pedido in listaPedidos)
            {
                string[] fila = new string[] {
                    pedido.obtenerDatos("id").ToString(),
                    (string)pedido.obtenerDatos("platos"),
                    pedido.obtenerDatos("conductor").ToString() };
                dataGridView1.Rows.Add(fila);
            }


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3 && e.RowIndex >= 0)
            {
                DataGridViewCheckBoxCell chkCell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex] as DataGridViewCheckBoxCell;
                bool boolValue = (bool)chkCell.Value;
                if (boolValue)
                {
                    // filtro el tipo a "IDelivery" y devuelvo el primer tipo que concida con la condición
                    IDelivery delivery = _listaDelivery.OfType<IDelivery>().FirstOrDefault();

                    delivery.realizarEntrega();
                    Pedido pedido = _listaPedidos[e.RowIndex];
                    double precioPedido = Convert.ToDouble(pedido.obtenerPrecioTotalPedidos());

                    _arca.agregarSaldo(precioPedido);
                    MessageBox.Show($"Consumo agregado de la mesa: ${precioPedido}");
                    MessageBox.Show($"Nuevo saldo en arca: ${_arca.obtenerSaldo().ToString()}");

                }
            }
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
