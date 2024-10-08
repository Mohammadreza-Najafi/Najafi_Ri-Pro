using Najafi_Rira_Pro.Domain;

namespace Najafi_Rira_Pro.Application
{
    public interface IProductApplication
    {
        public List<Product> GetProductsByCategory(Categories categories);
        public Product GetProductHighPrice();
        public int GetTotalPrice();
        public List<IGrouping<Categories, Product>> GroupProductsByCategory();
        public int GetAvePrice();
    }
}
