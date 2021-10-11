using System;
using BussinessLayer;
using BussinessObject;
namespace MathChimpanzee
{
    public partial class LessonDisplay : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnToQuiz_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["Lesson"]);
            Response.Redirect("QuizPage.aspx?quiz="+id);

        }

        protected void btntoPractice_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["Lesson"]);
            Response.Redirect("Practice.aspx?practice=" + id);
        }
    }
}