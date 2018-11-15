<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Mentor_And_Me.WebForm2" %>

<!DOCTYPE HTML>
<html>
    <style type="text/css">
        .auto-style1 {
            font-size: x-small;
        }
        
        
        table {
            width: 100%;
        }
    </style>

<head>
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
                    <li><a href="chat.aspx">Chat</a></li>                  
                    <li><a href="contact.aspx">Contact Us</a></li>
                </ul>
            </div>
        </div>

        
            <div id="content">
                <h1><strong>Welcome to Mentor&Me this is where you can start applying to other company projects</strong></h1
            </div>

            
                    <asp:SqlDataSource ID="userData" runat="server"
                        DataSourceMode="DataReader"
                        ConnectionString="<%$ ConnectionStrings:myDB %>"
                        SelectCommand="Select * from projecttest">
                    </asp:SqlDataSource>

                     <asp:Table ID="testtable" runat="server"
                        style="
                        padding-left:500px;
                        padding-right:500px;
                        padding-bottom:50px;
                        Height: 44px;"> 
                    <asp:TableRow>
                        <asp:TableHeaderCell style="width: 2%;"></asp:TableHeaderCell>
                       <asp:TableHeaderCell style="width: 20%;">Project Name</asp:TableHeaderCell>
                        <asp:TableHeaderCell style="width: 5%;">Size</asp:TableHeaderCell>
                        <asp:TableHeaderCell style="width: 10%;">Creator</asp:TableHeaderCell>
                    </asp:TableRow>
                </asp:Table>
        

    </div>  
         <footer>
                    
                    <h2 class="auto-style1">&copy; 2018, Synergy Scrum Corporation, LLC</h2>
		<p class="auto-style1">All Rights Reseved. Contents pertaining this app must not be shared or reproduced without prior authorization.<br/>
		Please  <a href="./Contact.aspx">contact</a> us for more information.</p>

        </footer>
 </form>
</body>
    

</html>
