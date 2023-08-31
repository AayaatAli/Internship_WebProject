using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Second
{
    public partial class Site : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            ProductCount();

        }

        protected void ProductCount()
        {

            var x = Session["dtShoppingCart"] as DataTable;
            if (x == null)
            {
                int Cartcount = 0;
                pCount.InnerText = Cartcount.ToString();
            }
            else
            {
                int CartCount = x.Rows.Count;

                pCount.InnerText = CartCount.ToString();

            }


        }

        protected void btnLogOut_Click(object sender, EventArgs e)
        {
            Session["userName"] = null;
            Response.Redirect("Login.aspx");
        }

        protected void btnShoppingCart_Click(object sender, EventArgs e)
        {
            Response.Redirect("ShoppingCart.aspx");
        }




    }
}