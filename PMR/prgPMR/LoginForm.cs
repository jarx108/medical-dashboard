using System.Data;
using Microsoft.SqlServer;
using Microsoft.Data.SqlClient;
using System;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Drawing;
namespace prgPMR
{


    public partial class LoginForm : Form
    {


        // Can't get the breaking up of connection string to work

        // string strDataConnString = @"Data Source = EJVIDSYS\SQLEXPRESS; " + 
        //                             "Initial Catalog=dbPMR; " +
        //                             "Integrated Security=True; " +
        //                             "Connect Timeout=30; " +
        //                             "Encrypt=True; " +
        //                             "Trust Server Certificate=True; " +
        //                             "Application Intent=ReadWrite; " +
        //                             "Multi Subnet Failover=False";

        // SqlConnection strConnectionDB = new SqlConnection(strDataConnString);

        SqlConnection strConnectionDB = new SqlConnection(@"Data Source = EJVIDSYS\SQLEXPRESS; Initial Catalog = dbPMR; Integrated Security = True; Connect Timeout = 30; Encrypt=True;Trust Server Certificate=True;Application Intent = ReadWrite; Multi Subnet Failover=False");

        public LoginForm()

        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void chkShowPW_CheckedChanged(object sender, EventArgs e)
        {
            // If checkbox is checked then show password, else use * to hide password
            if (chkShowPW.Checked)
            {
                txtbxPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtbxPassword.UseSystemPasswordChar = true;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Check if either the username or password is blank
            if (txtbxUsername.Text == "" || txtbxPassword.Text == "")
            {
                MessageBox.Show("Please fill all blank fields"
                    , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Check if connection to the database is open
                if (strConnectionDB.State != ConnectionState.Open)
                {
                    try
                    {
                        // Try to open connection to database
                        strConnectionDB.Open();

                        // Create a SQL query string
                        // "@username" and "@password" are placeholder in the SQL query
                        string strSQLQueryString = "SELECT * FROM tblUsernames WHERE Username = @username " +
                                                   "AND password = @password";

                        // Creates a command object "cmdSQLquery" to use to execute your SQL query and interact with the database
                        using (SqlCommand cmdSQLquery = new SqlCommand(strSQLQueryString, strConnectionDB))
                        {
                            // Populates the command object with the username and password values entered by the user
                            // so that the SQL query has actual values
                            cmdSQLquery.Parameters.AddWithValue("@Username", txtbxUsername.Text.Trim());
                            cmdSQLquery.Parameters.AddWithValue("@Password", txtbxPassword.Text.Trim());

                            // Create a adapter object to use to fill a database table with the results of the SQL query
                            SqlDataAdapter adptSQLQuery = new SqlDataAdapter(cmdSQLquery);

                            // Create an table object to contain the data resulting from the SQL query
                            DataTable tblTable = new DataTable();

                            // Fill the table with the results from the SQL query
                            adptSQLQuery.Fill(tblTable);

                            // Check to see the SQL query returned any values by checking how many rows in SQL query
                            // If it is >= 1 then a record was found in the dataabse
                            if (tblTable.Rows.Count >= 1)
                            {
                                MainForm frmMainForm = new MainForm();
                                frmMainForm.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Incorrect Username/Password", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }

                    catch (Exception ex)
                    {
                        // Trying to open connection to database failed, show error message
                        MessageBox.Show("Error: " + ex
                        , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        // Close connection to database
                        strConnectionDB.Close();
                    }
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnNewUser_Click(object sender, EventArgs e)
        {

        }
    }
}
