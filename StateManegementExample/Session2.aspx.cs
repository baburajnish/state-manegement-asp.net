using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateManegementExample
{
    public partial class Session2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (Session["Uid"] == null)
            //{
            //    Response.Redirect("Session1.aspx");
            //}
            lblMsg.Text = "Wellcome to"+" : "+ Session["Uid"];
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            
            Response.Redirect("Session1.aspx");
        }
    }
}