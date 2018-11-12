<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="Mentor_And_Me.WebForm2" %>

<!DOCTYPE HTML>
<html>


<head>
    <title>Mentor&Me - Projects</title>
    <meta name="description" content="website description" />
    <meta name="keywords" content="website keywords, website keywords" />
    <meta http-equiv="content-type" content="text/html; charset=windows-1252" />
    <link rel="stylesheet" type="text/css" href="style/style.css" title="style" />
</head>

<body>
    <form id="form1" runat="server">
    <div id="main">
        <div id="header">
            <div id="logo">
                <div id="logo_text">
                    <h1><a href="index.html">Mentor<span class="logo_colour"><em>&</em>Me</span></a></h1>
                    <h2></h2>
                </div>
            </div>
            <div id="menubar">
                <ul id="menu">
                    <li class="selected"><a href="index.html">Projects</a></li>
                    <li><a href="create.html">Create</a></li>
                    <li><a href="chat.html">Chat</a></li>
                    <li><a href="login.html">Login</a></li>
                    <li><a href="contact.html">Contact Us</a></li>
                </ul>
            </div>
        </div>

        
            <div id="content">
                <h1>Welcome to Mentor&Me this is where you can start applying to other company projects</h1>
                <!-- My thought is that this table should be loaded by an array or a list that populates the rows -->

                <table id="projecttable" style="width:100%; border-spacing:0; clip: rect(auto, auto, auto, auto);">
                    <tr>
                        <th>Project Name</th>
                        <th>Size</th>
                        <th>Posted By</th>
                    </tr>
                    <tr>
                        <td><a href="Project1.html">New web feature on company website</a></td>
                        <td>Small</td>
                        <td>Chris Scotts</td>
                    </tr>
                    <tr>
                        <td><a>Debugging of outsourced application</a></td>
                        <td>Medium</td>
                        <td>James Brown</td>
                    </tr>
                    <tr>
                        <td><a>Event set up for manager conference</a></td>
                        <td>Small</td>
                        <td>Valerie Evans</td>
                    </tr>
                    <tr>
                        <td><a>Lunch in with higher execs</a></td>
                        <td>Small</td>
                        <td>Benson Smith</td>
                    </tr>
                    <tr>
                        <td><a>Redesign of client database</a></td>
                        <td>Large</td>
                        <td>Christine Schollz</td>
                    </tr>
                </table>
            </div>

            <asp:SqlDataSource ID="userData" runat="server"
                DataSourceMode="DataReader"
                ConnectionString="<%$ ConnectionStrings:myDB %>"
                SelectCommand="Select * from projecttest">
            </asp:SqlDataSource>
        
        <asp:Table ID="testtable" runat="server" Width="75%">
            <asp:TableRow>
                <asp:TableCell>Project Name</asp:TableCell>
                <asp:TableCell>Size</asp:TableCell>
                <asp:TableCell>Creator</asp:TableCell>
            </asp:TableRow>
        </asp:Table>

    </div
</body>
    </form>

</html>
