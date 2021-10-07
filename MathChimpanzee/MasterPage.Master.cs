using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MathChimpanzee
{
    public partial class MasterPage : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["role"] == null)
            {
                LinkButton1.Visible = true; 
                LinkButton2.Visible = true; 
                LinkButton3.Visible = true; 
                LinkButton4.Visible = false; 
                LinkButton5.Visible = false; 
               
            }
            else if (Session["role"] == "user")
            {
                LinkButton1.Visible = false; 
                LinkButton2.Visible = false; 
                LinkButton3.Visible = false; 
                LinkButton4.Visible = true; 
                LinkButton5.Visible = true;
                LinkButton5.Text = Session["UserName"].ToString();

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
            Session["username"] = "";
            Session["fullname"] = "";
            Session["role"] = "";
            Session["status"] = "";

            LinkButton1.Visible = true;
            LinkButton2.Visible = true;
            LinkButton3.Visible = true;
            LinkButton4.Visible = false;
            LinkButton5.Visible = false;
            Response.Redirect("Homepage.aspx");

        }
    }
}