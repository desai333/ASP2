﻿using System;
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
        string name = FileUpload1.FileName;
        string type = FileUpload1.PostedFile.ContentType;
        int size = FileUpload1.PostedFile.ContentLength / 1024;
        if (FileUpload1.HasFile)
        {
           
                FileUpload1.SaveAs(@"D:\ASP\Unit 2\" + FileUpload1.FileName);
                Label1.ForeColor = Color.Black;
                Label1.Text = "<br>" + "File Name : " + name + "<br>" + "<br>" + "File Tpe : " + type + "<br>" + "<br> " + "File Size[kb] : " + size;
                // Label1.Text = "File Upload Succsessfullly";
           
        }
       
        
    }
}
