using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
/// <summary>
/// Descripción breve de gestionDatos
/// </summary>
public class gestionDatos
{
    public bool InsertPersona(string cedula, string nombre, string apellido, string telefono, string deuda)
    {
        conexion cn = new conexion();

        try
        {
            string sql = "Insert into Persona values ('" + cedula + "', '" + nombre + "','" + apellido + "','" + telefono + "','" + deuda + "')";
            SqlCommand cmd = new SqlCommand(sql, cn.getConexion());
            int n = cmd.ExecuteNonQuery();
            return n > 0;

        }
        catch (Exception)
        {

            return false;
        }
    }


}