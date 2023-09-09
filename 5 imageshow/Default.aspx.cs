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
using System.IO;
using System.Drawing;

public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Label1.Text = "";

        string sp = Server.MapPath("~/image/");
        if (!Directory.Exists(sp))
        {
            Directory.CreateDirectory(sp);
        }
        if (FileUpload1.HasFile)
        {
            
                FileUpload1.SaveAs(sp + Path.GetFileName(FileUpload1.FileName));
                Image1.ImageUrl = "~/image/" + Path.GetFileName(FileUpload1.FileName);

                Image1.Height = 300;
                Image1.Width = 300;
           
        }
        else
        {
            Label1.ForeColor = Color.Red;
            Label1.Text = "File Size less than 4MB";
            Image1.Height =0;
            Image1.Width = 0;
        }
    }
}
