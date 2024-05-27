using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace usuarios
{
    public class Cuentas
    {
        private Dictionary<string, string> cuentas;

        public Cuentas()
        {
            cuentas = new Dictionary<string, string>();
        }

        public void AgregarUsuario(string nombre, string contraseña)
        {
            // verificar si existe la cuenta. Si no existe ningún username...
            if (!cuentas.ContainsKey(nombre))
            {
                // ...entonces agregar cuenta
                cuentas.Add(nombre, contraseña);
                Console.WriteLine("Usuario agregado correctamente.");
            }
            else
            {
                Console.WriteLine("El usuario ya existe.");
            }
        }

        // verificar si hay una cuenta con ese username y esa contraseña
        public bool VerificarCuenta(string nombre, string contraseña)
        {
            return cuentas.ContainsKey(nombre) ? cuentas[nombre] == contraseña : false;
        }
    }

}
