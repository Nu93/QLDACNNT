using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ictshop.Models;

namespace Ictshop.Controllers
{
    public class SanphamController : Controller
    {
        Qlbanhang db = new Qlbanhang();

        // GET: Sanpham
        public ActionResult HGGundam()
        {
            var ip = db.Sanphams.Where(n=>n.Mahang==1).Take(int.MaxValue).ToList();
           return PartialView(ip);
        }
        public ActionResult MGGundam()
        {
            var ss = db.Sanphams.Where(n => n.Mahang == 2).Take(int.MaxValue).ToList();
            return PartialView(ss);
        }
        public ActionResult RGGundam()
        {
            var mi = db.Sanphams.Where(n => n.Mahang == 3).Take(int.MaxValue).ToList();
            return PartialView(mi);
        }
        //public ActionResult dttheohang()
        //{
        //    var mi = db.Sanphams.Where(n => n.Mahang == 5).Take(4).ToList();
        //    return PartialView(mi);
        //}
        public ActionResult xemchitiet(int Masp=0)
        {
            var chitiet = db.Sanphams.SingleOrDefault(n=>n.Masp==Masp);
            if (chitiet == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            return View(chitiet);
        }

    }

}