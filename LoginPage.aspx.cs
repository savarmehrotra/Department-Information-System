using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class LoginPage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        Label2.Visible = false;
        ValidationSettings.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;

    }

    protected void Check(object sender, EventArgs e)
    {
        if (TextBox2.Text.Equals("Admin") && TextBox3.Text.Equals("Admin"))
        {
        }

        else
        {
            Label2.Text = "INVALID CREDENTIALS";
            Label2.Visible = true;
        }
    }
}