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
        private List<Plato> _listaPlatos;

        public Pedido(int id, string conductorAsignado, List<Plato> listaPlatos)
        {
            this._id = id;
            this._conductorAsignado = conductorAsignado;
            this._listaPlatos = listaPlatos;
        }

        public double obtenerPrecioTotalPedidos()
        {
            double precioTotal = 0;
            foreach (Plato plato in _listaPlatos)
            {
                precioTotal += (double)plato.obtenerDatos("precio");
            }
            return precioTotal;
        }

        public object obtenerDatos(string atributo)
        {
            switch (atributo)
            {
                case "id":
                    return _id;
                case "conductor":
                    return _conductorAsignado;
                case "platos":
                    string platosText = string.Join(", ", _listaPlatos.Select(plato => plato.obtenerDatos("nombre")));
                    return platosText;
                default:
                    throw new ArgumentException("Nombre de atributo inválido");
            }
        }


    }
}
