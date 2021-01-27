using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BusinessLayer
{
    class OrderItem
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public decimal? PurchasePrice { get; set; }

        public OrderItem()
        {

        }

        public bool Validate()
        {
            var isValid = true;
            if (Quantity < 1) isValid = false;
            if (PurchasePrice == null) isValid = false;

            return isValid;
        }

        public void Retrieve()
        {

        }

        public void Save()
        {

        }
    }
}
