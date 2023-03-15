using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Businesslayer.Abstract;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using DataAccessLayer.EntityFramework;

namespace Businesslayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        EfCategoryRepository efCategoryRepository;

        public CategoryManager()
        {
            efCategoryRepository = new EfCategoryRepository();
        }
        public void CategoryAdd(Category category)
        {
            efCategoryRepository.Insert(category);

        }

        public void CategoryDelete(Category category)
        {
            efCategoryRepository.Delete(category);
        }

        public Category CategoryGetById(int id)
        {
            return efCategoryRepository.GetById(id);
        }

        public List<Category> CategoryList()
        {
            return efCategoryRepository.GetListAll();
        }

        public void CategoryUpdate(Category category)
        {
            efCategoryRepository.Update(category);
        }
    }
}
