using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using administracion;

namespace RestoApp
{
    public partial class menu_encargado_saldo : Form
    {
        private List<Arca> _listaArcas;
        public menu_encargado_saldo(List<Arca> listaArcas)
        {
            InitializeComponent();
            this._listaArcas = listaArcas;
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
