using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace administracion.Tests
{
    [TestClass]
    public class PedidoTests
    {
        [TestMethod]
        public void TestObtenerPrecioTotalPedidos_SinPlatos()
        {
            var pedido = new Pedido(1, "Juan", new List<Plato>());

            var resultado = pedido.obtenerPrecioTotalPedidos();

            Assert.AreEqual(0, resultado);
        }

        [TestMethod]
        public void TestObtenerPrecioTotalPedidos_ConPlatos()
        {
            var platos = new List<Plato>
            {
                new Plato("Pizza", 12.99, new Dictionary<string, int> { { "Masa", 200 }, { "Queso", 100 }, { "Tomate", 50 } }, 30),
                new Plato("Ensalada", 6.5, new Dictionary<string, int> { { "Lechuga", 150 }, { "Tomate", 50 }, { "Aceite", 20 } }, 15)
            };
            var pedido = new Pedido(2, "María", platos);

            var resultado = pedido.obtenerPrecioTotalPedidos();

            Assert.AreEqual(19.490000000000002, resultado);
        }

        [TestMethod]
        public void TestObtenerDatos_Id()
        {
            var platos = new List<Plato>
            {
                new Plato("Pasta", 8.5, new Dictionary<string, int> { { "Pasta", 200 }, { "Salsa", 100 } }, 20),
                new Plato("Helado", 4.0, new Dictionary<string, int> { { "Crema", 150 }, { "Chocolate", 50 } }, 10)
            };
            var pedido = new Pedido(3, "Pedro", platos);

            var resultado = pedido.obtenerDatos("id");

            Assert.AreEqual(3, resultado);
        }

        [TestMethod]
        public void TestObtenerDatos_Conductor()
        {
            var platos = new List<Plato>
            {
                new Plato("Sushi", 15.0, new Dictionary<string, int> { { "Arroz", 100 }, { "Pescado", 50 }, { "Alga", 20 } }, 25),
                new Plato("Sopa", 5.0, new Dictionary<string, int> { { "Caldo", 200 }, { "Fideos", 100 } }, 15)
            };
            var pedido = new Pedido(4, "Ana", platos);

            var resultado = pedido.obtenerDatos("conductor");

            Assert.AreEqual("Ana", resultado);
        }

        [TestMethod]
        public void TestObtenerDatos_Platos()
        {
            var platos = new List<Plato>
            {
                new Plato("Hamburguesa", 10.0, new Dictionary<string, int> { { "Carne", 150 }, { "Pan", 100 }, { "Lechuga", 50 } }, 20),
                new Plato("Refresco", 2.5, new Dictionary<string, int> { { "Agua", 300 }, { "Jarabe", 50 } }, 5)
            };
            var pedido = new Pedido(5, "Carlos", platos);

            var resultado = pedido.obtenerDatos("platos");

            Assert.AreEqual("Hamburguesa, Refresco", resultado);
        }
    }
}
