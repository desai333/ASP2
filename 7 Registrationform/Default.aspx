<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
    <style type="text/css">
        .style1
        {
        }
        .style2
        {
            width: 629px;
        }
        .style3
        {
            height: 26px;
        }
        .style4
        {
            width: 629px;
            height: 26px;
        }
        body
        {
        	background-color:white;
        	
        	
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <table style="width: 54%; height: 223px;">
            <tr>
                <td colspan="2">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
                   <b> Personal Information</b>&nbsp;<br />
                    <br />
                </td>
            </tr>
            <tr>
                <td class="style1">
                    <asp:Label ID="Label3" runat="server" Text="Full Name"></asp:Label>
                </td>
                <td class="style2">
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    <br />
                </td>
            </tr>
            <tr>
                <td class="style1">
                    <asp:Label ID="Label4" runat="server" Text="Corespondance Address"></asp:Label>
                </td>
                <td class="style2">
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style1" colspan="2">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:CheckBox ID="CheckBox5" runat="server" Text="Same As Above" 
                        oncheckedchanged="CheckBox1_CheckedChanged" AutoPostBack="True" />
                    <br />
                </td>
            </tr>
            <tr>
                <td class="style1">
                    <asp:Label ID="Label5" runat="server" Text="Permanent Address"></asp:Label>
                </td>
                <td class="style2">
                    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                    <br />
                </td>
            </tr>
            <tr>
                <td class="style1">
                    <asp:Label ID="Label6" runat="server" Text="County"></asp:Label>
                </td>
                <td class="style2">
                    <asp:DropDownList ID="DropDownList1" runat="server">
                        <asp:ListItem>India</asp:ListItem>
                        <asp:ListItem Value="USA"></asp:ListItem>
                        <asp:ListItem Value="UAE"></asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="style1">
                    <asp:Label ID="Label7" runat="server" Text="State"></asp:Label>
                </td>
                <td class="style2">
                    <asp:DropDownList ID="DropDownList2" runat="server">
                        <asp:ListItem Value="Gujarat"></asp:ListItem>
                        <asp:ListItem Value="New York">New York</asp:ListItem>
                        <asp:ListItem Value="Abu dhabi"></asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="style1">
                    <asp:Label ID="Label8" runat="server" Text="City"></asp:Label>
                </td>
                <td class="style2">
                    <asp:DropDownList ID="DropDownList3" runat="server">
                        <asp:ListItem Value="Ahmedabad"></asp:ListItem>
                        <asp:ListItem Value="Chicago"></asp:ListItem>
                        <asp:ListItem Value="Dubai"></asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="style3">
                    <asp:Label ID="Label9" runat="server" Text="Gender"></asp:Label>
                </td>
                <td class="style4">
                    <asp:RadioButton ID="RadioButton1" runat="server" Text="Male" 
                        GroupName="Gender" />
&nbsp;&nbsp;&nbsp;
                    <asp:RadioButton ID="RadioButton2" runat="server" Text="Female" 
                        GroupName="Gender" />
                </td>
            </tr>
            <tr>
                <td class="style1">
                    <asp:Label ID="Label10" runat="server" Text="Hobbie"></asp:Label>
                </td>
                <td class="style2">
                    <asp:CheckBox ID="CheckBox1" runat="server" Text="Cricket" />
&nbsp;&nbsp;
                    <asp:CheckBox ID="CheckBox2" runat="server" Text="FootBall" />
&nbsp;&nbsp;
                    <asp:CheckBox ID="CheckBox3" runat="server" Text="Chess" />
                </td>
            </tr>
            <tr>
                <td class="style1" colspan="2">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="Button1" runat="server" Text="Next" onclick="Button1_Click" />
                    &nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
