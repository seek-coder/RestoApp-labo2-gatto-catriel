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

            Empleado empleado1 = new Empleado("Catriel", "Gatto", "Alfa 123", 123456789, 600000, "encargado", "catriel", "clave1", false);
            Empleado empleado2 = new Empleado("Ramón", "Perez", "Beta 123", 123456788, 600000, "encargado", "ramon", "clave2", false);
            Empleado empleado3 = new Empleado("Raúl", "Gímenez", "Gamma 123", 123456787, 200000, "mesero", "raul", "clave3", false);
            Empleado empleado4 = new Empleado("Damián", "Gómez", "Delta 123", 123456786, 350000, "cocinero", "damian", "clave4", false);
            Empleado empleado5 = new Empleado("Tomás", "Huxon", "Epsilon 123", 123456785, 250000, "delivery", "tomas", "clave5", false);

            listaEmpleados.Add(empleado1);
            listaEmpleados.Add(empleado2);
            listaEmpleados.Add(empleado3);
            listaEmpleados.Add(empleado4);
            listaEmpleados.Add(empleado5);

            IEncargado encargado1 = empleado1;
            IEncargado encargado2 = empleado2;

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