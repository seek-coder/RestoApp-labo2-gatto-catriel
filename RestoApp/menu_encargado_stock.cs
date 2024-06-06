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
    public partial class menu_encargado_stock : Form
    {
        private List<Stock> _listaProductosActual;
        private List<Arca> _listaArcas;
        private List<Empleado> _listaEmpleados;
        private List<Proveedor> _listaProveedores;
        public menu_encargado_stock(List<Stock> listaProductos, List<Arca> listaArcas,
            List<Empleado> listaEmpleados, List<Proveedor> listaProveedores)
        {
            InitializeComponent();
            this._listaProductosActual = listaProductos;
            this._listaArcas = listaArcas;
            this._listaEmpleados = listaEmpleados;
            this._listaProveedores = listaProveedores;

            foreach (Stock producto in _listaProductosActual)
            {
                string[] fila = new string[] { producto.obtenerDatos("id").ToString(), producto.obtenerDatos("nombre").ToString(), producto.obtenerDatos("unidades disponibles").ToString(), producto.obtenerDatos("precio por unidad").ToString() };
                dataGridView1.Rows.Add(fila);
            }
            
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            // método para detectar ingreso de productos vía manual

            int fila = e.RowIndex;
            int columna = e.ColumnIndex;

            // evalúo si estoy en alguna de las dos columnas, precio x unidad o cantidad
            if (dataGridView1.Columns[columna].Name == "precioUnitario" 
                || dataGridView1.Columns[columna].Name == "cantidad")
            {
                // obtengo el índice de las columnas para hacer las cuentas
                int indiceCantidad = dataGridView1.Columns["cantidad"].Index;
                int indicePrecioUnitario = dataGridView1.Columns["precioUnitario"].Index;

                // obtengo el valor de las celdas de cantidad y precio x unidad
                DataGridViewCell celdaCantidad = dataGridView1.Rows[fila].Cells[indiceCantidad];
                DataGridViewCell celdaPrecioUnitario = dataGridView1.Rows[fila].Cells[indicePrecioUnitario];

                // evalúo a null porque sino me tira error (como en otros casos).
                // intento parsear a flotante y devuelvo cantidad y precio para hacer la multiplicación
                if (celdaCantidad.Value != null && celdaPrecioUnitario.Value != null && 
                    float.TryParse(celdaCantidad.Value.ToString(), out float cantidad) &&
                    float.TryParse(celdaPrecioUnitario.Value.ToString(), out float precio))
                {
                    float resultado = cantidad * precio;
                    MessageBox.Show($"Resultado de la multiplicación entre cantidad y precio unitario ${resultado} (se descontará" +
                        $" del arca principal)");

                    Arca arcaN = _listaArcas.FirstOrDefault(arca => arca.obtenerSaldo() > 0);
                    string arcaNSaldo = arcaN.obtenerSaldo().ToString();

                    IEncargado encargado = _listaEmpleados.OfType<IEncargado>().FirstOrDefault();
                    encargado.pagarProveedores(_listaProveedores[0], _listaArcas[0], resultado);

                }

                MessageBox.Show("Se editó la celda de precio mi rey.");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
