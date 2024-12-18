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
    public partial class Cart : System.Web.UI.Page
    {
        SqlConnection conn;
        protected void Page_Load(object sender, EventArgs e)
        {
            string cs = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
            conn = new SqlConnection(cs);
            conn.Open();
            fetchproduct();
            findtotal();


        }

        public void fetchproduct()
        {
            string user = Session["MyUser"].ToString();
            string query = $"exec FindUserByEmail '{user}'";
            SqlCommand cmdd = new SqlCommand(query, conn);
            SqlDataReader rdr = cmdd.ExecuteReader();
            rdr.Read();
            string  us= rdr["username"].ToString();
            string command = $"exec FetchCartByUser {us}";
            SqlCommand cmd = new SqlCommand(command, conn);
            SqlDataReader r = cmd.ExecuteReader();
            GridView1.DataSource = r;
            GridView1.DataBind();
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            Label l1=GridView1.Rows[e.RowIndex].FindControl("Label1") as Label;
            string pid=l1.Text;
            string q = $"exec DeleteCartByID {pid}";
            SqlCommand cmd=new SqlCommand(q, conn);
            cmd.ExecuteNonQuery();
            fetchproduct();
            findtotal();
        }
        public void findtotal() {
            string email = Session["MyUser"].ToString();
            string query = $"exec FindUserByEmail '{email}'";
            SqlCommand cmdd = new SqlCommand(query, conn);
            SqlDataReader rdr = cmdd.ExecuteReader();
            rdr.Read();
            string su = rdr["username"].ToString();
            string q = $"exec findtotal '{su}'";
            SqlCommand cmd = new SqlCommand(q, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            string amt =reader["grandtotal"].ToString();
            Label8.Text ="Grand Total : "+ amt;
            Session["GrandTotal"] = amt;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string email = Session["MyUser"].ToString();
            string query = $"exec FindUserByEmail '{email}'";
            SqlCommand cmdd = new SqlCommand(query, conn);
            SqlDataReader rdr = cmdd.ExecuteReader();
            rdr.Read();
            string su = rdr["username"].ToString();
            string q1 = $"exec Checkoutproc {su}";
            SqlCommand cmd= new SqlCommand(q1, conn);
            int row=cmd.ExecuteNonQuery();
            if (row > 0)
            {
                string q2 = $"exec deletefromcart {su}";
                SqlCommand cmd2 = new SqlCommand(q2,conn);
                cmd2.ExecuteNonQuery();
                Response.Redirect("Payment.aspx");
            }
            else
            {
                Response.Write("Wrong");

            }

        }
    }
}