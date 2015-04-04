using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class HotelFloor
    {
        public long HotelFloorId { get; set; }

        public int FloorNo { get; set; }

        public long HotelID { get; set; }

        public string HotelName { get; set; }

        public string HotelModelImgPath { get; set; }

        public override string ToString()
        {
            return HotelFloorId + ": 第" + FloorNo + "层" + "(" + HotelID + ":" + HotelName + ")";
        }
    }
}
