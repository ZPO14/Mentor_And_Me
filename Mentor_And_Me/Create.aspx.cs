using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
//these three last using statements are needed to work with the database

namespace Mentor_And_Me
{
    public partial class WebForm1 : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
          
        }

        protected void createButton_Click(object sender, EventArgs e)
        {
            string sqlConnectString = System.Configuration.ConfigurationManager.ConnectionStrings["myDB"].ConnectionString;
            //string sqlSelect = "insert into projecttest(userid, name, creator, desciption, size, requirements, date) values (@pid, @pname, @pcre, @pdesc, @psize, @preq, @pdate)";
            string sqlSelect = "insert into project(projectid, userid, name, creator, description, size, requirements, date) values (@pid ,@uid, @pname, @pcre, @pdesc, @psize, @preq, @pdate)";
            //string sqlFindId = "select max(projectid) from project";

            SqlConnection sqlConnection = new SqlConnection(sqlConnectString);
            SqlCommand sqlCommand = new SqlCommand(sqlSelect, sqlConnection);
            //SqlCommand sqlCommand2 = new SqlCommand(sqlFindId, sqlConnection);

            sqlCommand.Parameters.Add("@pid", System.Data.SqlDbType.NVarChar);
            sqlCommand.Parameters["@pid"].Value = (Convert.ToInt32(SqlLastId()) + 1);

            sqlCommand.Parameters.Add("@uid", System.Data.SqlDbType.NVarChar);
            sqlCommand.Parameters["@uid"].Value = 1;

            sqlCommand.Parameters.Add("@pname", System.Data.SqlDbType.NVarChar);
            sqlCommand.Parameters["@pname"].Value = nameTextBox.Text;

            sqlCommand.Parameters.Add("@pcre", System.Data.SqlDbType.NVarChar);
            sqlCommand.Parameters["@pcre"].Value = creatorTextBox.Text;

            sqlCommand.Parameters.Add("@pdesc", System.Data.SqlDbType.NVarChar);
            sqlCommand.Parameters["@pdesc"].Value = descriptionTextBox.Text;

            sqlCommand.Parameters.Add("@psize", System.Data.SqlDbType.NVarChar);
            sqlCommand.Parameters["@psize"].Value = sizeTextBox.Text;

            sqlCommand.Parameters.Add("@preq", System.Data.SqlDbType.NVarChar);
            sqlCommand.Parameters["@preq"].Value = requirementsTextBox.Text;

            sqlCommand.Parameters.Add("@pdate", System.Data.SqlDbType.NVarChar);
            sqlCommand.Parameters["@pdate"].Value = dateTextBox.Text;

            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();

            nameTextBox.Text = "";
            creatorTextBox.Text = "";
            descriptionTextBox.Text = "";
            sizeTextBox.Text = "";
            requirementsTextBox.Text = "";
            dateTextBox.Text = "";


            
        }

        public int SqlLastId()
        {
            string sqlConnectString = System.Configuration.ConfigurationManager.ConnectionStrings["myDB"].ConnectionString;
            string stmt = "Select max(projectid) from project";
            int count = 0;

            using (SqlConnection thisconnection = new SqlConnection(sqlConnectString))
            {
                using (SqlCommand cmdCount = new SqlCommand(stmt, thisconnection))
                {
                    thisconnection.Open();
                    count = (int)cmdCount.ExecuteScalar();
                }
            }
            return count;
        }
    }
}