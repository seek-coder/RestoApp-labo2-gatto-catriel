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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RestoApp
{
    public partial class menu_mesero_mesas : Form
    {
        private List<Mesa> _listaMesas;
        private List<Plato> _listaPlatos;
        private List<Stock> _listaProductos;
        private List<Mesa> _listaMesasParaAgregar = new List<Mesa>();

        private double _recaudacionMesa;
        private Arca _arca;

        public int countMesa = 0;
        public double consumoMesero = 0;

        // top 3 ventas
        private Dictionary<string, double> _ventasMeseros = new Dictionary<string, double>();

        public menu_mesero_mesas(List<Mesa> listaMesas, Arca arca, List<Plato> listaPlatos, List<Stock> listaProductos)

        {
            InitializeComponent();
            this._recaudacionMesa = 0;
            this._listaMesas = listaMesas;
            this._arca = arca;
            this._listaPlatos = listaPlatos;
            this._listaProductos = listaProductos;

            label6.Text = $"Consumo total del mesero: {consumoMesero.ToString()}";

            foreach (Mesa mesa in _listaMesas)
            {
                DataGridViewRow fila = new DataGridViewRow();
                fila.CreateCells(dataGridView1);

                fila.Cells[0].Value = mesa.obtenerDatos("capacidad").ToString();
                fila.Cells[1].Value = mesa.obtenerDatos("mesero").ToString();
                fila.Cells[2].Value = mesa.obtenerDatos("platos");
                fila.Cells[3].Value = "SI";
                fila.Cells[5].Value = countMesa.ToString();

                dataGridView1.Rows.Add(fila);

            }

        }

        private void DataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == 4 && e.RowIndex >= 0)
            {
                DataGridViewCheckBoxCell chkCell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex] as DataGridViewCheckBoxCell;
                bool boolValue = (bool)chkCell.Value;

                if (boolValue && dataGridView1.Rows[e.RowIndex].Cells[2].Value != null)
                {
                    string nombresPlatos = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                    string[] nombresPlatosArray = nombresPlatos.Split(new string[] { "; " }, StringSplitOptions.None);

                    double precioTotal = 0.0;

                    foreach (string nombrePlato in nombresPlatosArray)
                    {
                        Plato plato = _listaPlatos.FirstOrDefault(p => p.obtenerDatos("nombre").ToString() == nombrePlato);
                        if (plato != null)
                        {
                            double precioPlato = Convert.ToDouble(plato.obtenerDatos("precio"));
                            precioTotal += precioPlato;
                        }
                    }

                    // top ventas
                    string nombreMesero = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();

                    if (!_ventasMeseros.ContainsKey(nombreMesero))
                    {
                        _ventasMeseros.Add(nombreMesero, precioTotal);
                    }
                    else
                    {
                        _ventasMeseros[nombreMesero] += precioTotal;
                    }
                    //

                    _arca.agregarRecaudacion(precioTotal);
                    consumoMesero += precioTotal;
                    label6.Text = $"Consumo total de los meseros: ${consumoMesero.ToString()}";
                    MessageBox.Show($"Consumo agregado a la recaudación diaria: ${precioTotal}");

                }

            }
        }

        private void verTopVendedores()
        {
            var vendedoresOrdenados = _ventasMeseros.OrderByDescending(kv => kv.Value).ToList();

            if (vendedoresOrdenados.Count > 0)
                MessageBox.Show($"1er lugar: {vendedoresOrdenados[0].Key} (${vendedoresOrdenados[0].Value})");
            if (vendedoresOrdenados.Count > 1)
                MessageBox.Show($"2do lugar: {vendedoresOrdenados[1].Key} (${vendedoresOrdenados[1].Value})");
            if (vendedoresOrdenados.Count > 2)
                MessageBox.Show($"3er lugar: {vendedoresOrdenados[2].Key} (${vendedoresOrdenados[2].Value})");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox3.SelectedItem != null && comboBox2.SelectedItem != null && textBox2.Text != "" && listBox1.Items.Count > 0)
            {
                string capacidad = textBox2.Text;
                string nombreDelMesero = comboBox3.SelectedItem.ToString();
                string ocupada = comboBox2.SelectedItem.ToString();
                countMesa += 1;
                string numeroMesa = countMesa.ToString();

                string itemString = string.Join("; ", listBox1.Items.Cast<object>());

                List<Plato> platosAsignados = new List<Plato>();

                foreach (var item in listBox1.Items)
                {
                    string nombrePlato = item.ToString();
                    Plato plato = _listaPlatos.FirstOrDefault(p => p.obtenerDatos("nombre").ToString() == nombrePlato);
                    if (plato != null)
                    {
                        platosAsignados.Add(plato);
                    }

                    // top 3 ventas
                }
                Mesa nuevaMesa = new Mesa(Int32.Parse(capacidad), nombreDelMesero, platosAsignados, _listaProductos);
                _listaMesasParaAgregar.Add(nuevaMesa);

                DataGridViewRow fila = new DataGridViewRow();
                fila.CreateCells(dataGridView1);

                fila.Cells[0].Value = nuevaMesa.obtenerDatos("capacidad").ToString();
                fila.Cells[1].Value = nuevaMesa.obtenerDatos("mesero").ToString();
                fila.Cells[2].Value = string.Join("; ", platosAsignados.Select(p => p.obtenerDatos("nombre")));
                fila.Cells[3].Value = ocupada;
                fila.Cells[5].Value = numeroMesa;

                dataGridView1.Rows.Add(fila);

                listBox1.Items.Clear();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                string platoSeleccionado = comboBox1.SelectedItem.ToString();


                listBox1.Items.Add(platoSeleccionado);

                comboBox1.SelectedIndex = -1;
                textBox2.Text = string.Empty;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            verTopVendedores();
        }
    }
}
