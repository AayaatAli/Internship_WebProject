using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Second
{
    public class cls_Order
    {
        public String custID { get; set; }
        public List<items> items_ { get; set; }
    }

    public class items
    {
        public String itemName { get; set; }
        public int itemID { get; set; }
        public int quantity { get; set; }
        public Double price { get; set; }
        public string itemImg { get; set; }
    }
}