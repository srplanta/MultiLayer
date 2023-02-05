using BOL;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public interface ICategoryBs
    {
        public IEnumerable<Category> GetAll();
        public Category GetById(int id);
        public bool Insert(Category category);
        public bool Delete(int id);
        public bool Update(Category category);
    }
    //*****************************************************************************
    //********************* ICATEGORY INTERFACE ENDS ******************************
    //*****************************************************************************

    public class CategoryBs : ICategoryBs
    {
        private readonly ICategoryDb ICategoryDb;

        public CategoryBs(ICategoryDb iCategoryDb)
        {
            ICategoryDb = iCategoryDb;
        }

        public IEnumerable<Category> GetAll()
        {
            return ICategoryDb.GetAll();
        }

        public Category GetById(int id)
        {
            return ICategoryDb.GetById(id);
        }

        public bool Insert(Category category)
        {
            return ICategoryDb.Insert(category);
            //return true; CategoryDb.Insert already returns true
        }

        public bool Delete(int id)
        {
            return ICategoryDb.Delete(id);
            //return true; CategoryDb.Delete already returns true
        }

        public bool Update(Category category)
        {
            return ICategoryDb.Update(category);
            //return true; CategoryDb.Update already returns true
        }
    }
}
