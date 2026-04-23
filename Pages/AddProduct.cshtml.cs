using Furlong_UnitTest.Data;
using Furlong_UnitTest.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Furlong_UnitTest.Pages
{
    public class AddProductModel : PageModel
    {


        private readonly IProductRepository productRepository;

        public AddProductModel(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }


        [BindProperty]
        public Product product { get; set; }




        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            productRepository.CreateProduct(product);
            return RedirectToPage("Index");






        }
    }
}
