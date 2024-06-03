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
using administracion;

namespace RestoApp
{
    
    public partial class menu_login : Form
    {
        private List<Empleado> _listaEmpleados;
        private List<Stock> _listaProductosActual;
        private List<Arca> _listaArcas;
        private List<Proveedor> _listaProveedores;
        public string usernameActual = "¿Nombre?";
        string rol;

        public menu_login(List<Empleado> listaEmpleados, List<Stock> listaProductos, List<Arca> listaArcas, List<Proveedor> listaProveedores)
        {
            InitializeComponent();
            this._listaEmpleados = listaEmpleados;
            this._listaProductosActual = listaProductos;
            this._listaArcas = listaArcas;
            this._listaProveedores = listaProveedores;
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
            menu_bienvenida main = new menu_bienvenida(_listaEmpleados, _listaProductosActual, _listaArcas, _listaProveedores);
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
                    rol = empleado.obtenerDatos("rol").ToString();
                    usernameActual = username;
                    MessageBox.Show($"Bienvenid@ {username}.");
                    break;
                }
            }

            if (!usuarioEncontrado)
            {
                MessageBox.Show("Usuario o contraseña incorrectos.");
                this.username.Text = "";
                this.password.Text = "";
            } 
            else
            {
                this.Hide();
                menu_login login = new menu_login(_listaEmpleados, _listaProductosActual, _listaArcas, _listaProveedores);

                // acá creo los forms directamente con acciones del usuario y NO en los constructores porque me parece más rápido en este caso,
                // donde no tengo que preocuparme por tanto manejo de datos (tengo en cuenta sólo los roles).
                if (rol == "encargado")
                {
                    menu_encargado encargadoForm = new menu_encargado(login, this._listaEmpleados, usernameActual,
                        this._listaProductosActual, this._listaArcas, this._listaProveedores);
                    encargadoForm.Show();
                }

                else if (rol == "mesero")
                {
                    menu_mesero meseroForm = new menu_mesero(login, this._listaEmpleados, usernameActual);
                    meseroForm.Show();
                }

                else if (rol == "cocinero")
                {
                    menu_cocinero cocineroForm = new menu_cocinero(login, this._listaEmpleados, usernameActual);
                    cocineroForm.Show();
                }

                else if (rol == "delivery")
                {
                    menu_delivery deliveryForm = new menu_delivery(login, this._listaEmpleados, usernameActual);
                    deliveryForm.Show();
                }

                else
                {
                    throw new ArgumentException("Rol inválido.");
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

        /*
         * 
         * Hecho con mucho amor y dedicación
         * por Catriel Gatto, en el 2024,
         * mientras estudiaba para programación II de la UTN <3
         * 
         */
    }
}
