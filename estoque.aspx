<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="estoque.aspx.cs" Inherits="sistema_De_estoque2.WebForm1" Async="true" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body style="font-family: Arial; background-color: #f4f6f8;">
    <form id="form1" runat="server">


        <div style="max-width: 600px; margin: 40px auto; padding: 20px; background: white; border-radius: 10px; box-shadow: 0px 0px 10px #ccc;">

            <h1 style="text-align:center;"> Estoque Papelaria</h1>

            <div style="margin-bottom: 10px;">
                <asp:TextBox ID="txtNome" runat="server" placeholder="Produto"
                    style="width:100%; padding:10px; margin-bottom:10px;"></asp:TextBox>

                <asp:TextBox ID="txtQtd" runat="server" placeholder="Quantidade"
                    style="width:100%; padding:10px;"></asp:TextBox>
            </div>

            <asp:Button ID="btnAdd" runat="server" Text="Adicionar"
                OnClick="btnAdd_Click"
                style="width:100%; padding:10px; background:#28a745; color:white;font-weight: bold; border:none; border-radius:5px; cursor:pointer;" />

            <br /><br />

            <asp:GridView ID="GridView1" runat="server"
                AutoGenerateColumns="False"
                OnRowCommand="GridView1_RowCommand"
                style="width:100%;text-align: center;" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">

                <Columns>
                    <asp:BoundField DataField="Nome" HeaderText="Produto" />
                    <asp:BoundField DataField="Quantidade" HeaderText="Quantidade" />

                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:Button runat="server"
                                Text="Excluir"
                                CommandName="Excluir"
                                CommandArgument='<%# Eval("Id") %>'
                                style="background:pink; color:black;font-weight: bold; border:none; padding:5px 10px; border-radius:5px;" />
                        </ItemTemplate>
                    </asp:TemplateField>

                </Columns>

            </asp:GridView>

            <br />
            <br />
            <div style="text-align:right;">
            <asp:Button ID="btnSair" runat="server" Text="Sair" OnClick="btnSair_Click"
                style="font-size:16px; padding:10px 20px; background: black; color:yellowgreen; font-weight: bold" />
                
        </div>

    </form>
</body>
</html>
