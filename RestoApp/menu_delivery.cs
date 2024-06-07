using administracion;
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
    public partial class menu_delivery : Form
    {
        private string currentUserName;
        private List<Empleado> _listaEmpleados;
        private List<Pedido> _listaPedidos;

        private menu_delivery_pedidos _deliveryPedidos;
        private menu_login _login;
        public menu_delivery(menu_login login, List<Empleado> listaEmpleados, string currentUserName, List<Pedido> listaPedidos)
        {
            InitializeComponent();
            this.currentUserName = currentUserName;
            this._login = login;
            this._listaEmpleados = listaEmpleados;
            this._deliveryPedidos = new menu_delivery_pedidos(listaPedidos);
        }
        private void menu_delivery_Load(object sender, EventArgs e)
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
            Application.Exit();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            _deliveryPedidos.Show();
        }
    }
}
