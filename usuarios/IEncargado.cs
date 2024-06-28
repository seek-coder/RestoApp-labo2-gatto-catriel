using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using administracion;

namespace usuarios
{
    public interface IEncargado
    {
        Stock consultarStockActual(Stock stock);
        double recaudarIngresoDiario(List<Mesa> mesa, List<Pedido> pedido);
        double pagarSueldoMensual(Empleado empleado, Arca arca);
        double pagarProveedores(Proveedor proveedor, Arca arca, double monto);
    }
}
