using administracion;
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
            // GESTIÓN DE EMPLEADOS // 

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

            // GESTIÓN DE STOCK //

            List<Stock> listaProductosActual = new List<Stock>();

            Stock producto1 = new Stock(1, "Manzanas", 50, 150);
            Stock producto2 = new Stock(2, "Bananas", 40, 180);
            Stock producto3 = new Stock(3, "Leche", 20, 1400);
            Stock producto4 = new Stock(4, "Pan Integral", 30, 2100);
            Stock producto5 = new Stock(5, "Maple de huevos", 10, 3800);

            listaProductosActual.Add(producto1);
            listaProductosActual.Add(producto2);
            listaProductosActual.Add(producto3);
            listaProductosActual.Add(producto4);
            listaProductosActual.Add(producto5);

            List<Arca> listaArcas = new List<Arca>();

            ApplicationConfiguration.Initialize(); 

            // arranco la aplicación con cuentas para que me tome los usuarios
            Application.Run(new menu_bienvenida(listaEmpleados, listaProductosActual, listaArcas));

        }
    }
}