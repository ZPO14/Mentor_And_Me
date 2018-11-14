using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Mentor_And_Me
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void logSubmitBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("Create.aspx");
        }
    }
}