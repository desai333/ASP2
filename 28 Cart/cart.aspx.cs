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
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;



public partial class cart : System.Web.UI.Page
{
   
    
 
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["cart"] != null)
            {
                string cart;
                cart = Session["cart"].ToString();
                //string sentence = "Mahesh Chand";
                char[] charArr = cart.ToCharArray();
                foreach (char ch in charArr)
                {

                    System.Web.UI.WebControls.ImageMap image = new System.Web.UI.WebControls.ImageMap();
                    Label mylab = new Label();
                    switch (ch)
                    {
                        case 'a':
                            image.ImageUrl = "~/ac1.jpeg";
                            mylab.Text = "&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;" + "3000$" + "</br>";
                            mylab.ForeColor = Color.Green;
                            this.Controls.Add(image);
                            this.Controls.Add(mylab);
                            mylab.ForeColor = System.Drawing.SystemColors.HotTrack;
                            mylab.Font.Size = 45;

                            break;

                        case 'b':

                            image.ImageUrl = "~/ac2.jpeg";
                            mylab.Text = "&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;" + "5000$" + "</br>";
                            mylab.ForeColor = Color.Green;
                            this.Controls.Add(image);
                            this.Controls.Add(mylab);
                            mylab.ForeColor = System.Drawing.SystemColors.HotTrack;
                            mylab.Font.Size = 45;

                            break;
                        case 'c':

                            image.ImageUrl = "~/ac3.jpeg";
                            mylab.Text = "&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;" + "6000$" + "</br>";
                            mylab.ForeColor = Color.Green;
                            this.Controls.Add(image);
                            this.Controls.Add(mylab);
                            mylab.ForeColor = System.Drawing.SystemColors.HotTrack;
                            mylab.Font.Size = 45;
                            break;

                        case 'd':

                            image.ImageUrl = "~/ac4.jpeg";
                            mylab.Text = "&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;" + "8000$" + "</br>";
                            mylab.ForeColor = Color.Green;
                            this.Controls.Add(image);
                            this.Controls.Add(mylab);
                            mylab.ForeColor = System.Drawing.SystemColors.HotTrack;
                            mylab.Font.Size = 45;
                            break;

                        case 'e':
                            image.ImageUrl = "~/tv2.jpeg";
                            mylab.Text = "&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;" + "3455$" + "</br>";
                            mylab.ForeColor = Color.Green;
                            this.Controls.Add(image);
                            this.Controls.Add(mylab);
                            mylab.ForeColor = System.Drawing.SystemColors.HotTrack;
                            mylab.Font.Size = 45;

                            break;

                        case 'f':
                            image.ImageUrl = "~/tv3.jpeg";
                            mylab.Text = "&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;" + "4353$" + "</br>";
                            mylab.ForeColor = Color.Green;
                            this.Controls.Add(image);
                            this.Controls.Add(mylab);
                            mylab.ForeColor = System.Drawing.SystemColors.HotTrack;
                            mylab.Font.Size = 45;

                            break;

                        case 'g':
                            image.ImageUrl = "~/tv4.jpeg";
                            mylab.Text = "&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;" + "4353$" + "</br>";
                            mylab.ForeColor = Color.Green;
                            this.Controls.Add(image);
                            this.Controls.Add(mylab);
                            mylab.ForeColor = System.Drawing.SystemColors.HotTrack;
                            mylab.Font.Size = 45;

                            break;

                        case 'h':
                            image.ImageUrl = "~/tv5.jpeg";
                            mylab.Text = "&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;" + "3453$" + "</br>";
                            mylab.ForeColor = Color.Green;
                            this.Controls.Add(image);
                            this.Controls.Add(mylab);
                            mylab.ForeColor = System.Drawing.SystemColors.HotTrack;
                            mylab.Font.Size = 45;

                            break;

                        case 'i':
                            image.ImageUrl = "~/sam1.jpeg";
                            mylab.Text = "&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;" + "4664$" + "</br>";
                            mylab.ForeColor = Color.Green;
                            this.Controls.Add(image);
                            this.Controls.Add(mylab);
                            mylab.ForeColor = System.Drawing.SystemColors.HotTrack;
                            mylab.Font.Size = 45;

                            break;

                        case 'j':
                            image.ImageUrl = "~/sam2.jpeg";
                            mylab.Text = "&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;" + "5664$" + "</br>";
                            mylab.ForeColor = Color.Green;
                            this.Controls.Add(image);
                            this.Controls.Add(mylab);
                            mylab.ForeColor = System.Drawing.SystemColors.HotTrack;
                            mylab.Font.Size = 45;

                            break;

                        case 'k':
                            image.ImageUrl = "~/sam3.jpeg";
                            mylab.Text = "&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;" + "4566$" + "</br>";
                            mylab.ForeColor = Color.Green;
                            this.Controls.Add(image);
                            this.Controls.Add(mylab);
                            mylab.ForeColor = System.Drawing.SystemColors.HotTrack;
                            mylab.Font.Size = 45;

                            break;

                        case 'l':
                            image.ImageUrl = "~/sam4.jpeg";
                            mylab.Text = "&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;" + "4566$" + "</br>";
                            mylab.ForeColor = Color.Green;
                            this.Controls.Add(image);
                            this.Controls.Add(mylab);
                            mylab.ForeColor = System.Drawing.SystemColors.HotTrack;
                            mylab.Font.Size = 45;

                            break;

                        case 'm':
                            image.ImageUrl = "~/i1.jpeg";
                            mylab.Text = "&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;" + "2344$" + "</br>";
                            mylab.ForeColor = Color.Green;
                            this.Controls.Add(image);
                            this.Controls.Add(mylab);
                            mylab.ForeColor = System.Drawing.SystemColors.HotTrack;
                            mylab.Font.Size = 45;

                            break;

                        case 'n':
                            image.ImageUrl = "~/i2.jpeg";
                            mylab.Text = "&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;" + "2346$" + "</br>";
                            mylab.ForeColor = Color.Green;
                            this.Controls.Add(image);
                            this.Controls.Add(mylab);
                            mylab.ForeColor = System.Drawing.SystemColors.HotTrack;
                            mylab.Font.Size = 45;

                            break;

                        case 'o':
                            image.ImageUrl = "~/i3.jpeg";
                            mylab.Text = "&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;" + "3455$" + "</br>";
                            mylab.ForeColor = Color.Green;
                            this.Controls.Add(image);
                            this.Controls.Add(mylab);
                            mylab.ForeColor = System.Drawing.SystemColors.HotTrack;
                            mylab.Font.Size = 45;

                            break;

                        case 'p':
                            image.ImageUrl = "~/i4.jpeg";
                            mylab.Text = "&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;" + "3455$" + "</br>";
                            mylab.ForeColor = Color.Green;
                            this.Controls.Add(image);
                            this.Controls.Add(mylab);
                            mylab.ForeColor = System.Drawing.SystemColors.HotTrack;
                            mylab.Font.Size = 45;

                            break;

                        case 'q':
                            image.ImageUrl = "~/c1.jpeg";
                            mylab.Text = "&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;" + "289$" + "</br>";
                            mylab.ForeColor = Color.Green;
                            this.Controls.Add(image);
                            this.Controls.Add(mylab);
                            mylab.ForeColor = System.Drawing.SystemColors.HotTrack;
                            mylab.Font.Size = 45;

                            break;

                        case 'r':
                            image.ImageUrl = "~/c2.jpeg";
                            mylab.Text = "&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;" + "232$" + "</br>";
                            mylab.ForeColor = Color.Green;
                            this.Controls.Add(image);
                            this.Controls.Add(mylab);
                            mylab.ForeColor = System.Drawing.SystemColors.HotTrack;
                            mylab.Font.Size = 45;

                            break;

                        case 's':
                            image.ImageUrl = "~/c3.jpeg";
                            mylab.Text = "&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;" + "345$" + "</br>";
                            mylab.ForeColor = Color.Green;
                            this.Controls.Add(image);
                            this.Controls.Add(mylab);
                            mylab.ForeColor = System.Drawing.SystemColors.HotTrack;
                            mylab.Font.Size = 45;

                            break;

                        case 't':
                            image.ImageUrl = "~/c4.jpeg";
                            mylab.Text = "&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;" + "453$" + "</br>";
                            mylab.ForeColor = Color.Green;
                            this.Controls.Add(image);
                            this.Controls.Add(mylab);
                            mylab.ForeColor = System.Drawing.SystemColors.HotTrack;
                            mylab.Font.Size = 45;

                            break;

                        case 'u':
                            image.ImageUrl = "~/z1.jpeg";
                            mylab.Text = "&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;" + "3455$" + "</br>";
                            mylab.ForeColor = Color.Green;
                            this.Controls.Add(image);
                            this.Controls.Add(mylab);
                            mylab.ForeColor = System.Drawing.SystemColors.HotTrack;
                            mylab.Font.Size = 45;

                            break;

                        case 'v':
                            image.ImageUrl = "~/z2.jpeg";
                            mylab.Text = "&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;" + "34$" + "</br>";
                            mylab.ForeColor = Color.Green;
                            this.Controls.Add(image);
                            this.Controls.Add(mylab);
                            mylab.ForeColor = System.Drawing.SystemColors.HotTrack;
                            mylab.Font.Size = 45;

                            break;

                        case 'w':
                            image.ImageUrl = "~/z3.jpeg";
                            mylab.Text = "&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;" + "45$" + "</br>";
                            mylab.ForeColor = Color.Green;
                            this.Controls.Add(image);
                            this.Controls.Add(mylab);
                            mylab.ForeColor = System.Drawing.SystemColors.HotTrack;
                            mylab.Font.Size = 45;

                            break;

                        case 'x':
                            image.ImageUrl = "~/z4.jpeg";
                            mylab.Text = "&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;" + "345$" + "</br>";
                            mylab.ForeColor = Color.Green;
                            this.Controls.Add(image);
                            this.Controls.Add(mylab);
                            mylab.ForeColor = System.Drawing.SystemColors.HotTrack;
                            mylab.Font.Size = 45;

                            break;
                    }
                       
                }

            }
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("ac.aspx");
        }
}

