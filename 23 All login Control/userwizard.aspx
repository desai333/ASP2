<%@ Page Language="C#" AutoEventWireup="true" CodeFile="userwizard.aspx.cs" Inherits="userwizard" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
       <b> Registration Page<br />
        </b><br />
    
        <asp:CreateUserWizard ID="CreateUserWizard1" runat="server" 
            ContinueDestinationPageUrl="~/welcome.aspx">
            <WizardSteps>
                <asp:CreateUserWizardStep runat="server" />
                <asp:CompleteWizardStep runat="server" />
            </WizardSteps>
        </asp:CreateUserWizard>
    
    </div>
    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Login" />
    </form>
</body>
</html>
