using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Student1 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        ValidationSettings.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
    }

    protected void RadioButton2_CheckedChanged(object sender, EventArgs e)
    {

    }

    protected void RadioButton2_CheckedChanged1(object sender, EventArgs e)
    {

    }

    protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
    {

    }

    protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        string uid = TextBox1.Text;

        string qs = "";

        if (RadioButtonList1.SelectedIndex == 0)
        {
            qs += "StudentDisplay.aspx?unique_id=";
            qs += uid;

        }

        else if (RadioButtonList1.SelectedIndex == 1)
        {
            qs += "StudentUpdate.apsx?unique_id";
            qs += uid;
        }

        Response.Redirect(qs);

    }

    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }
}