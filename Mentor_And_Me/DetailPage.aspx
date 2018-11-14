<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DetailPage.aspx.cs" Inherits="Mentor_And_Me.DetailPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Mentor&Me - CreateEvent</title>
    <meta name="description" content="website description" />
    <meta name="keywords" content="website keywords, website keywords" />
    <meta http-equiv="content-type" content="text/html; charset=windows-1252" />
    <link rel="stylesheet" type="text/css" href="style/style.css" title="style" />
</head>
<body>
    <form id="form1" runat="server">
        <div id="menubar">
                <ul id="menu">
                    <li><a href="Index.aspx">Projects</a></li>
                    <li class="selected"><a href="Create.aspx">Create</a></li>
                    <li><a href="chat.html">Chat</a></li>
                    <li><a href="login.html">Login</a></li>
                    <li><a href="contact.html">Contact Us</a></li>
                   </ul>
            </div>
        <div class="projDetails">          
            <asp:Label ID="nameLabel" runat="server" Text="Label"></asp:Label>
            <br />
            <br />
        <br /> 
            <br />
            <asp:Label ID="creatoLabel" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:Label ID="descriptionLabel" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:Label ID="sizeLabel" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:Label ID="requirementsLabel" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:Label ID="dateLabel" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:Button ID="applyButton" runat="server" OnClick="applyButton_Click" OnCommand="applyButton_Command" Text="Button" />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
