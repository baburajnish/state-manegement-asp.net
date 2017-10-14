using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateManegementExample
{
    public partial class QueryString1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            Response.Redirect("QueryString2.aspx?eno=" + txtEno.Text  + "&ename=" + txtEname.Text );
        }
    }
}