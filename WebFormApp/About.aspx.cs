using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormApp
{
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var result = Request.GetOwinContext().Authentication.AuthenticateAsync("Cookies").GetAwaiter().GetResult();
            string idToken = result.Properties.Dictionary["id_token"];
            string accessToken = result.Properties.Dictionary["access_token"];
            TextBox1.Text = accessToken;
            TextBox2.Text = idToken;
        }
    }
}