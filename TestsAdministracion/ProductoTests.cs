using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace administracion.Tests
{
    [TestClass]
    public class ProductoTests
    {
        [TestMethod]
        public void ObtenerDatos_DeberiaRetornarValoresCorrectos()
        {
            Producto producto = new Producto("Producto1", 10, 15.0f);

            int cantidad = (int)producto.obtenerDatos("cantidad");
            float precio = (float)producto.obtenerDatos("precio");
            string nombre = (string)producto.obtenerDatos("nombre");

            Assert.AreEqual("Producto1", nombre);
            Assert.AreEqual(10, cantidad);
            Assert.AreEqual(15.0f, precio);
        }
    }
}
