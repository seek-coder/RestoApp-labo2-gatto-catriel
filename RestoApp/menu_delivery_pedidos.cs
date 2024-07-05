using administracion;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RestoApp
{
    public partial class menu_delivery_pedidos : Form
    {
        private List<Pedido> _listaPedidos;
        private List<string> _listaDelivery;
        private Arca _arca;
        private List<Plato> _listaPlatos;
        private List<Pedido> _listaPedidosParaAgregar = new List<Pedido>();
        public double consumoDelivery = 0;


        // top 3 ventas
        private Dictionary<string, double> _ventasDelivery = new Dictionary<string, double>();
        public menu_delivery_pedidos(List<Pedido> listaPedidos, Arca arca, List<string> listaDelivery, List<Plato> listaPlatos)
        {
            InitializeComponent();


            this._listaPedidos = listaPedidos;
            this._arca = arca;
            this._listaDelivery = listaDelivery;
            this._listaPlatos = listaPlatos;


            foreach (Pedido pedido in listaPedidos)
            {

                DataGridViewRow fila = new DataGridViewRow();
                fila.CreateCells(dataGridView1);

                fila.Cells[0].Value = pedido.obtenerDatos("conductor");
                fila.Cells[1].Value = pedido.obtenerDatos("platos");

                dataGridView1.Rows.Add(fila);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2 && e.RowIndex >= 0)
            {
                DataGridViewCheckBoxCell chkCell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex] as DataGridViewCheckBoxCell;
                bool boolValue = (bool)chkCell.Value;
                if (boolValue)
                {
                    string nombresPlatos = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                    string[] nombresPlatosArray = nombresPlatos.Split(new string[] { ", " }, StringSplitOptions.None);

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
                    _arca.agregarRecaudacion(precioTotal);
                    consumoDelivery += precioTotal;
                    label3.Text = $"Consumo total de los delivery: ${consumoDelivery.ToString()}";
                    MessageBox.Show($"Consumo agregado a la recaudación diaria: ${precioTotal}");

                    // top ventas
                    string nombreDelivery = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();

                    if (!_ventasDelivery.ContainsKey(nombreDelivery))
                    {
                        _ventasDelivery.Add(nombreDelivery, precioTotal);
                    }
                    else
                    {
                        _ventasDelivery[nombreDelivery] += precioTotal;
                    }
                    //
                }
            }

        }



        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox2.SelectedItem != null && listBox1.Items.Count > 0)
            {
                string nombreDelRepartidor = comboBox2.SelectedItem.ToString();

                string itemString = string.Join(", ", listBox1.Items.Cast<object>());

                List<Plato> platosAsignados = new List<Plato>();

                foreach (var item in listBox1.Items)
                {
                    string nombrePlato = item.ToString();
                    Plato plato = _listaPlatos.FirstOrDefault(p => p.obtenerDatos("nombre").ToString() == nombrePlato);
                    if (plato != null)
                    {
                        platosAsignados.Add(plato);
                    }
                }
                Pedido nuevoPedido = new Pedido(0, nombreDelRepartidor, _listaPlatos);
                _listaPedidosParaAgregar.Add(nuevoPedido);

                DataGridViewRow fila = new DataGridViewRow();
                fila.CreateCells(dataGridView1);

                fila.Cells[0].Value = nuevoPedido.obtenerDatos("conductor").ToString();
                fila.Cells[1].Value = string.Join(", ", platosAsignados.Select(p => p.obtenerDatos("nombre")));

                dataGridView1.Rows.Add(fila);

                listBox1.Items.Clear();

            }

        }

        private void verTopVendedores()
        {
            var vendedoresOrdenados = _ventasDelivery.OrderByDescending(kv => kv.Value).ToList();

            if (vendedoresOrdenados.Count > 0)
                MessageBox.Show($"1er lugar: {vendedoresOrdenados[0].Key} (${vendedoresOrdenados[0].Value})");
            if (vendedoresOrdenados.Count > 1)
                MessageBox.Show($"2do lugar: {vendedoresOrdenados[1].Key} (${vendedoresOrdenados[1].Value})");
            if (vendedoresOrdenados.Count > 2)
                MessageBox.Show($"3er lugar: {vendedoresOrdenados[2].Key} (${vendedoresOrdenados[2].Value})");
        }

        private void menu_delivery_pedidos_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                string platoSeleccionado = comboBox1.SelectedItem.ToString();


                listBox1.Items.Add(platoSeleccionado);

                comboBox1.SelectedIndex = -1;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            verTopVendedores();
        }
    }
}
