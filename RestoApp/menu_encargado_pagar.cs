﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using usuarios;
using administracion;

namespace RestoApp
{
    public partial class menu_encargado_pagar : Form
    {
        private List<Empleado> _listaEmpleados;
        private List<Arca> _listaArcas;

        public int encargadosPagados = 0;
        public menu_encargado_pagar(List<Empleado> listaEmpleados, List<Arca> listaArcas)
        {
            InitializeComponent();
            this._listaEmpleados = listaEmpleados;
            this._listaArcas = listaArcas;
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null && comboBox1.SelectedItem != "" && _listaArcas[0].obtenerSaldo() > 0)
            {
                string nombreEmpleadoN = comboBox1.SelectedItem.ToString();

                Empleado empleadoN = _listaEmpleados.FirstOrDefault(emp => (emp.obtenerDatos("nombre")) == nombreEmpleadoN);

                string sueldoEmpleadoN = empleadoN.obtenerDatos("sueldo").ToString();

                if (empleadoN.obtenerDatos("rol").ToString() == "encargado" && encargadosPagados < 2)
                {
                    DialogResult result = MessageBox.Show($"¿Desea continuar con el pago mensual de ${sueldoEmpleadoN} para {nombreEmpleadoN}?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    // filtro el tipo a "IEncargado" y devuelvo el primer tipo que concida con la condición
                    IEncargado encargado = _listaEmpleados.OfType<IEncargado>().FirstOrDefault();

                    if (result == DialogResult.Yes)
                    {
                        // pago el sueldo y lo resto del arca, que en este caso es la única que existe (la primera)
                        encargado.pagarSueldoMensual(empleadoN, _listaArcas[0]);
                        MessageBox.Show($"El sueldo ha sido depositado a {nombreEmpleadoN} con éxito.");
                        comboBox1.Items.Remove(nombreEmpleadoN);
                        encargadosPagados += 1;

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
                    MessageBox.Show($"Recuerda: los primeros en cobrar son los encargados.");
                }


                if (empleadoN.obtenerDatos("rol").ToString() != "encargado" && encargadosPagados >= 2)
                {
                    DialogResult result = MessageBox.Show($"¿Desea continuar con el pago mensual de ${sueldoEmpleadoN} para {nombreEmpleadoN}?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    // filtro el tipo a "IEncargado" y devuelvo el primer tipo que concida con la condición
                    IEncargado encargado = _listaEmpleados.OfType<IEncargado>().FirstOrDefault();

                    if (result == DialogResult.Yes)
                    {
                        // pago el sueldo y lo resto del arca, que en este caso es la única que existe (la primera)
                        encargado.pagarSueldoMensual(empleadoN, _listaArcas[0]);
                        MessageBox.Show($"El sueldo ha sido depositado a {nombreEmpleadoN} con éxito.");
                        comboBox1.Items.Remove(nombreEmpleadoN);
                        encargadosPagados += 1;

                        // si ya no hay más items en el combobox, agregar un ítem vacío y seleccionarlo para evitar que quede el último ítem activo
                        if (comboBox1.Items.Count == 0)
                        {
                            comboBox1.Items.Add("");
                            comboBox1.SelectedIndex = 0;
                        }
                    }
                }


                }

            else
            {
                MessageBox.Show($"Ningún empleado ha sido seleccionado o no hay monto disponible para utilizar.");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void menu_encargado_pagar_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
