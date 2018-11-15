<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DetailPage.aspx.cs" Inherits="Mentor_And_Me.DetailPage" %>

<!DOCTYPE html>
    
    <style>


    </style>

<html xmlns="http://www.w3.org/1999/xhtml">
 <title>Mentor&Me - Projects</title>
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
                    <h1><a href="index.aspx">Mentor<span class="logo_colour"><em>&</em>Me</span></a></h1>
                    <h2></h2>
                </div>
            </div>
            <div id="menubar">
                <ul id="menu">
                    <li><a href="login.aspx">Login</a></li>
                    <li><a href="Create.aspx">Create</a></li>
                    <li class="selected"><a href="index.aspx">Projects</a></li>               
                    <li><a href="Chat.html">Chat</a></li>                  
                    <li><a href="Contact.html">Contact Us</a></li>
                </ul>
            </div>
        </div>
            </div>
        <div class="projDetails" style="text-align:center;">          
            <br />
            <asp:Label ID="nameLabel" runat="server" Text="Label" Style="font-size:32pt;" ></asp:Label>
            <br />
            <asp:Label ID="creatoLabel" runat="server" Text="Label" Style="font-size:24pt;" ></asp:Label>
            <br />
            <br />
            <br />
            <div style="padding-left:400px; padding-right: 400px;">
            <asp:Label ID="descriptionLabel" runat="server" Text="Label" Style="font-size:16pt;"></asp:Label>
                <br />
                <br />
                Rewirements:<br />
            <asp:Label ID="requirementsLabel" runat="server" Text="Label" Style="font-size:16pt;"></asp:Label>
                </div>
            <br />
            Size:
            <asp:Label ID="sizeLabel" runat="server" Text="Label" Style="font-size:16pt;"></asp:Label>
            &nbsp;&nbsp; Applicants will be chosen by:
            <asp:Label ID="dateLabel" runat="server" Text="Label" Style="font-size:16pt;"></asp:Label>
            <br />
&nbsp;
            <br />
            <br />
            <br />
            <br />   
            
       
       
            <br />
            <asp:Button ID="submitBtn" runat="server" OnClick="submitBtn_Click" Text="Apply" />
            <br />
        <br />
            <br />
            <asp:Button ID="deleteButton" runat="server" OnClick="deleteButton_Click" Text="Delete Event" />
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
