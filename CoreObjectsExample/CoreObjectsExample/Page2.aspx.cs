using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CoreObjectsExample
{
    public partial class Page2 : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            //Response.Write("<h1>" + Request.QueryString["txtName"] + "</h1><br/>");
            //Response.Write("<h1>" + Request.QueryString["txtCity"] + "</h1><br/>");
            //Response.Write("<h1>" + Request.Form["txtName"] + "</h1><br/>");
            //Response.Write("<h1>" + Request.Form["txtCity"] + "</h1><br/>");
            //Response.Write("<h1>" + Request["txtName"] + "</h1><br/>");
            //Response.Write("<h1>" + Request["txtCity"] + "</h1><br/>");
            Response.Write("<h1>" + Request.QueryString["name"] + "</h1><br/>");
            Response.Write("<h1>" + Request["city"] + "</h1><br/>");
        }
    }
}