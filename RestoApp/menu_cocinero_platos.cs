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
    public partial class menu_cocinero_platos : Form
    {
        private List<Plato> _listaPlatos;
        private List<Empleado> _listaEmpleados;
        public menu_cocinero_platos(List<Plato> listaPlatos, List<Empleado> listaEmpleados)
        {
            InitializeComponent();
            this._listaPlatos = listaPlatos;
            this._listaEmpleados = listaEmpleados;

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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != null && textBox3.Text != null && listBox1.Text != null
                && textBox1.Text != "" && textBox3.Text != "" && listBox1.Items.Count > 0)
            {
                string nombreDelPlato = textBox1.Text;
                string tiempoDePreparacion = textBox3.Text;

                List<string> ingredientesList = new List<string>();
                List<int> gramosList = new List<int>();

                foreach (var item in listBox1.Items)
                {
                    string itemString = item.ToString();
                    string nombreIngrediente = itemString.Substring(0, itemString.LastIndexOf(","));
                    ingredientesList.Add(nombreIngrediente.Trim());

                    string gramosText = itemString.Substring(itemString.LastIndexOf(",") + 2).Trim();
                    if (int.TryParse(gramosText.Split(' ')[0], out int gramos))
                    {
                        gramosList.Add(gramos);
                    }
                }

                string ingredientesString = string.Join(", ", ingredientesList);
                string gramosString = string.Join(", ", gramosList);

                    string[] fila = new string[]
                    {

                        nombreDelPlato,
                        ingredientesString,
                        gramosString,
                        tiempoDePreparacion
                    };
                    dataGridView1.Rows.Add(fila);

                }
            listBox1.Items.Clear();
            }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                string productoSeleccionado = comboBox1.SelectedItem.ToString();
                string gramos = textBox2.Text;

                var ingredientes = new Dictionary<string, int>()
                {
                    {productoSeleccionado,  Int32.Parse(gramos)}
                };

                // agrego elementos a la lista de ingredientes y gramos
                if (gramos != null && int.TryParse(gramos, out _))
                {
                    foreach (var item in ingredientes)
                    {
                        listBox1.Items.Add($"{item.Key}, {item.Value} gramos");
                    }

                    comboBox1.SelectedIndex = -1;
                    textBox2.Text = string.Empty;
                }
            }
        }
    }
}
