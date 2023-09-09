<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <b>Range Validtor<br />
        </b><br />
    
    </div>
    <asp:Label ID="Label1" runat="server" Text="Age"></asp:Label>
&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
&nbsp;
    <asp:RangeValidator ID="RangeValidator1" runat="server" 
        ControlToValidate="TextBox1" ErrorMessage="Enter Age Between 1 to 18" 
        MaximumValue="18" MinimumValue="01" SetFocusOnError="True" Type="Integer"></asp:RangeValidator>
    <br />
    <br />
    <asp:Button ID="Button1" runat="server" Text="Submit" />
    </form>
</body>
</html>
