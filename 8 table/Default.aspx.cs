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
        Table t = new Table();
        t.BorderStyle = BorderStyle.Solid;
        for (int i = 0; i < 3; i++)
        {
            TableRow tr = new TableRow();
            tr.BorderStyle = BorderStyle.Solid;
            for (int j = 0; j < 3; j++)
            {
                TableCell tc = new TableCell();
                tc.BorderStyle = BorderStyle.Solid;
                tc.Text = j.ToString();
                tc.Text = j.ToString();
                tr.Cells.Add(tc);
            }
            Table1.Rows.Add(tr);
            
        }
        PlaceHolder1.Controls.Add(t);



    }
}
