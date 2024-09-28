using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;



namespace Project_1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            if (ViewState["data"] == null)
            {
                dt.Columns.Add("Name");
                dt.Columns.Add("Address");
                dt.Columns.Add("Email");
                dt.Columns.Add("Mobile");
            }
            else

                dt = (DataTable)ViewState["data"];
            DataRow dr = dt.NewRow();
            dr["name"] = TextBox1.Text;
            dr["Address"] = TextBox2.Text;
            dr["Email"] = TextBox3.Text;
            dr["Mobile"] = TextBox4.Text;
            dt.Rows.Add(dr);
            ViewState["data"] = dt;
            GridView1.DataSource = dt;
            GridView1.DataBind();

            TextBox1.Text = string.Empty;
            TextBox2.Text = string.Empty;
            TextBox3.Text = string.Empty;
            TextBox4.Text = string.Empty;
        }


            protected void Button2_Click(object sender, EventArgs e)
            {
            for (int i = 0; i < GridView1.Rows.Count; i++)
            {
                string nm = GridView1.Rows[i].Cells[0].Text;
                string ad = GridView1.Rows[i].Cells[1].Text;
                string em = GridView1.Rows[i].Cells[2].Text;
                string mob = GridView1.Rows[i].Cells[3].Text;

                string q = "insert into data ('" + nm + "','" + ad + "','" + em + "','" + mob + "')";
                SqlConnection cn = new SqlConnection("Data Source=LAPTOP-FC70M26Q\\SQLEXPRESS;Initial Catalog=collage;Integrated Security=True");     
                SqlCommand cmd = new SqlCommand(q, cn);
                
               

            }
            Response.Write("succsessfully saved data.....");
            GridView1.Visible = false;
               }
            }





        }

  
