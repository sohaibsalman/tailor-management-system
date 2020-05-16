<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FormLogin.aspx.cs" Inherits="Web.UI.FormLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>TMS - Login</title>
    <!-- Font Awesome CSS -->
    <link href="Fonts/font-awesome/css/all.min.css" rel="stylesheet" />
    <!-- Bootstrap CSS -->
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <!-- Google Font Link -->
    <link href="https://fonts.googleapis.com/css2?family=Roboto:wght@100;300;500;700&display=swap" rel="stylesheet" />
    <!-- Custom CSS -->
    <link href="Css/style.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="_wrapper">
            <div class="login_form">
                <div class="left_side">
                    <div class="left_content">
                        <h6>Welcome to</h6>
                        <h1>TMS</h1>
                    </div>
                </div>
                <div class="right_side">
                    <h1>Tailor Management System</h1>
                    <h3>Welcome Back, </h3>
                    <h6>Sign in to continue</h6>
                    <div class="_form">
                        <label>Username</label>
                        <asp:DropDownList ID="ddlUsernames" runat="server"></asp:DropDownList>
                        <label>Password</label>
                        <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" placeholder="Enter your Password..." required></asp:TextBox>
                        <div id="wrong_password" runat="server" class="_error">

                        </div>
                        <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" />
                        <a href="#">Forgot your Password?</a>
                    </div>

                </div>
            </div>
        </div>
    </form>
</body>
</html>
