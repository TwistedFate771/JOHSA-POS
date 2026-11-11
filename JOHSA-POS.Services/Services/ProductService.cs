
using System.Collections.Generic;
using JOHSA_POS.Domain;
using JOHSA_POS.Data.Repositories;

namespace JOHSA_POS.Services.Services
{
    public sealed class ProductService
    {
        private readonly ProductRepository productRepository;

        public ProductService()
        {
            productRepository = new ProductRepository();
        }

        public List<Product> GetAllProducts()
        {
            return productRepository.GetAll();
        }

        public int AddProduct(Product product)
        {
            return productRepository.Create(product);
        }

        public void UpdateProduct(Product product)
        {
            productRepository.Update(product);
        }

        public void DeleteProduct(int productId)
        {
            productRepository.Delete(productId);
        }

        public List<KeyValuePair<int, string>> GetCategories()
        {
            CategoryRepository categoryRepository =
                new CategoryRepository();

            return categoryRepository.GetAll();
        }
    }
}
