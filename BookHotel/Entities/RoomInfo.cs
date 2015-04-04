using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    //http://localhost:8080/images/exit.png
    public class RoomInfo
    {
        public RoomInfo()
        {
            RoomInfoId = 0;
            Angle = 90;
            Height = 4;
            Width = 4;
            HotelFloorId = 0;
            PositionX = 0;
            PositionY = 0;
            Message = "";
            PicURl = "http://172.68.2.198:8080/Images/home.png";
            RoomNo = "109";
        }

        /// <summary>RoomInfoId </summary>
        public long RoomInfoId { get; set; }

        /// <summary>房间类型编号 </summary>
        public long RoomTypeId { get; set; }

        /// <summary> HotelFloorID </summary> 
        public long HotelFloorId { get; set; }

        /// <summary>房间号 </summary>
        public string RoomNo { get; set; }

        /// <summary>房间上显示的文字 </summary>
        public string Message { get; set; }

        /// <summary> 是否可被预定 </summary>
        public bool IsCanBook { get; set; }

        /// <summary>如果有特殊的显示图片，则设置 </summary>
        public string PicURl { get; set; }

        /// <summary>房间起始点位置 </summary>
        public double PositionX { get; set; }

        /// <summary>房间起始点位置 </summary>

        public double PositionY { get; set; }

        /// <summary>房间横跨几个小格子 </summary>
        public double Width { get; set; }

        /// <summary>房间纵向几个小格子 </summary>
        public double Height { get; set; }

        /// <summary>房间类型图片显示旋转的角度：0,90,180,270 </summary>
        public double Angle { get; set; }
    }
}
