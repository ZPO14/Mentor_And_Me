<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Mentor_And_Me.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<title>Mentor&Me - Login page</title>
    <meta name="description" content="website description" />
    <meta name="keywords" content="website keywords, website keywords" />
    <meta http-equiv="content-type" content="text/html; charset=windows-1252" />
    <link rel="stylesheet" type="text/css" href="./Style/Style.css" title="style" />
</head>
<body>
    <form id="form1" runat="server">
      <div id="main">
        <div id="header">
            <div id="logo">
                <div id="logo_text">
                    <h1><a href="index.html">Mentor<span class="logo_colour">&Me</span></a></h1>
                </div>
            </div>
            <div id="menubar">
                <ul id="menu">
                    <li class="selected"><a href="Login.html">Login</a></li>
                    <li><a href="Create.aspx">Create</a></li>
                    <li><a href="Index.aspx">Projects</a></li>                  
                    <li><a href="chat.html">Chat</a></li>                  
                    <li><a href="contact.html">Contact Us</a></li>
                </ul>
            </div>
        </div>
        <div id="content_header"></div>

        <div id="content">
            <!-- insert the page content here -->
            

        </div>

    </div>
      
        <asp:TextBox ID="userNameTxBx" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label1" runat="server" Text="Username"></asp:Label>
        <br />
        <br />
        <asp:TextBox ID="passWordTxBx" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>
        <br />
        <br />
        <asp:Button ID="logSubmitBtn" runat="server" OnClick="logSubmitBtn_Click" Text="Submit" />
      
    </form>
</body>
</html>
