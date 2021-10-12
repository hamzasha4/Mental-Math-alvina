using System;
using BussinessLayer;
using BussinessObject;
namespace MathChimpanzee
{
    public partial class Login_page : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            UserBO user;
            UserBL userBL = new UserBL();
            user = userBL.getUser(txtemail.Text, txtpassword.Text);
            if (user != null)
            {
                //sessions
                Session["user"] = user;
                Response.Redirect("Dashboard.aspx");
            }
            else
            {
                //warning message only
                Response.Write("<script>alert('Invalid credentials');</script>");
            }
        }
        protected void Button2_Click(object sender, System.EventArgs e)
        {
            Response.Redirect("SignUp.aspx");
        }
    }
}
//naming