using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace administracion
{
    public class Producto
    {
        private string _nombre;
        private int _cantidadEnStock;
        private float _precio;

        public Producto(string nombre, int cantidadEnStock, float precio)
        {
            this._nombre = nombre;
            this._cantidadEnStock = cantidadEnStock;
            this._precio = precio;
        }
    }
}
