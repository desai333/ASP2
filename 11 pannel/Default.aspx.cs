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
    
    protected void Button3_Click(object sender, EventArgs e)
    {
        if (Session["username"] != null && (Session["password"] != null))
        {
            // if(Session["username"].ToString().Contains(TextBox1.Text) && Session["password"].ToString().Contains(TextBox2.Text) )
            if (TextBox2.Text.Contains(Session["username"].ToString()) && TextBox3.Text.Contains(Session["password"].ToString()))
            {
                Response.Redirect("show.aspx");
            }
            else
            {
                Label10.Text = "Invalid UserName OR Password";
            }
        }
        else
        {
            Label10.Text = "User Not Found";
        }
       
    }
    protected void Button1_Click1(object sender, EventArgs e)
    {
        if (TextBox3.Text == "" && TextBox4.Text == "" && TextBox5.Text == "")
        {
            Label11.Text = "Enter Valid Information !!!";
        }
        else if(TextBox4.Text == TextBox5.Text)
            {
                Label9.Text = " ";
                Session["username"] = TextBox1.Text;
                Session["password"] = TextBox5.Text;
                Response.Redirect("show.aspx");
            }
            else
            {

                Label9.Text = "Password Must Be Same";
            }
        
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        TextBox1.Text = "";
        TextBox4.Text = "";
        TextBox5.Text = "";
    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        TextBox2.Text = "";
        TextBox3.Text = "";
    }
}
