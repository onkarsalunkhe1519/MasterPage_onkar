using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MasterPage_onkar
{
    public partial class AddProduct : System.Web.UI.Page
    {
        SqlConnection conn;
        protected void Page_Load(object sender, EventArgs e)
        {
            string cs = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
            conn = new SqlConnection(cs);
            conn.Open();

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string pname = TextBox1.Text;
            string pcat = DropDownList1.SelectedValue;
            double price = double.Parse(TextBox2.Text);
            FileUpload1.SaveAs(Server.MapPath("images/") + Path.GetFileName(FileUpload1.FileName));
            string pic = "images/" + Path.GetFileName(FileUpload1.FileName);

            string q = $"exec insertproductdetails '{pname}','{pcat}','{price}','{pic}'";
            SqlCommand sqlCommand = new SqlCommand(q, conn);
            sqlCommand.ExecuteNonQuery();
        }
    }
}