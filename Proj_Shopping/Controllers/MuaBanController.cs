using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Proj_Shopping.Models;

namespace Proj_Shopping.Controllers
{
    public class MuaBanController : Controller
    {
        // GET: MuaBan
        public ActionResult Index()
        {
            List<Sanpham> ds = new List<Sanpham>();
            ds.Add(new Sanpham("sp1", "IPhone 12 128", "1.jpg", 2000));
            ds.Add(new Sanpham("sp2", "Samsung Galaxy21", "2.jpg", 1500));
            ds.Add(new Sanpham("sp3", "Vivo Y51", "3.jpg", 600));
            Session["hanghoa"] = ds;
            return View(ds);
        }
        public ActionResult Chonmua(SanphamMua spm)
        {
            List<SanphamMua> dsmua = (List<SanphamMua>)Session["giohang"];
                if(dsmua==null)
            {
                dsmua = new List<SanphamMua>();
            }    
                if(dsmua.Contains(spm))
            {
                int vitri = dsmua.IndexOf(spm);
                dsmua[vitri].soluong++;
            }    
                else
            {
                spm.soluong = 1;
                dsmua.Add(spm);
            }
            Session["giohang"] = dsmua;
            return View();
        }
        public ActionResult XemGioHang()
        {
            List<SanphamMua> dsmua = (List<SanphamMua>)Session["giohang"];
            return View(dsmua);
        }
         public ActionResult XoaSanpham(string masp)
        {
            List<SanphamMua> dsmua = (List<SanphamMua>)Session["giohang"];
            SanphamMua s = new SanphamMua();
            s.masp = masp;
            int index = dsmua.IndexOf(s);
            s = dsmua[index];
            dsmua.Remove(s);
            Session["giohang"] = dsmua;
            return View("Chonmua");
        }
        public ActionResult Datmua()
        {
            List<SanphamMua> dsm = (List<SanphamMua>)Session["giohang"];
            Session.Remove("giohang");
            return View(dsm);
        }
    
}
}