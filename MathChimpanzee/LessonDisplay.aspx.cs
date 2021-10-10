using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BussinessLayer;
using BussinessObject;
namespace MathChimpanzee
{
    public partial class LessonDisplay : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                
            }

        }

        protected void btnToQuiz_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["Lesson"]);
            Response.Redirect("QuizPage.aspx?quiz="+id);

        }
    }
}