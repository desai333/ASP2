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
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("userwizard.aspx");
    }
   
    protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
    {

    }
    protected void Login1_LoggingIn(object sender, LoginCancelEventArgs e)
    {
        if (Session["username"] != null && (Session["password"] != null))
        {
          
            if (Login1.UserName.Contains(Session["username"].ToString()) && Login1.Password.Contains(Session["password"].ToString()))
            {
                Response.Redirect("welcome.aspx");
            }
        }

      
       
    }
}
