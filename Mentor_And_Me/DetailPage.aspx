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
                    <li class="selected"><a href="Create.html">Create</a></li>
                    <li><a href="chat.html">Chat</a></li>
                    <li><a href="login.html">Login</a></li>
                    <li><a href="contact.html">Contact Us</a></li>
                   </ul>
            </div>
        <div class="projDetails">          
            <em>          
            <asp:Label ID="Label1" runat="server" Text="Project Name:Debugging of outsourced Application"></asp:Label>
            </em>
            <br />
            <br />
            <strong>The total project will eliminate the unnecessary quota strategy <br />
            along with the superficial cost that wasn't accounted for previously.<br />
            This project requires exceptional mental stability and physical<br />
            endurance. </strong>
            <br />
            <br />   
            
       
       
        <asp:RadioButton ID="RadioButton2" runat="server" OnCheckedChanged="RadioButton2_CheckedChanged" />
        <asp:Label ID="Label2" runat="server" Text="Accept"></asp:Label>
&nbsp;&nbsp;
       
        <asp:RadioButton ID="RadioButton6" runat="server" OnCheckedChanged="RadioButton2_CheckedChanged" />
        Deny<br />
            <asp:Button ID="submitBtn" runat="server" OnClick="submitBtn_Click" Text="Submit" />
            <br />
        <br />
        <div>          
            <asp:Label ID="Label3" runat="server" Text="Project Name:New web feature in company website"></asp:Label>


            <br />
            <br />          
        </div>
       
        <asp:RadioButton ID="RadioButton3" runat="server" OnCheckedChanged="RadioButton2_CheckedChanged" />
        <asp:Label ID="Label4" runat="server" Text="Accept"></asp:Label>
&nbsp;&nbsp;
       
        <asp:RadioButton ID="RadioButton7" runat="server" OnCheckedChanged="RadioButton2_CheckedChanged" />
        Deny<br />
        <br />
        <div>          
            <asp:Label ID="Label5" runat="server" Text="Project Name:Event set up for manager conference"></asp:Label>
            <br />
            <br />
            <br />          
        </div>
       
        <asp:RadioButton ID="RadioButton4" runat="server" OnCheckedChanged="RadioButton2_CheckedChanged" />
        <asp:Label ID="Label6" runat="server" Text="Accept"></asp:Label>
&nbsp;&nbsp;
       
        <asp:RadioButton ID="RadioButton8" runat="server" OnCheckedChanged="RadioButton2_CheckedChanged" />
        Deny<br />
        <br />
        <div>          
            <asp:Label ID="Label7" runat="server" Text="Project Name:Lunch in with higher executives"></asp:Label>
            <br />
            <br />
            <br />         
        </div>
       
        <asp:RadioButton ID="RadioButton5" runat="server" OnCheckedChanged="RadioButton2_CheckedChanged" />
        <asp:Label ID="Label8" runat="server" Text="Accept"></asp:Label>
&nbsp;&nbsp;
       
        <asp:RadioButton ID="RadioButton9" runat="server" OnCheckedChanged="RadioButton2_CheckedChanged" />
        Deny<br />
        <br /> </div>
    </form>
</body>
</html>
