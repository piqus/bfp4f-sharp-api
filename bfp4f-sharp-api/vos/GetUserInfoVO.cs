using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bfp4f_sharp_api.vos
{
    class GetUserInfoVO
    {
        public string result { get; set; }
        public string status { get; set; }
        public GetUserInfoDataVO data { get; set; }
    }

    class GetUserInfoDataVO
    {
        public string id { get; set; }
        public bool isRequestorUser { get; set; }
        public bool isFriend { get; set; }
        public int friendState { get; set; }
        public string friendStatus { get; set; }
        public bool isOnline { get; set; }
    }
}
