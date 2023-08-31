using log4net;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Second
{
    public partial class Login : System.Web.UI.Page
    {
        ILog _logg = Logs.getInstance();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            lblError.Text = String.Empty;


            try
            {
                //Logs.printLogs("hello");
                _logg.Info("In buttonClick");
                Sql sql_ = new Sql();
                DataTable dt = Sql.fillDataTable("select  * from dbo.Customer where [userName] ='" + TextBox1.Text + "' and [password] ='" + TextBox2.Text + "'");
                if (dt.Rows.Count > 0)
                {
                    //if (form2Example31.Checked)
                    //{

                    //}


                    //adding new code
                    Session["userID"] = dt.Rows[0]["userID"].ToString();
                    var x= Session["userID"];
                    Session["userName"] = TextBox1.Text;
                    //Session["Pwd"] = TextBox2.Text;


                    Response.Redirect("Home.aspx");
                }
                else
                {
                    lblError.Text = "Invalid email or password";
                    return;
                }
                _logg.Debug("In buttonClick debug");
                //var test = dt.Rows[0][0].ToString();


            }
            //catch (NullReferenceException)
            catch (Exception ex)
            {
                lblError.Text = "Somethikng went wrong!";
                _logg.Error(ex.Message, ex);
                //Logs.printLogs(ex.Message);
                //ex.Message;
                //Console.WriteLine("Invalid email or password");

            }





        }
    }
}