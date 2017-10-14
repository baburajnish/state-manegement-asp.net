using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using StateManegementExample.Models;
using System.Web.Script.Serialization;

namespace StateManegementExample
{
    public partial class HiddenField1 : System.Web.UI.Page
    {
        public static string value { get; private set; }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();
            employee.Id = 123;
            employee.Name= txtEname.Text;
            employee.Salary= double.Parse(txtEsal.Text);
            //int eno = 123;
            
            //string ename = txtEname.Text;
            //double esal = double.Parse(txtEsal.Text);
            var js = new JavaScriptSerializer();
            var jsEmployee = js.Serialize(employee);
            hdn.Value = jsEmployee;


            lblHiddenValue.Text = hdn.Value;
            txtEname.Text = "";
            txtEsal.Text = "";
            txtEname.Focus();
        }
    }
}