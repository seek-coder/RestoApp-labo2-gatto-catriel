using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace administracion
{
    public class Mesa
    {
        private int _id;
        private int _capacidad;
        private string _meseroAsignado;

        public Mesa(int id, int capacidad, string meseroAsignado )
        {
            this._id = id;
            this._capacidad = capacidad;
            this._meseroAsignado = meseroAsignado;
        }

        public object obtenerDatos(string atributo)
        {
            switch (atributo)
            {
                case "id":
                    return _id;
                case "capacidad":
                    return _capacidad;
                case "mesero":
                    return _meseroAsignado;
                default:
                    throw new ArgumentException("Nombre de atributo inválido");
            }
        }
    }
}
