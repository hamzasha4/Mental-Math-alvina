using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MathChimpanzee
{
    public partial class Lessons : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null)
            {
                Response.Redirect("Home.aspx");
            }

        }
        protected void btnLesson1_Click(object sender, EventArgs e)
        {
            Response.Redirect("LessonDisplay.aspx?Lesson=1");
        }

        protected void btnLesson2_Click(object sender, EventArgs e)
        {
            Response.Redirect("LessonDisplay.aspx?Lesson=2");
        }
    }
}


