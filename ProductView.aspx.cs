using Second.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Second
{
    public partial class ProductView : System.Web.UI.Page
    {
        ShoppingCart sc = new ShoppingCart();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindProductViewRptr();
            }
            if (Session["userName"] == null)
            {
                Response.Redirect("login.aspx");
            }

        }

        private void BindProductViewRptr()
        {

            int P_ID = Convert.ToInt32(Request.QueryString["Product_ID"]);
            //Sql sql_ = new Sql();
            //DataTable cmd = sql_.fillDataTable("select * from Product");

            //using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
            //{
            //DataTable dtProducts = Sql.getProd();
            DataTable dtProductView = Sql.getProduct(P_ID);//.fillDataTable("select * from dbo.Product where Product_ID=" + P_ID + "");

            //sda.Fill(dtProducts);
            rptrProductView.DataSource = dtProductView;
            rptrProductView.DataBind();

            //}        }
        }

        protected void btnAddToCart_Click(object sender, EventArgs e)
        {
            int P_ID = Convert.ToInt32(Request.QueryString["Product_ID"]);
            DataTable dtProductView = Sql.getProduct(P_ID);
            if (dtProductView.Rows.Count == 0){
                return;
            }
            //tbQuantity.;
            DataRow dr = dtProductView.Rows[0];
            int qu = Convert.ToInt32(Request.Form["tbQuantity"]);
            clsItems _item = new clsItems()
            { Prod_Id=Convert.ToInt32(dr["Product_ID"]), Price = Convert.ToDouble(dr["P_Price"]), Prod_Name=dr["P_Name"].ToString() ,Quantity = qu, Prod_img = dr["P_img"].ToString() };
            
            clsShoppingCart objSC = new clsShoppingCart();
            DataTable x = objSC.addItemRow(_item);
            Session["dtShoppingCart"] = x;

            //DataTable dt = Session["dtShoppingCart"] as DataTable;
            //if (Request.Cookies["Cart_ID"] != null)
            //{
            //    string CookiePID = Request.Cookies["Cart_ID"].Value.Split('=')[1];
            //    CookiePID = CookiePID + "," + P_ID;
            //    HttpCookie CartProducts = new HttpCookie("Cart_ID");
            //    CartProducts.Values["Cart_ID"] = CookiePID.ToString();
            //    CartProducts.Expires = DateTime.Now.AddDays(30);
            //    Response.Cookies.Add(CartProducts);

            //}
            //else
            //{

            //    HttpCookie CartProducts = new HttpCookie("Cart_ID");
            //    CartProducts.Values["Cart_ID"] = P_ID.ToString();
            //    CartProducts.Expires = DateTime.Now.AddDays(30);
            //    Response.Cookies.Add(CartProducts);

            //}
        }
    }
}