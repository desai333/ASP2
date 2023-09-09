using System;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

public partial class _Default : System.Web.UI.Page 
{
   
    protected void Page_Load(object sender, EventArgs e)
    {
       
    }
       
    protected void Wizard1_NextButtonClick(object sender, WizardNavigationEventArgs e)
    {
        if (e.NextStepIndex == 3)
        {
            if (CheckBox1.Checked)
            {
                Label20.Text = CheckBox1.Text;
            }
            if (CheckBox2.Checked)
            {

                Label20.Text = CheckBox2.Text;
            }
            if (CheckBox3.Checked)
            {

                Label20.Text = CheckBox3.Text;
            }
            if (CheckBox1.Checked && CheckBox2.Checked)
            {
                Label20.Text = CheckBox1.Text + " , " + CheckBox2.Text;
            }
            if (CheckBox1.Checked && CheckBox3.Checked)
            {
                Label20.Text = CheckBox1.Text + " , " + CheckBox3.Text;
            }
            if (CheckBox3.Checked && CheckBox2.Checked)
            {
                Label20.Text = CheckBox3.Text + " , " + CheckBox2.Text;
            }
            if (CheckBox1.Checked && CheckBox2.Checked && CheckBox3.Checked)
            {
                Label20.Text = CheckBox1.Text + " , " + CheckBox2.Text + " , " + CheckBox3.Text;
            }

            Label14.Text = TextBox1.Text;
            Label16.Text = TextBox2.Text;
            Label18.Text = RadioButtonList1.Text;
            Label30.Text = TextBox3.Text;
            Label32.Text = TextBox4.Text;
            Label26.Text = DropDownList1.Text;
            Label28.Text = DropDownList2.Text;
            Label22.Text = TextBox5.Text;
            Label24.Text = TextBox6.Text;
        }
    }
}
