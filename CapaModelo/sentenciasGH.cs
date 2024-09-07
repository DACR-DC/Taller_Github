using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;

namespace CapaModelo
{
    public class sentenciasGH
    {
        ConexionGH con = new ConexionGH();

        public void guardarEmpleado(string nombre_completo, string puesto, string departamento, int estado)
        {
            string query = $"INSERT INTO empleados (nombre_completo, Puesto, Departamento, Estado) VALUES ('{nombre_completo}', '{puesto}', '{departamento}', '{estado}')";
            OdbcCommand cmd = new OdbcCommand(query, con.conexion());
            cmd.ExecuteNonQuery();
        }

        public OdbcDataAdapter llenarTbl(string tabla)// metodo  que obtinene el contenio de una tabla
        {
            //string para almacenar los campos de OBTENERCAMPOS y utilizar el 1ro
            string sql = "SELECT * FROM " + tabla + "  ;";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, con.conexion());
            return dataTable;
        }

        public void eliminarEmpleado(string nombre_completo)
        {
            string query = $"DELETE FROM empleados WHERE nombre_completo = '{nombre_completo}'";
            OdbcCommand cmd = new OdbcCommand(query, con.conexion());
            cmd.ExecuteNonQuery();
        }
    }
}
