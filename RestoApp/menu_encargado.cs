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

        public menu_encargado(menu_login login)
        {
            InitializeComponent();
            this._login = login;
            currentUserName = _login.getCurrentUsername();
        }

        // creo método para carga del form
        private void menu_encargado_Load(object sender, EventArgs e)
        {
            label4.Text = $"Nombre: {currentUserName}";
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
