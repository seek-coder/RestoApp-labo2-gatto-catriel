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
    public partial class menu_encargado_stock : Form
    {
        private List<Stock> _listaProductosActual;
        public menu_encargado_stock(List<Stock> listaProductos)
        {
            InitializeComponent();
            this._listaProductosActual = listaProductos;

            foreach (Stock producto in _listaProductosActual)
            {
                string[] fila = new string[] { producto.obtenerDatos("id").ToString(), producto.obtenerDatos("nombre").ToString(), producto.obtenerDatos("unidades disponibles").ToString(), producto.obtenerDatos("precio por unidad").ToString() };
                dataGridView1.Rows.Add(fila);
            }

        }
    }
}
