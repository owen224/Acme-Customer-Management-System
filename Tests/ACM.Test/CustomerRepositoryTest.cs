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

    }
}
