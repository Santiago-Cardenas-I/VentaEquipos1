<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AgregarEquipo.aspx.cs" Inherits="GestionDeVentasEquipos.AgregarEquipo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Agregar equipo a ventas</title>
     <link rel="stylesheet" href="AgregarEquipo.css"/>
</head>
<body>
    <form id="form1" runat="server" action="#" method="post">
        <h2>Formulario de Equipos</h2>

    <div>
         <asp:Label ID="Label1" Class="form-label" runat="server" Text="Label">Tipo de equipo:</asp:Label>
         <asp:TextBox ID="txtTipoEquipo" Class="form-Control" Type="text" runat="server" ></asp:TextBox>
    </div>

    <div>
        <asp:Label ID="Label2" Class="form-label" runat="server" Text="Label">Marca de equipo:</asp:Label>
        <asp:TextBox ID="txtMarca" Class="form-Control" Type="text" runat="server"></asp:TextBox>
    </div>

    <div>
        <asp:Label ID="Label3" Class="form-label" runat="server" Text="Label">Precio:</asp:Label>
        <asp:TextBox ID="txtPrecio" Class="form-Control" Type="number" runat="server"></asp:TextBox><br class="Apple-interchange-newline"/>
    </div>

   
   <div>
    <asp:Label ID="Label4" CssClass="form-label" runat="server" Text="Especificaciones:"></asp:Label>
    <asp:TextBox ID="txtEspecificaciones" Class="form-Control" Type="text" runat="server" TextMode="MultiLine" Rows="5" placeholder="Ejemplo: Ram 8GB"></asp:TextBox>
</div>


        <br/>

    <div>
        <asp:Button ID="btnAgregar" Class="boton" runat ="server" Text="Agregar" OnClick="btnAgregar_Click" />
        <asp:Button ID="btnLimpiar" Class="boton" runat="server" Text="Limpiar" OnClick="btnLimpiar_Click"/>
    </div>
        <br class="Apple-interchange-newline"/>
        <br class="Apple-interchange-newline"/>
  

        
    <div class="containerAgregarEquipos col">
        <asp:GridView ID="GridViewEquipos" runat="server" AutoGenerateColumns="false" OnSelectedIndexChanged="GridViewEquipos_SelectedIndexChanged">
            <Columns>
                <asp:BoundField DataField="TipoEquipo" HeaderText="Tipo de Equipo" SortExpression="TipoEquipo"></asp:BoundField>
                <asp:BoundField DataField="Marca" HeaderText="Marca" SortExpression="Marca"></asp:BoundField>
                <asp:BoundField DataField="Precio" HeaderText="Precio" SortExpression="Precio"></asp:BoundField>
                <asp:BoundField DataField="Especificacoiones" HeaderText="Especificaciones" SortExpression="Especificaciones"></asp:BoundField>
            </Columns>
        </asp:GridView>
    </div>


        
        
    </form>
   

</body>
</html>

