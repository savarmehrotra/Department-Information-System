using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Invgrid : System.Web.UI.Page
{
    string x;
    protected void Page_Load(object sender, EventArgs e)
    {
        x = Request.QueryString["Selected"];
        DropDownList1.SelectedValue = Server.UrlDecode(x);
    }
    //Use QueryString method as on Page 59 of lab5 to send the updated check box details
    string URL;
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        URL = "Invgrid.aspx?";
        URL += "Selected=" + Server.UrlEncode(DropDownList1.SelectedItem.Text);
        //Response.Redirect(URL);

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Inventory1.aspx");
    }

    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}