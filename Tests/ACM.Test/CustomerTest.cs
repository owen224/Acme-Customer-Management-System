using System;
using Xunit;

namespace ACM.Test
{
    public class CustomerTest
    {
        [Fact]
        public void FullNameTestValid()
        {
            // Arrange
            Customer customer = new Customer
            {
                FirstName = "Fox",
                LastName = "Mulder"
            };
            string expected = "Mulder, Fox";

            // Act
            string actual = customer.FullName;

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void FullNameFirstNameEmpty()
        {
            // Arrange
            Customer customer = new Customer
            {
                LastName = "Mulder"
            };
            string expected = "Mulder";

            // Act
            string actual = customer.FullName;

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void FullNameLastNameEmpty()
        {
            // Arrange
            Customer customer = new Customer
            {
                FirstName = "Fox",
            };
            string expected = "Fox";

            // Act
            string actual = customer.FullName;

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void StaticTest()
        {
            // Arrange
            var c1 = new Customer();
            c1.FirstName = "Fox";
            Customer.InstanceCount += 1;

            var c2 = new Customer();
            c2.FirstName = "Hank";
            Customer.InstanceCount += 1;

            var c3 = new Customer();
            c3.FirstName = "Boris";
            Customer.InstanceCount += 1;

            // Act

            // Assert
            Assert.Equal(3, Customer.InstanceCount);
        }

        [Fact]
        public void ValidateValid()
        {
            // Arrange
            var customer = new Customer
            {
                LastName = "Mulder",
                EmailAddress = "FoxMulder@Gmail.com"
            };

            var expected = true;

            // Act
            var actual = customer.Validate();

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ValidateMissingLastName()
        {
            // Arrange
            var customer = new Customer
            {
                EmailAddress = "FoxMulder@Gmail.com"
            };

            var expected = false;

            // Act
            var actual = customer.Validate();

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
