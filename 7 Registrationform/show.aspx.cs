using System;
using System.Collections;
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
using System.Drawing;

public partial class show : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int t, g, p; 
      
        TextBox1.Text = Request.QueryString["fn"];
        TextBox2.Text = Request.QueryString["pad"];
        TextBox3.Text = Request.QueryString["ctr"];
        TextBox4.Text = Request.QueryString["sta"];
        TextBox5.Text = Request.QueryString["ct"];
        TextBox6.Text = Request.QueryString["gd"];
        TextBox7.Text = Request.QueryString["hb"];

        Label21.Text = Request.QueryString["gb"];
       Label12.Text= Request.QueryString["ug"];
       Label15.Text = Request.QueryString["pg"];
       Label10.Text = Request.QueryString["twp"] ;
       Label13.Text = Request.QueryString["ugp"];
       Label16.Text = Request.QueryString["pgp"];
       Image1.ImageUrl = Request.QueryString["fi"];
       Image2.ImageUrl = Request.QueryString["fi2"];
       HyperLink1.NavigateUrl = Request.QueryString["fp"];

       t = Convert.ToInt16(Label10.Text);
       g = Convert.ToInt16(Label13.Text);
       p = Convert.ToInt16(Label16.Text);

       if (t >= 90 && t <= 100)
       {
           Label11.Text = "A+";
       }
       else if (t >= 80 && t <= 89)
       {
           Label11.Text = "A";
       }
       else if (t >= 70 && t <= 79)
       {
           Label11.Text = "B+";
       }
       else if (t >= 60 && t <= 69)
       {
           Label11.Text = "B";
       }
       else if (t >= 50 && t <= 59)
       {
           Label11.Text = "C";
       }
       else if (t >= 40 && t <= 49)
       {
           Label11.Text = "D";
       }
       else if (t >= 30 && t <= 39)
       {
           Label11.Text = "E";
       }
       else
       {
           Label11.ForeColor = Color.Red;
           Label11.Text = "Fail";
       }



       if (g >= 90 && g <= 100)
       {
           Label14.Text = "A+";
       }
       else if (g >= 80 && g <= 89)
       {
           Label14.Text = "A";
       }
       else if (g >= 70 && g <= 79)
       {
           Label14.Text = "B+";
       }
       else if (g >= 60 && g <= 69)
       {
           Label14.Text = "B";
       }
       else if (g >= 50 && g <= 59)
       {
           Label14.Text = "C";
       }
       else if (g >= 40 && g <= 49)
       {
           Label14.Text = "D";
       }
       else if (g >= 30 && g <= 39)
       {
           Label14.Text = "E";
       }
       else
       {
           Label14.ForeColor = Color.Red;
           Label14.Text = "Fail";
       }





       if (p >= 90 && p <= 100)
       {
           Label17.Text = "A+";
       }
       else if (p >= 80 && p <= 89)
       {
           Label17.Text = "A";
       }
       else if (p >= 70 && p <= 79)
       {
           Label17.Text = "B+";
       }
       else if (p >= 60 && p <= 69)
       {
           Label17.Text = "B";
       }
       else if (p >= 50 && p <= 59)
       {
           Label17.Text = "C";
       }
       else if (p >= 40 && p <= 49)
       {
           Label17.Text = "D";
       }
       else if (p >= 30 && p <= 39)
       {
           Label17.Text = "E";
       }
       else
       {
           Label17.ForeColor = Color.Red;
           Label17.Text = "Fail";
       }


    }
    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }
}
