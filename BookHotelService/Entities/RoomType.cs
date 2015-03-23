using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entities
{
    //http://localhost:8080/images/exit.png
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
}
