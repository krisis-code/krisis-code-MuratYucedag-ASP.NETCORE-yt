using DataAccessLayer.Abstract;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfCategoryRepository : GenericRepository<Category>, ICategoryDal
    {
        public void Delete(Blog t)
        {
            throw new NotImplementedException();
        }

        public void Insert(Blog t)
        {
            throw new NotImplementedException();
        }

        public void Update(Blog t)
        {
            throw new NotImplementedException();
        }

        Blog IGenericDal<Blog>.GetById(int id)
        {
            throw new NotImplementedException();
        }

        List<Blog> IGenericDal<Blog>.GetListAll()
        {
            throw new NotImplementedException();
        }
    }
}
