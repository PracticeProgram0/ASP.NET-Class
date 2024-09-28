using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.Common;
using System.Reflection;
using System.Globalization;

namespace GridView_CRUD
{
    public partial class GridviewCRUD : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String s = "Select*from reg";
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-FC70M26Q\\SQLEXPRESS;Initial Catalog=Youtube;Integrated Security=True");
            con.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(s,con);
            DataSet ds = new DataSet(); 
            adapter.Fill(ds);

            GridView1.DataSource = ds;
            GridView1.DataBind();   
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex=e.NewEditIndex;
            Button1_Click(sender, e);   

        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            Button1_Click(sender, e);
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

            String id = GridView1.Rows[e.RowIndex].Cells[0].Text;
            string query = "DELETE FROM reg WHERE Id = @Id";
            using (SqlConnection con = new SqlConnection("Data Source=LAPTOP-FC70M26Q\\SQLEXPRESS;Initial Catalog=Youtube;Integrated Security=True"))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    GridView1.EditIndex = -1;
                    Button1_Click(sender, e);


                }
            }
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            String id = GridView1.Rows[e.RowIndex].Cells[0].Text;
            TextBox nm = (TextBox)GridView1.Rows[e.RowIndex].Cells[1].Controls[0];
          //  TextBox dob = (TextBox)GridView1.Rows[e.RowIndex].Cells[2].Controls[0];
            TextBox age = (TextBox)GridView1.Rows[e.RowIndex].Cells[2].Controls[0];
            TextBox email = (TextBox)GridView1.Rows[e.RowIndex].Cells[3].Controls[0];
            TextBox mobile = (TextBox)GridView1.Rows[e.RowIndex].Cells[4].Controls[0];

   
            string updateQuery = "update reg set name = @name,  age = @age, email = @email, mobile = @mobile where id = @id";
            using (SqlConnection con = new SqlConnection("Data Source=LAPTOP-FC70M26Q\\SQLEXPRESS;Initial Catalog=Youtube;Integrated Security=True"))
            {
                using (SqlCommand cmd = new SqlCommand(updateQuery, con))
                {
                    cmd.Parameters.AddWithValue("@name", nm.Text);
                   // cmd.Parameters.AddWithValue("@dob", dob.Text);
                    cmd.Parameters.AddWithValue("@age", age.Text);
                    cmd.Parameters.AddWithValue("@email", email.Text);
                    cmd.Parameters.AddWithValue("@mobile", mobile.Text);
                    cmd.Parameters.AddWithValue("@id", id);
                    con.Open();

                    cmd.ExecuteNonQuery();
                    GridView1.EditIndex = -1;
                    Button1_Click(sender, e);
                }
            }
            
        }
    }
}