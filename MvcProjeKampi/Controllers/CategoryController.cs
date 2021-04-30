using BusinessLayer.Concrete;
using EntityLayer.Concrete;
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
        CategoryManager cm = new CategoryManager();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetCategoryList()
        {
            //var categoryvalues = cm.GetAllBL(); //category manager sınıfından verileri aldık.

            return View(); //bize geriye aldığımız verileri döndür
        }

        [HttpGet]//sayfa yüklendiğinde çalışır
        public ActionResult AddCategory()
        {
            return View();
        }



        [HttpPost] //Sayfaya tıklandığında çalışır
        public ActionResult AddCategory(Category cat)
        {
            //cm.CategoryAddBL(cat); //catorgy managerden yer alan metotu kullandık.

            //ekleme işleminden sonra "  "   metota yönlendir.
            return RedirectToAction("GetCategoryList");  


        }
    }
}