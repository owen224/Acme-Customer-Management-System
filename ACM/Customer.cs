using System.Collections.Generic;

namespace ACM
{
    public class Customer
    {
        public Customer()
        {

        }

        public Customer(int customerId)
        {
            CustomerId = customerId;
        }

        public int CustomerId { get; private set; }
        public string EmailAddress { get; set; }
        public string WorkAddress { get; set; }
        public static int InstanceCount { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName
        {
            get
            {
                string fullName = LastName;
                if (!string.IsNullOrWhiteSpace(FirstName))
                {
                    if (!string.IsNullOrWhiteSpace(fullName))
                    {
                        fullName += ", ";
                    }
                    fullName += FirstName;
                }
                return fullName;
            }
        }

        /// <summary>
        /// Retrieve one customer.
        /// </summary>
        /// <returns></returns>
        public Customer Retrieve(int customerId)
        {
            return new Customer();
        }

        /// <summary>
        /// Retrieve all customers.
        /// </summary>
        /// <returns></returns>
        public List<Customer> Retrieve()
        {
            return new List<Customer>();
        }

        /// <summary>
        /// Saves the curent customer.
        /// </summary>
        /// <returns></returns>
        public bool Save()
        {
            return true;
        }
        /// <summary>
        /// Validates the customer data.
        /// </summary>
        /// <returns></returns>
        public bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
            if (string.IsNullOrWhiteSpace(EmailAddress)) isValid = false;

            return isValid;
        }
    }
}
