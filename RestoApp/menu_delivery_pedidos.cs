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
    public partial class menu_delivery_pedidos : Form
    {
        private List<Pedido> _listaPedidos;
        public menu_delivery_pedidos(List<Pedido> listaPedidos)
        {
            InitializeComponent();

            this._listaPedidos = listaPedidos;

            foreach (Pedido pedido in listaPedidos)
            {
                string[] fila = new string[] { pedido.obtenerDatos("id").ToString(),
                    pedido.obtenerDatos("conductor").ToString() };
                dataGridView1.Rows.Add(fila);
            }
            
        }
    }
}
