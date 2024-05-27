using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Security.Cryptography;

namespace usuarios
{
    public class Empleado : ICocinero, IDelivery, IEncargado, IMesero
    {
        private string _nombre;
        private string _apellido;
        private string _direccion;
        private int _contacto;
        private double _sueldo;
        private string _rol;
        private string _usuario;
        private string _contraseña;

        public Empleado(string nombre, string apellido, string direccion, int contacto, double sueldo, string rol, string usuario, string contraseña)
        {
            this._nombre = nombre;
            this._apellido = apellido;
            this._direccion = direccion;
            this._contacto = contacto;
            this._sueldo = sueldo;
            this._rol = rol;
            this._usuario = usuario;
            this._contraseña = contraseña;
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
                case "usuario":
                    return _usuario;
                case "contraseña":
                    return _contraseña;
                default:
                    throw new ArgumentException("Nombre de atributo inválido");
            }
        }

        bool ICocinero.cocinar()
        {
            throw new NotImplementedException();
        }

        string ICocinero.describrirPlato()
        {
            throw new NotImplementedException();
        }

        void ICocinero.eliminarPlato()
        {
            throw new NotImplementedException();
        }

        double IEncargado.pagarSueldoMensual()
        {
            throw new NotImplementedException();
        }

        bool IDelivery.realizarEntrega()
        {
            throw new NotImplementedException();
        }

        double IEncargado.recaudarIngresoDiario()
        {
            throw new NotImplementedException();
        }

        void IMesero.tomarMesa()
        {
            throw new NotImplementedException();
        }
    }
}
