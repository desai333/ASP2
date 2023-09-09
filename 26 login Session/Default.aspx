<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <br />
&nbsp;
        <asp:Login ID="Login1" runat="server" onauthenticate="Login1_Authenticate" 
            onloggingin="Login1_LoggingIn" DisplayRememberMe="False">
        </asp:Login>
        <br />
        <br />
&nbsp;
        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
            Text="Sing Up" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
