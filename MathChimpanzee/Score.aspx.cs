using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MathChimpanzee
{
    public partial class Score : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null)
            {
                Response.Redirect("Home.aspx");
            }
            else if (!IsPostBack)
            {
                score.Text = (string)Session["Score"];

            }
        }

        protected void BtnToLesson_Click(object sender, EventArgs e)
        {
            Response.Redirect("Lessons.aspx");
        }
    }
}