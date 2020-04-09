<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="Diseno.css" rel="stylesheet" />
    <style type="text/css">
        #form1 {
            height: 796px;
        }
    </style>
    <script type="text/javascript">

        function onKeyDecimal(e, thix) {
            var keynum = window.event ? window.event.keyCode : e.which;
            if (document.getElementById(thix.id).value.indexOf('.') != -1 && keynum == 46)
                return false;
            if ((keynum == 8 || keynum == 48 || keynum == 46))
                return true;
            if (keynum <= 47 || keynum >= 58) return false;
            return /\d/.test(String.fromCharCode(keynum));
        }

        function justNumbers(e) {
            var keynum = window.event ? window.event.keyCode : e.which;
            if ((keynum == 8 || keynum == 48))
                return true;
            if (keynum <= 47 || keynum >= 58) return false;
            return /\d/.test(String.fromCharCode(keynum));
        }

        function soloLetras(evt) {
            var charCode = (evt.which) ? evt.which : event.keyCode
            if (charCode > 31 && (charCode < 48 || charCode > 57))
                return true;

            return false;
        }

    </script>
</head>
<body >
    <form id="form1" runat="server">
    <div id ="cuerpo" >
    
    
       <div id="agregarPersonas"><h1> <asp:Label ID="Label1" runat="server" Height="43px" Text="Agregar personas" Width="330px" ></asp:Label>
           <asp:Label ID="Label7" runat="server" Text="Colmado De Juan"  Width="330px" Height="43px"></asp:Label>
           </h1></div>
     <h4>  <asp:Label ID="Label2" runat="server" Text="Cedula:"></asp:Label> 
       
            <asp:TextBox onkeypress="return justNumbers(event);" ID="txtCedula" runat="server" width="120px" Height="20px" OnTextChanged="txtCedula_TextChanged" ></asp:TextBox>
         <asp:Label ID="Label5" runat="server" Text="Telefono:"></asp:Label> 
        <asp:TextBox ID="txtTelefono" onkeypress="return justNumbers(event);"  runat="server" width="120px" Height="20px" ></asp:TextBox>  
         <asp:Label  ID="Label6" runat="server" Text="Digite el monto de la compra que tomo fiado este usuario:"></asp:Label> 
              <asp:TextBox width="120px" onkeypress="return justNumbers(event);" Height="20px" ID="txtDeuda" runat="server" ></asp:TextBox></h4>

      <p></p>
           <h4> <asp:Label ID="Label3" runat="server" Text="Nombre:"></asp:Label>
        
       
            <asp:TextBox ID="txtNombre" runat="server" width="120px" Height="20px" OnTextChanged="txtNombre_TextChanged"></asp:TextBox>
        
        
           <asp:Label ID="Label4" runat="server" Text="Apellido:"></asp:Label> 
       

            <asp:TextBox ID="txtApellido" runat="server" width="120px" Height="20px"></asp:TextBox>
           
                         <asp:Button ID="agregar" runat="server" OnClick="agregar_Click" Text="agregar" Height="45px" Font-Size="20pt" Width="151px" /> 
               <p></p>
               <asp:Label ID="Label12" runat="server" Text=" . " Width="2201px"></asp:Label>
               <p></p>
        </h4>
        <div id="paraconsultar"> <p> 
          <h4> <asp:Label ID="Label9" runat="server" Text="Para consultar la base de datos completa deje el espacio en blanco, <br />para buscar a un usuario en especifico escribe la cedula del usuario "></asp:Label> </p>
        <asp:Button ID="consultas" runat="server" OnClick="Button1_Click" Text="consultar" Font-Size="20pt" />    
            <asp:TextBox onkeypress="return justNumbers(event);" ID="txt_consulta"   runat="server"></asp:TextBox>  </h4>
            &nbsp;&nbsp;&nbsp;  
            </div>
             <h2> <asp:GridView ID="GridView1" runat="server" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" OnSelectedIndexChanging="GridView1_SelectedIndexChanging">
      
            </asp:GridView> </h2>
        
       
           <p></p>
       <h1 style="height: 35px; width: 727px;"> <asp:Label ID="Label8" runat="server" Text="Aqui Se mostraran los usuarios"></asp:Label></h1>
        
       
           
        <div id="dialogo">
           <p  id="p" style="width: 2202px"> &nbsp;</p>
         <h4>   En el primer cuadro en blanco escriba la cedula del usuario <br />que desea actualuzar su deuda. Y en el segundo <br /> cantidad que desea sumar o restar.</h4>
            <div id="campoSuma">
                <asp:Label ID="Label10" runat="server" Text="Cedula:"></asp:Label>
                <asp:TextBox ID="txtSuma" runat="server" OnTextChanged="txtSuma_TextChanged" onkeypress="return justNumbers(event);" Width="65px" Height="16px"></asp:TextBox> 
            
           &nbsp;&nbsp;<asp:Label ID="Label11" runat="server" Text="Cantidad"></asp:Label>
&nbsp;<asp:TextBox ID="txtSuma2" runat="server" onkeypress="return justNumbers(event);" OnTextChanged="txtSuma2_TextChanged" Width="65px" Height="16px"></asp:TextBox> </div>
          
          
          <div id="sumas">  <asp:Button ID="sumar" runat="server" Height="37px" OnClick="Button1_Click2" Text="Sumar A la Deuda" />
            <asp:Button ID="restar" runat="server" Height="38px" OnClick="Button1_Click1" Text="Restar A la deuda" Width="121px" /> &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="resultados" runat="server" Text=""></asp:Label> 
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
          <h4>  <asp:Label ID="update" runat="server" Text="¿Esta seguro que quiere actualizar el dinero que debe este usuario? esta seguro escribe la cedula aqui y dale aceptar sino a cancelar." Visible="False"></asp:Label></h4>
         
        </div>
      
            </div>
         </div>
 

    


        
    </form>
</body>
</html>

