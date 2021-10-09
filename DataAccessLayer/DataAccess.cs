using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using BussinessObject;

namespace DataAccessLayer
{
    public class DataAccess
    {
        string strcon = ConfigurationManager.ConnectionStrings["Appdb"].ConnectionString;

        public bool checkMemberExists(UserBO userBO)
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("SELECT * from Users where email='" + userBO.email + "';", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count >= 1)
                {

                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public bool signUpNewMember(UserBO userBO)
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand(@"INSERT INTO Users(UserName,email,password,Account_status) 
                values(@UserName,@email,@password,@Account_status)", con);
                cmd.Parameters.AddWithValue("@UserName", userBO.UserName);
                cmd.Parameters.AddWithValue("@email", userBO.email);
                cmd.Parameters.AddWithValue("@password", userBO.password);
                cmd.Parameters.AddWithValue("@Account_status", userBO.status);
                cmd.ExecuteNonQuery();
                con.Close();
                return true;

            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public bool addToCustomer(CustomersBO customersBO)
        {
            try
            {
                SqlConnection con2 = new SqlConnection(strcon);
                if (con2.State == ConnectionState.Closed)
                {
                    con2.Open();
                }
                SqlCommand cmd1 = new SqlCommand(@"insert into Customers(Userid,Name,Age,Progress)values(@Userid,@Name,@Age,@progress)", con2);
                cmd1.Parameters.AddWithValue("@Userid", customersBO.Userid);
                cmd1.Parameters.AddWithValue("@Name", customersBO.name);
                cmd1.Parameters.AddWithValue("@Age", customersBO.age);
                cmd1.Parameters.AddWithValue("@progress", customersBO.progress);
                cmd1.ExecuteNonQuery();
                con2.Close();
                return true;
            }
            catch
            {
                throw;
            }

        }

        public int getUserID(string useremail)
        {
            SqlConnection con = new SqlConnection(strcon);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("SELECT * from Users where email='" + useremail + "';", con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                UserBO userBO = new UserBO();
                while (dr.Read())
                {
                    userBO.Userid = Convert.ToInt32(dr.GetValue(0));
                    userBO.UserName = dr.GetValue(1).ToString();
                }
                con.Close();
                return userBO.Userid;
            }

            return 0;

        }

    }
}
    
