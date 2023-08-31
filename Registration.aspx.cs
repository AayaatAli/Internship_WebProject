using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Second
{
    public partial class Registration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void Button2_Click(object sender, EventArgs e)
        {

            if (TextBox1.Text != "" && TextBox2.Text != "" && TextBox3.Text != "")
            {


                //Sql sql_ = new Sql();
                DataTable dt = Sql.fillDataTable("insert into dbo.Customer ([userName],[email],[password]) values ('" + TextBox3.Text + "','" + TextBox1.Text + "','" + TextBox2.Text + "')");
                //var test = dt.Rows[0][0].ToString();
                Response.Redirect("Login.aspx");

            }

            else
            {
                lblError.Text = "All Fields Are Mandatory To Fill!";
            }

        }




    }
}