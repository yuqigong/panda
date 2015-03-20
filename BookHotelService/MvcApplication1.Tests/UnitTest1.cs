using System;
using System.Collections.Generic;
using DAL;
using Entities;
using HLAnalytics.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
//using MongoDB.Driver;

namespace MvcApplication1.Tests
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void TestMongoDB()
        {
            //var db = DBManager.GetDBInstance();



            //IMongoCollection<User> UserTable = db.GetCollection<User>("User");

            //UserTable.InsertOneAsync(
            //    new User()
            //    {
            //        Name = "jack",
            //        Password = "12344"
            //    }).Wait();




        }



        [TestMethod]
        public void TestObject()
        {
            List<RoomType> types = new List<RoomType>();

            RoomType t1 = new RoomType()
            {
                RoomTypeId = 0,
                Name = "普通标准房",
                Color = "#BE4C4C",
                IconUrl = "http://www.uimaker.com/uploads/allimg/110908/1_110908083206_3.png",
                Price = 120
            };
            RoomType t2 = new RoomType()
            {
                RoomTypeId = 1,
                Name = "普通大床房",
                Color = "#8791F0",
                IconUrl = "http://www.uimaker.com/uploads/allimg/110908/1_110908083206_3.png",
                Price = 150
            };
            RoomType t3 = new RoomType()
            {
                RoomTypeId = 2,
                Name = "普通双床房",
                Color = "#8791F0",
                IconUrl = "http://2b.zol-img.com.cn/product/57/519/ceSYZhOtGU8A.jpg",
                Price = 150
            };

            types.Add(t1);
            types.Add(t2);
            types.Add(t3);


            List<RoomInfo> roomInfos = new List<RoomInfo>()
            {
                new RoomInfo()
                {
                    Id = 0,
                    RoomTypeId = 0,
                    RoomNo = "101",
                    Message="",
                    PositionX = 0,
                    PositionY = 0,
                    Width = 4,
                    Height = 4,
                    Angle = 90,
                    PicURl = "http://www.uimaker.com/uploads/allimg/110908/1_110908083206_3.png"
                },
                new RoomInfo()
                {
                    Id = 1,
                    RoomTypeId = 2,
                    RoomNo = "102",
                    Message="",
                    PositionX = 4,
                    PositionY = 0,
                    Width = 4,
                    Height = 4,
                    Angle = 90,
                    PicURl = "http://www.uimaker.com/uploads/allimg/110908/1_110908083206_3.png"
                },
                new RoomInfo()
                {
                    Id = 2,
                    RoomTypeId = 0,
                    RoomNo = "103",
                    Message="",
                    PositionX = 8,
                    PositionY = 0,
                    Width = 4,
                    Height = 4,
                    Angle = 90,
                    PicURl = "http://www.uimaker.com/uploads/allimg/110908/1_110908083206_3.png"
                },
                new RoomInfo()
                {
                    Id = 3,
                    RoomTypeId = 0,
                    RoomNo = "104",
                    Message="",
                    PositionX = 12,
                    PositionY = 0,
                    Width = 4,
                    Height = 4,
                    Angle = 90,
                    PicURl = "http://www.uimaker.com/uploads/allimg/110908/1_110908083206_3.png"
                },
                new RoomInfo()
                {
                    Id = 4,
                    RoomTypeId = 0,
                    RoomNo = "105",
                    Message="",
                    PositionX = 16,
                    PositionY = 0,
                    Width = 4,
                    Height = 4,
                    Angle = 90,
                    PicURl = "http://www.uimaker.com/uploads/allimg/110908/1_110908083206_3.png"
                },
                new RoomInfo()
                {
                    Id = 5,
                    RoomTypeId = 0,
                    RoomNo = "106",
                    Message="",
                    PositionX = 20,
                    PositionY = 0,
                    Width = 4,
                    Height = 4,
                    Angle = 90,
                    PicURl = "http://www.uimaker.com/uploads/allimg/110908/1_110908083206_3.png"
                },
                new RoomInfo()
                {
                    Id = 6,
                    RoomTypeId = 0,
                    RoomNo = "107",
                    Message="",
                    PositionX = 20,
                    PositionY = 0,
                    Width = 4,
                    Height = 4,
                    Angle = 90,
                    PicURl = "http://www.uimaker.com/uploads/allimg/110908/1_110908083206_3.png"
                },
                new RoomInfo()
                {
                    Id = 7,
                    RoomTypeId = 0,
                    RoomNo = "108",
                    Message="",
                    PositionX = 0,
                    PositionY = 6,
                    Width = 4,
                    Height = 4,
                    Angle = 270,
                    PicURl = "http://www.uimaker.com/uploads/allimg/110908/1_110908083206_3.png"
                },
                new RoomInfo()
                {
                    Id = 8,
                    RoomTypeId = 0,
                    RoomNo = "109",
                    Message="",
                    PositionX = 4,
                    PositionY = 6,
                    Width = 4,
                    Height = 4,
                    Angle = 270,
                    PicURl = "http://www.uimaker.com/uploads/allimg/110908/1_110908083206_3.png"
                },
                new RoomInfo()
                {
                    Id = 9,
                    RoomTypeId = 0,
                    RoomNo = "110",
                    Message="",
                    PositionX = 8,
                    PositionY = 6,
                    Width = 4,
                    Height = 4,
                    Angle = 270,
                    PicURl = "http://www.uimaker.com/uploads/allimg/110908/1_110908083206_3.png"
                },
                new RoomInfo()
                {
                    Id = 10,
                    RoomTypeId = 0,
                    RoomNo = "111",
                    Message="",
                    PositionX = 12,
                    PositionY = 6,
                    Width = 4,
                    Height = 4,
                    Angle = 270,
                    PicURl = "http://www.uimaker.com/uploads/allimg/110908/1_110908083206_3.png"
                },
                new RoomInfo()
                {
                    Id = 11,
                    RoomTypeId = 0,
                    RoomNo = "112",
                    Message="",
                    PositionX = 16,
                    PositionY = 6,
                    Width = 4,
                    Height = 4,
                    Angle = 270,
                    PicURl = "http://www.uimaker.com/uploads/allimg/110908/1_110908083206_3.png"
                },
                new RoomInfo()
                {
                    Id = 12,
                    RoomTypeId = 0,
                    RoomNo = "113",
                    Message="",
                    PositionX = 20,
                    PositionY = 6,
                    Width = 4,
                    Height = 4,
                    Angle = 270,
                    PicURl = "http://www.uimaker.com/uploads/allimg/110908/1_110908083206_3.png"
                },
                new RoomInfo()
                {
                    Id = 13,
                    RoomTypeId = 0,
                    RoomNo = "114",
                    Message="",
                    PositionX = 24,
                    PositionY = 6,
                    Width = 4,
                    Height = 4,
                    Angle = 270,
                    PicURl = "http://www.uimaker.com/uploads/allimg/110908/1_110908083206_3.png"
                }
            };

            string typestring = types.ToJson();
            string roomstring = roomInfos.ToJson();
        }
    }
}
