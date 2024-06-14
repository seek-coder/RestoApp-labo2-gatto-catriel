using Microsoft.VisualStudio.TestTools.UnitTesting;
using administracion;

namespace AdministracionTests
{
    [TestClass]
    public class ArcaTests
    {
        [TestMethod]
        public void obtenerSaldo_DeberiaRetornarSaldoInicial()
        {
            // arrange
            double saldoInicial = 100.0;
            Arca arca = new Arca(saldoInicial);

            // act
            double saldoObtenido = arca.obtenerSaldo();

            // assert
            Assert.AreEqual(saldoInicial, saldoObtenido, "El saldo obtenido no es el saldo inicial esperado.");
        }

        [TestMethod]
        public void establecerSaldo_DeberiaEstablecerNuevoSaldo()
        {
            // arrange
            double nuevoSaldo = 150.0;
            Arca arca = new Arca(100.0);

            // act
            arca.establecerSaldo(nuevoSaldo);
            double saldoObtenido = arca.obtenerSaldo();

            // assert
            Assert.AreEqual(nuevoSaldo, saldoObtenido, "El saldo obtenido no coincide con el nuevo saldo establecido.");
        }

        [TestMethod]
        public void agregarSaldo_DeberiaSumarMontoAlSaldoActual()
        {
            // arrange
            double saldoInicial = 100.0;
            double montoAgregar = 50.0;
            Arca arca = new Arca(saldoInicial);

            // act
            arca.agregarSaldo(montoAgregar);
            double saldoEsperado = saldoInicial + montoAgregar;
            double saldoObtenido = arca.obtenerSaldo();

            // assert
            Assert.AreEqual(saldoEsperado, saldoObtenido, "El saldo obtenido no es el saldo esperado después de agregar saldo.");
        }

        [TestMethod]
        public void restarSaldo_DeberiaRestarMontoAlSaldoActual()
        {
            // arrange
            double saldoInicial = 100.0;
            double montoRestar = 30.0;
            Arca arca = new Arca(saldoInicial);

            // act
            arca.restarSaldo(montoRestar);
            double saldoEsperado = saldoInicial - montoRestar;
            double saldoObtenido = arca.obtenerSaldo();

            // assert
            Assert.AreEqual(saldoEsperado, saldoObtenido, "El saldo obtenido no es el saldo esperado después de restar saldo.");
        }
    }
}