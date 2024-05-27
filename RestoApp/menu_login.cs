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
        private Cuentas _cuentas;
        public menu_login(Cuentas cuentas)
        {
            InitializeComponent();
            this._cuentas = cuentas;
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
            menu_bienvenida main = new menu_bienvenida(_cuentas);
            main.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string username = this.username.Text;
            string password = this.password.Text;
            // users
            if (_cuentas.VerificarCuenta(username, password))
            {
                MessageBox.Show("Buena bro");
            }
            else
            {
                MessageBox.Show("No es el user o contra pa");
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
    }
}
