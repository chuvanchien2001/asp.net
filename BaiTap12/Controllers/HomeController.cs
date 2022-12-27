using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BaiTap12.Models;
using PagedList;

namespace BaiTap12.Controllers
{
    public class HomeController : Controller
    {
        private FShopDB db = new FShopDB();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult DisplaySuplier(int ? page)
        {
            var supliers = db.Nha_CC.Select(p => p);
            supliers = supliers.OrderBy(s => s.MaNCC);
            int pageSize = 3;
            int pageNumber = (page ?? 1);
            return View(supliers.ToPagedList(pageNumber,pageSize));
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}