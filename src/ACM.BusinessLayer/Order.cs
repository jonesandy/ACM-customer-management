﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BusinessLayer
{
    class Order
    {
        public Customer Customer { get; set; }
        public DateTimeOffset? OrderDate { get; private set; }

        public Order()
        {

        }

        public bool Validate()
        {
            var isValid = true;
            if (OrderDate == null) isValid = false;

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
