using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace usuarios
{
    public interface ICocinero
    {
        bool cocinar();
        //Plato crearPlato();
        //Plato modificarPlato();
        void eliminarPlato();
        string describrirPlato();
    }

}
