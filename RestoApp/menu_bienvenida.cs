using administracion;
using System.Collections.Generic;
using usuarios;

namespace RestoApp
{
    public partial class menu_bienvenida : Form
    {
        private menu_login _login;
        private List<Empleado> listaEmpleados;
        private List<Stock> _listaProductos;
        private List<Arca> _listaArcas;
        private List<Proveedor> _listaProveedores;
        private List<Plato> _listaPlatos;
        private List<Pedido> _listaPedidos;
        private List<Mesa> _listaMesas;
        public menu_bienvenida(List<Empleado> empleados, List<Stock> listaProductos, List<Arca> listaArcas,
            List<Proveedor> listaProveedores, List<Plato> listaPlatos, List<Mesa> listaMesas, List<Pedido> listaPedidos)
        {
            InitializeComponent();
            this.listaEmpleados = empleados;
            this._listaProductos = listaProductos;
            this._login = new menu_login(listaEmpleados, listaProductos, listaArcas, listaProveedores,
                listaPlatos, listaMesas, listaPedidos);
            this._listaArcas = listaArcas;
            this._listaProveedores = listaProveedores;
            this._listaPlatos = listaPlatos;
            this._listaMesas = listaMesas;
            this._listaPedidos = listaPedidos;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn_sc__Click(object sender, EventArgs e)
        {
            this.Hide();
            _login.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("© 2024, 'RestoApp' por Catriel Gatto. Todos los derechos reservados.\n\n Trabajo práctico para Programación/Laboratorio II de la UTN");
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
