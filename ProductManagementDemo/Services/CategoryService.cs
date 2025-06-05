using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects;

namespace Services
{
   
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository iCategoryRepository;
        public List<Category> GetCategories()
        {
            return iCategoryRepository.GetCategories();
        }
    }
}
