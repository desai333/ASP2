<%@ Page Language="C#" AutoEventWireup="true" CodeFile="sirt.aspx.cs" Inherits="sirt" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
    
        <asp:Menu ID="Menu1" runat="server" BorderColor="Black" BorderStyle="Solid" 
            Orientation="Horizontal">
        <Items>
        <asp:MenuItem Text="Electronics" Value="Electroniccs" >

           <asp:MenuItem Text="TV" Value="TV" NavigateUrl="tv.aspx"></asp:MenuItem>
           <asp:MenuItem Text="Mobile" Value="Mobile" NavigateUrl="mobile.aspx"></asp:MenuItem>        
        </asp:MenuItem>
          <asp:MenuItem Text="Fashion" Value="Fashion">

           <asp:MenuItem Text="T-Sirt" Value="T-Sirt" NavigateUrl="tshirt.aspx" ></asp:MenuItem>
           <asp:MenuItem Text="sirt" Value="sirt" NavigateUrl="~/sirt.aspx"></asp:MenuItem>        
        </asp:MenuItem>
        
            <asp:MenuItem NavigateUrl="~/Default.aspx" Text="Home" Value="Home">
            </asp:MenuItem>
        
        </Items>
        </asp:Menu>
    
    <br />
    <asp:Image ID="Image2" runat="server" ImageUrl="~/msd.jpg" />
    </form>
</body>
</html>
