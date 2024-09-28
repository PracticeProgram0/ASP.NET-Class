using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.Net.Mail;

namespace EmailIntrigation
{
    public partial class Emailsending : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SmtpClient obj = new SmtpClient();
            obj.Credentials = new NetworkCredential(TextBox1.Text,TextBox2.Text);
            obj.Port = 587;
            obj.Host = "smtp.gmail.com";
            obj.EnableSsl = true;

            MailMessage msg = new MailMessage(TextBox1.Text,TextBox3.Text,TextBox4.Text,TextBox5.Text);
            
            obj.Send(msg);
            Response.Write("Sending Email.....");

        }
    }
}