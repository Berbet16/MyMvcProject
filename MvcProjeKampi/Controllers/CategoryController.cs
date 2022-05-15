using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        //Category dan verileri çekmemiz için yeni nesne oluşturduk
        CategoryManager cm = new CategoryManager(new EfCategoryDal());

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetCategoryList()
        {
            var categoryvalues = cm.GetList(); //category manager sınıfından verileri aldık.

            return View(categoryvalues); //bize geriye aldığımız verileri döndür
        }

        [HttpGet]//sayfa yüklendiğinde çalışır
        public ActionResult AddCategory()
        {
            return View();
        }

        [HttpPost] //Sayfaya tıklandığında çalışır
        public ActionResult AddCategory(Category p)
        {
            //cm.CategoryAddBL(p); //catorgy managerden yer alan metotu kullandık.
            //ekleme işleminden sonra "  "   metota yönlendir.
            CategoryValidatior categoryValidator = new CategoryValidatior();
            ValidationResult results = categoryValidator.Validate(p); //results değişkeni gelen değerlere göre kontrol ediyor
            if(results.IsValid)
            {
                cm.CategoryAdd(p);
                return RedirectToAction("GetCategoryList");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    //modele error ları ekliyoruz (önce ne üzerinde çalışıyorsak,hatanın kendisi)
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }

            return View();


        }
    }
}
