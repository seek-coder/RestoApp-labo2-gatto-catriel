using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace administracion
{
    public class Arca
    {
        private double _saldo;

        public Arca(double saldo)
        {
            this._saldo = saldo;
        }

        public double obtenerSaldo() { return _saldo; }
        public void establecerSaldo(double monto) { _saldo = monto; }
        public void agregarSaldo(double monto) { _saldo += monto; }
        public void restarSaldo(double monto) { _saldo -= monto; }
    }
}
