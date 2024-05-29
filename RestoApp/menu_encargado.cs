using System;
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

namespace RestoApp
{

    public partial class menu_encargado : Form
    {
        private menu_login _login;
        private string currentUserName;
        private List<Empleado> _listaEmpleados;

        public menu_encargado(menu_login login, List<Empleado> listaEmpleados, string currentUserName)
        {
            InitializeComponent();
            this._login = login;
            this.currentUserName = currentUserName;
            this._listaEmpleados = listaEmpleados;
        }

        // creo método para carga del form
        private void menu_encargado_Load(object sender, EventArgs e)
        {
            Empleado empleadoN = _listaEmpleados.FirstOrDefault(emp => emp.obtenerDatos("usuario").ToString() == currentUserName);

            // Ahora puedes acceder a los datos del empleado1
            if (empleadoN != null)
            {
                string nombreEmpleadoN = empleadoN.obtenerDatos("nombre").ToString();
                string apellidoEmpleadoN = empleadoN.obtenerDatos("apellido").ToString();
                string direccionEmpleadoN = empleadoN.obtenerDatos("direccion").ToString();
                string contactoEmpleadoN = empleadoN.obtenerDatos("contacto").ToString();

                // Puedes utilizar estos datos como desees, por ejemplo, mostrarlos en un MessageBox
                label4.Text = $"Nombre: {nombreEmpleadoN}";
                label5.Text = $"Apellido: {apellidoEmpleadoN}";
                label6.Text = $"Dirección: {direccionEmpleadoN}";
                label7.Text = $"Contacto: {contactoEmpleadoN}";
            }
            
            //MessageBox.Show("Test");
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {
            // cambio el texto del label cuando el formulario se carga
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
