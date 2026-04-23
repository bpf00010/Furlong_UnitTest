using System.ComponentModel.DataAnnotations;

namespace Furlong_UnitTest.Models
{
    public class Product
    {


        [Key]
        public int ProductId { get; set; }





        public string ProductName { get; set; }

        public string Category { get; set; }

        public decimal Price { get; set; }

        public int StockQuantity { get; set; }








    }
}
