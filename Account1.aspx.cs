using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection();
        con.ConnectionString = @"Data Source=(localdb)\MSSQLlocalDB;Initial Catalog=Student;Integrated Security=True";
        try
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT into Account(Type,origin,Amount) VALUES (@Type, @origin , @Amount)", con);
            cmd.Parameters.AddWithValue("@Type", DropDownList1.SelectedItem.Text);
            cmd.Parameters.AddWithValue("@origin", TextBox1.Text);
            cmd.Parameters.AddWithValue("@Amount", TextBox2.Text);
            cmd.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
            lbl.Text = ex.Message;
        }
        finally
        {
            con.Close();
        }
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/AccGrid.aspx");
    }
    //Use QueryString method as on Page 59 of lab5 to send the updated check box details

    protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
    {
        //  Panel1.Visible =true;
        //  RadioButton1.Checked = false;
        // Panel2.Visible = false;

    }

    protected void RadioButton2_CheckedChanged(object sender, EventArgs e)
    {
        //   Panel1.Visible = false;
        //  RadioButton1.Checked = false;
        // Panel2.Visible = true;

    }


    protected void Button3_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection();
        con.ConnectionString = @"Data Source=(localdb)\MSSQLlocalDB;Initial Catalog=Student;Integrated Security=True";
        try
        {
            con.Open();
            SqlCommand cmd3 = new SqlCommand("UPDATE Account SET origin = @origin , Amount = @Amount WHERE Id = @id", con);
            cmd3.Parameters.AddWithValue("@origin", TextBox4.Text);
            cmd3.Parameters.AddWithValue("@Amount", TextBox5.Text);
            cmd3.Parameters.AddWithValue("@id", TextBox3.Text);
            cmd3.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
            lbl.Text = ex.Message;
        }
        finally
        {
            con.Close();
        }
    }
}