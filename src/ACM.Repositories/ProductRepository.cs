using ACM.BusinessLayer;

namespace ACM.Repositories
{
    class ProductRepository
    {
        public Product Retrieve()
        {
            Product product = new Product("phone");

            product.Description = "A phone";
            product.CurrentPrice = 1;

            return product;
        }

        public bool Save(Product product)
        {
            // Generic code for the sake of testing

            return true;
        }
    }
}
