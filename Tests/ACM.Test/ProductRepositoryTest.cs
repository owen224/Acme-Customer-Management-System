using Xunit;

namespace ACM.Test
{
    public class ProductRepositoryTest
    {
        [Fact]
        public void RetrieveTest()
        {
            //-- Arrange
            var productRepository = new ProductRepository();
            var expected = new Product(2)
            {
                CurrentPrice = 15.96M,
                ProductDescription = "Licence to kill",
                ProductName = "Die another Day"
            };

            //-- Act
            var actual = productRepository.Retrieve(2);

            //-- Assert
            Assert.Equal(expected.CurrentPrice, actual.CurrentPrice);
            Assert.Equal(expected.ProductDescription, actual.ProductDescription);
            Assert.Equal(expected.ProductName, actual.ProductName);
        }
    }
}