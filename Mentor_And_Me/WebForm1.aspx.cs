using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Mentor_And_Me
{
    public partial class WebForm1 : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
          
        }


        protected void createButton_Click(object sender, EventArgs e)
        {
            string projectName = nameTextBox.Text;
            string projectCreator = creatorTextBox.Text;
            string projectDesciption = descriptionTextBox.Text;
            string projectSize = sizeTextBox.Text;
            string projectRequirements = requirementsTextBox.Text;
            string projectDate = dateTextBox.Text;

            //Move values to database on click
        }
    }
}