<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DetailPage.aspx.cs" Inherits="Mentor_And_Me.DetailPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Mentor&Me - CreateEvent</title>
    <meta name="description" content="website description" />
    <meta name="keywords" content="website keywords, website keywords" />
    <meta http-equiv="content-type" content="text/html; charset=windows-1252" />
    <link rel="stylesheet" type="text/css" href="style/style.css" title="style" />
    <style type="text/css">
        .auto-style1 {
            margin-bottom: 16;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div id="menubar">
                <ul id="menu">
                    <li><a href="Index.aspx">Projects</a></li>
                    <li class="selected"><a href="Create.html">Create</a></li>
                    <li><a href="chat.html">Chat</a></li>
                    <li><a href="login.html">Login</a></li>
                    <li><a href="contact.html">Contact Us</a></li>
                   </ul>
            </div>
        
        <p>
            <asp:TextBox ID="applicationBox" runat="server" CssClass="auto-style1" Height="186px" Width="337px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label1" runat="server" Text="Enter email: "></asp:Label>
            <asp:TextBox ID="emailTextBox" runat="server"></asp:TextBox>
            <asp:Button ID="submitButton" runat="server" Text="Submit" />
        </p>
        
    </form>
</body>
</html>
