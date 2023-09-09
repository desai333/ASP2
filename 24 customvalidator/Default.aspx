<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
    <script language="javascript" type="text/javascript">
 function pass(source,args) 
{
  var decimal=  /^(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[^a-zA-Z0-9])(?!.*\s).{6,12}$/;

    if(TextBox1.value.match(decimal)) 
    { 
    alert('Correct..')
    return true;
    }
    else
    { 
    alert('Wrong...!')
    return false;
    } 
}

</script>
    
</head>
<body>
    
    <form id="form1" runat="server">
    <div>
    
        <b>Custom Validator</b><br />
        <br />
    
        Password&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
        <asp:TextBox ID="TextBox1" runat="server"   ></asp:TextBox>
&nbsp;<asp:CustomValidator ID="CustomValidator1" runat="server" 
            ClientValidationFunction="pass" ErrorMessage="Please Enter Proper Password" 
            ControlToValidate="TextBox1" 
            onservervalidate="CustomValidator1_ServerValidate1"></asp:CustomValidator>
        <br />
        <br />
        Confirm
    
        Password&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
&nbsp;<asp:CompareValidator ID="CompareValidator1" runat="server" 
            ControlToCompare="TextBox2" ControlToValidate="TextBox1" 
            ErrorMessage="Password Must be Same"></asp:CompareValidator>
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        &nbsp;
        <br />
        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Submit" />
    
    </div>
    </form>
</body>
</html>
