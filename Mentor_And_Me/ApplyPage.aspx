<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ApplyPage.aspx.cs" Inherits="Mentor_And_Me.ApplyPage" %>

<!DOCTYPE HTML>
<html>

<head>
    <title>Mentor&Me - CreateEvent</title>
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
                    <li><a href="Login.aspx">Login</a></li>
                    <li class="selected"><a href="Create.aspx">Create</a></li>
                    <li><a href="Index.aspx">Projects</a></li>                  
                    <li><a href="chat.html">Chat</a></li>                    
                    <li><a href="contact.html">Contact Us</a></li>
                </ul>
                <div id="projectnamediv">
                    <br>&nbsp;</div>
                <div id=submitdiv>
                    &nbsp;</div>
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <asp:TextBox ID="applyTextBox" runat="server" Height="19px" Width="261px"></asp:TextBox>
        &nbsp; Enter First Name and Last Name<br />
        <br />
        <asp:TextBox ID="contactTextbox" runat="server"></asp:TextBox>
        &nbsp;<asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                <br />
        <br />
        <asp:Button ID="applyButton" runat="server" OnClick="applyButton_Click" Text="Submit Application!" />

            </div>
            <div id="content_footer"></div><br><br><br><br><br><br>
            </div>

    </div> </form>
    <footer>
        © 2018, Synergy Scrum Corporation, LLC
All Rights Reseved. Contents pertaining this app must not be shared or reproduced without prior authorization.
Please contact us for more information.</footer>

       
</body>
</html>
