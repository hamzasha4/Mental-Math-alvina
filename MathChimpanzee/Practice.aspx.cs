using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MathChimpanzee
{
    public partial class Practice : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null)
            {
                Response.Redirect("Home.aspx");
            }
            else
            {
                if (!IsPostBack)
                {
                    if (Request.QueryString["practice"] != null) {
                        practiceid.Value = Request.QueryString["practice"];

                    }
                    else
                    {
                        Response.Redirect("Lessons.aspx");
                    }
                }
            }
        }

        protected void Finish_Click(object sender, EventArgs e)
        {
            practiceid.Value = Request.QueryString["practice"];
            Response.Redirect("LessonDisplay.aspx?Lesson="+ practiceid.Value);
        }
    }
}