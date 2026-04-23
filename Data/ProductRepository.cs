using Furlong_UnitTest.Models;
using Microsoft.Data.SqlClient;
using System.Data.Common;

namespace Furlong_UnitTest.Data
{
    public class ProductRepository : IProductRepository
    {
        private readonly string _connectionString;

        public ProductRepository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection");
        }


        public List<Product> GetProducts()
        {


            List<Product> products = new List<Product>();


            using (var connection = new SqlConnection(_connectionString))
            {
                using (var command = new SqlCommand("GetAllProducts", connection))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    connection.Open();

                    using (var reader = command.ExecuteReader())

                    {
                        while (reader.Read())
                        {
                            products.Add(new Product
                            {
                                ProductName = reader["ProductName"].ToString(),
                                Category = reader["Category"].ToString(),
                                Price = Convert.ToDecimal(reader["Price"]),
                                StockQuantity = Convert.ToInt32(reader["StockQuantity"])
                            
                            
                            
                            
                            });
                        
                        
                        
                        
                        
                        
                        }

                   
                    
                    
                    
                    
                    
                    }
                
                
                
                
                
                }
                return products;
            }
        }

        public void CreateProduct(Product product)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                using (var command = new SqlCommand("InsertProduct", connection))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@ProductId", product.ProductId);
                    command.Parameters.AddWithValue("@ProductName", product.ProductName);
                    command.Parameters.AddWithValue("@Category", product.Category);
                    command.Parameters.AddWithValue("@Price", product.Price);
                    command.Parameters.AddWithValue("@StockQuantity", product.StockQuantity);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }



        }
    }
}
