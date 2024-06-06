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
        public menu_mesero_mesas(List<Mesa> listaMesas)

        {
            InitializeComponent();
            this._listaMesas = listaMesas;

            foreach (Mesa mesa in _listaMesas)
            {
                string[] fila = new string[] { mesa.obtenerDatos("id").ToString(), mesa.obtenerDatos("capacidad").ToString(),
                    mesa.obtenerDatos("mesero").ToString() };
                dataGridView1.Rows.Add(fila);
            }
            
        }
    }
}
