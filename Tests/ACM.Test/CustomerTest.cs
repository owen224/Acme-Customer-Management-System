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
            string expected = "Fox, Mulder";

            // Act
            string actual = customer.FullName;

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
