<%@ Page Title="Login" Language="vb" AutoEventWireup="false" CodeBehind="Login.aspx.vb" Inherits="Web.Login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">


<script runat="server">
    Dim datos As New Datos.UsuarioLogeadoWeb
    Dim Neg As New Negocio.VerificarOtros
    Public Sub log(ByVal sender As Object, ByVal e As EventArgs)
        Dim re As New Integer
        re = Neg.VerificarLoginWeb(Usuario.Text, Contraseña.Text)
        If datos.Log = 1 Then
            Label4.Visible = True
            ButtonC.Visible = True
            If datos.Tipo = 1 Then
                Label4.Text = "Cliente"
            Else
                Label4.Text = "Asesor Profecional"
            End If
            Label3.Text = "Bienbenido De Nuevo " & datos.Nombre & " Tipo: "
        End If
        Usuario.Text = ""
        Contraseña.Text = ""
    End Sub
        
    public Sub close(ByVal sender As Object, ByVal e As EventArgs)
        datos.Log = 0
        Label4.Visible = False
        ButtonC.Visible = False
        Label3.Text = "No Logeado"
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
    <div class="loginDisplay">
    </div>
    <div class="clear hideSkiplink">
        <asp:Menu ID="NavigationMenu" runat="server" CssClass="menu" EnableViewState="false" IncludeStyleBlock="false" Orientation="Horizontal">
            <Items>
                <asp:MenuItem NavigateUrl="~/Index.aspx" Text="Página principal"/>
                <asp:MenuItem NavigateUrl="~/Productos.aspx" Text="Productos"/>
                <asp:MenuItem NavigateUrl="~/Acerca.aspx" Text="Acerca de"/>
                <asp:MenuItem NavigateUrl="~/Contacto.aspx" Text="Contacto"/>
            </Items>
        </asp:Menu>
    </div>
</div>
    <div>
        <div>
    
        <asp:Label ID="Label3" runat="server" Text="No Logeado"></asp:Label>
&nbsp;<asp:Label ID="Label4" runat="server" Visible="False"></asp:Label>
        <asp:Button ID="ButtonC" runat="server" Text="Cerrar secion" Visible="False" 
                OnClick="Close" />
    </div>
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
    </div>
    </form>
</body>
</html>


