using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entities
{
    public class RoomType
    {
        /// <summary>房间类型编号 </summary>
        public long RoomTypeId { get; set; }

        /// <summary>房间类型名字 如：标准间 </summary>
        public string Name { get; set; }

        /// <summary>房间类型平均价格 </summary>
        public double Price { get; set; }

        /// <summary>房间类型背景色 </summary>
        public string Color { get; set; }

        /// <summary>房间类型图片地址或者名字 </summary>
        public string IconUrl { get; set; }
    }

    public class RoomInfo
    {
        /// <summary>Id </summary>
        public long Id { get; set; }

        /// <summary>房间类型编号 </summary>
        public long RoomTypeId { get; set; }

        /// <summary>房间号 </summary>
        public string RoomNo { get; set; }

        /// <summary>房间上显示的文字 </summary>
        public string Message { get; set; }
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
