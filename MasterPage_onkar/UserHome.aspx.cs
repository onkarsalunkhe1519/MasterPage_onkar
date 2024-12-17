using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MasterPage_onkar
{
    public partial class UserHome : System.Web.UI.Page
    {
        SqlConnection conn;
        protected void Page_Load(object sender, EventArgs e)
        {
            string cs = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
            conn = new SqlConnection(cs);
            conn.Open();
            fetchproduct();
       

        }

        protected void DataList1_ItemCommand(object source, DataListCommandEventArgs e)
        {
            if (e.CommandName == "AddToCart")
            {
                string q = $"exec findProductByID '{e.CommandArgument.ToString()}'";
                SqlCommand cm = new SqlCommand(q, conn);
                SqlDataReader dr = cm.ExecuteReader();
                dr.Read();
                
                string prodname = dr["pname"].ToString();
                string prodcat = dr["pcat"].ToString();
                string prodpic = dr["pic"].ToString();
                double prodprice = double.Parse(dr["price"].ToString());

                string pdate = DateTime.Now.ToString("dd/MM/yyyy");
                DropDownList dropDown = e.Item.FindControl("DropDownList1") as DropDownList;
                int qty = int.Parse(dropDown.SelectedValue.ToString());
                double total = prodprice * qty;
                string suser = Session["MyUser"].ToString();
                string query = $"exec FindUserByEmail '{suser}'";
                SqlCommand cmdd = new SqlCommand(query, conn);
                SqlDataReader rdr = cmdd.ExecuteReader();
                rdr.Read();
                string us = rdr["username"].ToString();

                string q2 = $"exec AddToCart '{prodname}','{prodcat}','{prodpic}','{prodprice}','{qty}','{total}','{pdate}','{us}'";
                SqlCommand sqlCommand = new SqlCommand(q2, conn);
                sqlCommand.ExecuteNonQuery();
                Response.Redirect("Cart.aspx");

            }
        }

        public void fetchproduct()
        {
            string command = "exec fetchproductdetails";
            SqlCommand cmd = new SqlCommand(command, conn);
            SqlDataReader r = cmd.ExecuteReader();
            DataList1.DataSource = r;
            DataList1.DataBind();
        }






    }

}