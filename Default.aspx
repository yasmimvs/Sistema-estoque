<%@ Page Title="Home Page" Language="C#" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs"
    Inherits="sistema_De_estoque2._Default" Async="true" %>

<!DOCTYPE html>

<html>
<head runat="server">

    
    <body style="margin:0; height:100vh; background:#f4f6f8;">
    <title>Login</title>

    <style>
        .cadastro {
            width: 300px;
            margin: auto;
            padding: 20px;
            border: 1px solid #ccc;
        }

        .yo {
            color: blue;
        }
   
       .bot{
           text-color: pink;
       }
       
    </style>

</head>

<body>

    <form id="form1" runat="server">

        <div class="cadastro">

            <h2>
                <asp:Label ID="Label4" runat="server"
                    Text="Login de entrada"
                    CssClass="yo">
                </asp:Label>
            </h2>

            <asp:Label ID="Label5" runat="server" Text="Nome"></asp:Label>
            <asp:TextBox ID="TextBox3" runat="server" Width="219px"></asp:TextBox>

            <br /><br />

            <asp:Label ID="Label6" runat="server" Text="Senha"></asp:Label>
            <asp:TextBox ID="TextBox4" runat="server"
                TextMode="Password" Width="218px"></asp:TextBox>

            <br /><br />
           
            <div style="text-align:center;">
           <asp:Button style="background-color: pink; color: white;font-weight: bold" ID="Button2" runat="server" Text="Entrar" OnClick="Button2_Click" />
             </div>
        </div>

    </form>

</body>
</html>