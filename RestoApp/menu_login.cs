using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestoApp
{
    public partial class menu_login : Form
    {
        public menu_login()
        {
            InitializeComponent();
        }

        private void menu_login_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            welcome.Show();
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = this.username.Text;
            string password = this.password.Text;
            // users
            if(username == "Catriel" & password == "clave1")
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
    }
}
