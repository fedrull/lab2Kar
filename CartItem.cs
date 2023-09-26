using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_2_2._0
{
    internal  class CartItem
    {
        public Product productItem
        {
            get; 
            private set;   
        }
        public int quantity  { get; set; } = 0;
       

        public override string ToString()
        {
            return ($"{quantity} st, {productItem.Name}, {productItem.Price}, total: {productItem.Price * quantity}");
        }
        public bool MatchingItems(string item)
        {
             return this.productItem.Name.Equals(item);
        }

        public CartItem (Product item, int quantity)
        {
            this.productItem = item;
            this.quantity = quantity;   
        }

       


    }
}
