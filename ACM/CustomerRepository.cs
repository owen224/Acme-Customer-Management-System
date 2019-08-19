using System.Linq;

namespace ACM
{
    public class CustomerRepository
    {
        public CustomerRepository()
        {
            addressRepository = new AddressRepository();
        }
        private AddressRepository addressRepository {get; set; }
        /// <summary>
        /// Retrieve one Customer.
        /// </summary>
        /// <returns></returns>
        public Customer Retrieve(int customerId)
        {
            // Create the instance of the Customer class
            // Pass in the requested id
            Customer customer = new Customer(customerId);

            // Code that reyrieves the defined customer

            // Temporary hard-coded values to return
            // a populated customer
            if (customerId == 1)
            {
                customer.EmailAddress = "FoxMulder@Gmail.com";
                customer.FirstName = "Fox";
                customer.LastName = "Mulder";
                customer.AddressList = addressRepository.RetrieveByCustomerId(customerId).ToList();
            }
            return customer;
        }

        /// <summary>
        /// Saves the curent order.
        /// </summary>
        /// <returns></returns>
        public bool Save(Customer customer)
        {
            // Code that saves the passed in customer.
            return true;
        }
    }
}
