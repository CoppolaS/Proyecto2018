<%@ Page Title="Login" Language="vb" MasterPageFile="~/Site1.Master" AutoEventWireup="false" CodeBehind="Login.aspx.vb" Inherits="Web.Login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">


<script runat="server">
    Dim datos As New Datos.UsuarioLogeadoWeb
    Dim Neg As New Negocio.VerificarOtros
    Public Sub log(ByVal sender As Object, ByVal e As EventArgs)
        Dim re As New Integer
        re = Neg.VerificarLoginWeb(Usuario.Text, Contraseña.Text)
        If datos.Log = 1 Then
            Label4.Visible = True
            Button1.Visible = True
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
        Button1.Visible = False
        Label3.Text = "No Logeado"
    End Sub
</script>
<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

</asp:Content>

<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <div>
    
        <asp:Label ID="Label3" runat="server" Text="No Logeado"></asp:Label>
&nbsp;<asp:Label ID="Label4" runat="server" Visible="False"></asp:Label>
        <asp:Button ID="Button1" runat="server" Text="Cerrar secion" Visible="False" OnClick="Close" />
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
        <asp:Button runat="server" Text="Aceptar" OnCLick="log"/>
    </p>
</asp:Content>
