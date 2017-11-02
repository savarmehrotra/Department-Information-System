using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Invgrid.aspx");
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection();
        con.ConnectionString = @"Data Source = (localdb)\MSSQLlocalDB; Initial Catalog = proj; Integrated Security = true ; Pooling =false";
        try
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT into Inventory(Name , Quantity , total , Department) VALUES (@N, @Q , @Amount, @dept)", con);
            cmd.Parameters.AddWithValue("@dept", DropDownList1.SelectedItem.Text);
            cmd.Parameters.AddWithValue("@N", TextBox1.Text);
            cmd.Parameters.AddWithValue("@Q", TextBox2.Text);
            cmd.Parameters.AddWithValue("@Amount", TextBox3.Text);
            cmd.ExecuteNonQuery();
            SqlCommand cmd2 = new SqlCommand("INSERT into Account(Type,origin,Amount) VALUES (@T ,@dept ,@a )", con);
            cmd2.Parameters.AddWithValue("@T", "Debit");
            cmd2.Parameters.AddWithValue("@dept", DropDownList1.SelectedItem.Text);
            cmd2.Parameters.AddWithValue("@a", TextBox3.Text);
            cmd2.ExecuteNonQuery();
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