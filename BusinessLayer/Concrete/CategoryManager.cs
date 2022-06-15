using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFreamwork;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDAL _categoryDAL;
        public CategoryManager(ICategoryDAL categoryDAL)
        {
            _categoryDAL = categoryDAL;
        }

        public void Add(Category category)
        {
            _categoryDAL.Insert(category);
        }

        public void Delete(Category category)
        {
            _categoryDAL.Delete(category);
        }

        public Category GetByID(int id)
        {
            return _categoryDAL.GetByID(id);

        }

        public List<Category> GetList()
        {
            return _categoryDAL.ListAll();
        }

        public void Update(Category category)
        {
            _categoryDAL.Update(category);
        }
    }
}
