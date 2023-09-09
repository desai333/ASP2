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
using System.IO;

public partial class Uploaddetail : System.Web.UI.Page
{
    
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {

      
       
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
       
       
    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        
       
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        string f,pa,co,st,c,gd,hb;
        string fi = "";
        string fp = "";
        string fi2 = "";

        string sp = Server.MapPath("~/image/");


        f = Request.QueryString["fn"];
       
        pa = Request.QueryString["pad"];

        co= Request.QueryString["ctr"];
       
        st = Request.QueryString["sta"];
        c = Request.QueryString["ct"];
        gd = Request.QueryString["gd"];
        hb= Request.QueryString["hb"];

        if (FileUpload1.HasFile)
        {
            FileUpload1.SaveAs(sp + Path.GetFileName(FileUpload1.FileName));
            fi = "~/image/" + Path.GetFileName(FileUpload1.FileName);
            
        }

        if (FileUpload3.HasFile)
        {
            FileUpload3.SaveAs(sp + Path.GetFileName(FileUpload3.FileName));
            fp = "~/image/" + Path.GetFileName(FileUpload3.FileName);
        }
        if (FileUpload2.HasFile)
        {
            FileUpload2.SaveAs(sp + Path.GetFileName(FileUpload2.FileName));
            fi2 = "~/image/" + Path.GetFileName(FileUpload2.FileName);
        }
        Response.Redirect("show.aspx?ug=" + DropDownList1.SelectedItem + "&pg="+ DropDownList2.SelectedItem  +"&gb="+DropDownList3.SelectedItem  +"&twp=" + TextBox1.Text + "&ugp=" + TextBox2.Text + "&pgp=" + TextBox3.Text + "&fn=" + f + "&pad=" + pa + "&ctr=" + co + "&sta=" + st + "&ct=" + c + "&gd=" + gd + "&hb=" + hb + "&fi=" + fi + "&fi2=" + fi2 + "&fp=" + fp);
    }
}
