using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace administracion
{
    public class Proveedor
    {
        private List<Producto> _tipoProductoQueProvee;
        private string _medioDePago; // contado, tarjeta, transferencia
        private string _nombre;
        private string _CUIT;
        private string _direccion;
        private string _diaDeEntrega;
        private double _cuentaCorriente;

        public Proveedor(List<Producto> tipoProductoQueProvee, string medioDePago, string nombre, string cUIT, string direccion, string diaDeEntrega, double cuentaCorriente)
        {
            this._tipoProductoQueProvee = tipoProductoQueProvee;
            this._medioDePago = medioDePago;
            this._nombre = nombre;
            this._CUIT = cUIT;
            this._direccion = direccion;
            this._diaDeEntrega = diaDeEntrega;
            this._cuentaCorriente = cuentaCorriente;
        }

        private string obtenerTipoDeProductoComoTexto()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var producto in _tipoProductoQueProvee)
            {
                sb.AppendLine(producto.obtenerDatos("nombre").ToString() + "; ");
            }
            return sb.ToString();
        }

        public object obtenerDatos(string atributo)
        {
            switch (atributo)
            {
                case "tipo de producto":
                    return obtenerTipoDeProductoComoTexto();
                case "medio de pago":
                    return _medioDePago;
                case "nombre":
                    return _nombre;
                case "CUIT":
                    return _CUIT;
                case "dirección":
                    return _direccion;
                case "día de entrega":
                    return _diaDeEntrega;
                case "cuenta corriente":
                    return _cuentaCorriente;
                default:
                    throw new ArgumentException("Nombre de atributo inválido");
            }
        }
    }
}
