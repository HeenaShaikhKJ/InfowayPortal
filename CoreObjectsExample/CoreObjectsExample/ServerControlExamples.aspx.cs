using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CoreObjectsExample
{
    public partial class ServerControlExamples : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ddlCountries.Items.Add(new ListItem("India", "1"));
                ddlCountries.Items.Add(new ListItem("Japan", "2"));
                lblMessage.Text = "I am a GET Request!";
                Literal1.Text = "I am also a GET Request!";
            }
            else
            {
                lblMessage.Text = "I am a POST Request!";
            }
        }
    }
}