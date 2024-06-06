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
using usuarios;

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
            // encuentro primera arca cuyo saldo sea mayor a 0
            Arca arcaN = _listaArcas.FirstOrDefault(arca => arca.obtenerSaldo() > 0);
            string arcaNSaldo = arcaN.obtenerSaldo().ToString();

            // manejo una sola arca porque es lo común en ámbitos gastronómicos, pero dejo abierto a mejoras para agregar más
            if (comboBox1.Text == "Arca1")
            {
                MessageBox.Show($"El arca cuenta con un saldo de ${arcaNSaldo}");
            }
        }
    }
}
