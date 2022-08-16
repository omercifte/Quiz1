using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deneme
{
    public class ProductDal
    {
        
        
            public List<Product> GetAll()
            {
                SqlConnection connection = new SqlConnection(@"server=(localdb)\ProjectModels;initial catalog=quiz1;integrated security=true");
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                SqlCommand command = new SqlCommand("Select * from Products", connection);

                SqlDataReader reader = command.ExecuteReader();

                List<Product> products = new List<Product>();

                while (reader.Read())
                {

                    Product product = new Product
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        Name = reader["Name"].ToString(),
                        Stock = Convert.ToInt32(reader["Stock"]),
                        Price = Convert.ToDecimal(reader["Price"]),
                    };
                    products.Add(product);
                }

                reader.Close();
                connection.Close();
                return products;
            }
    }
    
}
