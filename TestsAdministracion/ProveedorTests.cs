using Microsoft.VisualStudio.TestTools.UnitTesting;
using administracion;
using System.Collections.Generic;

namespace AdministracionTests
{
    [TestClass]
    public class ProveedorTests
    {
        [TestMethod]
        public void obtenerDatos_DeberiaRetornarTipoDeProductoComoTexto()
        {
            // arrange
            List<Producto> productos = new List<Producto>
            {
                new Producto("Producto1", 10, 1000), new Producto("Producto2", 10, 1000)
            };
            Proveedor proveedor = new Proveedor(productos, "contado", "Proveedor1", "1234567890", "Calle 123", "Lunes", 1000.0);

            // act
            string tipoProductoObtenido = (string)proveedor.obtenerDatos("tipo de producto");

            // assert
            Assert.IsNotNull(tipoProductoObtenido);
            Assert.IsTrue(tipoProductoObtenido.Contains("Producto1"));
            Assert.IsTrue(tipoProductoObtenido.Contains("Producto2"));
        }

        [TestMethod]
        public void obtenerDatos_DeberiaRetornarMedioDePago()
        {
            // arrange
            List<Producto> productos = new List<Producto>();
            Proveedor proveedor = new Proveedor(productos, "tarjeta", "Proveedor2", "0987654321", "Av. Principal", "Martes", 500.0);

            // act
            string medioPagoObtenido = (string)proveedor.obtenerDatos("medio de pago");

            // assert
            Assert.AreEqual("tarjeta", medioPagoObtenido);
        }

        [TestMethod]
        public void obtenerDatos_DeberiaRetornarNombre()
        {
            // arrange
            List<Producto> productos = new List<Producto>();
            Proveedor proveedor = new Proveedor(productos, "transferencia", "Proveedor3", "1357924680", "Plaza Mayor", "Miércoles", 2000.0);

            // act
            string nombreObtenido = (string)proveedor.obtenerDatos("nombre");

            // assert
            Assert.AreEqual("Proveedor3", nombreObtenido);
        }

    }
}
