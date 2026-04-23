using Furlong_UnitTest.Data;
using Furlong_UnitTest.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Furlong_UnitTest.Pages
{
    public class IndexModel : PageModel
    {



        private readonly IProductRepository productRepository;

        public IndexModel(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }


        public List<Product> Products { get; set; }

        public void OnGet()
        {
            Products = productRepository.GetProducts();
        }
    }
}
