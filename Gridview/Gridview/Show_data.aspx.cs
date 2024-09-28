using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Gridview
{
    public partial class Show_data : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string s = "select * from student";
            SqlConnection cn = new SqlConnection("Data Source=LAPTOP-FC70M26Q\\SQLEXPRESS;Initial Catalog=collage;Integrated Security=True;");
            cn.Open();
            SqlDataAdapter da = new SqlDataAdapter(s, cn);
            DataSet dt = new DataSet();
            da.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
        
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex=e.NewEditIndex;
            Button1_Click(sender, e);   
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {

            TextBox nm = (TextBox)GridView1.Rows[e.RowIndex].Cells[0].Controls[0];
            TextBox ad = (TextBox)GridView1.Rows[e.RowIndex].Cells[1].Controls[0];
            TextBox em = (TextBox)GridView1.Rows[e.RowIndex].Cells[2].Controls[0];
            TextBox mo = (TextBox)GridView1.Rows[e.RowIndex].Cells[3].Controls[0];
            string id = GridView1.Rows[e.RowIndex].Cells[4].Text;

            string q = "update student set name ='"+nm.Text+"',address ='"+ad.Text+"',mobile ='"+mo.Text+"',email ='"+em.Text+"', where id='"+id+"'";
            SqlConnection cn = new SqlConnection("Data Source=LAPTOP-FC70M26Q\\SQLEXPRESS;Initial Catalog=collage;Integrated Security=True;");
            cn.Open();
            SqlCommand cmd = new SqlCommand(q, cn);
            cmd.ExecuteNonQuery();
            GridView1.EditIndex = -1;
            Button1_Click(sender, e);
        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            Button1_Click(sender, e);
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}