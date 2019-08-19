using System.Collections.Generic;

namespace ACM
{
    public class AddressRepository
    {
        /// <summary>
        /// Retrieve one address.
        /// </summary>
        public Address Retrieve(int addressId)
        {
            // Create the instance of the Address class
            // Pass in the requested Id
            Address address = new Address(addressId);

            // Code that retrieves the defined address

            // Temporary hard coded values to return 
            // a populated address
            if (addressId == 1)
            {
                address.AddressType = 1;
                address.StreetLine1 = "Piles Road";
                address.StreetLine2 = "Cathays";
                address.City = "Cardiff";
                address.County = "Glamorgan";
                address.Country = "Wales";
                address.PostalCode = "CF24 4BW";

            }
            return address;
        }

        public IEnumerable<Address> RetrieveByCustomerId(int customerId)
        {
            // Code that retrieves the defined addresses
            // for the customer.

            // Temporary hard-coded values to return 
            // a set of addresses for a customer
            var addressList = new List<Address>();
            Address address = new Address(1)
            {
                AddressType = 1,
                StreetLine1 = "Piles Road",
                StreetLine2 = "Cathays",
                City = "Cardiff",
                County = "Glamorgan",
                Country = "Wales",
                PostalCode = "CF24 4BW"
            };
            addressList.Add(address);

            address = new Address(2)
            {
                AddressType = 2,
                StreetLine1 = "Flora Street",
                City = "Cardiff",
                County = "Glamorgan",
                Country = "Wales",
                PostalCode = "CF24 4EQ"
            };
            addressList.Add(address);

            return addressList;
        }

        /// <summary>
        /// Saves the current address.
        /// </summary>
        /// <returns></returns>
        public bool Save(Address address)
        {
            // Code that saves the passed in address

            return true;
        }
    }
}