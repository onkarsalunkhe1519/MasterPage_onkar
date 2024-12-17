using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Caching;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MasterPage_onkar
{
    public partial class Admin : System.Web.UI.MasterPage
    {
        SqlConnection conn;
        protected void Page_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["connection"].ConnectionString);
            conn.Open();

            if (Session["MyUser"] != null)
            {
                string email = Session["MyUser"].ToString();
                string query = $"exec FindUserByEmail '{email}'";
                SqlCommand cmdd = new SqlCommand(query, conn);
                SqlDataReader rdr = cmdd.ExecuteReader();
                rdr.Read();
                Label1.Text = rdr["username"].ToString();



            }
            else
            {
                Response.Write("<script>alert('login first');windows.location.href='Login.aspx'</script>");
            }
            
           

            
            

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Session.Abandon();
            Response.Redirect("Login.aspx");
        }
    }
}