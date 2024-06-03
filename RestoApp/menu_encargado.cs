﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using usuarios;
using administracion;

namespace RestoApp
{

    public partial class menu_encargado : Form
    {
        private menu_encargado_pagar _encargadoPagar;
        private menu_encargado_stock _encargadoStock;
        private menu_encargado_saldo _encargadoSaldo;
        private menu_encargado_proveedores _encargadoProveedor;

        private string currentUserName;
        private List<Empleado> _listaEmpleados;
        private menu_login _login;
        private List<Stock> _listaProductosActual;
        private List<Arca> _listaArcas;
        private List<Proveedor> _listaProveedores;

        public menu_encargado(menu_login login, List<Empleado> listaEmpleados, string currentUserName,
            List<Stock> listaProductos, List<Arca> listaArcas, List<Proveedor> listaProveedores)
        {
            InitializeComponent();
            this._login = login;
            this.currentUserName = currentUserName;
            this._listaEmpleados = listaEmpleados;
            this._encargadoPagar = new menu_encargado_pagar(listaEmpleados);
            this._encargadoStock = new menu_encargado_stock(listaProductos);
            this._encargadoSaldo = new menu_encargado_saldo(listaArcas);
            this._encargadoProveedor = new menu_encargado_proveedores(listaProveedores);
            this._listaProductosActual = listaProductos;
            this._listaArcas = listaArcas;
            this._listaProveedores = listaProveedores;

            // manejo cierre de forms y en su lugar oculto el form
            this._encargadoPagar.FormClosing += new FormClosingEventHandler(Form_Closing);
            this._encargadoStock.FormClosing += new FormClosingEventHandler(Form_Closing);
            this._encargadoSaldo.FormClosing += new FormClosingEventHandler(Form_Closing);
            this._encargadoProveedor.FormClosing += new FormClosingEventHandler(Form_Closing);

        }

        // creo método para manejar cierre de forms
        private void Form_Closing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;  // cancelo el cierre
            ((Form)sender).Hide();  // oculto el form
        }

        // creo método para carga del form
        private void menu_encargado_Load(object sender, EventArgs e)
        {
            Empleado empleadoN = _listaEmpleados.FirstOrDefault(emp => emp.obtenerDatos("usuario").ToString() == currentUserName);

            // acceso a datos el empleadoN. Evalúo null porque sino me tira error
            if (empleadoN != null)
            {
                string nombreEmpleadoN = empleadoN.obtenerDatos("nombre").ToString();
                string apellidoEmpleadoN = empleadoN.obtenerDatos("apellido").ToString();
                string direccionEmpleadoN = empleadoN.obtenerDatos("direccion").ToString();
                string contactoEmpleadoN = empleadoN.obtenerDatos("contacto").ToString();

                label4.Text = $"Nombre: {nombreEmpleadoN}";
                label5.Text = $"Apellido: {apellidoEmpleadoN}";
                label6.Text = $"Dirección: {direccionEmpleadoN}";
                label7.Text = $"Contacto: {contactoEmpleadoN}";
            }
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // quito el manejo cierre de forms´para que no me bloquee el cierre de la app
            this._encargadoPagar.FormClosing -= new FormClosingEventHandler(Form_Closing);
            this._encargadoStock.FormClosing -= new FormClosingEventHandler(Form_Closing);
            this._encargadoSaldo.FormClosing -= new FormClosingEventHandler(Form_Closing);
            this._encargadoProveedor.FormClosing -= new FormClosingEventHandler(Form_Closing);

            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            _encargadoPagar.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _encargadoStock.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            _encargadoSaldo.Show();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            _encargadoProveedor.Show();
        }
    }
}
