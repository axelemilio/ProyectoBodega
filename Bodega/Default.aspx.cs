using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

public partial class _Default : System.Web.UI.Page
{


    conexion cn = new conexion();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void agregar_Click(object sender, EventArgs e)
    {
        if (txtCedula.Text == "") { Response.Write("<script> window.alert('El campo Cedula esta vacio')</script>"); return; }
        if (txtNombre.Text == "") { Response.Write("<script> window.alert('El campo Nombre esta vacio')</script>"); return; }
        if (txtApellido.Text == "") { Response.Write("<script> window.alert('El campo apellido esta vacio')</script>"); return; }
        if (txtTelefono.Text == "") { Response.Write("<script> window.alert('El campo Telefono esta vacio')</script>"); return; }
        if (txtDeuda.Text == "") { Response.Write("<script> window.alert('El campo Deuda esta vacio')</script>"); return; }

        gestionDatos op = new gestionDatos();

        string cedula, nombre, apellido, telefono, deuda;
        cedula = txtCedula.Text;
        nombre = txtNombre.Text;
        apellido = txtApellido.Text;
        telefono = txtTelefono.Text;
        deuda = txtDeuda.Text;
        if (op.InsertPersona(cedula, nombre, apellido, telefono, deuda))
        {
            Response.Write("<script>window.alert('Persona ingresada correctamente')</script>");
            txtApellido.Text = "";
            txtNombre.Text = "";
            txtCedula.Text = "";
        }
        else
        {
            Response.Write("<script> window.alert('Error al ingresar esta persona')</script>");

        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (txt_consulta.Text == "")
        {

            try
            {
                SqlCommand comando = new SqlCommand("select * from Persona", cn.getConexion());
                SqlDataAdapter data = new SqlDataAdapter(comando);
                DataTable tabla = new DataTable();
                data.Fill(tabla);
                this.GridView1.DataSource = tabla;
                GridView1.DataBind();
                Label8.Visible = false;
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }
        else
        {

            SqlCommand comando = new SqlCommand("select * from Persona where cedula = '" + txt_consulta.Text + "'", cn.getConexion());
            SqlDataAdapter data = new SqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            data.Fill(tabla);
            this.GridView1.DataSource = tabla;
            GridView1.DataBind();
            Label8.Visible = false;
        }
        /* else
         {


             SqlCommand comando = new SqlCommand("select * from Persona where rut = '"+txt_consulta+"'", cn.getConexion());
             SqlDataAdapter data = new SqlDataAdapter(comando);
             DataTable tabla = new DataTable();
             data.Fill(tabla);
             GridView1.DataSource = tabla;
             GridView1.DataBind();
         }*/

    }
    protected void tabla_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void Button1_Click1(object sender, EventArgs e)
    {

        if (txtSuma.Text == "")
        {
            Response.Write("<script>window.alert('No puedes dejar el apartado cedula vacio')</script>");
            return;
        }
        else
        {
            resultados.Text = "Ahora la deuda del usuario con cedula " + txtSuma.Text + " se le disminuyo " + txtSuma2.Text + " pesos";


            try
            {

                string sql = "update Persona set Deuda = Deuda - '" + txtSuma2.Text + "' where cedula = '" + txtSuma.Text + "'";
                SqlCommand cmd = new SqlCommand(sql, cn.getConexion());
                int n = cmd.ExecuteNonQuery();
                Response.Write("<script>window.alert('Se actualizo la cedula correctamente. actualice la base de datos y verifique si es correcto')</script>");

                SqlCommand comando = new SqlCommand("select * from Persona", cn.getConexion());
                SqlDataAdapter data = new SqlDataAdapter(comando);
                DataTable tabla = new DataTable();
                data.Fill(tabla);
                this.GridView1.DataSource = tabla;
                GridView1.DataBind();

                return;

            }
            catch (Exception)
            {

                Response.Write("<script> window.alert('No funciono')</script>");
                return;
            }
        }
    }

    protected void GridView1_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
    {


    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void Button1_Click2(object sender, EventArgs e)
    {

     

        if (txtSuma.Text == "")
        {

            Response.Write("<script>window.alert('No puedes dejar el apartado cedula vacio')</script>");
            return;
        }
        else
        {

            resultados.Text = "Ahora la deuda del usuario con cedula " + txtSuma.Text + " se aumento " + txtSuma2.Text + " pesos";

            try
            {

                string sql = "update Persona set Deuda = Deuda + '" + txtSuma2.Text + "' where cedula = '" + txtSuma.Text + "'";
                SqlCommand cmd = new SqlCommand(sql, cn.getConexion());
                int n = cmd.ExecuteNonQuery();
                Response.Write("<script>window.alert('Se actualizo la cedula correctamente. actualice la base de datos y verifique si es correcto')</script>");

                SqlCommand comando = new SqlCommand("select * from Persona", cn.getConexion());
                SqlDataAdapter data = new SqlDataAdapter(comando);
                DataTable tabla = new DataTable();
                data.Fill(tabla);
                this.GridView1.DataSource = tabla;
                GridView1.DataBind();
               
                Label8.Visible = false;

 return;
               
            }
            catch (Exception)
            {

                Response.Write("<script> window.alert('No funciono')</script>");
                return;
            }
        }


    }
    protected void txtSuma_TextChanged(object sender, EventArgs e)
    {

    }
    protected void txtSuma2_TextChanged(object sender, EventArgs e)
    {


    }
  
    protected void txtNombre_TextChanged(object sender, EventArgs e)
    {

    }
    protected void txtCedula_TextChanged(object sender, EventArgs e)
    {

    }

}