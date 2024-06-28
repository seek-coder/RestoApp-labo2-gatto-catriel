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
    public partial class menu_mesero : Form
    {
        private string currentUserName;
        private List<Empleado> _listaEmpleados;
        private List<Mesa> _listaMesas;
        private menu_login _login;
        private menu_mesero_mesas _meseroMesas;
        private List<Plato> _listaPlatos;
        private Arca _arca;
        private List<Stock> _listaProductos;
        public menu_mesero(menu_login login, List<Empleado> listaEmpleados, string currentUserName,
            List<Mesa> listaMesas, Arca arca, List<Plato> listaPlatos, List<Stock> listaProductos)
        {
            InitializeComponent();
            this.currentUserName = currentUserName;
            this._login = login;
            this._listaEmpleados = listaEmpleados;
            this._listaMesas = listaMesas;
            this._meseroMesas = new menu_mesero_mesas(listaMesas, arca, listaPlatos, listaProductos);
            this._arca = arca;
            this._listaPlatos = listaPlatos;

            this._meseroMesas.FormClosing += new FormClosingEventHandler(Form_Closing);
            this._listaProductos = listaProductos;
        }


        // creo método para manejar cierre de forms
        private void Form_Closing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;  // cancelo el cierre
            ((Form)sender).Hide();  // oculto el form
        }


    private void menu_mesero_Load(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            this._meseroMesas.FormClosing -= new FormClosingEventHandler(Form_Closing);
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _meseroMesas.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            _login.Show();
        }
    }
}
