<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CadastroCidade.aspx.cs" Inherits="ProjAula4.CadastroCidade" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body style="height: 637px">
    <form id="form1" runat="server">
        <p>
            <h2> Cadastro de Cidades </h2>
        <p>
        <p>   
            <asp:Label ID="LblMSG" runat="server" Text=""></asp:Label>
        </p> 
            Descrição:</p>
        <p>
            <asp:TextBox ID="TxtDescricao" runat="server"></asp:TextBox>
        </p>
        <p>
            Estado:</p>
        <p>
            <asp:DropDownList ID="DDLEstado" runat="server">
            </asp:DropDownList>
        </p>
        <p>
            <asp:Button ID="BtnSalvar" runat="server" Height="25px" OnClick="BtnSalvar_Click" Text="Salvar" Width="54px" />
        </p>
        <p>
            <asp:Button ID="BtnVoltar" runat="server" Text="Voltar" />
        </p>
        <asp:GridView ID="GVCidade" runat="server" >
        </asp:GridView>
    </form>
</body>
</html>
