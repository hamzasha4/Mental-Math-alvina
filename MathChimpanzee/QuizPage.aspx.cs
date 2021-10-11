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
using BussinessLayer;
using BussinessObject;

namespace MathChimpanzee
{
    public partial class QuizPage : System.Web.UI.Page
    {
        

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack && Request.QueryString["quiz"] != null)
            {
                int quizNumber = Convert.ToInt32(Request.QueryString["quiz"]);
                
                List<QuizQuestionsBO> quizQuestions;
                QuizQuestionsBL quizQuestionsBL = new QuizQuestionsBL();

                quizQuestions = quizQuestionsBL.GetQuizQuestions(quizNumber);

                JavaScriptSerializer ser = new JavaScriptSerializer();
                hf.Value = ser.Serialize(quizQuestions);
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
            QuizResultBO resultBO = new QuizResultBO();
            resultBO.Score = score_count;
            resultBO.result = result.Value.ToString();
            resultBO.Userid = (Int32)Session["Userid"];
            resultBO.Lessonid = Convert.ToInt32(Request.QueryString["quiz"]);

            QuizResultBL resultBL = new QuizResultBL();
            bool isSuccess = resultBL.SaveQuizResult(resultBO);
            if (isSuccess)
            { 
                //score not in query string
                Response.Redirect("Score.aspx?s="+score_count+"&l="+qs.Count);
            }
        }
        
        }
    }
