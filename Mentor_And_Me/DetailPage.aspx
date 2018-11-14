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
                    <li><a href="login.html">Login</a></li>
                    <li class="selected"><a href="Create.aspx">Create</a></li>
                    <li><a href="Index.aspx">Projects</a></li>                 
                    <li><a href="chat.html">Chat</a></li>                  
                    <li><a href="contact.html">Contact Us</a></li>
                   </ul>
            </div>
        <div class="projDetails">          
            <br />
            <asp:Label ID="nameLabel" runat="server" Text="Label"></asp:Label>
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
            <br />   
            
       
       
        <asp:RadioButton ID="aceptRadioBtn" runat="server" OnCheckedChanged="RadioButton2_CheckedChanged" />
        <asp:Label ID="Label2" runat="server" Text="Accept"></asp:Label>
&nbsp;&nbsp;
       
        <asp:RadioButton ID="denyRadioBtn" runat="server" OnCheckedChanged="RadioButton2_CheckedChanged" />
        Deny<br />
            <asp:Button ID="submitBtn" runat="server" OnClick="submitBtn_Click" Text="Submit" />
            <br />
        <br />
            <br />
            <br />
        <br /> 
            <br />
            <br />
            <br />
        </div>
    </form>
    <footer>© 2018, Synergy Scrum Corporation, LLC
All Rights Reseved. Contents pertaining this app must not be shared or reproduced without prior authorization.
Please contact us for more information.</footer>

</body>
</html>
