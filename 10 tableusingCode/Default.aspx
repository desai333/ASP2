<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <b> Control Using Asp code<br />
        <br />
        <br />
        <asp:Table ID="Table1" runat="server" BorderStyle="Solid" CellPadding="10">
        <asp:TableHeaderRow>
              <asp:TableHeaderCell><b>RollNo</b> </asp:TableHeaderCell>
              <asp:TableHeaderCell> Name</asp:TableHeaderCell>
        </asp:TableHeaderRow>
        <asp:TableRow>
        <asp:TableCell>1</asp:TableCell>
        <asp:TableCell>A</asp:TableCell> 
        </asp:TableRow>
         <asp:TableRow>
        <asp:TableCell>2</asp:TableCell>
        <asp:TableCell>B</asp:TableCell> 
        </asp:TableRow>
         <asp:TableRow>
        <asp:TableCell>3</asp:TableCell>
        <asp:TableCell>C</asp:TableCell> 
        </asp:TableRow>
        </asp:Table>
    
        </b>
    
    </div>
    </form>
</body>
</html>
