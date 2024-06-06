using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Security.Cryptography;
using administracion;

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
        private bool _cobroSueldo;

        public Empleado(string nombre, string apellido, string direccion, int contacto, double sueldo, string rol, string usuario, string contraseña, bool cobroSueldo)
        {
            this._nombre = nombre;
            this._apellido = apellido;
            this._direccion = direccion;
            this._contacto = contacto;
            this._sueldo = sueldo;
            this._rol = rol;
            this._usuario = usuario;
            this._contraseña = contraseña;
            this._cobroSueldo = cobroSueldo;
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
                case "cobro":
                    return _cobroSueldo;
                default:
                    throw new ArgumentException("Nombre de atributo inválido");
            }
        }


        bool ICocinero.cocinar(Plato plato)
        {
            throw new NotImplementedException();
        }

        Stock IEncargado.consultarStockActual()
        {
            throw new NotImplementedException();
        }

        Stock IEncargado.consultarStockAnterior()
        {
            throw new NotImplementedException();
        }

        Plato ICocinero.crearPlato(Plato plato)
        {
            throw new NotImplementedException();
        }

        string ICocinero.describrirPlato(Plato plato)
        {
            throw new NotImplementedException();
        }

        void ICocinero.eliminarPlato(Plato plato)
        {
            throw new NotImplementedException();
        }

        Plato ICocinero.modificarPlato(Plato plato)
        {
            throw new NotImplementedException();
        }

        double IEncargado.pagarProveedores(Proveedor proveedor, Arca arca, double monto)
        {
            arca.restarSaldo(monto);
            return arca.obtenerSaldo();
        }

        double IEncargado.pagarSueldoMensual(Empleado empleado, Arca arca)
        {
            empleado._cobroSueldo = true;
            arca.restarSaldo(empleado._sueldo);
            return empleado._sueldo;
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
