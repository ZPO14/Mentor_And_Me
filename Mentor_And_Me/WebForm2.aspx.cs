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
    public partial class WebForm2 : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            
            
            string sqlConnectString = System.Configuration.ConfigurationManager.ConnectionStrings["myDB"].ConnectionString;
            string sqlSelect = "select name, size, creator from projecttest";

            SqlConnection sqlConnection = new SqlConnection(sqlConnectString);
            SqlCommand sqlCommand = new SqlCommand(sqlSelect, sqlConnection);
            sqlConnection.Open();

            SqlDataReader rd = sqlCommand.ExecuteReader();


          

            for(int i = 1; i <= SqlTableLength(); i++)
            {
                

                TableRow row = new TableRow();
                testtable.Rows.Add(row);
                TableCell cell1 = new TableCell();
                TableCell cell2 = new TableCell();
                TableCell cell3 = new TableCell();
                row.Cells.Add(cell1);
                row.Cells.Add(cell2);
                row.Cells.Add(cell3);
                cell1.Text = Convert.ToString(sqlProjectName(i));
                cell2.Text = Convert.ToString(sqlProjectSize(i));
                cell3.Text = Convert.ToString(sqlProjectCreator(i));
            }

            

            sqlConnection.Close();
        }

        public int SqlTableLength()
        {
            string sqlConnectString = System.Configuration.ConfigurationManager.ConnectionStrings["myDB"].ConnectionString;
            string stmt = "Select count(*) from projecttest";
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

        public string sqlProjectName(int number)
        {
            int num = number;
            string sqlConnectString = System.Configuration.ConfigurationManager.ConnectionStrings["myDB"].ConnectionString;
            string stmt = "SELECT name From projecttest WHERE projectid =" + Convert.ToString(num);
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
            string stmt = "SELECT creator From projecttest WHERE projectid =" + Convert.ToString(num);
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
            string stmt = "SELECT desription From projecttest WHERE projectid =" + Convert.ToString(num);
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
            string stmt = "SELECT size From projecttest WHERE projectid =" + Convert.ToString(num);
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
            string stmt = "SELECT requirements From projecttest WHERE projectid =" + Convert.ToString(num);
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
            string stmt = "SELECT date From projecttest WHERE projectid =" + Convert.ToString(num);
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

    }
}