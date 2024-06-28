using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace administracion.Tests
{
    [TestClass]
    public class PlatoTests
    {
        [TestMethod]
        public void ObtenerDatos_DeberiaRetornarValoresCorrectos()
        {
            Dictionary<string, int> ingredientes = new Dictionary<string, int>
            {
                { "Ingrediente1", 100 },
                { "Ingrediente2", 200 }
            };
            Plato plato = new Plato("Plato1", 15.0, ingredientes, 30);

            string nombre = (string)plato.obtenerDatos("nombre");
            double precio = (double)plato.obtenerDatos("precio");
            List<string> nombresIngredientes = (List<string>)plato.obtenerDatos("ingredientes");
            List<int> gramosIngredientes = (List<int>)plato.obtenerDatos("gramos");
            int tiempoPreparacion = (int)plato.obtenerDatos("tiempo de preparación");

            Assert.AreEqual("Plato1", nombre);
            Assert.AreEqual(15.0, precio);
            CollectionAssert.AreEqual(new List<string> { "Ingrediente1", "Ingrediente2" }, nombresIngredientes);
            CollectionAssert.AreEqual(new List<int> { 100, 200 }, gramosIngredientes);
            Assert.AreEqual(30, tiempoPreparacion);
        }
    }
}
