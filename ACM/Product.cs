namespace ACM
{
    public class Product
    {
        public Product()
        {

        }

        public Product(int productId)
        {
            ProductId = productId;
        }
        public int ProductId { get; private set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public decimal? CurrentPrice { get; set; }

        /// <summary>
        /// Retrieve one item.
        /// </summary>
        /// <returns></returns>
        public Product Retrieve(int productId)
        {
            return new Product();
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
        /// Validates the product data.
        /// </summary>
        /// <returns></returns>
        public bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(ProductName)) isValid = false;
            if (CurrentPrice == null) isValid = false;

            return isValid;
        }
    }
}
