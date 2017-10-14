using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateManegementExample
{
    public partial class ViewState1 : System.Web.UI.Page
    {
        List<string> Products = null; 

        protected void Page_Load(object sender, EventArgs e)
        {
            if (ViewState["Products"] == null)
            {
                Products = CreateProducts();
            }
            else

            {
                Products = ViewState["Products"] as List<string>;
                GridView1.DataSource = Products;
                GridView1.DataBind();
            }
           

        }

        private List<string> CreateProducts()
        {
            List<string> products = new List<string>();
            products.Add("Sart");
            products.Add("Pent");
            products.Add("Jins");
            return products;

        }
        protected void Page_PreRender(object sender, EventArgs e)
        {
            ViewState["Products"] = Products;
        }




    }
}