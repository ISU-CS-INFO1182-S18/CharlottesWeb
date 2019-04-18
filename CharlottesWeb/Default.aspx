<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CharlottesWeb.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>This is my Default Page</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <p>I have stuffs. And other things that are really cool. And even more.</p>
        </div>
        <asp:Button ID="btnDoSomething" runat="server" Text="Click Me" OnClick="btnDoSomething_Click" />
        
        <asp:label ID="lblOutput" runat="server" text="Label">has some Text</asp:label>
        <a href="Other.aspx">Other Page</a>
        <a href="Other.aspx">Other.aspx</a><a href="Default.aspx">Default.aspx</a>
    </form>
</body>
</html>

