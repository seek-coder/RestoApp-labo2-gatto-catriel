using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace administracion
{
    public class Plato
    {
        private string _nombre;
        private float _precio;
        private Dictionary<string, int> _ingredientes;
        private int _tiempoPreparacionEnMin;

        public Plato(string nombre, float precio, Dictionary<string, int> ingredientes, int tiempoPreparacionEnMin)
        {
            this._nombre = nombre;
            this._precio = precio;
            this._ingredientes = ingredientes;
            this._tiempoPreparacionEnMin = tiempoPreparacionEnMin;
        }

        // separador de ingredientes de gramos en el diccionario para después usarlo en la tabla del form
        private (List<string>, List<int>) separarIngredientes()
        {
            List<string> ingredientes = new List<string>();
            List<int> gramos = new List<int>();

            // KeyValuePair define un par clave-valor que puede settearse o devolverse. Acá hacemos las dos cosas
            foreach (KeyValuePair<string, int> ingrediente in _ingredientes)
            {
                ingredientes.Add(ingrediente.Key);
                gramos.Add(ingrediente.Value);
            }

            return (ingredientes, gramos);
        }

        public object obtenerDatos(string atributo)
        {
            switch (atributo)
            {
                case "nombre":
                    return _nombre;
                case "precio":
                    return _precio;
                case "ingredientes":
                    return separarIngredientes().Item1;
                case "gramos":
                    return separarIngredientes().Item2;
                case "tiempo de preparación":
                    return _tiempoPreparacionEnMin;
                default:
                    throw new ArgumentException("Nombre de atributo inválido");
            }
        }
    }
}
