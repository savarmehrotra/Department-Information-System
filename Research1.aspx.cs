using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Research1 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {

        
        if (RadioButtonList1.SelectedIndex == 0)
            Response.Redirect("ResearchD.aspx");

        else
            Response.Redirect("ResearchU.aspx");
    }
}