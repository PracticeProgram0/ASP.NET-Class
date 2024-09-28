using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Cookies
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

      
        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "ram" && TextBox2.Text == "seeta")
            {
                HttpCookie ck = new HttpCookie("unm");
                ck.Value = TextBox1.Text;
                if(CheckBox1.Checked)
                    ck.Expires= DateTime.Now.AddHours(1);

                Response.Cookies.Add(ck);
                Response.Redirect("~/user/user_home.aspx");
            
            }
            else
            {
                Response.Write("invalid login......");
            }
        }
    }
}