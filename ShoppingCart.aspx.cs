using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Second
{
    public partial class ShoppingCart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            

            if (!IsPostBack)
            {
                CartProducts();

            }
            

        }

        private void CartProducts()
        {
            if (Session["userName"] != null)
            {
                if (Session["dtShoppingCart"] != null)
                {

                    var x = Session["dtShoppingCart"] as DataTable;
                    int CartCount = x.Rows.Count;
                    cartCount.InnerText = CartCount.ToString() + " items";
                    cartCount_.InnerText = "ITEMS " + CartCount.ToString();
                    PriceDetails.Visible = true;

                    int total = 0;

                    for (int i = 0; i < x.Rows.Count; i++)
                    {

                        total += Convert.ToInt32(x.Rows[i]["pPrice"]) * Convert.ToInt32(x.Rows[i]["pQuantity"]);
                      
                    }

                    P_total.InnerText = "$" + total.ToString();
                    Session["total"]= P_total.InnerText; 
                    C_total.InnerText = "$" + (5 + total).ToString();
                    Session["subTotal"] = C_total.InnerText;

                    rptrCart.DataSource = x;

                    rptrCart.DataBind();

                }
                else
                {
                    emptyCart.InnerText = "Your Shopping Cart is Empty";
                    PriceDetails.Visible = false;
                }


            }
            else
            {
                Response.Redirect("Login.aspx");
            }

        }

        protected void btnRemove_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string PID = btn.CommandArgument;
            var x = Session["dtShoppingCart"] as DataTable;
            


            for (int i = 0; i < x.Rows.Count; i++)
            {
                DataRow dr = x.Rows[i];
                if (dr["pID"].ToString() == PID)
                {
                    dr.Delete();
                    i -= 1;
                }
            }
            x.AcceptChanges();
            rptrCart.DataSource = x;

            rptrCart.DataBind();




        }



        protected void btnCheckout_Click(object sender, EventArgs e)
        {
            Response.Redirect("ShippingDetails.aspx");

        }

     

        //{
        //    Int64 P_ID = Convert.ToInt64(Request.QueryString["Product_ID"]);

        //    DataTable dtCart = Sql.fillDataTable("select * from Product where Product_ID=" + P_ID + "");
        //    rptrCart.DataSource = dtCart;
        //    rptrCart.DataBind();

        //}
    }
}