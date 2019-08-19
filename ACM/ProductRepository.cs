﻿using System;

namespace ACM
{
    public class ProductRepository
    {
        /// <summary>
        /// Retrieve one product.
        /// </summary>
        public Product Retrieve(int productId)
        {
            // Create the instance of the Product class
            // Pass in the requested Id
            Product product = new Product(productId);

            // Code that retrieves the defined product

            // Temporary hard-coded values to return 
            // a populated product
            if (productId == 2)
            {
                product.ProductName = "Die another Day";
                product.ProductDescription = "Licence to kill";
                product.CurrentPrice = 15.96M;
            }
            return product;
        }

        /// <summary>
        /// Saves the current product.
        /// </summary>
        /// <returns></returns>
        public bool Save(Product product)
        {
            // Code that saves the passed in product

            return true;
        }
    }
}
