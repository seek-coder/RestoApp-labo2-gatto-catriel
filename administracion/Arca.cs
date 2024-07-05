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
        private double _recaudacionDiaria;

        public Arca(double saldo, double recaudacionDiaria)
        {
            this._saldo = saldo;
            this._recaudacionDiaria = recaudacionDiaria;
        }

        public double obtenerSaldo() { return _saldo; }
        public void establecerSaldo(double monto) { _saldo = monto; }
        public void agregarSaldo(double monto) { _saldo += monto; }
        public void restarSaldo(double monto) { _saldo -= monto; }

        public double obtenerRecaudacion() { return _recaudacionDiaria; }
        public void agregarRecaudacion(double monto) { _recaudacionDiaria += monto; }
        public void restablecerRecaudacion() { _recaudacionDiaria = 0; }
    }
}
