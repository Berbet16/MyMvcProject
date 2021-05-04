using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Repositories;
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
        ICategoryDal _categorydal;

        //yapıcı metot
        public CategoryManager(ICategoryDal categorydal)
        {
            _categorydal = categorydal;
        }

        public void CategoryAdd(Category category)
        {
            _categorydal.Insert(category);
        }

        public List<Category> GetList()
        {
            return _categorydal.List();
        }

        //public void CategoryAddBl(Category p)
        //{
        //    if (p.CategoryName == "" || p.CategoryStatus == false || p.CategoryName.Length <= 2)
        //    {
        //        //hata mesajı
        //    }
        //    else
        //    {
        //        _categorydal.Insert(p);
        //    }
        //}


    }
}
