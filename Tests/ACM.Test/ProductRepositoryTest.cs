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

        [Fact]
        public void SaveTestValid()
        {
            //-- Arrange
            var productRepository = new ProductRepository();
            var updatedProduct = new Product(2)
            {
                CurrentPrice = 18M,
                ProductDescription = "Licence to Kill",
                ProductName = "Die another Day",
                HasChanges = true
            };

            //-- Act
            var actual = productRepository.Save(updatedProduct);

            //-- Assert
            Assert.Equal(true, actual);
        }

        [Fact]
        public void SaveTestMissingPrice()
        {
            //-- Arrange
            var productRepository = new ProductRepository();
            var updatedProduct = new Product(2)
            {
                CurrentPrice = null,
                ProductDescription = "Licence to kill",
                ProductName = "Die another Day",
                HasChanges = true
            };

            //-- Act
            var actual = productRepository.Save(updatedProduct);

            //-- Assert
            Assert.Equal(false, actual);
        }
    }
}
