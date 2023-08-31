using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Second.Classes
{
    public class clsShoppingCart
    {
        public static DataTable Item_List { get; set; }

        public clsShoppingCart()
        {
            if (Item_List == null)
            {
                Item_List = new DataTable();
                Item_List.Columns.Add(new DataColumn("pID", typeof(Int32)));
                Item_List.Columns.Add(new DataColumn("pName", typeof(String)));
                Item_List.Columns.Add(new DataColumn("pPrice", typeof(Int32)));
                Item_List.Columns.Add(new DataColumn("pQuantity", typeof(Int32)));
                Item_List.Columns.Add(new DataColumn("pImg", typeof(String)));


            }
        }

        public static DataTable getTable()
        {
            return Item_List;
        }

        public  DataTable addItemRow(clsItems item)
        {
            if (item == null)
            {
                return null;
            }
            //if (Item_List == null)
            //{
            //    new clsShoppingCart();
            //}

            int count = 0;
            bool quantityGiven = false;
            DataRow dr = Item_List.NewRow();
            
            if (item.Quantity>1)
            {
                count = item.Quantity;
                quantityGiven = true;
            }
            else
            {
                count++;
            }
            
            if (Item_List.Rows.Count>0 && Item_List.Select("pID = " + item.Prod_Id).FirstOrDefault() !=null )
            {
                DataRow dr_ = Item_List.Select("pID = " + item.Prod_Id).FirstOrDefault();
                
                if (dr_.ItemArray.Count() > 0)
                {
                    int _count = Convert.ToInt32(dr_["pQuantity"]);

                    dr_["pQuantity"] = count+_count;//quantityGiven? count: count +1;
                                                    //Item_List.Rows.Remove(i[0]);
                                                    //return Item_List;

                    return Item_List;
                }
            }
            else
            {
                dr["pID"] = item.Prod_Id;
                dr["pName"] = item.Prod_Name;
                dr["pPrice"] = item.Price;
                dr["pQuantity"] = count;
                dr["pImg"] = item.Prod_img;
                Item_List.Rows.Add(dr);
            }
            
            
            return Item_List;
        }
        //public int quantity { get; set; }
    }


}