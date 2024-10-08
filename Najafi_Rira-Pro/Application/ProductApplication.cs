using Najafi_Rira_Pro.Domain;
using Najafi_Rira_Pro.Repository;

namespace Najafi_Rira_Pro.Application
{
    public class ProductApplication : IProductApplication
    {
        private List<Product> _products;

        public ProductApplication(ProductRepository productRepository)
        {
            _products = productRepository.Products;
        }

        public List<Product> GetProductsByCategory(Categories categories)
        {
             return _products.Where(p => p.Category == categories).ToList();
        }
        public Product GetProductHighPrice()
        {
            int maxPrice = _products.Max(p => p.Price);
            return _products.FirstOrDefault(p => p.Price == maxPrice);
        }

        public int GetTotalPrice()
        {
            return _products.Sum(p => p.Price);
        }
        public List<IGrouping<Categories, Product>> GroupProductsByCategory()
        {
            return _products.GroupBy(p => p.Category).ToList();
        }

        public int GetAvePrice()
        {
            return (int)_products.Average(p => p.Price);
        }
    }
}
