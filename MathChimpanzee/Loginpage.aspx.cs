using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MathChimpanzee
{
    public partial class Login_page : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["con2"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("SELECT * from Users where email='" + TextBox1.Text.Trim() + "' AND password='"+TextBox2.Text.Trim()+"'", con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Session["Userid"] = dr.GetValue(0);
                        Session["UserName"] = dr.GetValue(1).ToString();
                        Session["role"] = "user";
                        Session["Status"] = dr.GetValue(4).ToString();
                        
                    }
                    con.Close();
                }
                else
                {
                    Response.Write("<script>alert('Invalid credentials');</script>");
                }
                SqlConnection con2 = new SqlConnection(strcon);
                if (con2.State == ConnectionState.Closed)
                {
                    con2.Open();
                }
                SqlCommand cmd1 = new SqlCommand("SELECT * from Customers where Name='" + (String)Session["UserName"] + "'", con2);
                SqlDataReader dr2 = cmd1.ExecuteReader();
                if (dr2.HasRows)
                {
                    while (dr2.Read())
                    { 
                        Session["Progress"] = Convert.ToInt32(dr2.GetValue(3));
                        Response.Redirect("Homepage.aspx");
                    }
                }

                else
                {
                    Response.Write("<script>alert('Invalid credentials');</script>");
                }

            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        protected void Button2_Click(object sender, System.EventArgs e)
        {
            Response.Redirect("SignUp.aspx");
        }
    }
}