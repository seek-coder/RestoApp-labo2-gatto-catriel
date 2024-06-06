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
    public partial class menu_cocinero_platos : Form
    {
        private List<Plato> _listaPlatos;
        public menu_cocinero_platos(List<Plato> listaPlatos)
        {
            InitializeComponent();
            this._listaPlatos = listaPlatos;

            foreach (Plato plato in _listaPlatos)
            {
                List<string> ingredientes = plato.obtenerDatos("ingredientes") as List<string>;
                List<int> gramos = plato.obtenerDatos("gramos") as List<int>;

                // de lista a texto para que se muestre bien en la tabla, sino me tira el nombre del objeto

                string ingredientesString = String.Join(", ", ingredientes);
                string gramosString = String.Join(", ", gramos);

                string[] fila = new string[] { plato.obtenerDatos("nombre").ToString(),
                    ingredientesString,
                    gramosString,
                    plato.obtenerDatos("tiempo de preparación").ToString()};
                dataGridView1.Rows.Add(fila);
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
