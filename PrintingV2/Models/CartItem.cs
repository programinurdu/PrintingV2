using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace PrintingV2.Models
{
    public class CartItem
    {
        [DisplayName("Item Name")]
        public string ItemName { get; set; }
        
        public int Quantity { get; set; }

        [DisplayName("Unit Price")]
        public decimal UnitPrice { get; set; }

        [DisplayName("Total Price")]
        public decimal TotalPrice { get; set; }
    }
}
