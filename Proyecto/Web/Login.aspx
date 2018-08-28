<%@ Page Title="Login" Language="vb" AutoEventWireup="false" CodeBehind="Login.aspx.vb" Inherits="Web.Login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">


<script runat="server">
    Dim datos As New Datos.UsuarioLogeadoWeb
    Dim Neg As New Negocio.VerificarOtros
    Dim re As New Integer
    Dim boton As New Integer
    Public Sub log(ByVal sender As Object, ByVal e As EventArgs)
        boton = 1
        re = Neg.VerificarLoginWeb(Usuario.Text, Contraseña.Text)
        Usuario.Text = ""
        Contraseña.Text = ""
    End Sub
        
    public Sub close(ByVal sender As Object, ByVal e As EventArgs)
        datos.Log = 0
    End Sub

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
    <div class="loginDisplay">
    </div>
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
                    NavigateUrl="~/CloseLog.aspx"></asp:MenuItem>
            </Items>
            
        </asp:Menu>
        <%  Else%>
        <asp:Menu ID="NavigationMenu" runat="server" CssClass="menu" EnableViewState="false" IncludeStyleBlock="false" Orientation="Horizontal">
            <Items>
                <asp:MenuItem NavigateUrl="~/Index.aspx" Text="Página principal"/>
                <asp:MenuItem NavigateUrl="~/Productos.aspx" Text="Productos"/>
                <asp:MenuItem NavigateUrl="~/Acerca.aspx" Text="Acerca de"/>
                <asp:MenuItem NavigateUrl="~/Formulario web1.aspx" Text="Contacto"/>
                <asp:MenuItem Text="LogIn" Value="LogIn"></asp:MenuItem>
            </Items>
            
        </asp:Menu>
        <%End If%>
        
    </div>
</div>
</br>
</br>
</br>
</br>
<center>
    <div class="LogBox">
    <%  If (datos.Log = 0) Then
            If (boton = 1) Then
                boton = 0
                If (re = 1) Then
                    LogBad.Visible = False
                Else
                    re = 1
                    LogBad.Visible = True
                End If
            Else
                LogBad.Visible = False
            End If%>
    <asp:Label Visible="false" ID="LogBad" runat="server" Text="Hubo un error al iniciar sesion"></asp:Label>
    <p>
        <asp:Label ID="Label1" runat="server" Text="Usuario:"></asp:Label>
        <asp:TextBox ID="Usuario" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="Label2" runat="server" Text="Contraseña"></asp:Label>
        <asp:TextBox ID="Contraseña" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="Button1" runat="server" Text="Aceptar" OnCLick="log"/>
    </p>
    <%  Else
            CloseMS.Text = datos.Nombre & " Estas seguro que deseas Cerrar sesion?"%>
    </br>
    <asp:Label ID="CloseMS" runat="server" Text=""></asp:Label>
    <asp:Button ID="Button2" runat="server" Text="Cerrar sesion" OnCLick="close"/>

    <%  
          End If%>
    </div>
    </center>
    </form>
</body>
</html>


