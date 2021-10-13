using System;
using System.Collections.Generic;
using System.Web.Script.Serialization;
using Newtonsoft.Json;
using BussinessLayer;
using BussinessObject;

namespace MathChimpanzee
{
    public partial class QuizPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null)
            {
                Response.Redirect("Home.aspx");
            }
            else if (!IsPostBack && Request.QueryString["quiz"] != null)
                {
                    int quizNumber = Convert.ToInt32(Request.QueryString["quiz"]);

                    List<QuizQuestionsBO> quizQuestions;
                    QuizQuestionsBL quizQuestionsBL = new QuizQuestionsBL();

                    quizQuestions = quizQuestionsBL.GetQuizQuestions(quizNumber);
                    if(quizQuestions == null)
                {
                    Response.Redirect("Error.aspx");
                }
                    JavaScriptSerializer ser = new JavaScriptSerializer();
                    hf.Value = ser.Serialize(quizQuestions);
                }
        }
        protected void submit_Click(object sender, EventArgs e)

        {
            List<QuizScoreBO> qs = JsonConvert.DeserializeObject<List<QuizScoreBO>>(result.Value);
            if(qs == null)
            {
                Session["Score"] = "Quiz Not Completed";
                Response.Redirect("Score.aspx");
            }
            int score_count = 0;
            foreach (var cor in qs)
            {
                if (cor.result == "true")
                {
                    score_count++;
                }
            }
            QuizResultBO resultBO = new QuizResultBO();
            UserBO user = (UserBO)Session["user"];
            resultBO.Score = score_count;
            resultBO.Userid = user.Userid;
            resultBO.Lessonid = Convert.ToInt32(Request.QueryString["quiz"]);
            resultBO.date = DateTime.Now;
            QuizResultBL resultBL = new QuizResultBL();
            int isSuccess = resultBL.SaveQuizResult(resultBO , qs);
            if (isSuccess==1)
            {
                //score not in query string
                Session["Score"] = score_count + "/" + qs.Count.ToString();
                Response.Redirect("Score.aspx");
            }
            if(isSuccess  == -1)
            {
                Response.Redirect("Error.aspx");
            }
        }
        protected void Page_Error(object sender, EventArgs e)
        {
            Response.Redirect("Error.aspx");
        }

    }
    }
