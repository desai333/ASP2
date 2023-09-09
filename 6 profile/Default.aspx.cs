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
            if (FileUpload1.PostedFile.ContentLength < 10000)
            {
                Label1.Text = "";
                FileUpload1.SaveAs(sp + Path.GetFileName(FileUpload1.FileName));
                Image2.ImageUrl = "~/image/" + Path.GetFileName(FileUpload1.FileName);

                Image2.Height = 300;
                Image2.Width = 300;
            }
            else
            {

                Label1.Text = "File Size less than 10kb";
                Image2.Height = 0;
                Image2.Width = 0;
            }
        }
        else
        {

            Label1.Text = "File Size less than 10kb";
            Image2.Height = 0;
            Image2.Width = 0;
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
      

        string sp = Server.MapPath("~/image/");
        if (!Directory.Exists(sp))
        {
            Directory.CreateDirectory(sp);
        }
        if (FileUpload2.HasFile)
        {
           
            if (FileUpload2.PostedFile.ContentLength < 6000)
            {
                Label2.Text = "";
                FileUpload2.SaveAs(sp + Path.GetFileName(FileUpload2.FileName));
                Image3.ImageUrl = "~/image/" + Path.GetFileName(FileUpload2.FileName);

                Image3.Height = 300;
                Image3.Width = 300;
            }
            else
            {

                Label2.Text = "File Size less than 5kb";
                Image3.Height = 0;
                Image3.Width = 0;
            }
        }
        else
        {

            Label2.Text = "File Size less than 5kb";
            Image3.Height = 0;
            Image3.Width = 0;
        }
    }
}
