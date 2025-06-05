using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects;
using DataAccessLayer;

namespace Repositories
{
    public interface ProductRepository : IProductRepository
    {
        public void SaveProduct(Product p) => ProductDAO.SaveProduct(p);
        public void DeleteProduct(Product p) => ProductDAO.DeleteProduct(p);
        public void UpdateProduct(Product p) => ProductDAO.UpdateProduct(p);
        public List<Product> GetProducts() => ProductDAO.GetProducts();
        public Product GetProductById(int id) => ProductDAO.GetProductById(id);
    }
}
