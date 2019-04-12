<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication6.WebForm1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br />

    <asp:RequiredFieldValidator ControlToValidate="TextBox1" ID="rfv1" ErrorMessage="Please enter" runat="server"></asp:RequiredFieldValidator>

    <asp:RegularExpressionValidator runat="server" id="rexNumber" controltovalidate="TextBox1" validationexpression="^[0-9]$" errormessage="Please enter digit number!"></asp:RegularExpressionValidator>
<br /><br />
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><br />

         <asp:RegularExpressionValidator runat="server" id="RegularExpressionValidator1" controltovalidate="TextBox2" validationexpression="^[0-9]$" errormessage="Please enter digit number!"></asp:RegularExpressionValidator>
<br /><br />

<asp:RequiredFieldValidator ControlToValidate="TextBox2" ID="RequiredFieldValidator1" runat="server" ErrorMessage="Please enter"></asp:RequiredFieldValidator>

        <asp:Label ID="Label1" runat="server" Text="Result"></asp:Label><br />
        <asp:Button ID="Button1" runat="server" Text="+" onclick="Button1_Click" 
            Width="53px" />
        <asp:Button ID="Button2" runat="server" Text="-" onclick="Button2_Click" 
            Width="49px" />
        <asp:Button ID="Button3" runat="server" Text="/" onclick="Button3_Click" 
            Width="45px" />
        <asp:Button ID="Button4" runat="server" Text="*" onclick="Button4_Click" 
            Width="55px" />
    </div>

    </form>
</body>
</html>
