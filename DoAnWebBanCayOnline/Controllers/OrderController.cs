using DoAnWebBanCayOnline.Models;
using Microsoft.AspNet.Identity;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;

namespace DoAnWebBanCayOnline.Controllers
{
    public class OrderController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: Order
        public ActionResult Index(int? page)
        {
            //var items = db.Orders.OrderByDescending(x => x.CreatedDate).ToList();
            var items = from tt in db.Orders where tt.UserName == User.Identity.Name select tt;
            //if (page == null)
            //{
            //    page = 1;
            //}
            //var pageNumber = page ?? 1;
            //var pageSize = 10;
            //ViewBag.PageSize = pageSize;
            //ViewBag.Page = pageNumber;
            return View(items);
        }

        public ActionResult View(int id)
        {
            var item = db.Orders.Find(id);
            return View(item);
        }

        public ActionResult Partial_SanPham(int id)
        {
            var items = db.OrderDetails.Where(x => x.OrderId == id).ToList();
            return PartialView(items);
        }
    }
}