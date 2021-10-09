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

            int result = userBL.addUser(userbo);
            if (result != 0)
            {
                CustomersBO customerobj = new CustomersBO();
                customerobj.name = userbo.UserName;
                customerobj.Userid = result;
                customerobj.age = Convert.ToInt32(txtage.Text);
                customerobj.progress = 1;
                CustomersBL customersBL = new CustomersBL();
                if (customersBL.addCustomer(customerobj))
                {
                    Session["UserId"] = customerobj.Userid;
                    Session["UserName"] = customerobj.name;
                    Session["progress"] = customerobj.progress;
                    Session["role"] = "user";
                    Response.Redirect("Homepage.aspx");

                }
            }


            //if (checkMemberExists())
            //{

            //    Response.Write("<script>alert('Member Already Exist with this Member ID, try other ID');</script>");

            //}
            //else
            //{  
            //    if (signUpNewMember())
            //    {
            //        redirectToPage();
            //    }

            //}
        }

        // user defined method
        //bool checkMemberExists()
        //{
        //    try
        //    {
        //        SqlConnection con = new SqlConnection(strcon);
        //        if (con.State == ConnectionState.Closed)
        //        {
        //            con.Open();
        //        }
        //        SqlCommand cmd = new SqlCommand("SELECT * from Users where email='" + TextBox1.Text.Trim() + "';", con);
        //        SqlDataAdapter da = new SqlDataAdapter(cmd);
        //        DataTable dt = new DataTable();
        //        da.Fill(dt);               
        //        if (dt.Rows.Count >= 1)
        //        {
        //            return true;
        //        }
        //        else
        //        {
        //            return false;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Response.Write("<script>alert('" + ex.Message + "');</script>");
        //        return false;
        //    }
        //}
        //bool signUpNewMember()
        //{
        //    //Response.Write("<script>alert('Testing');</script>");
        //    try
        //    {
        //        SqlConnection con = new SqlConnection(strcon);
        //        if (con.State == ConnectionState.Closed)
        //        {
        //            con.Open();
        //        }
        //        SqlCommand cmd = new SqlCommand(@"INSERT INTO Users(UserName,email,password,Account_status) 
        //    values(@UserName,@email,@password,@Account_status)",con);
        //        cmd.Parameters.AddWithValue("@UserName", TextBox4.Text.Trim());
        //        cmd.Parameters.AddWithValue("@email", TextBox1.Text.Trim());
        //        cmd.Parameters.AddWithValue("@password", TextBox2.Text.Trim());
        //        cmd.Parameters.AddWithValue("@Account_status", "pending");
        //        cmd.ExecuteNonQuery();
        //        con.Close();
        //        Response.Write("<script>alert('Sign Up Successful. Go to User Login to Login');</script>");
        //        return true;
                
        //    }
        //    catch (Exception ex)
        //    {
        //        Response.Write("<script>alert('" + ex.Message + "');</script>");
        //        return false;
        //    }
        //}

        //void redirectToPage()
        //{
        //    SqlConnection con = new SqlConnection(strcon);
        //    if (con.State == ConnectionState.Closed)
        //    {
        //        con.Open();
        //    }
        //    SqlCommand cmd = new SqlCommand("SELECT * from Users where email='" + TextBox1.Text.Trim() + "';", con);
        //    SqlDataReader dr = cmd.ExecuteReader();
        //    if (dr.HasRows)
        //    {
        //        while (dr.Read())
        //        {
        //            Session["UserId"] = dr.GetValue(0).ToString();
        //            Session["UserName"] = dr.GetValue(1).ToString();
        //            Session["role"] = "user";
        //            Session["Status"] = dr.GetValue(4).ToString();
        //            Session["Progress"] = 1;
                    
        //        }
        //        con.Close();
        //    }
          
        //    else
        //    {
        //        Response.Write("<script>alert('Invalid credentials');</script>");
        //    }
        //    SqlConnection con2 = new SqlConnection(strcon);
        //    if (con2.State == ConnectionState.Closed)
        //    {
        //        con2.Open();
        //    }
        //    SqlCommand cmd1 = new SqlCommand(@"insert into Customers(Userid,Name,Age,Progress)values(@Userid,@Name,@Age,@progress)", con2);
        //    cmd1.Parameters.AddWithValue("@Userid",Session["UserId"]);
        //    cmd1.Parameters.AddWithValue("@Name", TextBox4.Text.Trim());
        //    cmd1.Parameters.AddWithValue("@Age", Age.Text.Trim());
        //    cmd1.Parameters.AddWithValue("@progress", 1);
        //    cmd1.ExecuteNonQuery();

        //    con2.Close();
        //    Response.Redirect("Homepage.aspx");
        //}


    }
}