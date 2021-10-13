using System;
using BussinessLayer;
using BussinessObject;

namespace MathChimpanzee
{
    public partial class Sign_Up : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSignUp_Click(object sender, EventArgs e)
        {
            UserBL userBL = new UserBL();

            UserBO userbo = new UserBO();
           
            userbo.UserName = txtusername.Text;
            userbo.email = txtemail.Text;
            userbo.status = "Confirm";
            userbo.password = txtpassword.Text;
            //dob not age
            userbo.age = Convert.ToInt32(txtage.Text);
            userbo.progress = 1;
            userbo.role = "user";

            int result = userBL.addUser(userbo);

            if (result == 1)
            {

                userbo.Userid = userBL.getUserID(userbo.email);
                Session["User"] = userbo;
                Response.Redirect("Dashboard.aspx");
            }
            else if(result == 0){
                Response.Write("<script>alert('User already signed up')</script>");
            }
            else if(result==2)
            {
                Response.Write("<script>alert('Can't signup the User')</script>");
            }
           
        }
    }
}