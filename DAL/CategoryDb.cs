using BOL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CategoryDb
    {
        private ApplicationDbContext dbContext = new ApplicationDbContext();
        public IEnumerable<Category> GetAll()
        {   // IEnumerable cannot be manipulated by the user
            // List can be manipulated
            return dbContext.Category;
        }

        public Category GetById(int id)
        {
            return dbContext.Category.Find(id);
        }

        public bool Insert(Category category)
        {
            dbContext.Category.Add(category);
            dbContext.SaveChanges();
            return true;
        }

        public bool Update(Category category)
        {
            dbContext.Category.Update(category);
            dbContext.SaveChanges();
            return true;
        }
        
        public bool Delete(int id)
        {
            dbContext.Category.Remove(dbContext.Category.Find(id));
            dbContext.SaveChanges();
            return true;
        }
    }
}
