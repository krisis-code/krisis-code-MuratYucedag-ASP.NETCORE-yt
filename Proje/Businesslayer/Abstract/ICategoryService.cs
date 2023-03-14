using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businesslayer.Abstract
{
    public interface ICategoryService
    {
        void CategoryAdd(CategoryManager category);
        void CategoryDelete(CategoryManager category);
        void CategoryUpdate(CategoryManager category);
       List<CategoryManager> CategoryList();

       CategoryManager CategoryGetById(int id);

    }
}
