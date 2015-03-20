using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL
{
    public class DBManager
    {
        /// <summary>
        /// 数据库连接
        /// </summary>
        private const string conn = "mongodb://127.0.0.1:27017";
        /// <summary>
        /// 指定的数据库
        /// </summary>
        private const string dbName = "BookHotelDB";

        //public static IMongoDatabase GetDBInstance()
        //{
        //    MongoClient client = new MongoClient(conn);
        //    IAsyncCursor<BsonDocument> v = client.ListDatabasesAsync().Result;
        //    return client.GetDatabase(dbName);
        //}
    }
}
