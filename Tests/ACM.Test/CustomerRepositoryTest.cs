using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ACM.Test
{
    public class CustomerRepositoryTest
    {
        [Fact]
        public void RetrieveValid()
        {
            // Arrange
            var customerRepository = new CustomerRepository();
            var expected = new Customer(1)
            {
                EmailAddress = "FoxMulder@Gmail.com",
                FirstName = "Fox",
                LastName = "Mulder"
            };

            // Act
            var actual = customerRepository.Retrieve(1);
            // Assert
            Assert.Equal(expected.CustomerId, actual.CustomerId);
            Assert.Equal(expected.EmailAddress, actual.EmailAddress);
            Assert.Equal(expected.FirstName, actual.FirstName);
            Assert.Equal(expected.LastName, actual.LastName);
        }

        [Fact]
        public void RetrieveExistingWithAddress()
        {
            // Arrange
            var customerRepository = new CustomerRepository();
            var expected = new Customer(1)
            {
                EmailAddress = "FoxMulder@Gmail.com",
                FirstName = "Fox",
                LastName = "Mulder",
                AddressList = new List<Address>()
                {
                    new Address()
                    {
                        AddressType = 1,
                        StreetLine1 = "Piles Road",
                        StreetLine2 = "Cathays",
                        City = "Cardiff",
                        County = "Glamorgan",
                        Country = "Wales",
                        PostalCode = "CF24 4BW"
                    },
                    new Address()
                    {
                        AddressType = 2,
                        StreetLine1 = "Flora Street",
                        StreetLine2 = "Cathays",
                        City = "Cardiff",
                        County = "Glamorgan",
                        Country = "Wales",
                        PostalCode = "CF24 4EQ"
                    }
                }
            };
            // Act
            var actual = customerRepository.Retrieve(1);

            // Assert
            Assert.Equal(expected.CustomerId, actual.CustomerId);
            Assert.Equal(expected.EmailAddress, actual.EmailAddress);
            Assert.Equal(expected.FirstName, actual.FirstName);
            Assert.Equal(expected.LastName, actual.LastName);

            for (int i = 0; i < 1; i++)
            {
                Assert.Equal(expected.AddressList[i].AddressType, actual.AddressList[i].AddressType);
                Assert.Equal(expected.AddressList[i].StreetLine1, actual.AddressList[i].StreetLine1);
                Assert.Equal(expected.AddressList[i].City, actual.AddressList[i].City);
                Assert.Equal(expected.AddressList[i].County, actual.AddressList[i].County);
                Assert.Equal(expected.AddressList[i].Country, actual.AddressList[i].Country);
                Assert.Equal(expected.AddressList[i].PostalCode, actual.AddressList[i].PostalCode);
            }
        }
    }
}
