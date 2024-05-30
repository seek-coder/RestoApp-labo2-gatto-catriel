using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace usuarios
{
    public interface IEncargado
    {
        //Stock consultarStockActual();
        //Stock consultarStockAnterior();
        double recaudarIngresoDiario();
        double pagarSueldoMensual(Empleado empleado);
    }
}
