<%@ Page Title="Inicio" Language="vb" AutoEventWireup="false" CodeBehind="Index.aspx.vb" Inherits="Web.Index"%>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<script runat="server">
    Dim datos As New Datos.UsuarioLogeadoWeb
</script>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <link href="~/CSS/Estilos.css" rel="stylesheet" type="text/css" />



</head>
<body>
    <form id="form1" runat="server">
    <div class="header">
    <div class="title">
        <h1>
            [NOMBRE DE LA BODEGA]
        </h1>
        
    </div>
    </br>
    </br>
    </br>
    <div class="clear hideSkiplink">
        <%  If (datos.Log = 1) Then%>
        <asp:Menu ID="Menu1" runat="server" CssClass="menu" EnableViewState="false" IncludeStyleBlock="false" Orientation="Horizontal">
            <Items>
                <asp:MenuItem NavigateUrl="~/Index.aspx" Text="Página principal"/>
                <asp:MenuItem NavigateUrl="~/Productos.aspx" Text="Productos"/>
                <asp:MenuItem NavigateUrl="~/Acerca.aspx" Text="Acerca de"/>
                <asp:MenuItem NavigateUrl="~/Contacto.aspx" Text="Contacto"/>
                <asp:MenuItem Text="Perfil" Value="Perfil"></asp:MenuItem>
                <asp:MenuItem Text="Cerrar sesion" Value="Cerrar sesion" 
                    NavigateUrl="~/Login.aspx"></asp:MenuItem>
            </Items>
            
        </asp:Menu>
        <%  Else%>
        <asp:Menu ID="NavigationMenu" runat="server" CssClass="menu" EnableViewState="false" IncludeStyleBlock="false" Orientation="Horizontal">
            <Items>
                <asp:MenuItem NavigateUrl="~/Index.aspx" Text="Página principal"/>
                <asp:MenuItem NavigateUrl="~/Productos.aspx" Text="Productos"/>
                <asp:MenuItem NavigateUrl="~/Acerca.aspx" Text="Acerca de"/>
                <asp:MenuItem NavigateUrl="~/Contacto.aspx" Text="Contacto"/>
                <asp:MenuItem Text="LogIn" Value="LogIn" NavigateUrl="~/Login.aspx"></asp:MenuItem>
            </Items>
            
        </asp:Menu>
        <%End If%>
        
    </div>
</div>
</br>
</br>
</br>
<center>
    <div class="LogBox">
    <%  If (datos.Log = 0) Then
            MSnoLog.Text = "La pagina de inicio sin estar Logeado esta en mantenimiento, por favor intentelo mas tarde"%>
        </br>
        <asp:Label ID="MSnoLog" runat="server" Text=""></asp:Label>
    <%  Else%>
        </br>
        <%  If (datos.Tipo = 1) Then
                MSLog.Text = datos.Nombre & ", por el momento el Inicio de Clientes esta en mantenimiento, por favor intentelo mas tarde"
            ElseIf (datos.Tipo = 2) Then
                MSLog.Text = datos.Nombre & ", por el momento el Inicio de Asesores Profesionales esta en mantenimiento, por favor intentelo mas tarde"
            End If%>
            <asp:Label ID="MSLog" runat="server" Text=""></asp:Label>
        
        <%  
          End If%>
    </div>
    </center>
</form>
</body>
</html>