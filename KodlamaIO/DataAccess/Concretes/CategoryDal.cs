using KodlamaIO.DataAccess.Abstracts;
using KodlamaIO.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIO.DataAccess.Concretes
{
    public class CategoryDal : ICategoryDal
    {
        private List<Category> _categories;
        public CategoryDal() {
            _categories = new List<Category>()
            {
                new Category()
                {
                    CategoryName = "C#",
                    Id = 1,
                    CourseId = 1,
                }
            };
        }
        public void Add(Category category)
        {
            _categories.Add(category);
        }

        public void Delete(Category category)
        {
            _categories.RemoveAll(c=> c.Id == category.Id); 
        }

        public List<Category> GetCategories()
        {
            return _categories;
        }

        public void Update(Category category)
        {
            Console.Write("ID: ");
            int Id;
            if (int.TryParse(Console.ReadLine(), out Id))
            {
                Console.WriteLine("New course information: ");
                Category updatedCategory = new Category { Id = Id };

                Console.Write("New course name: ");
                updatedCategory.CategoryName = Console.ReadLine();

                Category categoryToUpdate = _categories.FirstOrDefault(c => c.Id == updatedCategory.Id);

                if (categoryToUpdate != null)
                {
                    categoryToUpdate.CategoryName = updatedCategory.CategoryName;
                    Console.WriteLine("Success");
                    GetCategories();
                }
                else
                {
                    Console.WriteLine("Category with the specified ID not found.");
                }
            }
        }
    }
    }
}
