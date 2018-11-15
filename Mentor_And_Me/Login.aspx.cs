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
            //Login use = new Login();
            //Login pass = new Login();

            if(userNameTxBx.Text=="Mentor" && passWordTxBx.Text == "12345")
            {
                Response.Redirect("Create.aspx");
            }
            else if (userNameTxBx.Text == "Mentee" && passWordTxBx.Text == "67890")
            {
                Response.Redirect("index.aspx");
            }
            else
            {
                messageLabel.Visible = true;            
            }

        }

        protected void passWordTxBx_TextChanged(object sender, EventArgs e)
        {
            //passWordTxBx.PassWordChar();
        }
        public void PassWordChar()
        {

        }
    }
}