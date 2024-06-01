using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace administracion
{
    public class Stock
    {
        private int _id;
        private string _nombre;
        private int _unidadesDisponibles;
        private double _precioPorUnidad;

        public Stock(int id, string nombre, int unidadesDisponibles, double precioPorUnidad)
        {
            this._id = id;
            this._nombre = nombre;
            this._unidadesDisponibles = unidadesDisponibles;
            this._precioPorUnidad = precioPorUnidad;
        }

        public object obtenerDatos(string atributo)
        {
            switch (atributo)
            {
                case "id":
                    return _id;
                case "nombre":
                    return _nombre;
                case "unidades disponibles":
                    return _unidadesDisponibles;
                case "precio por unidad":
                    return _precioPorUnidad;
                default:
                    throw new ArgumentException("Nombre de atributo inválido");
            }
        }
    }
}
