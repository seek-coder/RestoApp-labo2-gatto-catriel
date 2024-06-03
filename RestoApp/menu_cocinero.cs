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
    public partial class menu_cocinero : Form
    {
        private string currentUserName;
        private List<Empleado> _listaEmpleados;
        private menu_login _login;
        public menu_cocinero(menu_login login, List<Empleado> listaEmpleados, string currentUserName)
        {
            InitializeComponent();
            this.currentUserName = currentUserName;
            this._listaEmpleados = listaEmpleados;
            this._login = login;
        }
    }
}
