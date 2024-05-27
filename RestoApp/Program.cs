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
            // Cuentas cuentas = new Cuentas();

            List<Empleado> listaEmpleados = new List<Empleado>();

            Empleado empleado1 = new Empleado("Catriel", "Gatto", "Alfa 123", 123456789, 600000, "encargado", "catriel", "clave1");
            Empleado empleado2 = new Empleado("Ramón", "Perez", "Beta 123", 123456788, 200000, "mesero", "ramon", "clave2");
            Empleado empleado3 = new Empleado("Damián", "Gómez", "Gamma 123", 123456789, 600000, "cocinero", "damian", "clave3");
            Empleado empleado4 = new Empleado("Tomás", "Huxon", "Delta 123", 123456789, 600000, "delivery", "tomas", "clave4");

            listaEmpleados.Add(empleado1);
            listaEmpleados.Add(empleado2);
            listaEmpleados.Add(empleado3);
            listaEmpleados.Add(empleado4);

            IEncargado encargado1 = empleado1;

            // cuentas
            // cuentas.AgregarUsuario("catriel", "clave1"); // encargado
            // cuentas.AgregarUsuario("ramon", "clave2"); // mesero
            // cuentas.AgregarUsuario("damian", "clave3"); // cocinero
            //  cuentas.AgregarUsuario("tomas", "clave4"); // delivery

            ApplicationConfiguration.Initialize(); 
            // arranco la aplicación con cuentas para que me tome los usuarios
            Application.Run(new menu_bienvenida(listaEmpleados));

        }
    }
}