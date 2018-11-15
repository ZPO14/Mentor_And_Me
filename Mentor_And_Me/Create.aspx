<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Create.aspx.cs" Inherits="Mentor_And_Me.WebForm1" %>

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
            </div>

            <!-- Essentially these all need to be thrown into an array or a list through javascript with an "onClick", this array will be directed to the table on the home page and the details page that the project hyperlink will lead to -->
            <div id="projectcreation">
                <div id="projectnamediv">
                    Project name:<br> 
                    <asp:TextBox ID="nameTextBox" runat="server" Height="17px"></asp:TextBox>
                    <br>
                </div>
                <div id="projectcreatordiv">
                    Project creator: <br> 
                    <asp:TextBox ID="creatorTextBox" runat="server"></asp:TextBox>
                    <br>
                </div>
                <div id="projectdesciptiondiv">
                    Project desciption:<br> 
                    <asp:TextBox ID="descriptionTextBox" runat="server" Height="158px" Width="463px"></asp:TextBox>
                    <br>
                </div>
                <div id="projectsizediv">
                    Project size: <br> 
                    <asp:TextBox ID="sizeTextBox" runat="server"></asp:TextBox>
                    &nbsp;<datalist id="SizeList">
                        <option>Small</option>
                        <option> Medium</option> 
                        <option> Large</option>
                    </datalist>
                </div>
                <br>
                <div id="projectrequirementsdiv">
                    Project requirements: <br> 
                    <asp:TextBox ID="requirementsTextBox" runat="server" Height="97px" Width="389px"></asp:TextBox>
                    <br>
                </div>
                <div id="projectpickdatediv">
                    Application end date:<br> &nbsp;<asp:TextBox ID="dateTextBox" runat="server" Height="19px" Width="125px"></asp:TextBox>
                </div>
                <div id=submitdiv>
                    &nbsp;<asp:Button ID="createButton" runat="server" OnClick="createButton_Click" Text="Create" />
                </div>
            </div>
            <div id="content_footer"></div><br><br><br><br><br><br>
            </div>

    </div>

    </form>
    <footer>
        © 2018, Synergy Scrum Corporation, LLC
All Rights Reseved. Contents pertaining this app must not be shared or reproduced without prior authorization.
Please contact us for more information.</footer>

</body>
</html>
