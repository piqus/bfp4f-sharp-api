using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bfp4f_sharp_api
{
    class ApiStats
    {

        //curl "http://battlefield.play4free.com/en/profile/userInfo/2627733530"
        public static void getUserInfo(string profileId = "2627733530")
        {
            ApiCommunication api = new ApiCommunication("en", "profile/userInfo/" + profileId);
            api.prepare();
            Console.WriteLine(api.call());
        }
    }
}
