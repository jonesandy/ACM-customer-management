using System;

namespace ACM.BusinessLayer
{
    public class Customer
    {
        public static int CustomerCount { get; private set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName => GenerateFullName();
        public string EmailAddress { get; set; }
        public Guid CustomerId { get; private set; }


        public Customer()
        {
            CustomerCount++;
        }

        private string GenerateFullName()
        {
            string fullName = LastName;

            if(!string.IsNullOrEmpty(FirstName))
            {
                if(!string.IsNullOrEmpty(fullName))
                {
                    fullName += ", ";
                }
                fullName += FirstName;
            }

            return fullName;
        }
    }
}
