using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace Crud_chatGPT
{
    public partial class login_page : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGeneratePassword_Click(object sender, EventArgs e)
        {
            // Generate a random password
            string generatedPassword = GenerateRandomPassword();

            // Save the user details to the database here (not implemented in this example)

            // Redirect to the login page, passing the username and password
            Response.Redirect("Login.aspx?username=" + txtEmail.Text + "&password=" + generatedPassword);
        }

        private string GenerateRandomPassword()
        {
            // Logic to generate a random password
            return Guid.NewGuid().ToString().Substring(0, 8);
        }
    }
}