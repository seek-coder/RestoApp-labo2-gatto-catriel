using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace administracion
{
    public class Pedido
    {
        private int _id;
        private string _conductorAsignado;

        public Pedido(int id, string conductorAsignado)
        {
            this._id = id;
            this._conductorAsignado = conductorAsignado;
        }

        public object obtenerDatos(string atributo)
        {
            switch (atributo)
            {
                case "id":
                    return _id;
                case "conductor":
                    return _conductorAsignado;
                default:
                    throw new ArgumentException("Nombre de atributo inválido");
            }
        }
    }
}
