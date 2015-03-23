using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using Entities;
using WHPLib;

namespace DAL
{
    public class DbData
    {
        public List<HotelFloor> HotelFloors { get; set; }
        public List<RoomType> RoomTypes { get; set; }
        public List<RoomInfo> RoomInfos { get; set; }

        public DbData()
        {
            HotelFloors = new List<HotelFloor>();
            RoomTypes = new List<RoomType>();
            RoomInfos = new List<RoomInfo>();
        }


        public void Init()
        {
            HotelFloors = new List<HotelFloor>()
            {
                new HotelFloor()
                {
                    HotelFloorId = 0,
                    HotelID = 0,
                    FloorNo = 1,
                    HotelName = "华美达大酒店"
                },
                new HotelFloor()
                {
                    HotelFloorId = 1,
                    HotelID = 0,
                    FloorNo = 2,
                    HotelName = "华美达大酒店"
                },
                new HotelFloor()
                {
                    HotelFloorId = 2,
                    HotelID = 0,
                    FloorNo = 3,
                    HotelName = "华美达大酒店"
                },
                new HotelFloor()
                {
                    HotelFloorId = 3,
                    HotelID = 0,
                    FloorNo = 4,
                    HotelName = "华美达大酒店"
                },
                new HotelFloor()
                {
                    HotelFloorId = 4,
                    HotelID = 0,
                    FloorNo = 5,
                    HotelName = "华美达大酒店"
                },
                new HotelFloor()
                {
                    HotelFloorId = 5,
                    HotelID = 0,
                    FloorNo = 6,
                    HotelName = "华美达大酒店"
                }
            };

            RoomTypes = new List<RoomType>()
            {
                new RoomType()
                {
                    RoomTypeId = 0,
                    Name = "普通标准房",
                    Color = "#BE4C4C",
                    IconUrl = "http://172.68.2.198:8080/images/home.png",
                    Price = 120
                },
                new RoomType()
                {
                    RoomTypeId = 1,
                    Name = "普通大床房",
                    Color = "#8791F0",
                    IconUrl = "http://172.68.2.198:8080/images/home.png",
                    Price = 150
                },
                new RoomType()
                {
                    RoomTypeId = 2,
                    Name = "普通双床房",
                    Color = "#8791F0",
                    IconUrl = "http://172.68.2.198:8080/images/home.png",
                    Price = 150
                }

            };

            RoomInfos = new List<RoomInfo>()
            {
                new RoomInfo()
                {
                    RoomInfoId = 0,
                    RoomTypeId = 0,
                    HotelFloorId = 0,
                    RoomNo = "101",
                    Message="",
                    IsCanBook = true,
                    PositionX = 0,
                    PositionY = 0,
                    Width = 4,
                    Height = 4,
                    Angle = 0,
                    PicURl = "http://172.68.2.198:8080/images/home.png"
                },
                new RoomInfo()
                {
                    RoomInfoId = 1,
                    RoomTypeId = 2,
                    HotelFloorId = 0,
                    RoomNo = "102",
                    Message="",
                    IsCanBook = true,
                    PositionX = 4,
                    PositionY = 0,
                    Width = 4,
                    Height = 4,
                    Angle = 0,
                    PicURl = "http://172.68.2.198:8080/images/home.png"
                },
                new RoomInfo()
                {
                    RoomInfoId = 2,
                    RoomTypeId = 0,
                    HotelFloorId = 0,
                    RoomNo = "103",
                    Message="",
                    IsCanBook = false,
                    PositionX = 8,
                    PositionY = 0,
                    Width = 4,
                    Height = 4,
                    Angle = 0,
                    PicURl = "http://172.68.2.198:8080/images/home.png"
                }
            };
        }
    }
}
