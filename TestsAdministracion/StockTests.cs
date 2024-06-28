using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace administracion.Tests
{
    [TestClass]
    public class StockTests
    {
        [TestMethod]
        public void ObtenerDatos_DeberiaRetornarValoresCorrectos()
        {
            Stock stock = new Stock(1, "Producto1", 500, 5.0);

            int id = (int)stock.obtenerDatos("id");
            string nombre = (string)stock.obtenerDatos("nombre");
            int unidadesDisponibles = (int)stock.obtenerDatos("unidades disponibles");
            double precioPorUnidad = (double)stock.obtenerDatos("precio por unidad");

            Assert.AreEqual(1, id);
            Assert.AreEqual("Producto1", nombre);
            Assert.AreEqual(500, unidadesDisponibles);
            Assert.AreEqual(5.0, precioPorUnidad);
        }

        [TestMethod]
        public void DescontarGramos_DeberiaReducirUnidadesDisponibles()
        {
            Stock stock = new Stock(1, "Producto1", 500, 5.0);

            stock.descontarGramos(200);

            int unidadesDisponibles = (int)stock.obtenerDatos("unidades disponibles");

            Assert.AreEqual(300, unidadesDisponibles);
        }
    }
}
