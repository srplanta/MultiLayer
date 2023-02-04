using BOL;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CategoryBs
    {
        CategoryDb CategoryDb = new CategoryDb();

        public IEnumerable<Category> GetAll()
        {
            return CategoryDb.GetAll();
        }

        public Category GetById(int id)
        {
            return CategoryDb.GetById(id);
        }

        public bool Insert(Category category)
        {
            return CategoryDb.Insert(category);
            //return true; CategoryDb.Insert already returns true
        }

        public bool Delete(int id)
        {
            return CategoryDb.Delete(id);
            //return true; CategoryDb.Delete already returns true
        }

        public bool Update(Category category)
        {
            return CategoryDb.Update(category);
            //return true; CategoryDb.Update already returns true
        }
    }
}
