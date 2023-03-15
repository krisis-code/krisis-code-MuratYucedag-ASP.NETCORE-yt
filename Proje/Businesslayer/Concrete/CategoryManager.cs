using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Businesslayer.Abstract;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;

namespace Businesslayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        GenericRepository<Category> repo = new GenericRepository<Category>();
        public void CategoryAdd(Category category)
        {
            throw new NotImplementedException(); 

        }

        public void CategoryDelete(Category category)
        {
            throw new NotImplementedException();
        }

        public Category CategoryGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Category> CategoryList()
        {
            throw new NotImplementedException();
        }

        public void CategoryUpdate(Category category)
        {
            throw new NotImplementedException();
        }
    }
}
