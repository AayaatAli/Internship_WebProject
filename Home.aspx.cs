using System;
using System.Collections.Generic;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Second.Classes;

namespace Second
{
    public partial class Home : System.Web.UI.Page
    {
        //public static clsShoppingCart shopping_Cart;

        //public static clsItems _items;
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                BindProductsRptr();
            }



            if (Session["userName"] != null)
            {


                sessionlbl.Text = String.Empty;
                String strUname = Session["userName"] as String;
                if (!String.IsNullOrEmpty(strUname))
                {
                    //String t = Session["Email"].ToString()?? null;
                    //String x = Session["Email"] as String;
                    sessionlbl.Text = "Welcome " + strUname;
                    //shopping_Cart = new clsShoppingCart();

                }
            }
            else
            {
               
                Response.Redirect("login.aspx");
            }


            //protected void AddItem(object sender, EventArgs e)



            //{
            //    int price = int.Parse(PZ2.Text);

            //    Sql sql_ = new Sql();
            //    DataTable dt = sql_.fillDataTable("insert into dbo.Cart ([P_Name],[P_Quantity],[T_Price]) values ('" + P2.Text + "','" + 1 + "','" + price + "')");

            //    Response.Redirect("Home.aspx");

            //}





        }

        private void BindProductsRptr()
        {

            //Sql sql_ = new Sql();
            //DataTable cmd = sql_.fillDataTable("select * from Product");

            //using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
            //{
            DataTable dtProducts = Sql.getAllProd();
            //sda.Fill(dtProducts);
            rptrProducts.DataSource = dtProducts;
            rptrProducts.DataBind();

            //}



        }

        protected void btnAddToCart_Click(object sender, EventArgs e)
        {

            //var x =Eval("P_Name").ToString();
            //DataBinder.Eval(GetDataItem(), "P_Name");


            int P_ID = Convert.ToInt32(Request.QueryString["Product_ID"]);
            //List<int> pids = new List<int> { 1, 4, 5, 7 };
            string userID = Session["userID"].ToString();
            string Product_ID = Session["Product_ID"].ToString();
            string P_Name = Session["P_Name"].ToString();
            string P_Price = Session["P_Price"].ToString();
            string P_img = Session["P_img"].ToString();


            DataTable dtCart = Sql.fillDataTable("insert into dbo.Cart ([userID],[Product_ID] values ('" + Convert.ToInt64(userID) + "','" + Convert.ToInt64(Product_ID) + "')");


























            //Int64 P_ID = Convert.ToInt64(Request.QueryString["Product_ID"]);

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