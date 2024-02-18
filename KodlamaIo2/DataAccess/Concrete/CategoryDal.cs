using KodlamaIo2.DataAccess.Abstract;
using KodlamaIo2.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIo2.DataAccess.Concrete
{
    public class CategoryDal : ICategoryDal
    {
        List<Category> categories;
        public CategoryDal()
        {
            Category category1 = new Category();
            category1.Id = 1;
            category1.Name = "BackEnd";

            Category category2 = new Category();
            category2.Id = 2;
            category2.Name = "FrontEnd";

            categories = new List<Category>() { category1,category2};
        }
        public void Add(Category category)
        {
            categories.Add(category);
        }

        public void Delete(Category category)
        {
            Category categoryToRemove = categories.FirstOrDefault(c => c.Id == category.Id);
            if (categoryToRemove != null) 
            {
                categories.Remove(categoryToRemove);
            }
            else
            {
                Console.WriteLine("Kategori bulunamadı.");
            }
        }

        public List<Category> GetAll()
        {
            return categories;
        }
    }
}
