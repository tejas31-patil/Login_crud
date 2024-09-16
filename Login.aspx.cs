using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Drawing;

namespace Login_crud
{
    public partial class Login : System.Web.UI.Page
    {
        //creating variable to access connection string in  web.config file
        string cs = "Data Source=DESKTOP-SS35PNP\\SQLEXPRESS;Initial Catalog = DBLogin; Integrated Security = True; Encrypt=True;TrustServerCertificate=True";
        protected void Page_Load(object sender, EventArgs e)
        {
     
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //to create a sqlconnectiopn object and pass them variable
            SqlConnection con = new SqlConnection(cs);
            //select query 
            string query = "select * from tblLogin where uname=@uname and password=@pass";
            // create object of sqlcommand and pass query and connection object
            SqlCommand cmd = new SqlCommand(query,con);
            //passing parameters 
            cmd.Parameters.AddWithValue("@uname",nametxt.Text);
            cmd.Parameters.AddWithValue("@pass" , passtxt.Text);
            //open connection
            con.Open();
            //create obj and pass them query
            SqlDataReader dr=cmd.ExecuteReader();
            //check the rows is present in table
            if(dr.HasRows)
            {
                Session["uname"] = nametxt.Text;
                //display message 
                Response.Write("<script>alert('Login Successfully ..Welcome ')</script>");
                Response.Redirect("DashBoard.aspx");


            }
            else
            {
                //display message
                Response.Write("<script>alert('Please Enter Valid Username And Password')</script>");

            }
            con.Close();
        }
    }
}