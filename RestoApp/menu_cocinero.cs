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
    public partial class menu_cocinero : Form
    {
        private string currentUserName;
        private List<Empleado> _listaEmpleados;
        private List<Plato> _listaPlatos;

        private menu_login _login;
        private menu_cocinero_platos _cocineroPlatos;
        public menu_cocinero(menu_login login, List<Empleado> listaEmpleados, string currentUserName, List<Plato> listaPlatos)
        {
            InitializeComponent();
            this.currentUserName = currentUserName;
            this._listaEmpleados = listaEmpleados;
            this._login = login;
            this._listaPlatos = listaPlatos;

            this._cocineroPlatos = new menu_cocinero_platos(listaPlatos, listaEmpleados);

            this._cocineroPlatos.FormClosing += new FormClosingEventHandler(Form_Closing);
        }



        // creo método para manejar cierre de forms
        private void Form_Closing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;  // cancelo el cierre
            ((Form)sender).Hide();  // oculto el form
        }

        private void menu_cocinero_Load(object sender, EventArgs e)
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
            this._cocineroPlatos.FormClosing -= new FormClosingEventHandler(Form_Closing);

            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _cocineroPlatos.Show();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            _login.Show();
        }
    }
}
