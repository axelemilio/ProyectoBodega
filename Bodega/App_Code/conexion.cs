using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;


public class conexion
{
    public SqlConnection getConexion()
    {
        try
        {
            string cadena = @"Data source=EMILIO-PC\SQLEXPRESS; Initial Catalog=ColmadoJuan; Integrated Security=True ";
            SqlConnection cnn = new SqlConnection(cadena);
            cnn.Open();
            return cnn;

        }
        catch (Exception)
        {
            return null;
        }


    }
}