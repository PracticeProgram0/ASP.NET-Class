using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace Image_gridview
{
    public partial class Show_image : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string s = "select * from img";
            SqlConnection cn = new SqlConnection("Data Source=LAPTOP-FC70M26Q\\SQLEXPRESS;Initial Catalog=Mvc;Integrated Security=True");
            cn.Open();
            SqlDataAdapter da= new SqlDataAdapter(s,cn);
            DataSet ds = new DataSet();
            da.Fill(ds);

            GridView1.DataSource = ds;
            GridView1.DataBind();

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if(FileUpload1.HasFile)
            {
                string strname = FileUpload1.FileName.ToString();
                FileUpload1.PostedFile.SaveAs(Server.MapPath("~/image/") + strname);
                string path = "~/image/" + strname.ToString();
                string q = "insert into img values('" + TextBox1.Text + "','" + path + "')";
                SqlConnection cn = new SqlConnection("Data Source=LAPTOP-FC70M26Q\\SQLEXPRESS;Initial Catalog=Mvc;Integrated Security=True");
                cn.Open();
                SqlCommand cmd = new SqlCommand(q, cn);
                cmd.ExecuteNonQuery();

                Response.Write("insert image....");
            }
        }
    }
}