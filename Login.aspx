<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Login_crud.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login Page</title>
    <style>
        body
        {
            background-color:purple;
        }
        .container{

            width:60%;
            height:300px;
            text-align:center;
            background-color:white;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="header">
                <h1>Login </h1>
                <p>&nbsp;</p>
            </div>
            <div class="body">
                <asp:Label ID="Label1" runat="server" Text="User Name" Font-Bold="True"></asp:Label>
                &nbsp;<asp:TextBox ID="nametxt" runat="server"></asp:TextBox>
                <br />
                <br />
                </br>
                <asp:Label ID="Label2" runat="server" Text="Password" Font-Bold="True"></asp:Label>
                &nbsp;
                <asp:TextBox ID="passtxt" runat="server" TextMode="Password"></asp:TextBox>

                <br />
                <br />
                <br />
                <asp:Button ID="Button1" runat="server" Text="Login" OnClick="Button1_Click" />

            </div>

        </div>
    </form>
</body>
</html>
