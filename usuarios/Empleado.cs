using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Security.Cryptography;

namespace usuarios
{
    public class Empleado
    {
        private string _nombre;
        private string _apellido;
        private string _direccion;
        private int _contacto;
        private double _sueldo;
        private string _rol;

        public Empleado(string nombre, string apellido, string direccion, int contacto, double sueldo, string rol)
        {
            _nombre = nombre;
            _apellido = apellido;
            _direccion = direccion;
            _contacto = contacto;
            _sueldo = sueldo;
            _rol = rol;
        }

        public object obtenerDatos(string atributo)
        {
            switch (atributo)
            {
                case "nombre":
                    return _nombre;
                case "apellido":
                    return _apellido;
                case "direccion":
                    return _direccion;
                case "contacto":
                    return _contacto;
                case "sueldo":
                    return _sueldo;
                case "rol":
                    return _rol;
                default:
                    throw new ArgumentException("Nombre de atributo inválido");
            }
        }
    }
}
