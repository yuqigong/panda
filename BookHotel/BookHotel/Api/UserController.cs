//using System;
//using System.Collections.Generic;
//using System.Web;
//using System.Web.Http;
//using Entities;

//namespace BookHotel.Api
//{
//    public class UserController : ApiController
//    {
//        // GET api/<controller>
//        public IEnumerable<string> Get()
//        {
//            return new string[] { "value1", "value2" };
//        }

//        // GET api/<controller>/5
//        public string Get(int id)
//        {
//            return "value";
//        }

//        //// POST api/<controller>
//        //public object Post(User user)
//        //{
//        //    var v = HttpContext.Current.Request;

//        //    return new ResultObject()
//        //    {
//        //        ResultCode = 1,
//        //        ResultMessage = "success",
//        //        KvDictionary = new Dictionary<int, string>() { },
//        //        User = user,
//        //        Time = DateTime.Now
//        //    };
//        //}

//        // PUT api/<controller>/5
//        public void Put(int id, [FromBody]string value)
//        {
//        }

//        // DELETE api/<controller>/5
//        public void Delete(int id)
//        {
//        }
//    }
//}