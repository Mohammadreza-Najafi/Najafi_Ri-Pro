using Microsoft.AspNetCore.Mvc;
using Najafi_Rira_Pro.Application;
using Najafi_Rira_Pro.Domain;

namespace Najafi_Rira_Pro.Controllers
{
    public class ProductController : Controller
    {
        private IProductApplication _productApplication;

        public ProductController(IProductApplication productApplication)
        {
            _productApplication = productApplication;
        }
        
        public List<Product> getProductsByCategory()
        {
            return _productApplication.GetProductsByCategory(Categories.Category1);
        }

        public Product getProductHighPrice()
        {
            return _productApplication.GetProductHighPrice();
        }

        public int getTotalPrice()
        {
            return _productApplication.GetTotalPrice();
        }

        public List<IGrouping<Categories, Product>> groupProductsByCategory()
        {
            return _productApplication.GroupProductsByCategory();
        }

        public int getAvePrice()
        {
            return _productApplication.GetAvePrice();
        }
    }
}
