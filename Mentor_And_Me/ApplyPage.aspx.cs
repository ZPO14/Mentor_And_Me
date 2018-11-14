using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace Mentor_And_Me
{
    public partial class ApplyPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void applyButton_Click(object sender, EventArgs e)
        {
            string sqlConnectString = System.Configuration.ConfigurationManager.ConnectionStrings["myDB"].ConnectionString;
            //string sqlSelect = "insert into projecttest(userid, name, creator, desciption, size, requirements, date) values (@pid, @pname, @pcre, @pdesc, @psize, @preq, @pdate)";
            string sqlSelect = "insert into applicant(creatorId, userId, accepted, applyInfo, contact, projectId, submitted) values (@cid, @uid, @acc, @apply, @contact, @pid, @sub)";

            SqlConnection sqlConnection = new SqlConnection(sqlConnectString);
            SqlCommand sqlCommand = new SqlCommand(sqlSelect, sqlConnection);

            //sqlCommand.Parameters.Add("@id", System.Data.SqlDbType.NVarChar);
            //sqlCommand.Parameters["@id"].Value = ;

            sqlCommand.Parameters.Add("@cid", System.Data.SqlDbType.NVarChar);
            sqlCommand.Parameters["@cid"].Value = 1;

            sqlCommand.Parameters.Add("@uid", System.Data.SqlDbType.NVarChar);
            sqlCommand.Parameters["@uid"].Value = 2;

            sqlCommand.Parameters.Add("@acc", System.Data.SqlDbType.NVarChar);
            sqlCommand.Parameters["@acc"].Value = "false";

            sqlCommand.Parameters.Add("@apply", System.Data.SqlDbType.NVarChar);
            sqlCommand.Parameters["@apply"].Value = applyTextBox.Text;

            sqlCommand.Parameters.Add("@contact", System.Data.SqlDbType.NVarChar);
            sqlCommand.Parameters["@contact"].Value = contactTextbox.Text;

            int projectId = 1;
            projectId = Convert.ToInt32(Page.Request.QueryString["value"]);
            Label1.Text = Page.Request.QueryString["value"];

            sqlCommand.Parameters.Add("@pid", System.Data.SqlDbType.NVarChar);
            sqlCommand.Parameters["@pid"].Value = projectId;

            sqlCommand.Parameters.Add("@sub", System.Data.SqlDbType.NVarChar);
            sqlCommand.Parameters["@sub"].Value = "true";

            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();

            applyTextBox.Text = "";
            contactTextbox.Text = "";
        }
    }
}