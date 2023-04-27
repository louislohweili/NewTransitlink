using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NewTransitlink.Models
{
    public class CartItem
    {


        public int Qty
        {
            get;
            set;
        }

        public  Product Product { get; set; }
    }
}