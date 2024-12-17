using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MasterPage_onkar
{
    public partial class Login : System.Web.UI.Page
    {
        SqlConnection conn;
        protected void Page_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["connection"].ConnectionString);
            conn.Open();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string email=TextBox1.Text;
            
            string password=TextBox2.Text;
           
            
            string q = $"exec SignIn '{email}','{password}'";
            SqlCommand cmd = new SqlCommand(q, conn);
            SqlDataReader r = cmd.ExecuteReader();

            

            if (r.HasRows) {
                while (r.Read()) {
                    if ((r["email"].Equals(email) || r["username"].Equals(email) && r["password"].Equals(password)) && r["urole"].Equals("admin"))
                    {
                        Session["MyUser"] = email;
                        Response.Redirect("AdminHome.aspx");
                    }
                    if (r["email"].Equals(email) || r["username"].Equals(email) && r["password"].Equals(password) && r["urole"].Equals("user"))
                    {
                        Session["MyUser"] = email;
                        Response.Redirect("UserHome.aspx");
                    }

                }
            }
            else
            {
                Response.Write("<script>alert('Invalid Email Or Password');</script>");

            }

;        }
    }
}