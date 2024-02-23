using KodlamaIO.DataAccess.Abstracts;
using KodlamaIO.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIO.Business
{
    public class CategoryManager
    {
        private readonly ICategoryDal _categoryDal;
        public CategoryManager(ICategoryDal categoryDal) {
            _categoryDal = categoryDal;
        }
        public List<Category> GetAllCategories() {
            return _categoryDal.GetCategories();
        }
    }
}
