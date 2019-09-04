<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CadastroEstado.aspx.cs" Inherits="ProjAula4.CadastroEstado" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 608px;
        }
    </style>
</head>
<body>
     <form id="form1" runat="server">
        <p>
            <h2> Cadastro de Estados </h2>
         <p> 
             <asp:Label ID="LblMsg" runat="server"></asp:Label>
         </p>
        <p>
            Descrição:</p>
        <p>
            <asp:TextBox ID="TxtDescricao" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="BtnSalvar" runat="server" Height="25px" OnClick="BtnSalvar_Click" Text="Salvar" Width="54px" />
        </p>
        <asp:GridView ID="GVEstado" runat="server">
        </asp:GridView>
    </form>
</body>
</html>
