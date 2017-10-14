using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;


namespace StateManegementExample
{
    public class Global : System.Web.HttpApplication
    {


        //Request.Url.ToString().Contains("Session1.aspx");
        //private object txtUid;

        //public void Session_Start(object sender, EventArgs e)
        //{

        //}
        //When in this application, AcquireRequestState event happen then 
        //Application_AcquireRequestState() this event handler will be called by .net. 
        //when
        public void Application_AcquireRequestState()
        {
            if (!Request.Url.ToString().Contains("Session1.aspx"))
            {
                if (HttpContext.Current.Session == null)
                {
                    Response.Redirect("Session1.aspx");
                }

            }
         
        }

        protected void Application_Start(object sender, EventArgs e)
        {
        }
    }
}