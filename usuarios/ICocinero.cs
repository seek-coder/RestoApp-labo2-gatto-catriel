using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using administracion;

namespace usuarios
{
    public interface ICocinero
    {
        bool cocinar(Plato plato);
        Plato crearPlato(Plato plato);
        Plato modificarPlato(Plato plato);
        void eliminarPlato(Plato plato);
        string describrirPlato(Plato plato);
    }

}
