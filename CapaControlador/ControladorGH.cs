using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaModelo;

namespace CapaControlador
{
    public class ControladorGH
    {
        sentenciasGH sn = new sentenciasGH();
        public void GuardarEmpleado(string nombre_completo, string puesto, string departamento, int estado)
        {
            sn.guardarEmpleado(nombre_completo, puesto, departamento, estado);
        }
    }
}
