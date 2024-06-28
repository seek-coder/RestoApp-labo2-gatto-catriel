using Microsoft.VisualStudio.TestTools.UnitTesting;
using administracion;

namespace AdministracionTests
{
    [TestClass]
    public class ArcaTests
    {
        [TestMethod]
        public void TestObtenerSaldo()
        {
            double saldoInicial = 100.0;
            Arca arca = new Arca(saldoInicial);

            double saldoObtenido = arca.obtenerSaldo();

            Assert.AreEqual(saldoInicial, saldoObtenido, "El saldo inicial no es el esperado.");
        }

        [TestMethod]
        public void TestEstablecerSaldo()
        {
            double saldoInicial = 100.0;
            double nuevoSaldo = 200.0;
            Arca arca = new Arca(saldoInicial);

            arca.establecerSaldo(nuevoSaldo);
            double saldoObtenido = arca.obtenerSaldo();

            Assert.AreEqual(nuevoSaldo, saldoObtenido, "El saldo establecido no es el esperado.");
        }

        [TestMethod]
        public void TestAgregarSaldo()
        {
            double saldoInicial = 100.0;
            double montoAgregar = 50.0;
            Arca arca = new Arca(saldoInicial);

            arca.agregarSaldo(montoAgregar);
            double saldoObtenido = arca.obtenerSaldo();

            Assert.AreEqual(saldoInicial + montoAgregar, saldoObtenido, "El saldo después de agregar no es el esperado.");
        }

        [TestMethod]
        public void TestRestarSaldo()
        {
            double saldoInicial = 100.0;
            double montoRestar = 50.0;
            Arca arca = new Arca(saldoInicial);

            arca.restarSaldo(montoRestar);
            double saldoObtenido = arca.obtenerSaldo();

            Assert.AreEqual(saldoInicial - montoRestar, saldoObtenido, "El saldo después de restar no es el esperado.");
        }
    }
}
