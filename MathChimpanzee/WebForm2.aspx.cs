using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MathChimpanzee
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Request.QueryString["Lesson"] != null)
            {
                int les = Convert.ToInt32(Request.QueryString["Lesson"]);
                if (les > (Int32)Session["Progress"])
                {
                    Response.Write("<script>alert('Lesson Locked');</script>");
                    Response.Redirect("Lessons.aspx");
                    
                }
            }
        }
       

    }
}