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
        private List<Plato> _listaPlatos;
        private List<Pedido> _listaPedidos;
        private List<Mesa> _listaMesas;
        private List<Producto> _listaProductos;

        private menu_encargado encargadoForm;
        private menu_mesero meseroForm;
        private menu_cocinero cocineroForm;
        private menu_delivery deliveryForm;
        private menu_bienvenida main;

        // public menu_encargado encargadoForm = new menu_encargado(login, _listaEmpleados, usernameActual, _listaProductosActual, _listaArcas, _listaProveedores, _listaMesas, _listaPedidos);
        // menu_login login = new menu_login(_listaEmpleados, _listaProductosActual, _listaArcas, _listaProveedores, _listaPlatos, _listaMesas, _listaPedidos);


        private string usernameActual = "¿Nombre?";
        string rol;

        public menu_login(List<Empleado> listaEmpleados, List<Stock> listaProductos, List<Arca> listaArcas,
            List<Proveedor> listaProveedores, List<Plato> listaPlatos, List<Mesa> listaMesas,
            List<Pedido> listaPedidos)
        {
            InitializeComponent();
            this._listaEmpleados = listaEmpleados;
            this._listaProductosActual = listaProductos;
            this._listaArcas = listaArcas;
            this._listaProveedores = listaProveedores;
            this._listaPlatos = listaPlatos;
            this._listaMesas = listaMesas;
            this._listaPedidos = listaPedidos;

            //this.encargadoForm = new menu_encargado(this, _listaEmpleados, usernameActual,
              //  _listaProductosActual, _listaArcas, _listaProveedores, _listaMesas, _listaPedidos);
            
            //this.cocineroForm = new menu_cocinero(this, _listaEmpleados, usernameActual, _listaPlatos);
            //this.deliveryForm = new menu_delivery(this, _listaEmpleados, usernameActual, _listaPedidos);

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
            this.main = new menu_bienvenida(_listaEmpleados, _listaProductosActual, _listaArcas,
            _listaProveedores, _listaPlatos, _listaMesas, _listaPedidos);
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

                if (rol == "encargado")
                {
                    if (encargadoForm == null)
                    {
                        encargadoForm = new menu_encargado(this, _listaEmpleados, usernameActual,
                            _listaProductosActual, _listaArcas, _listaProveedores, _listaMesas, _listaPedidos);
                    }
                    encargadoForm.Show();

                }

                else if (rol == "mesero")
                {
                    if (meseroForm == null)
                    {
                        this.meseroForm = new menu_mesero(this, _listaEmpleados, usernameActual, _listaMesas, _listaArcas[0], _listaPlatos, _listaProductosActual);
                    }
                    meseroForm.Show();
                }

                else if (rol == "cocinero")
                {
                    if (cocineroForm == null)
                    {
                        cocineroForm = new menu_cocinero(this, _listaEmpleados, usernameActual, _listaPlatos);
                    }
                    cocineroForm.Show();
                }

                else if (rol == "delivery")
                {
                    if (deliveryForm == null)
                    {
                        deliveryForm = new menu_delivery(this, _listaEmpleados,
                            usernameActual, _listaPedidos, _listaArcas[0], _listaPlatos);
                    }
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

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
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
