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
    public partial class WebForm2 : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            string sqlConnectString = System.Configuration.ConfigurationManager.ConnectionStrings["myDB"].ConnectionString;
            string sqlSelect = "select name, size, creator from project";

            SqlConnection sqlConnection = new SqlConnection(sqlConnectString);
            SqlCommand sqlCommand = new SqlCommand(sqlSelect, sqlConnection);
            sqlConnection.Open();

            SqlDataReader rd = sqlCommand.ExecuteReader();

            
            //this loops through and prints a new row for the main table from the database
            for (int i = 1; i <= SqlTableLength(); i++)
            {
                Button viewButton = new Button();
                viewButton.Text = "View";
                viewButton.CommandArgument = i.ToString();
                viewButton.Click += viewButton_Click;

                TableRow row = new TableRow();
                testtable.Rows.Add(row);
                TableCell cell1 = new TableCell();
                TableCell cell2 = new TableCell();
                TableCell cell3 = new TableCell();
                TableCell cell4 = new TableCell();
                row.Cells.Add(cell1);
                row.Cells.Add(cell2);
                row.Cells.Add(cell3);
                row.Cells.Add(cell4);
                cell1.Controls.Add(viewButton); 
                cell2.Text = Convert.ToString(sqlProjectName(i));
                cell3.Text = Convert.ToString(sqlProjectSize(i));
                cell4.Text = Convert.ToString(sqlProjectCreator(i));
            }
           
            sqlConnection.Close();
        }

        //method to grab the length of the table
        public int SqlTableLength()
        {
            string sqlConnectString = System.Configuration.ConfigurationManager.ConnectionStrings["myDB"].ConnectionString;
            string stmt = "Select count(*) from project";
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

        //methods to grab the specific value from the database
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

        public string sqlProjectDesciption(int number)
        {
            int num = number;
            string sqlConnectString = System.Configuration.ConfigurationManager.ConnectionStrings["myDB"].ConnectionString;
            string stmt = "SELECT desription From project WHERE projectid =" + Convert.ToString(num);
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
            string stmt = "SELECT projectid From projecttest WHERE projectid =" + Convert.ToString(num);
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

        protected void detailBtn_Click(object sender, EventArgs e)
        {
           
        }

        protected void viewButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            Console.WriteLine(button.CommandArgument);

            Response.Redirect("DetailPage.aspx?value=" + (button.CommandArgument));        
        }
      
    }
}