using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaModelo;
using System.Data;
using System.Data.Odbc;

namespace CapaControlador
{
    public class ControladorGH
    {
        sentenciasGH sn = new sentenciasGH();

        public void GuardarEmpleado(string nombre_completo, string puesto, string departamento, int estado)
        {
            sn.guardarEmpleado(nombre_completo, puesto, departamento, estado);
        }

        public DataTable llenarTbl(string tabla)
        {
            OdbcDataAdapter dt = sn.llenarTbl(tabla);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }
        public void EliminarEmpleado(string nombre_completo)
        {
            sentenciasGH sn = new sentenciasGH();
            sn.eliminarEmpleado(nombre_completo);
        }

        public void ActualizarEmpleado(string nombre_completo, string puesto, string departamento, int estado)
        {
            sentenciasGH sn = new sentenciasGH();
            sn.actualizarEmpleado(nombre_completo, puesto, departamento, estado);
        }

    }
}
