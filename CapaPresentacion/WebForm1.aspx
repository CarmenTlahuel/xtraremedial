<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="CapaPresentacion.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">

    <h1>REGISTRA Y CONSULTA USUARIOS</h1>
        <div>
            Nombre:
            <asp:TextBox ID="TextBox1" runat="server" Width="251px"></asp:TextBox>
&nbsp;<br />
            Colonia:
            <asp:TextBox ID="TextBox2" runat="server" Width="255px"></asp:TextBox>
&nbsp;<br />
            Numero:
            <asp:TextBox ID="TextBox3" runat="server" Width="255px"></asp:TextBox>
&nbsp;<br />
            CP:
            <asp:TextBox ID="TextBox4" runat="server" Width="165px"></asp:TextBox>
&nbsp;<br />
            Centro de Tabajo:
            <asp:TextBox ID="TextBox5" runat="server" Width="217px"></asp:TextBox>
&nbsp;<br />
            Telefono:
            <asp:TextBox ID="TextBox6" runat="server" Width="270px"></asp:TextBox>
&nbsp;<br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Insertar " Width="191px" />
&nbsp;<asp:Button ID="Button4" runat="server" Text="Modificar" Width="173px" />
            <br />
            <br />
            <br />
            Nombre:
            <asp:TextBox ID="TextBox7" runat="server" Width="222px"></asp:TextBox>
&nbsp;
            <asp:Button ID="Button2" runat="server" Text="Buscar " Width="160px" />
&nbsp;<asp:Button ID="Button3" runat="server" Text="Eliminar " Width="180px" />
        </div>

    <h2>Consulta publicaciones de usuario</h2>
        <div>
            Selecciona un usuario: 
            <asp:DropDownList ID="DropDownList1" runat="server" Width="295px">
            </asp:DropDownList>
&nbsp;<asp:Button ID="Button5" runat="server" Text="Seleccionar" />
            <br />
            <asp:GridView ID="GridView1" runat="server" AutoGenerateSelectButton="True" Width="323px">
            </asp:GridView>
            <br />
            <asp:Button ID="Button6" runat="server" Text="Ver info" />
            <br />
            <br />
            <asp:ListBox ID="ListBox1" runat="server" Width="363px"></asp:ListBox>
        </div>
    </form>
</body>
</html>
