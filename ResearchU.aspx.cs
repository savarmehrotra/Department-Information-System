using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class ResearchU : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       

    }

    protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
    {
        
        

    }

    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }

    protected void CheckBoxList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        if(CheckBoxList1.SelectedIndex == 0)
        {
            TextBox1.Visible = true;
            TextBox2.Visible = true;
            TextBox3.Visible = true;
            TextBox4.Visible = true;
            Button1.Visible = true;

            TextBox5.Visible = false;
            TextBox6.Visible = false;
            TextBox7.Visible = false;
            Button2.Visible = false;
        }

        else
        {

            TextBox5.Visible =true;
            TextBox6.Visible = true;
            TextBox7.Visible = true;
            Button2.Visible = true;
        

            TextBox1.Visible = false;
            TextBox2.Visible = false;
            TextBox3.Visible = false;
            TextBox4.Visible = false;
            Button1.Visible = false;


        }
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLlocalDB;Initial Catalog=Student;Integrated Security=True");
        SqlCommand comm = new SqlCommand("INSERT INTO ResearchProjects(Project_Id,Faculty_Name ,Area, Amount) values(@id, @fname, @area, @amount);", conn);
        comm.Parameters.AddWithValue("@id", int.Parse(TextBox1.Text));
        comm.Parameters.AddWithValue("@fname", TextBox2.Text);
        comm.Parameters.AddWithValue("@area", TextBox3.Text);
        comm.Parameters.AddWithValue("@amount", int.Parse(TextBox4.Text));

        try
        {
            conn.Open();

            comm.ExecuteNonQuery();
        }

        catch(Exception ex)
        {

        }

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLlocalDB;Initial Catalog=Student;Integrated Security=True");
        SqlCommand comm = new SqlCommand("INSERT INTO Publications(Name, Faculty, Year) values(@name, @fname, @year) ", conn);
        comm.Parameters.AddWithValue("@id", TextBox5.Text);
        comm.Parameters.AddWithValue("@fname", TextBox6.Text);
        comm.Parameters.AddWithValue("@year", Convert.ToDateTime(TextBox7.Text));
        

        try
        {
            conn.Open();

            comm.ExecuteNonQuery();
        }

        catch (Exception ex)
        {

        }
    }

    protected void TextBox6_TextChanged(object sender, EventArgs e)
    {

    }

    protected void TextBox5_TextChanged(object sender, EventArgs e)
    {

    }

    protected void TextBox7_TextChanged(object sender, EventArgs e)
    {

    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        Response.Redirect("Research1.aspx");
    }
}