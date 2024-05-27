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
        private List<Empleado> listaEmpleados;
        public menu_login(List<Empleado> listaEmpleados)
        {
            InitializeComponent();
            this.listaEmpleados = listaEmpleados;
            // this._cuentas = cuentas;
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
            menu_bienvenida main = new menu_bienvenida(listaEmpleados);
            main.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = this.username.Text;
            string password = this.password.Text;

            bool usuarioEncontrado = false;

            // users
            foreach (Empleado empleado in listaEmpleados)
            {
                if (username.ToLower() == empleado.obtenerDatos("usuario").ToString() &&
                    password == empleado.obtenerDatos("contraseña").ToString())
                {
                    usuarioEncontrado = true;
                    MessageBox.Show("Buena bro");
                    break;
                }
            }

            if (!usuarioEncontrado)
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
                this.username.Text = "";
                this.password.Text = "";
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
    }
}
