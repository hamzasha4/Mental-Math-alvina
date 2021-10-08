using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Script.Serialization;
using MathChimpanzee.Models;
using Newtonsoft.Json;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace MathChimpanzee
{
    public partial class QuizPage : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["con2"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                List<Quiz> quizlist = new List<Quiz>()
            {

             new Quiz {id = 1, question = "2+2", ans = 4},
             new Quiz {id = 2, question = "3+5", ans  = 8},
             new Quiz {id = 3,question = "2+7", ans  = 9}
            };

                JavaScriptSerializer ser = new JavaScriptSerializer();
                hf.Value = ser.Serialize(quizlist);
            }
        }
        protected void submit_Click(object sender, EventArgs e)

        {
            List<Quizscore> qs = JsonConvert.DeserializeObject<List<Quizscore>>(result.Value);
            int score_count = 0;
            foreach (var cor in qs)
            {
                if (cor.result == "true")
                {
                    score_count++;
                }
            }

            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand(@"INSERT INTO Quiz(QuizScore, CustomerID) 
                values(@quizscore, @customerid)", con);
                cmd.Parameters.AddWithValue("@quizscore", score_count);
                cmd.Parameters.AddWithValue("@customerid", 1);
                cmd.ExecuteNonQuery();
                con.Close();
                Response.Write("<script>alert('Successfull');</script>");
                Response.Redirect("Score.aspx/?s=" + score_count + "&l=" + qs.Count);
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }
        
        }
    }
