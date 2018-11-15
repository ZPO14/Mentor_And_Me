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
    public partial class DetailPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int dataId = 1;
            dataId = Convert.ToInt32(Page.Request.QueryString["value"]);

            nameLabel.Text = sqlProjectName(dataId).ToString();
            creatoLabel.Text = sqlProjectCreator(dataId).ToString();
            descriptionLabel.Text = sqlProjectDescription(dataId).ToString();
            sizeLabel.Text = sqlProjectSize(dataId).ToString();
            requirementsLabel.Text = sqlProjectRequirements(dataId).ToString();
            dateLabel.Text = sqlProjectDate(dataId).ToString();


            submitBtn.CommandArgument = dataId.ToString();
            submitBtn.Click += submitBtn_Click;

            deleteButton.CommandArgument = dataId.ToString();
            deleteButton.Click += deleteButton_Click;
        }

        //protected void RadioButton2_CheckedChanged(object sender, EventArgs e)
        //{

        //}

        protected void submitBtn_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            Response.Redirect("ApplyPage.aspx?value=" + (button.CommandArgument));
        }

        public string sqlProjectName(int number)
        {
            int num = number;
            string sqlConnectString = System.Configuration.ConfigurationManager.ConnectionStrings["myDB"].ConnectionString;
            string stmt = "SELECT name From project WHERE projectid =" + Convert.ToString(num);
            string cell;

            using (SqlConnection thisconnection = new SqlConnection(sqlConnectString))
            {
                using (SqlCommand cmd = new SqlCommand(stmt, thisconnection))
                {
                    thisconnection.Open();
                    cell = (string)cmd.ExecuteScalar();
                }

            }
            return cell;
        }

        public string sqlProjectCreator(int number)
        {
            int num = number;
            string sqlConnectString = System.Configuration.ConfigurationManager.ConnectionStrings["myDB"].ConnectionString;
            string stmt = "SELECT creator From project WHERE projectid =" + Convert.ToString(num);
            string cell;

            using (SqlConnection thisconnection = new SqlConnection(sqlConnectString))
            {
                using (SqlCommand cmd = new SqlCommand(stmt, thisconnection))
                {
                    thisconnection.Open();
                    cell = (string)cmd.ExecuteScalar();
                }

            }
            return cell;
        }

        public string sqlProjectDescription(int number)
        {
            int num = number;
            string sqlConnectString = System.Configuration.ConfigurationManager.ConnectionStrings["myDB"].ConnectionString;
            string stmt = "SELECT description From project WHERE projectid =" + Convert.ToString(num);
            string cell;

            using (SqlConnection thisconnection = new SqlConnection(sqlConnectString))
            {
                using (SqlCommand cmd = new SqlCommand(stmt, thisconnection))
                {
                    thisconnection.Open();
                    cell = (string)cmd.ExecuteScalar();
                }

            }
            return cell;
        }

        public string sqlProjectSize(int number)
        {
            int num = number;
            string sqlConnectString = System.Configuration.ConfigurationManager.ConnectionStrings["myDB"].ConnectionString;
            string stmt = "SELECT size From project WHERE projectid =" + Convert.ToString(num);
            string cell;

            using (SqlConnection thisconnection = new SqlConnection(sqlConnectString))
            {
                using (SqlCommand cmd = new SqlCommand(stmt, thisconnection))
                {
                    thisconnection.Open();
                    cell = (string)cmd.ExecuteScalar();
                }

            }
            return cell;
        }

        public string sqlProjectRequirements(int number)
        {
            int num = number;
            string sqlConnectString = System.Configuration.ConfigurationManager.ConnectionStrings["myDB"].ConnectionString;
            string stmt = "SELECT requirements From project WHERE projectid =" + Convert.ToString(num);
            string cell;

            using (SqlConnection thisconnection = new SqlConnection(sqlConnectString))
            {
                using (SqlCommand cmd = new SqlCommand(stmt, thisconnection))
                {
                    thisconnection.Open();
                    cell = (string)cmd.ExecuteScalar();
                }

            }
            return cell;
        }

        public string sqlProjectDate(int number)
        {
            int num = number;
            string sqlConnectString = System.Configuration.ConfigurationManager.ConnectionStrings["myDB"].ConnectionString;
            string stmt = "SELECT date From project WHERE projectid =" + Convert.ToString(num);
            string cell;

            using (SqlConnection thisconnection = new SqlConnection(sqlConnectString))
            {
                using (SqlCommand cmd = new SqlCommand(stmt, thisconnection))
                {
                    thisconnection.Open();
                    cell = (string)cmd.ExecuteScalar();
                }

            }
            return cell;
        }

        public string sqlProjectId(int number)
        {
            int num = number;
            string sqlConnectString = System.Configuration.ConfigurationManager.ConnectionStrings["myDB"].ConnectionString;
            string stmt = "SELECT projectid From project WHERE projectid =" + Convert.ToString(num);
            string cell;

            using (SqlConnection thisconnection = new SqlConnection(sqlConnectString))
            {
                using (SqlCommand cmd = new SqlCommand(stmt, thisconnection))
                {
                    thisconnection.Open();
                    cell = (string)cmd.ExecuteScalar();
                }

            }
            return cell;
        }

        protected void applyButton_Command(object sender, CommandEventArgs e)
        {

        }

        protected void deleteButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            sqlDeleteRow((Convert.ToInt32(button.CommandArgument)));
        }

        public string sqlDeleteRow(int number)
        {
            int num = number;
            string sqlConnectString = System.Configuration.ConfigurationManager.ConnectionStrings["myDB"].ConnectionString;
            string stmt = "Delete From project WHERE projectid =" + Convert.ToString(num);
            string cell;

            using (SqlConnection thisconnection = new SqlConnection(sqlConnectString))
            {
                using (SqlCommand cmd = new SqlCommand(stmt, thisconnection))
                {
                    thisconnection.Open();
                    cell = (string)cmd.ExecuteScalar();
                }

            }
            return cell;
        }


        //protected void applyButton_Click(object sender, EventArgs e)
        //{

        //}

        //protected void submitButton_Click(object sender, EventArgs e)
        //{

        //}

        //protected void emailTextBox_TextChanged(object sender, EventArgs e)
        //{

        //}
    }
}