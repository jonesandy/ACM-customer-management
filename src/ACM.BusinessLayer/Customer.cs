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
        public int CustomerId { get; set; }


        public Customer()
        {
            CustomerCount++;
        }
        
        public Customer(int id)
        {
            CustomerId = id;
        }

        /// <summary>
        /// Validates that key properties are not empty or null
        /// </summary>
        public bool ValidCustomerData()
        {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
            if (string.IsNullOrWhiteSpace(EmailAddress)) isValid = false;

            return isValid;
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
