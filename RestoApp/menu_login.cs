using Microsoft.VisualBasic.Logging;
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
    
    public partial class menu_login : Form
    {
        // private Cuentas _cuentas;
        private List<Empleado> _listaEmpleados;
        public string usernameActual = "¿Nombre?";

        public menu_login(List<Empleado> listaEmpleados)
        {
            InitializeComponent();
            this._listaEmpleados = listaEmpleados;
        }

        private void menu_login_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu_bienvenida main = new menu_bienvenida(_listaEmpleados);
            main.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = this.username.Text;
            string password = this.password.Text;

            bool usuarioEncontrado = false;

            // usuarios
            foreach (Empleado empleado in _listaEmpleados)
            {
                if (username.ToLower() == empleado.obtenerDatos("usuario").ToString() &&
                    password == empleado.obtenerDatos("contraseña").ToString())
                {
                    usuarioEncontrado = true;
                    usernameActual = username;
                    MessageBox.Show($"Bienvenid@ {username}.");
                    break;
                }
            }

            if (!usuarioEncontrado)
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
                this.username.Text = "";
                this.password.Text = "";
            } 
            else
            {
                if (usernameActual == "catriel") // probar con el método de arriba
                {
                    this.Hide();
                    menu_login login = new menu_login(_listaEmpleados);
                    menu_encargado encargadoForm = new menu_encargado(login, this._listaEmpleados, usernameActual);
                    encargadoForm.Show();
                }
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        public string getCurrentUsername() { return usernameActual; }
    }
}
