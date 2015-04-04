using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DAL;

namespace BookHotel.Controllers
{
    public class FloorController : Controller
    {
        //
        // GET: /Floor/

        //public ActionResult Index()
        //{
        //    return View();
        //}

        //
        // GET: /Floor/Details/5
        //传入楼层ID，返回该楼层的ID
        public ActionResult Rooms(long id)
        {
            return this.Json(DBManager.Data.RoomInfos.Where(room => room.HotelFloorId == id).ToList(), JsonRequestBehavior.AllowGet);
        }

        //传入楼层ID，返回楼层中所有的房间类型：
        public JsonResult RoomTypes(long id)
        {
            var rooms = DBManager.Data.RoomInfos.Where(room => room.HotelFloorId == id).ToList();
            var roomtypeids = from room in rooms
                              select room.RoomTypeId;
            roomtypeids = roomtypeids.Distinct();


            var roomtypes = DBManager.Data.RoomTypes.Where(roomtype => roomtypeids.Contains(roomtype.RoomTypeId)).ToList();



            return this.Json(roomtypes, JsonRequestBehavior.AllowGet);
        }
    }
}
