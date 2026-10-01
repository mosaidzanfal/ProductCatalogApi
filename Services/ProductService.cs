using ProductCatalogApi.Models;

namespace ProductCatalogApi.Services
{
    public class ProductService : IProductService
    {
        private static readonly List<Product> _products = new();

        public Task<IEnumerable<Product>> GetAllProductsAsync()
        {
            return Task.FromResult<IEnumerable<Product>>(_products);
        }

        public Task<Product?> GetProductByIdAsync(int id)
        {
            var product = _products.FirstOrDefault(p => p.Id == id);

            return Task.FromResult(product);
        }

        public Task<Product> CreateProductAsync(Product product)
        {
            product.Id = _products.Count == 0
                ? 1
                : _products.Max(p => p.Id) + 1;

            _products.Add(product);

            return Task.FromResult(product);
        }

        public Task<Product?> UpdateProductAsync(int id, Product product)
        {
            var existingProduct = _products.FirstOrDefault(p => p.Id == id);

            if (existingProduct == null)
            {
                return Task.FromResult<Product?>(null);
            }

            existingProduct.Name = product.Name;
            existingProduct.Description = product.Description;
            existingProduct.Price = product.Price;

            return Task.FromResult<Product?>(existingProduct);
        }

        public Task<bool> DeleteProductAsync(int id)
        {
            var product = _products.FirstOrDefault(p => p.Id == id);

            if (product == null)
            {
                return Task.FromResult(false);
            }

            _products.Remove(product);

            return Task.FromResult(true);
        }
    }
}