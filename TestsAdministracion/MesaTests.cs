using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace administracion.Tests
{
    [TestClass]
    public class MesaTests
    {
        [TestMethod]
        public void TestObtenerPrecioTotalPlatos_SinPlatos()
        {
            var mesa = new Mesa(4, "Juan", new List<Plato>(), new List<Stock>());

            var resultado = mesa.obtenerPrecioTotalPlatos();

            Assert.AreEqual(0, resultado);
        }

        [TestMethod]
        public void TestObtenerPrecioTotalPlatos_ConPlatos()
        {
            var platos = new List<Plato>
            {
                new Plato("Pizza", 12.99, new Dictionary<string, int> { { "Masa", 200 }, { "Queso", 100 }, { "Tomate", 50 } }, 30),
                new Plato("Ensalada", 6.5, new Dictionary<string, int> { { "Lechuga", 150 }, { "Tomate", 50 }, { "Aceite", 20 } }, 15)
            };
            var mesa = new Mesa(6, "María", platos, new List<Stock>());

            var resultado = mesa.obtenerPrecioTotalPlatos();

            Assert.AreEqual(19.490000000000002, resultado);
        }


        [TestMethod]
        public void TestObtenerDatos_Capacidad()
        {
            var mesa = new Mesa(4, "Ana", new List<Plato>(), new List<Stock>());

            var resultado = mesa.obtenerDatos("capacidad");

            Assert.AreEqual(4, resultado);
        }

        [TestMethod]
        public void TestObtenerDatos_Mesero()
        {
            var mesa = new Mesa(3, "Carlos", new List<Plato>(), new List<Stock>());

            var resultado = mesa.obtenerDatos("mesero");

            Assert.AreEqual("Carlos", resultado);
        }

        [TestMethod]
        public void TestObtenerDatos_Platos()
        {
            var platos = new List<Plato>
            {
                new Plato("Hamburguesa", 10.0, new Dictionary<string, int> { { "Carne", 150 }, { "Pan", 100 }, { "Lechuga", 50 } }, 20),
                new Plato("Refresco", 2.5, new Dictionary<string, int> { { "Agua", 300 }, { "Jarabe", 50 } }, 5)
            };
            var mesa = new Mesa(4, "Daniela", platos, new List<Stock>());

            var resultado = mesa.obtenerDatos("platos");

            Assert.AreEqual("Hamburguesa; \r\nRefresco; \r\n", resultado);
        }

    }
}
