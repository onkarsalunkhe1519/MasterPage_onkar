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
    public partial class SignUp : System.Web.UI.Page
    {
        SqlConnection conn;
        protected void Page_Load(object sender, EventArgs e)
        {
            conn=new SqlConnection(ConfigurationManager.ConnectionStrings["connection"].ConnectionString);
            conn.Open();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string username=TextBox1.Text;
            string email=TextBox2.Text;
            string password=TextBox3.Text;
            string urole = "user";
            string q = $"exec AddUser '{username}','{email}','{password}','{urole}'";
            SqlCommand cmd= new SqlCommand(q,conn);
            cmd.ExecuteNonQuery();
            Response.Write("<script>alert('User Registered');window.location.href='Login.aspx'</script>");

        }
    }
}