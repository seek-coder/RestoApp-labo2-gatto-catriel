using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace administracion.Tests
{
    [TestClass]
    public class ProveedorTests
    {
        [TestMethod]
        public void TestObtenerTipoDeProductoComoTexto_SinProductos()
        {
            var productos = new List<Producto>();
            var proveedor = new Proveedor(productos, "contado", "Proveedor A", "12345678901", "Calle 123", "Lunes", 0);

            var resultado = proveedor.obtenerDatos("tipo de producto");

            Assert.AreEqual("", resultado);
        }

        [TestMethod]
        public void TestObtenerTipoDeProductoComoTexto_ConProductos()
        {
            var producto1 = new Producto("Harina", 20, 200);
            var producto2 = new Producto("Azúcar", 20, 200);
            var producto3 = new Producto("Levadura", 20, 200);
            var productos = new List<Producto> { producto1, producto2, producto3 };
            var proveedor = new Proveedor(productos, "transferencia", "Proveedor B", "98765432109", "Av. Principal", "Miércoles", 5000);

            var resultado = proveedor.obtenerDatos("tipo de producto");

            Assert.AreEqual($"{producto1.obtenerDatos("nombre")}; \r\n{producto2.obtenerDatos("nombre")}; \r\n{producto3.obtenerDatos("nombre")}; \r\n", resultado);
        }

        [TestMethod]
        public void TestObtenerDatos_MedioDePago()
        {
            var productos = new List<Producto>();
            var proveedor = new Proveedor(productos, "tarjeta", "Proveedor C", "45678901234", "Ruta 1", "Viernes", 10000);

            var resultado = proveedor.obtenerDatos("medio de pago");

            Assert.AreEqual("tarjeta", resultado);
        }

        [TestMethod]
        public void TestObtenerDatos_Nombre()
        {
            var productos = new List<Producto>();
            var proveedor = new Proveedor(productos, "contado", "Proveedor D", "56789012345", "Calle Central", "Martes", 8000);

            var resultado = proveedor.obtenerDatos("nombre");

            Assert.AreEqual("Proveedor D", resultado);
        }

        [TestMethod]
        public void TestObtenerDatos_CUIT()
        {
            var productos = new List<Producto>();
            var proveedor = new Proveedor(productos, "contado", "Proveedor E", "67890123456", "Avenida Principal", "Jueves", 12000);

            var resultado = proveedor.obtenerDatos("CUIT");

            Assert.AreEqual("67890123456", resultado);
        }

        [TestMethod]
        public void TestObtenerDatos_Direccion()
        {
            var productos = new List<Producto>();
            var proveedor = new Proveedor(productos, "contado", "Proveedor F", "78901234567", "Calle Secundaria", "Sábado", 15000);

            var resultado = proveedor.obtenerDatos("dirección");

            Assert.AreEqual("Calle Secundaria", resultado);
        }

        [TestMethod]
        public void TestObtenerDatos_DiaDeEntrega()
        {
            var productos = new List<Producto>();
            var proveedor = new Proveedor(productos, "contado", "Proveedor G", "89012345678", "Avenida Secundaria", "Domingo", 20000);

            var resultado = proveedor.obtenerDatos("día de entrega");

            Assert.AreEqual("Domingo", resultado);
        }

        [TestMethod]
        public void TestObtenerDatos_CuentaCorriente()
        {
            var productos = new List<Producto>();
            var proveedor = new Proveedor(productos, "contado", "Proveedor H", "90123456789", "Calle Peatonal", "Lunes", 30000);

            var resultado = proveedor.obtenerDatos("cuenta corriente");

            Assert.AreEqual((double)30000, resultado);
        }
    }
}
