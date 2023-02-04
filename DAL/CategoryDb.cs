using BOL;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface ICategoryDb
    {
        public IEnumerable<Category> GetAll();
        public Category GetById(int id);
        public bool Insert(Category category);
        public bool Update(Category category);
        public bool Delete(int id);
    }
    //*****************************************************************************
    //********************* ICATEGORY INTERFACE ENDS ******************************
    //*****************************************************************************

    public class CategoryDb : ICategoryDb
    {
        private ApplicationDbContext dbContext;
        public CategoryDb(ApplicationDbContext _dbContext)
        {
            dbContext = _dbContext;
        }

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
