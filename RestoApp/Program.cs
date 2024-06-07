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
           // -------------------- //

            List<Empleado> listaEmpleados = new List<Empleado>();

            Empleado empleado1 = new Empleado("Catriel", "Gatto", "Alfa 123", 123456789, 600000, "encargado", "catriel", "clave1", false);
            Empleado empleado2 = new Empleado("Denise", "Figueroa", "Beta 123", 123456788, 600000, "encargado", "denise", "clave2", false);
            Empleado empleado3 = new Empleado("Raúl", "Gímenez", "Gamma 123", 123456787, 200000, "mesero", "raul", "clave3", false);
            Empleado empleado4 = new Empleado("Damián", "Gómez", "Delta 123", 123456786, 350000, "cocinero", "damian", "clave4", false);
            Empleado empleado5 = new Empleado("Tomás", "Huxon", "Epsilon 123", 123456785, 250000, "delivery", "tomas", "clave5", false);

            listaEmpleados.Add(empleado1);
            listaEmpleados.Add(empleado2);
            listaEmpleados.Add(empleado3);
            listaEmpleados.Add(empleado4);
            listaEmpleados.Add(empleado5);

            // ROLES //
           // ----- //

            IEncargado encargado1 = empleado1;
            IEncargado encargado2 = empleado2;
            IMesero mesero1 = empleado3;
            ICocinero cocinero1 = empleado4;
            IDelivery delivery1 = empleado5;

            // GESTIÓN DE ARCA //
           // --------------- //

            List<Arca> listaArcas = new List<Arca>();
            Arca arca1 = new Arca(3000000);

            listaArcas.Add(arca1);

            // PROVEEDORES //
           // ----------- //

            List<Proveedor> listaProveedores = new List<Proveedor>();

            Proveedor proveedor1 = new Proveedor("Varios", "Contado", "Juan Domingo", "199199234", "Por acá 1212", "Jueves", 300000);
            Proveedor proveedor2 = new Proveedor("Bebidas", "Tarjeta", "Coco Colo", "199499234", "Por allá 1414", "Sábado", 900000);
            Proveedor proveedor3 = new Proveedor("Pastas", "Transferencia", "Ayrton Senna", "199799234", "Por ahí 1616", "Lunes", 600000);

            listaProveedores.Add(proveedor1);
            listaProveedores.Add(proveedor2);
            listaProveedores.Add(proveedor3);

            // GESTIÓN DE STOCK //
            // ---------------- //

            List<Stock> listaProductosActual = new List<Stock>();

            // 100 g = 1 unidad

            Stock producto1 = new Stock(1, "Milanesas de pollo", 900, 150);
            Stock producto2 = new Stock(2, "Papas", 1400, 180);
            Stock producto3 = new Stock(3, "Limón", 200, 120);
            Stock producto4 = new Stock(4, "Harina de trigo", 3000, 200);
            Stock producto5 = new Stock(5, "Harina de maíz", 3000, 190);
            Stock producto6 = new Stock(6, "Salsa de tomate", 300, 100);
            Stock producto7 = new Stock(7, "Bola de lomo", 2000, 350);

            listaProductosActual.Add(producto1);
            listaProductosActual.Add(producto2);
            listaProductosActual.Add(producto3);
            listaProductosActual.Add(producto4);
            listaProductosActual.Add(producto5);
            listaProductosActual.Add(producto6);
            listaProductosActual.Add(producto7);

            // LISTA DE PLATOS //
            // --------------- //

            List<Plato> listaPlatos = new List<Plato>();

            Plato plato1 = new Plato("Milanesas de pollo con puré de papas", 6800, new Dictionary<string, int> { { "Milanesas de pollo", 200 }, { "Papas", 300 }, { "Limón", 20 } }, 45);
            Plato plato2 = new Plato("Ñoquis", 5400, new Dictionary<string, int> { { "Harina de trigo", 150 }, { "Papas", 150 }, { "Salsa de tomate", 30 } }, 60);
            Plato plato3 = new Plato("Polenta con tuco", 3800, new Dictionary<string, int> { { "Harina de maíz", 150 }, { "Bola de lomo", 200 }, { "Limón", 20 } }, 45);

            listaPlatos.Add(plato1);
            listaPlatos.Add(plato2);
            listaPlatos.Add(plato3);

            // LISTA DE MESAS //
            // --------------- //

            List<Mesa> listaMesas = new List<Mesa>();

            Mesa mesa1 = new Mesa(1, 6, "Raúl");
            Mesa mesa2 = new Mesa(2, 4, "Raúl");
            Mesa mesa3 = new Mesa(3, 2, "Raúl");

            listaMesas.Add(mesa1);
            listaMesas.Add(mesa2);
            listaMesas.Add(mesa3);

            // LISTA DE PEDIDOS //
            // --------------- //

            List<Pedido> listaPedidos = new List<Pedido>();

            Pedido pedido1 = new Pedido(1, "Tomás");

            listaPedidos.Add(pedido1);

            // INICIO DE APLICACIÓN //
            // -------------------- //

            ApplicationConfiguration.Initialize(); 

            // arranco la aplicación con cuentas para que me tome los usuarios
            Application.Run(new menu_bienvenida(listaEmpleados, listaProductosActual, listaArcas,
                listaProveedores, listaPlatos, listaMesas, listaPedidos));

        }
    }
}