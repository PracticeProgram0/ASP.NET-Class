using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Crud_vivek
{
    public partial class Crud : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string cn = "select * from student where id =" + TextBox1.Text;
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-FC70M26Q\\SQLEXPRESS;Initial Catalog=collage;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand(cn, con);
            SqlDataReader Dr = cmd.ExecuteReader();
            if (Dr.Read())
            {
                for (int i = 0; i < 2; i++)
                {
                    TextBox2.Text = Dr[1].ToString();
                    TextBox3.Text = Dr[2].ToString();
                    TextBox4.Text = Dr[3].ToString();

                }
            }
            else
            {
                Response.Write("Record Not found");
            }

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            String d = "Delete from student where id=" + TextBox1.Text;
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-FC70M26Q\\SQLEXPRESS;Initial Catalog=collage;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand(d, con);
            int i = cmd.ExecuteNonQuery();
            if (i > 0)
            {
                Response.Write("Deleted data");
            }
            else
                Response.Write("not Deleted ");

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            string d = "update asd set name='" + TextBox2.Text + "', city='" + TextBox3.Text + "', mobile_no='" + TextBox4.Text + "' where id='" + TextBox1.Text + "'";

            //String d = "update asd set name="+TextBox2.Text,"city="+TextBox3.Text,"mobile_no="+TextBox4.Text "where id=" + TextBox1.Text;
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-FC70M26Q\\SQLEXPRESS;Initial Catalog=collage;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand(d, con);
            int i = cmd.ExecuteNonQuery();
            if (i > 0)
            {
                Response.Write("Update data");
            }
            else
            {
                Response.Write("not Update ");
            }

        }
    }
}