using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public partial class ac : System.Web.UI.Page
{
  
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (Session["cart"]!=null)
        {
            Session["cart"] = Session["cart"] + "a";
        }
        else
        {
            Session["cart"] = "a";
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        if (Session["cart"] != null)
        {
            Session["cart"] = Session["cart"] + "b";
        }
        else
        {
            Session["cart"] = "b";
        }
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        if (Session["cart"] != null)
        {
            Session["cart"] = Session["cart"] + "c";
        }
        else
        {
            Session["cart"] = "c";
        }
    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        if (Session["cart"] != null)
        {
            Session["cart"] = Session["cart"] + "d";  
        }
        else
        {
            Session["cart"] = "d";
        }
    }
}
