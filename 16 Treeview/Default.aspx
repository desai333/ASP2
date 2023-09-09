<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" Culture="Auto" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
       <b> Tree View Control</b><br />
    
        &nbsp;<asp:TreeView ID="TreeView1" runat="server" ImageSet="Simple" ShowLines="True">
        <Nodes>
            <asp:TreeNode Text="Cars" Value="Cars">
                <asp:TreeNode Text="Tata" Value="Tata">
                    <asp:TreeNode Text="Nexon" Value="Nexon"></asp:TreeNode>
                </asp:TreeNode>
                <asp:TreeNode Text="Toyota" Value="Toyota"></asp:TreeNode>
            </asp:TreeNode>
             <asp:TreeNode Text="Bikes" Value="Bikes">
                <asp:TreeNode Text="Hero" Value="Hero">
                    <asp:TreeNode Text="Spelder" Value="Spelder"></asp:TreeNode>
                 </asp:TreeNode>
                <asp:TreeNode Text="Honda" Value="Honda"></asp:TreeNode>
            </asp:TreeNode>
        </Nodes>
        </asp:TreeView>
    
    </div>
    </form>
</body>
</html>
