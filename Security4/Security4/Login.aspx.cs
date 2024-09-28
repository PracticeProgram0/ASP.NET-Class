using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
using System.Data.SqlClient;

namespace Security4
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            string s = "Select  email , password from security";

            SqlConnection con = new SqlConnection("Data Source=LAPTOP-FC70M26Q\\SQLEXPRESS;Initial Catalog=Mvc;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand(s, con);
           SqlDataReader dr= cmd.ExecuteReader();
            if (dr.Read())
            {
                

                if (dr["EMAIL"].ToString() == TextBox1.Text && dr["PASSWORD"].ToString() == TextBox2.Text)
                {
                    FormsAuthentication.RedirectFromLoginPage(TextBox1.Text, CheckBox1.Checked);
                    Response.Redirect("~/Admin/admin_home.aspx");
                   


                }
                else
                {
                    Label1.Text = " Invalid Username and Password.....";
                }

            }


        }
    }
}