using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateManegementExample
{
    public partial class Session1 : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            //Session["Uid"] = txtUid.Text;
        }
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUid.Text) || string.IsNullOrWhiteSpace(txtPwd.Text))
            {
                lblError.Text = "Fill the requred field.";

            }
            else
            {
                Session["Uid"] = txtUid.Text;
                Response.Redirect("Session2.aspx");
            }

        }
        protected void btnGo_Click(object sender, EventArgs e)
        {
            Response.Redirect("Session1.aspx");
        }
    }
}