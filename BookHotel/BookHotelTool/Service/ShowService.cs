using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using Entities;

namespace BookHotelTool.Service
{
    public class ShowService
    {
        public event Action OnShow;
        public List<RoomInfo> rooms = new List<RoomInfo>();
        public long floor = 0;
        public void loadFloor()
        {
            rooms.Clear();
            rooms.AddRange(DBManager.Data.RoomInfos.Where(r => r.HotelFloorId == floor));
        }

        public void Show()
        {
            if (this.OnShow != null)
            {
                this.OnShow();
            }
        }
    }
}
