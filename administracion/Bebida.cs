using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace administracion
{
    public class Bebida : Producto
    {
        private bool _tieneAlcohol;

        public Bebida(string nombre, int cantidadEnStock, float precio, bool tieneAlcohol) : base(nombre, cantidadEnStock, precio)
        {
            this._tieneAlcohol = tieneAlcohol;
        }

        public bool TieneAlcohol()
        {
            return _tieneAlcohol;
        }
    }
}
