using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BussinessLayer;
using BussinessObject;

namespace MathChimpanzee
{
    public partial class Sign_Up : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["con2"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            UserBL userBL = new UserBL();

            UserBO userbo = new UserBO();

            userbo.UserName = txtusername.Text;
            userbo.email = txtemail.Text;
            userbo.status = "Confirm";
            userbo.password = txtpassword.Text;
            userbo.age = Convert.ToInt32(txtage.Text);
            userbo.progress = 1;

            int result = userBL.addUser(userbo);

            //if (result != 0)
            //{
            //    CustomersBO customerobj = new CustomersBO();
            //    customerobj.name = userbo.UserName;
            //    customerobj.Userid = result;
            //    customerobj.age = Convert.ToInt32(txtage.Text);
            //    customerobj.progress = 1;
            //    CustomersBL customersBL = new CustomersBL();
            //    if (customersBL.addCustomer(customerobj))
            //    {
            //        Session["UserId"] = customerobj.Userid;
            //        Session["UserName"] = customerobj.name;
            //        Session["progress"] = customerobj.progress;
            //        Session["role"] = "user";
            //        Response.Redirect("Homepage.aspx");

            //    }
            //}

        }
    }
}