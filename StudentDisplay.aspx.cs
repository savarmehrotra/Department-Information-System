using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class StudentDispaly : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLlocalDB;Initial Catalog=Student;Integrated Security=True");

        SqlCommand comm = new SqlCommand("Select * from Details where id=@uid");

        //string ui = 

        int uiid;
        int.TryParse(Request.QueryString["unique_id"], out uiid);

        comm.Parameters.AddWithValue("@uid", uiid);


        try
        {
            con.Open();
            SqlDataReader reader = comm.ExecuteReader();

            while(reader.Read())
            {
                Label1.Text = reader["Name"].ToString();

                Label2.Text = reader["Id"].ToString();

                Label3.Text = "COURSES COMPLETED : \n";

                Label4.Text = "INCOMPLETE COURSES : \n";

                if(reader["Grade1"].ToString().Equals("F"))
                {
                    Label3.Text += reader["Course1"].ToString();
                    Label3.Text += reader["Grade1"].ToString();
                    Label3.Text += "\n";
                }

                else
                {
                    Label4.Text += reader["Course1"].ToString();
                    Label4.Text += reader["Grade1"].ToString();
                    Label4.Text += "\n";

                }

                if (reader["Grade2"].ToString().Equals("F"))
                {
                    Label3.Text += reader["Course2"].ToString();
                    Label3.Text += reader["Grade2"].ToString();
                    Label3.Text += "\n";
                }

                else
                {
                    Label4.Text += reader["Course2"].ToString();
                    Label4.Text += reader["Grade2"].ToString();
                    Label4.Text += "\n";

                }

                if (reader["Grade3"].ToString().Equals("F"))
                {
                    Label3.Text += reader["Course3"].ToString();
                    Label3.Text += reader["Grade3"].ToString();
                    Label3.Text += "\n";
                }

                else
                {
                    Label4.Text += reader["Course3"].ToString();
                    Label4.Text += reader["Grade3"].ToString();
                    Label4.Text += "\n";

                }

                if (reader["Grade4"].ToString().Equals("F"))
                {
                    Label3.Text += reader["Course4"].ToString();
                    Label3.Text += reader["Grade4"].ToString();
                    Label3.Text += "\n";
                }

                else
                {
                    Label4.Text += reader["Course4"].ToString();
                    Label4.Text += reader["Grade4"].ToString();
                    Label4.Text += "\n";

                }

            }

        }

        catch
        {

        }

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("Student1.aspx");
    }
}