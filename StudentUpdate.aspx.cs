using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class StudentUpdate : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       


    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        string sid = Request.QueryString["unique_id"].ToString();

        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLlocalDB;Initial Catalog=Student;Integrated Security=True");

        string c1 = TextBox1.Text;
        string c2 = TextBox2.Text;
        string c3 = TextBox3.Text;
        string c4 = TextBox7.Text;
        string g1 = TextBox6.Text;
        string g2 = TextBox5.Text;
        string g3 = TextBox4.Text;
        string g4 = TextBox8.Text;


        string s = "INSERT INTO Details VALUES(";

        s += c1;
        s += g1;
        s += c2;
        s += g2;
        s += c3;
        s += g3;
        s += c4;
        s += g4;

        s += ")WHERE Id=";

        s += sid;

        SqlCommand comm = new SqlCommand(s, con);

        comm.ExecuteNonQuery();
    }

    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }

    protected void TextBox6_TextChanged(object sender, EventArgs e)
    {

    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("Student1.aspx");
    }
}