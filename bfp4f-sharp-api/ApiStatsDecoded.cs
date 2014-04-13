using System;
using System.Collections.Generic;
using bfp4f_sharp_api.vos; // Decoded JSON into classes - VO stands for Virtual Object
using Newtonsoft.Json; // Added via NuGet (Json.net)

namespace bfp4f_sharp_api
{
    class ApiStatsDecoded
    {
        public static GetUserInfoVO getUserInfo(string profileId, string lang = "en")
        {
            return JsonConvert.DeserializeObject<GetUserInfoVO>(ApiStatsSingleton.Instance.getUserInfo(profileId, lang));
        }

        public static GetLoadoutVO getLoadout(string profileId, string soldierId, string lang = "en")
        {
            return JsonConvert.DeserializeObject<GetLoadoutVO>(ApiStatsSingleton.Instance.getLoadout(profileId, soldierId, lang));
        }
    }
}
