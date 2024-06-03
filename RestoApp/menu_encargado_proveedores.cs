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
    public partial class menu_encargado_proveedores : Form
    {
        private List<Proveedor> _listaProveedores;
        public menu_encargado_proveedores(List<Proveedor> listaProveedores)
        {
            InitializeComponent();
            this._listaProveedores = listaProveedores;

            foreach (Proveedor prov in _listaProveedores)
            {
                string[] fila = new string[] { prov.obtenerDatos("tipo de producto").ToString(),
                    prov.obtenerDatos("medio de pago").ToString(),
                    prov.obtenerDatos("nombre").ToString(),
                    prov.obtenerDatos("CUIT").ToString(),
                    prov.obtenerDatos("dirección").ToString()};
                dataGridView1.Rows.Add(fila);
            }
        }
    }
}
