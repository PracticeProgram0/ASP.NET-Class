using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace Data_man_form
{
    public partial class VPfROM : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataTable dt;
            if (ViewState["data"] == null)
            {
                dt = new DataTable();
                dt.Columns.Add("Name");
                dt.Columns.Add("Dob");
                dt.Columns.Add("Date of joining");
                dt.Columns.Add("Address");
                dt.Columns.Add("City");
                dt.Columns.Add("State");
                dt.Columns.Add("Country");
                dt.Columns.Add("Age");
                dt.Columns.Add("Mobile");
                dt.Columns.Add("Class");
                dt.Columns.Add("College");
                dt.Columns.Add("Obtaining");
                dt.Columns.Add("Obtained");
                dt.Columns.Add("%");
                dt.Columns.Add("Overall%");
            }
            else
                dt = (DataTable)ViewState["data"];
            DataRow dr = dt.NewRow();
            dr["Name"] = TextBox1.Text;
            dr["dob"] = TextBox2.Text;
            dr["Date of joining"] = TextBox3.Text;
            dr["Address"] = TextBox24.Text;
           // dr["Address"] = TextArea1.Text.Trim();
            dr["City"] = DropDownList1.Text;
            dr["State"] = TextBox4.Text;
            dr["Country"] = TextBox5.Text;
            dr["Age"] = TextBox7.Text;
            dr["Mobile"] = TextBox6.Text;

            dr["Class"] = TextBox8.Text;
            dr["College"] = TextBox9.Text;
            dr["Obtaining"] = TextBox10.Text;
            dr["Obtained"] = TextBox11.Text;
            dr["%"] = TextBox12.Text;

            dr["Class"] = TextBox13.Text;
            dr["College"] = TextBox14.Text;
            dr["Obtaining"] = TextBox15.Text;
            dr["Obtained"] = TextBox16.Text;
            dr["%"] = TextBox17.Text;

            dr["Class"] = TextBox18.Text;
            dr["College"] = TextBox19.Text;
            dr["Obtaining"] = TextBox20.Text;
            dr["Obtained"] = TextBox21.Text;
            dr["%"] = TextBox22.Text;

            dr["Overall%"] = TextBox23.Text;

            dt.Rows.Add(dr);
            ViewState["data"] = dt;

            GridView1.DataSource = ViewState["data"];
            GridView1.DataBind();


            TextBox1.Text = "";
            TextBox2.Text = "";


        }

        protected void TextBox23_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            //String INSERT = $"insert into dataman  values('{TextBox1.Text}','"+TextBox2.Text+"','"+TextBox3.Text+"','"+ TextBox24.Text+ "','"+DropDownList1.Text+"','"+TextBox4.Text+"','"+TextBox5.Text+"','"+TextBox7.Text+"','"+TextBox6.Text+"','"+TextBox8.Text+"','"+TextBox9.Text+"','"+TextBox10.Text+"','"+TextBox11.Text+"','"+TextBox12.Text+"','"+TextBox13.Text+"','"+TextBox14.Text+"','"+TextBox15.Text+"')";
            //string INSERT = $"insert into dataman values ({TextBox1.Text},{TextBox2.Text},{TextBox3.Text},{TextBox24.Text},{DropDownList1.Items},{TextBox4.Text},{TextBox5.Text},{TextBox7.Text},{TextBox6.Text},{TextBox8.Text},{TextBox9.Text},{TextBox10.Text},{TextBox11.Text},{TextBox12.Text},{TextBox13.Text},{TextBox14.Text},{TextBox15.Text},{TextBox16.Text},{TextBox17.Text},{TextBox18.Text},{TextBox19.Text},{TextBox20.Text},{TextBox21.Text},{TextBox22.Text},{TextBox23.Text}) ";

            //SqlConnection con = new SqlConnection("Data Source=LAPTOP-FC70M26Q\\SQLEXPRESS;Initial Catalog=btps;Integrated Security=True;");
            //con.Open();
            //SqlCommand cmd = new SqlCommand(INSERT,con);
            //int i = cmd.ExecuteNonQuery();
            //if (i > 0)
            //{
            //    Response.Write("inserted ...");
            //}
            //else
            //{
            //    Response.Write(" Not  inserted ...");

            //}
      

            string INSERT = "INSERT INTO DATAMAN1 (NAME,DOB,DOJ,ADDRESS,CITY,STATE,COUNTRY,AGE,MOBILE,CLASS,COLLEGE,Obtaining,Obtained,PAR,Overall) VALUES (@TextBox1, @TextBox2, @TextBox3, @TextBox24, @DropDownList1.item, @TextBox4, @TextBox5, @TextBox7, @TextBox6, @TextBox8, @TextBox9, @TextBox10, @TextBox11, @TextBox12, @TextBox13, @TextBox14, @TextBox15, @TextBox16, @TextBox17, @TextBox18, @TextBox19, @TextBox20, @TextBox21, @TextBox22, @TextBox23)";

            using (SqlConnection con = new SqlConnection("Data Source=LAPTOP-FC70M26Q\\SQLEXPRESS;Initial Catalog=btps;Integrated Security=True;"))
            {
                try
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(INSERT, con))
                    {
                        // Add parameters with appropriate values
                        cmd.Parameters.AddWithValue("@TextBox1", TextBox1.Text);
                        cmd.Parameters.AddWithValue("@TextBox2", TextBox2.Text);
                        cmd.Parameters.AddWithValue("@TextBox3", TextBox3.Text);
                        cmd.Parameters.AddWithValue("@TextBox24", TextBox24.Text);
                        cmd.Parameters.AddWithValue("@DropDownList1", DropDownList1.SelectedValue);
                        cmd.Parameters.AddWithValue("@TextBox4", TextBox4.Text);
                        cmd.Parameters.AddWithValue("@TextBox5", TextBox5.Text);
                        cmd.Parameters.AddWithValue("@TextBox7", TextBox7.Text);
                        cmd.Parameters.AddWithValue("@TextBox6", TextBox6.Text);
                        cmd.Parameters.AddWithValue("@TextBox8", TextBox8.Text);
                        cmd.Parameters.AddWithValue("@TextBox9", TextBox9.Text);
                        cmd.Parameters.AddWithValue("@TextBox10", TextBox10.Text);
                        cmd.Parameters.AddWithValue("@TextBox11", TextBox11.Text);
                        cmd.Parameters.AddWithValue("@TextBox12", TextBox12.Text);
                        cmd.Parameters.AddWithValue("@TextBox13", TextBox13.Text);
                        cmd.Parameters.AddWithValue("@TextBox14", TextBox14.Text);
                        cmd.Parameters.AddWithValue("@TextBox15", TextBox15.Text);
                        cmd.Parameters.AddWithValue("@TextBox16", TextBox16.Text);
                        cmd.Parameters.AddWithValue("@TextBox17", TextBox17.Text);
                        cmd.Parameters.AddWithValue("@TextBox18", TextBox18.Text);
                        cmd.Parameters.AddWithValue("@TextBox19", TextBox19.Text);
                        cmd.Parameters.AddWithValue("@TextBox20", TextBox20.Text);
                        cmd.Parameters.AddWithValue("@TextBox21", TextBox21.Text);
                        cmd.Parameters.AddWithValue("@TextBox22", TextBox22.Text);
                        cmd.Parameters.AddWithValue("@TextBox23", TextBox23.Text);

                        int i = cmd.ExecuteNonQuery();
                        if (i > 0)
                        {
                            Response.Write("Inserted successfully.");
                        }
                        else
                        {
                            Response.Write("Insertion failed.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Handle exceptions
                    Response.Write($"An error occurred: {ex.Message}");
                }
            }



        }
    }
}