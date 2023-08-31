using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Second
{
    public partial class Confirmation : System.Web.UI.Page
    {
     

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ConfirmProduct();

            }
        }

        private void ConfirmProduct()
        {
            var x = Session["dtShoppingCart"] as DataTable;

            Total.InnerText = Convert.ToString(Session["total"]);
            subTotal.InnerText = Convert.ToString(Session["subTotal"]);

            rptrConfirm.DataSource = x;
            rptrConfirm.DataBind();

            DataTable row_=Confirmation_.getRow();
            //rptrShippingDetails.DataSource = row_;
            //rptrShippingDetails.DataBind();







            var ShippingId = row_.Rows[0]["ShippingID"];
            Session["ID"] = ShippingId;
            var firstName = row_.Rows[0]["F_Name"];
            Session["firstName"] = firstName;
            var lastName = row_.Rows[0]["L_Name"];
            Session["lastName"] = lastName;
            var address = row_.Rows[0]["C_address"];
            Session["address"] = address;
            rptrShippingDetails.DataSource = row_;
            rptrShippingDetails.DataBind();
            lbl4.InnerText = "Hello, " + Convert.ToString(Session["firstName"]) + " " + Convert.ToString(Session["lastName"]);

            //DateTime today = DateTime.Today;
            string date = DateTime.UtcNow.ToString("d");
            date_span.InnerText = Convert.ToString(date);











            //DataTable new_dt = Sql.fillDataTable("select  * from dbo.ShippingInfo ");
            //int count=new_dt.Rows.Count;
            //Sql sql_1 = new Sql();
            //DataTable dt = Sql.fillDataTable("select  * from dbo.ShippingInfo where [ShippingID]="+ count +"");



        }

        protected void Button2_Click(object sender, EventArgs e)
        {

            Button2.Visible = false;
            Session["dtShoppingCart"] = null;



            string date = DateTime.UtcNow.ToString("d");
            var FName = Session["firstName"];
            var LName = Session["lastName"];
            var address = Session["address"];
            var total = Session["subTotal"];

            DataTable dt = Sql.fillDataTable("insert into dbo.OrderTable ([Order_date],[Customer_name],[address],[Total]) values ('" + date + "','" + Convert.ToString(FName) + " " + Convert.ToString(LName) + "','" + Convert.ToString(address) + "','" + Convert.ToString(total) + "')");

            //lbl4.InnerText = "Hello, " + Convert.ToString(Session["firstName"]) + " " + Convert.ToString(Session["lastName"]);








            Label1.Text = "We will be sending shipping confirmation email when the item shipped successfully!";
            Label2.Text = "Thanks for shopping with us!";
            Label3.Text = "Your order Confirmed!";
            lbl4.InnerText = "Hello " + Convert.ToString(Session["userName"]);
            lbl5.Visible = true;
        }
    }
}