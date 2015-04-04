using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DAL;

namespace BookHotel.Controllers
{
    public class HotelController : Controller
    {
        ////
        //// GET: /Hotel/

        //public ActionResult Index()
        //{
        //    return View();
        //}

        ////
        //// GET: /Hotel/Details/5

        //public ActionResult Details(long id)
        //{
        //    return View();
        //}

        //
        // GET: /Hotel/Details/5

        //传入酒店ID，返回酒店所有的楼层编号
        public JsonResult Floors(long id)
        {
            return this.Json(DBManager.Data.HotelFloors.Where(f => f.HotelID == id).ToList(), JsonRequestBehavior.AllowGet);
        }

        //
        // GET: /Hotel/Create
    }
}
