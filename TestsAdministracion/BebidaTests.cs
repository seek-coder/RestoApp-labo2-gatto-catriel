using Microsoft.VisualStudio.TestTools.UnitTesting;
using administracion;

namespace AdministracionTests
{
    [TestClass]
    public class BebidaTests
    {
        [TestMethod]
        public void TestConstructor()
        {
            Bebida bebida = new Bebida("Cerveza", 10, 5.0f, true);
            Assert.AreEqual("Cerveza", bebida.obtenerDatos("nombre"));
            Assert.AreEqual(10, bebida.obtenerDatos("cantidad"));
            Assert.AreEqual(5.0f, bebida.obtenerDatos("precio"));
            Assert.IsTrue(bebida.TieneAlcohol());
        }

        [TestMethod]
        public void TestSinAlcohol()
        {
            Bebida bebida = new Bebida("Jugo", 20, 2.5f, false);
            Assert.IsFalse(bebida.TieneAlcohol());
        }
    }
}
