<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="impresoras.aspx.cs" Inherits="GestionDeVentasEquipos.impresoras" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Menú Desplegable</title>
    <link rel="stylesheet" href="RegistroVentas.css"/>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DropDownList ID="ddlProductos" runat="server" OnSelectedIndexChanged="ddlProductos_SelectedIndexChanged" AutoPostBack="True">
                <asp:ListItem Text="Tipo de equipo" Value="Tipo de equipo" />
                <asp:ListItem Text="Portátil" Value="portatil" />
                <asp:ListItem Text="Impresora" Value="impresora" />
                <asp:ListItem Text="Monitor" Value="monitor" />
            </asp:DropDownList>
        </div>

        <asp:DropDownList ID="ddlMemorias" runat="server" Visible="False" > 
            <asp:ListItem Text="Memoria" Value="Memoria" />
            <asp:ListItem Text="8 GB" Value="8GB" />
            <asp:ListItem Text="16 GB" Value="16GB" />
            <asp:ListItem Text="20 GB" Value="20GB" />
        </asp:DropDownList>

        <asp:DropDownList ID="ddlSSD" runat="server" Visible="False">
            <asp:ListItem Text="Disco solido" Value="Disco solido" />
            <asp:ListItem Text="256 GB" Value="256GB" />
            <asp:ListItem Text="512 GB" Value="512GB" />
            <asp:ListItem Text="1000 GB" Value="1000GB" />
        </asp:DropDownList>

        <asp:DropDownList ID="ddlMarcaPc" runat="server" Visible="False">
            <asp:ListItem Text="Marca" Value="Marca " />
            <asp:ListItem Text="Asus" Value="Asus" />
            <asp:ListItem Text="HP" Value="HP" />
            <asp:ListItem Text="MAC" Value="MAC" />
        </asp:DropDownList>

<div>
    <asp:DropDownList ID="ddlResolucionPantalla" runat="server" Visible="false">
        <asp:ListItem Text="Resolución de pantalla" Value="Resolución de pantalla" />
        <asp:ListItem Text="4320p (8K): 7680 × 4320" Value="4320p (8K): 7680 × 4320" />
        <asp:ListItem Text="2160p (4K): 3840 × 2160." Value="2160p (4K): 3840 × 2160." />
        <asp:ListItem Text="1080p (HD): 1920 × 1080." Value="1080p (HD): 1920 × 1080." />
    </asp:DropDownList>
</div>

<div>
    <asp:DropDownList ID="ddlMarcaMonitor" runat="server" Visible="false">
        <asp:ListItem Text="Marca del monitor" Value="Marca del monitor" />
        <asp:ListItem Text="Asus" Value="Asus"/>
        <asp:ListItem Text="LG" Value="LG" />
        <asp:ListItem Text="Samsung" Value="Samsung"/>
    </asp:DropDownList>
</div>

<div>
    <asp:DropDownList ID="ddlResolucionImpresora" runat="server" Visible="false">
       <asp:ListItem Text="Resolución de impresión" Value="Resolución de impresión" />
        <asp:ListItem Text="600ppp" Value="600ppp" />
        <asp:ListItem Text="1200ppp" Value="1200ppp" />
        <asp:ListItem Text="3000ppp" Value="3000ppp" />
    </asp:DropDownList>
</div>


<div>
    <asp:DropDownList ID="ddlMarcaImpresora" runat="server" Visible="false">
        <asp:ListItem Text="Marca de la impresora" Value="Marca de la impresora" />
        <asp:ListItem Text="HP" Value="HP"/>
        <asp:ListItem Text="CANNON" Value="CANNON" />
        <asp:ListItem Text="EPSON" Value="EPSON"/>
    </asp:DropDownList>
</div>


        <asp:Button ID="btnComprar" runat="server" Text="Comprar" OnClick="btnComprar_Click" />
       

        <br /> <br />

        <asp:Label ID="lblResultado" runat="server" Text=""></asp:Label>

        <br /> <br />

        <asp:label ID="lblContador" runat="server"  Text=""></asp:label>


    </form>



    



</body>
</html>
    
