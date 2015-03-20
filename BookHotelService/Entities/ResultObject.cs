using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;

namespace Entities
{
    public class ResultObject
    {
        /// <summary>0:Success 1:Failure
        /// </summary>
        public int ResultCode { get; set; }

        /// <summary>返回的提示信息
        /// </summary>
        public string ResultMessage { get; set; }

        public DateTime Time { get; set; }


        public List<string> V1 { get; set; }
        public Dictionary<int, string> KvDictionary { get; set; }

        public User User { get; set; }
    }
}
