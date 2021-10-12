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
        // datalist 
        protected void Button9_Click(object sender, EventArgs e)
        {
            Response.Redirect("LessonDisplay.aspx?Lesson=1");

        }
        protected void Button8_Click(object sender, EventArgs e)
        {
            Response.Redirect("LessonDisplay.aspx?Lesson=2");
            //if (2 > (Int32)Session["Progress"])
            //{
            //    Response.Write("<script>alert('Lesson Locked');</script>");
            //}
            //else
            //{
            //    Response.Redirect("WebForm2.aspx?Lesson=2");
            //}

            //}
        }
    }
}


