<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default5.aspx.cs" Inherits="Default5" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <p>
        <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="X-Large" 
            Text="View Page"></asp:Label>
        </p>
    <p>
        <asp:SiteMapPath ID="SiteMapPath1" runat="server" PathSeparator=" &gt;&gt;">
        </asp:SiteMapPath>
    </p>
    <p>
        &nbsp;<asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Default4.aspx">Privious</asp:HyperLink>
&nbsp;&nbsp;
    </p>
    </form>
</body>
</html>
