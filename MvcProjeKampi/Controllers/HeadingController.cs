using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class HeadingController : Controller
    {
        // GET: Heading
        HeadingManager hm = new HeadingManager(new EfHeadingDal());
        CategoryManager cm = new CategoryManager(new EfCategoryDal());
        WriterManager wm = new WriterManager(new EfWriterDal());

        public ActionResult Index()
        {
            var headingvalues = hm.GetList();
            return View(headingvalues);
        }

        [HttpGet]
        public ActionResult AddHeading()
        {
            //Catgeory sınıfındaki değerleri name ve id olarak tutacak
            //listeden seçilecek bir değer , category tablosuna gitmemiz için nesne türettik üst tarafta
            List<SelectListItem> valuecategory = (from x in cm.GetList() select new SelectListItem
            {
                //biz verileri  dropdown olaak tutuyoruz, valuenumber= seçmiş olduğumuz değerin id si
                //displaynumber = id nin görüntüsü
                Text = x.CategoryName,
                Value = x.CategoryID.ToString() //catgeoryıd sini string'e çevirmemiz gerekiyor
            }).ToList();

            List<SelectListItem> valuewriter = (from x in wm.GetList() select new SelectListItem
            {
                Text =x.WriterName + " " + x.WriterSurname,
                Value = x.WriterID.ToString()
            }).ToList();

            ViewBag.vlc = valuecategory; //view e taşıyoruz.
            ViewBag.vlw = valuewriter;
            return View();
        }

        [HttpPost]
        public ActionResult AddHeading(Heading p)
        {
            p.HeadingDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            hm.HeadingAdd(p);
            return RedirectToAction("Index");
        }
    }
}