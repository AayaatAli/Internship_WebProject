using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Second
{
    public partial class ShippingDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //protected void btnPlaceOrder_Click(object sender, EventArgs e)
        //{
        //    DataTable dt = Sql.fillDataTable("insert into dbo.ShippingInfo ([F_Name],[L_Name],[C_address]),(C_state),(City),(PhoneNo),(Email),(userID) values ('" + txtFirstName.Value + "','" + txtLastName.Value + "','" + txtAddress.Value + "','" + txtState.Value + "','" + txtCity.Value + "','" + Convert.ToInt32(txtPhoneNo.Value) + "','" + txtEmail.Value + "','" + Convert.ToInt32(Session["userID"]) + "')");
        //}

        protected void btnPlaceOrder_Click1(object sender, EventArgs e)
        {
            DataTable dt = Sql.fillDataTable("insert into dbo.ShippingInfo ([F_Name],[L_Name],[C_address],[C_state],[City],[PhoneNo],[Email],[userID]) values ('" + txtFirstName.Value + "','" + txtLastName.Value + "','" + txtAddress.Value + "','" + txtState.Value + "','" + txtCity.Value + "','" + txtPhoneNo.Value + "','" + txtEmail.Value + "','" + Convert.ToInt32(Session["userID"]) + "')");
            
  


            Response.Redirect("Confirmation.aspx");
        }

        //protected void btnPlaceOrder_Click(object sender, EventArgs e)
        //{

        //}
    }
}