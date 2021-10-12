using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BussinessObject;
namespace MathChimpanzee
{
    public partial class MasterPage : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null)
            {
                LinkButton1.Visible = true; 
                LinkButton2.Visible = true; 
                LinkButton3.Visible = true; 
                LinkButton4.Visible = false; 
                LinkButton5.Visible = false; 
               
            }
            else 
            {
                UserBO user = (UserBO)Session["user"];

                if (user.role == "user")
                {
                    LinkButton1.Visible = false;
                    LinkButton2.Visible = false;
                    LinkButton3.Visible = false;
                    LinkButton4.Visible = true;
                    LinkButton5.Visible = true;
                    LinkButton5.Text = user.UserName;
                }

            }
           
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Loginpage.aspx");
        }

        protected void LinkButton3_Click(object sender, EventArgs e)
        {
            
            Response.Redirect("SignUp.aspx");
        }

        protected void LinkButton4_Click(object sender, EventArgs e)
        {
            Session["user"] = null;

            LinkButton1.Visible = true;
            LinkButton2.Visible = true;
            LinkButton3.Visible = true;
            LinkButton4.Visible = false;
            LinkButton5.Visible = false;
            Response.Redirect("Home.aspx");

        }
    }
}