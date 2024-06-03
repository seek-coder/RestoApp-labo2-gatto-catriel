using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace administracion
{
    public class Proveedor
    {
        private string _tipoProductoQueProvee;
        private string _medioDePago; // contado, tarjeta, transferencia
        private string _nombre;
        private string _CUIT;
        private string _direccion;
        private string _diaDeEntrega;
        private double _cuentaCorriente;

        public Proveedor(string tipoProductoQueProvee, string medioDePago, string nombre, string cUIT, string direccion, string diaDeEntrega, double cuentaCorriente)
        {
            this._tipoProductoQueProvee = tipoProductoQueProvee;
            this._medioDePago = medioDePago;
            this._nombre = nombre;
            this._CUIT = cUIT;
            this._direccion = direccion;
            this._diaDeEntrega = diaDeEntrega;
            this._cuentaCorriente = cuentaCorriente;
        }

        public object obtenerDatos(string atributo)
        {
            switch (atributo)
            {
                case "tipo de producto":
                    return _tipoProductoQueProvee;
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
