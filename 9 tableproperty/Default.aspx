<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <b>Table Control Using Property</b><br />
        <br />
    
        <asp:Table ID="Table1" runat="server" BorderStyle="Solid" Font-Size="Large" 
            Width="202px">
            <asp:TableRow runat="server" BorderStyle="Solid">
                <asp:TableCell runat="server" BorderStyle="Solid">1</asp:TableCell>
                <asp:TableCell runat="server" BorderStyle="Solid">2</asp:TableCell>
                <asp:TableCell runat="server" BorderStyle="Solid">3</asp:TableCell>
            </asp:TableRow>
            <asp:TableRow runat="server" BorderStyle="Solid">
                <asp:TableCell runat="server" BorderStyle="Solid">4</asp:TableCell>
                <asp:TableCell runat="server" BorderStyle="Solid">5</asp:TableCell>
                <asp:TableCell runat="server" BorderStyle="Solid">6</asp:TableCell>
            </asp:TableRow>
            <asp:TableRow runat="server" BorderStyle="Solid">
                <asp:TableCell runat="server" BorderStyle="Solid">7</asp:TableCell>
                <asp:TableCell runat="server" BorderStyle="Solid">8</asp:TableCell>
                <asp:TableCell runat="server" BorderStyle="Solid">9</asp:TableCell>
            </asp:TableRow>
        </asp:Table>
    
    </div>
    </form>
</body>
</html>
