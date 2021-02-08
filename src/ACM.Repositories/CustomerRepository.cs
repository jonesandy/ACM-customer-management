using ACM.BusinessLayer;
using System;

namespace ACM.Repositories
{
    public class CustomerRepository
    {
        public Customer Retrieve(int id)
        {
            // Generic code for the sake of testing

            Customer customer = new Customer(id);

            if (id == 1)
            {
                customer.EmailAddress = "fbaggins@hobbiton.me";
                customer.FirstName = "Frodo";
                customer.LastName = "Baggins";
            }

            return customer;
        }

        public bool Save(Customer customer)
        {
            // Generic code for the sake of testing

            return true;
        }
    }
}
