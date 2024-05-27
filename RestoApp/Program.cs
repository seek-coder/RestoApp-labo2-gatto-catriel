using usuarios;

namespace RestoApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Cuentas cuentas = new Cuentas();

            // cuentas
            cuentas.AgregarUsuario("Catriel", "clave1"); // encargado
            cuentas.AgregarUsuario("Ram�n", "clave2"); // mesero
            cuentas.AgregarUsuario("Dami�n", "clave3"); // cocinero
            cuentas.AgregarUsuario("Tom�s", "clave4"); // delivery

            ApplicationConfiguration.Initialize(); 
            // arranco la aplicaci�n con cuentas para que me tome los usuarios
            Application.Run(new menu_bienvenida(cuentas));




        }
    }
}