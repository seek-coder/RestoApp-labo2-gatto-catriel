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
            cuentas.AgregarUsuario("Ramón", "clave2"); // mesero
            cuentas.AgregarUsuario("Damián", "clave3"); // cocinero
            cuentas.AgregarUsuario("Tomás", "clave4"); // delivery

            ApplicationConfiguration.Initialize(); 
            // arranco la aplicación con cuentas para que me tome los usuarios
            Application.Run(new menu_bienvenida(cuentas));




        }
    }
}