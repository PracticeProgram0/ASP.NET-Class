using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace Crud_youtube
{
    public partial class crud : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection("Data Source=LAPTOP-FC70M26Q\\SQLEXPRESS;Initial Catalog=Youtube;Integrated Security=True");
            SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[MAN]
           ([ID]
           ,[NAME]
           ,[PHONE]
           ,[ADDRESS])
     VALUES
         ('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "')", cn);
                cn.Open();
            cmd.ExecuteNonQuery();
            Response.Write("Data inserted successfully");
           cn.Close();
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection("Data Source=LAPTOP-FC70M26Q\\SQLEXPRESS;Initial Catalog=Youtube;Integrated Security=True");
            SqlCommand cmd = new SqlCommand(@"
                   DELETE FROM [dbo].[MAN]
                    WHERE [ID]= '"+TextBox1+"'",cn);
                  cn.Open();
         
            Response.Write("delete successfully");
            cn.Close();
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection("Data Source=LAPTOP-FC70M26Q\\SQLEXPRESS;Initial Catalog=Youtube;Integrated Security=True");
            SqlCommand cmd = new SqlCommand(@"
                        UPDATE [dbo].[MAN]
                      SET [ID] = '"+TextBox1+"' ,[NAME] = '"+TextBox2+"' , [PHONE] = '"+TextBox3+"', [ADDRESS] = '"+TextBox4+"' WHERE [ID]= '"+TextBox1+"'",cn);
                     
                 cn.Open();
            cmd.ExecuteNonQuery();
            Response.Write("update successfilly");
            cn.Close();
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";

        }
    }
}