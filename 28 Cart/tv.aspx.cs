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

public partial class tv : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (Session["cart"] != null)
        {
            Session["cart"] = Session["cart"] + "e";
        }
        else
        {
            Session["cart"] = "e";
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        if (Session["cart"] != null)
        {
            Session["cart"] = Session["cart"] + "f";
        }
        else
        {
            Session["cart"] = "f";
        }
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        if (Session["cart"] != null)
        {
            Session["cart"] = Session["cart"] + "g";
        }
        else
        {
            Session["cart"] = "g";
        }
    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        if (Session["cart"] != null)
        {
            Session["cart"] = Session["cart"] + "h";
        }
        else
        {
            Session["cart"] = "h";
        }
    }
}
