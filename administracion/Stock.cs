﻿using System;
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
        private int _unidadesDisponibles; // 100g = 1 unidad
        private double _precioPorUnidad;

        public Stock(int id, string nombre, int unidadesDisponibles, double precioPorUnidad)
        {
            this._id = id;
            this._nombre = nombre;
            this._unidadesDisponibles = unidadesDisponibles; // en gramos
            this._precioPorUnidad = precioPorUnidad;
        }

        public void descontarGramos(int gramos)
        {
            _unidadesDisponibles -= gramos;
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
