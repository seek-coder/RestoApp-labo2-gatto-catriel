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
        private List<Plato> _platosLista;
        private List<Stock> _stockLista;

        public Mesa(int id, int capacidad, string meseroAsignado, List<Plato> platosLista, List<Stock> stockLista)
        {
            this._id = id;
            this._capacidad = capacidad;
            this._meseroAsignado = meseroAsignado;
            this._platosLista = platosLista;
            this._stockLista = stockLista;
        }
        private string obtenerPlatosComoTexto()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var plato in _platosLista)
            {
                sb.AppendLine(plato.obtenerDatos("nombre").ToString() + "; ");
            }
            return sb.ToString();
        }

        public double obtenerPrecioTotalPlatos()
        {
            double precioTotal = 0;
            foreach (var plato in _platosLista)
            {
                precioTotal += (double)plato.obtenerDatos("precio");
            }
            return precioTotal;
        }

        // falta implementar este método
        private void descontarStock(Dictionary<string, int> ingredientes)
        {
            foreach (var ingrediente in ingredientes)
            {
                var elementoStock = _stockLista.FirstOrDefault(stock => stock.obtenerDatos("nombre").ToString() == ingrediente.Key);
                elementoStock.descontarGramos(ingrediente.Value);
            }
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
                case "platos":
                    return obtenerPlatosComoTexto();
                default:
                    throw new ArgumentException("Nombre de atributo inválido");
            }
        }
    }
}
