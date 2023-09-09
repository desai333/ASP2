<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
    </head>
<body>
    <form id="form1" runat="server">
    <div style="width: 818px">
    
        <asp:Wizard ID="Wizard1" runat="server" ActiveStepIndex="1" BackColor="#CCFFCC" 
            BorderStyle="Solid" HeaderText="Registration Form" Height="408px" 
            Width="757px" OnNextButtonClick="Wizard1_NextButtonClick" >
            <NavigationStyle BackColor="#FFCCFF" />
            <WizardSteps>
                <asp:WizardStep runat="server" title="Personal Information">
                    <table >
                        <tr>
                            <td colspan="2">
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:Label ID="Label12" runat="server" Font-Bold="True" Font-Size="Larger" 
                                    Text="Personal Detail"></asp:Label>
                                &nbsp;<br />
                                <br />
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                                <br />
                                <br />
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="Label2" runat="server" Text="Address"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                                <br />
                                <br />
                            </td>
                        </tr>
                        <tr>
                            <td>
                                Gender</td>
                            <td>
                                <asp:RadioButtonList ID="RadioButtonList1" runat="server" 
                                    RepeatDirection="Horizontal">
                                    <asp:ListItem Value="Male"></asp:ListItem>
                                    <asp:ListItem Value="Female"></asp:ListItem>
                                </asp:RadioButtonList>
                                <br />
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="Label3" runat="server" Text="Hobbie"></asp:Label>
                            </td>
                            <td>
                                <asp:CheckBox ID="CheckBox1" runat="server" Text="Cricket" />
                                <br />
                                <asp:CheckBox ID="CheckBox2" runat="server" Text="Football" />
                                <br />
                                <asp:CheckBox ID="CheckBox3" runat="server" Text="Hokey" />
                            </td>
                        </tr>
                    </table>
                </asp:WizardStep>
                <asp:WizardStep runat="server" title="Educatinal Qualification">
                    <table >
                        <tr>
                            <td colspan="2">
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:Label ID="Label11" runat="server" Font-Bold="True" Font-Size="Larger" 
                                    Text="Educational Detail"></asp:Label>
                                <br />
                                <br />
                                <br />
                                <br />
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="Label4" runat="server" Text="10th per"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                                <br />
                                <br />
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="Label5" runat="server" Text="12th"></asp:Label>
                                &nbsp;per</td>
                            <td>
                                <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                                <br />
                                <br />
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="Label6" runat="server" Text="Graduation"></asp:Label>
                            </td>
                            <td>
                                <asp:DropDownList ID="DropDownList1" runat="server" Width="169px">
                                    <asp:ListItem>BCA</asp:ListItem>
                                    <asp:ListItem>BBA</asp:ListItem>
                                </asp:DropDownList>
                                <br />
                                <br />
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="Label7" runat="server" Text="Post Graduation"></asp:Label>
                            </td>
                            <td>
                                <asp:DropDownList ID="DropDownList2" runat="server" Width="169px">
                                    <asp:ListItem>MCA</asp:ListItem>
                                    <asp:ListItem Value="MBA"></asp:ListItem>
                                </asp:DropDownList>
                            </td>
                        </tr>
                    </table>
                </asp:WizardStep>
                <asp:WizardStep runat="server" Title="Contact">
                    <table >
                        <tr>
                            <td colspan="2">
                                <asp:Label ID="Label10" runat="server" Font-Bold="True" 
                                    Font-Names="Arial Unicode MS" Text="Contact Detail"></asp:Label>
                                <br />
                                <br />
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="Label8" runat="server" Text="Contact"></asp:Label>
                            </td>
                            <td>
                                &nbsp;&nbsp;&nbsp;
                                <asp:TextBox ID="TextBox5" runat="server" MaxLength="10" AutoComplete="off"></asp:TextBox>
                                &nbsp;&nbsp;&nbsp;&nbsp; &nbsp;</td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="Label9" runat="server" Text="Email"></asp:Label>
                            </td>
                            <td>
                                &nbsp;&nbsp;&nbsp;
                                <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td>
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                        </tr>
                    </table>
                    &nbsp;</asp:WizardStep>
                <asp:WizardStep runat="server" Title="Summary">
                    <asp:Label ID="Label13" runat="server" Font-Bold="True" Text="Name"></asp:Label>
                    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;
                    <asp:Label ID="Label14" runat="server"></asp:Label>
                    <br />
                    <asp:Label ID="Label15" runat="server" Font-Bold="True" Text="Address"></asp:Label>
                    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;
                    <asp:Label ID="Label16" runat="server"></asp:Label>
                    <br />
                    <asp:Label ID="Label17" runat="server" Font-Bold="True" Text="Gender"></asp:Label>
                    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                    <asp:Label ID="Label18" runat="server"></asp:Label>
                    <br />
                    <asp:Label ID="Label19" runat="server" Font-Bold="True" Text="Hobbie"></asp:Label>
                    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp; &nbsp;
                    <asp:Label ID="Label20" runat="server"></asp:Label>
                    <br />
                    <br />
                    <asp:Label ID="Label29" runat="server" Font-Bold="True" Text="10th Per"></asp:Label>
                    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;
                    <asp:Label ID="Label30" runat="server"></asp:Label>
                    <br />
                    <asp:Label ID="Label31" runat="server" Font-Bold="True" Text="12th Per"></asp:Label>
                    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;
                    <asp:Label ID="Label32" runat="server"></asp:Label>
                    <br />
                    <asp:Label ID="Label25" runat="server" Font-Bold="True" Text="Graduation"></asp:Label>
                    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                    <asp:Label ID="Label26" runat="server"></asp:Label>
                    <br />
                    <asp:Label ID="Label27" runat="server" Font-Bold="True" Text="Post Graduation "></asp:Label>
                    &nbsp; &nbsp; &nbsp;&nbsp;
                    <asp:Label ID="Label28" runat="server"></asp:Label>
                    <br />
                    <br />
                    <asp:Label ID="Label21" runat="server" Font-Bold="True" Text="Mobile No."></asp:Label>
                    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                    <asp:Label ID="Label22" runat="server"></asp:Label>
                    <br />
                    <asp:Label ID="Label23" runat="server" Font-Bold="True" Text="Email "></asp:Label>
                    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                    <asp:Label ID="Label24" runat="server"></asp:Label>
                </asp:WizardStep>
            </WizardSteps>
            <SideBarStyle BackColor="#66FFFF" Width="210px" />
            <HeaderStyle BackColor="#99FF66" Font-Size="Larger" Height="50px" />
        </asp:Wizard>
    
    </div>
    <p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    </p>
    </form>
</body>
</html>
