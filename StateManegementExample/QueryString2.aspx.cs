using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateManegementExample
{
    public partial class QueryString2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            { 
            lblEno.Text = "Your Employee Number is : " + Request.QueryString["eno"];
            lblEname.Text = "Your Employee Name is : " + Request.QueryString["ename"];
            }
        }

        protected void LinkPrev_Click(object sender, EventArgs e)
        {
            LinkPrev.PostBackUrl = "QueryString1.aspx";
        }
    }
}