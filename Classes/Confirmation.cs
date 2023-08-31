using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;

namespace Second
{
    public class Confirmation_
    {
        //public DataTable Confirmation_()
        //{
        //   return getRow();
        //}

        public static int getCount()
        {
            var x=Sql.getAllShipping();
            int count = x.Rows.Count;
            return count;
        }

        public static DataTable getRow()
        {
            int count_ = getCount();
            return Sql.fillDataTable("select * from ShippingInfo where [ShippingID]=" + count_ + "");
        }
    }
}