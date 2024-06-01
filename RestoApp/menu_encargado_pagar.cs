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
    public partial class menu_encargado_pagar : Form
    {
        private List<Empleado> _listaEmpleados;
        public menu_encargado_pagar(List<Empleado> listaEmpleados)
        {
            InitializeComponent();
            this._listaEmpleados = listaEmpleados;
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null && comboBox1.SelectedItem != "")
            {
                string nombreEmpleadoN = comboBox1.SelectedItem.ToString();

                Empleado empleadoN = _listaEmpleados.FirstOrDefault(emp => (emp.obtenerDatos("nombre")) == nombreEmpleadoN);

                string sueldoEmpleadoN = empleadoN.obtenerDatos("sueldo").ToString();

                DialogResult result = MessageBox.Show($"¿Desea continuar con el pago mensual de ${sueldoEmpleadoN} para {nombreEmpleadoN}?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                // filtro el tipo a "IEncargado" y devuelvo el primer tipo que concida con la condición
                IEncargado encargado = _listaEmpleados.OfType<IEncargado>().FirstOrDefault();

                if (result == DialogResult.Yes)
                {
                    encargado.pagarSueldoMensual(empleadoN);
                    MessageBox.Show($"El sueldo ha sido depositado a {nombreEmpleadoN} con éxito.");
                    comboBox1.Items.Remove(nombreEmpleadoN);

                    // si ya no hay más items en el combobox, agregar un ítem vacío y seleccionarlo para evitar que quede el último ítem activo
                    if (comboBox1.Items.Count == 0)
                    {
                        comboBox1.Items.Add("");
                        comboBox1.SelectedIndex = 0;
                    }
                }
            }

            else
            {
                MessageBox.Show($"Ningún empleado ha sido seleccionado.");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
