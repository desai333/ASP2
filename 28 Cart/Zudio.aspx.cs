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

public partial class Zudio : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (Session["cart"] != null)
        {
            Session["cart"] = Session["cart"] + "u";
        }
        else
        {
            Session["cart"] = "u";
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        if (Session["cart"] != null)
        {
            Session["cart"] = Session["cart"] + "v";
        }
        else
        {
            Session["cart"] = "v";
        }
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        if (Session["cart"] != null)
        {
            Session["cart"] = Session["cart"] + "w";
        }
        else
        {
            Session["cart"] = "w";
        }
    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        if (Session["cart"] != null)
        {
            Session["cart"] = Session["cart"] + "x";
        }
        else
        {
            Session["cart"] = "x";
        }
    }
}
