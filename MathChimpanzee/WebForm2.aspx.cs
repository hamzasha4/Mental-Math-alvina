using System;
using BussinessLayer;
using BussinessObject;

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