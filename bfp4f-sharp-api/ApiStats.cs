using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bfp4f_sharp_api
{
    class ApiStats
    {
        /// <summary>
        /// Get user info of selected profileID
        /// </summary>
        public static string getUserInfo(string profileId, string lang = "en")
        {
            ApiCommunication api = new ApiCommunication(lang, "profile/userInfo/" + profileId);
            api.prepare();
            return api.call();
        }


        /// <summary>
        /// Get all soldiers connected with profileID
        /// </summary>
        public static string getSoldiers(string profileId, string lang = "en")
        {
            ApiCommunication api = new ApiCommunication(lang, "profile/soldiers/" + profileId);
            api.prepare();
            return api.call();
        }

        /// <summary>
        /// Obtain loadout of selected soldier
        /// </summary>
        public static string getLoadout(string profileId, string soldierId, string lang = "en")
        {
            ApiCommunication api = new ApiCommunication(lang, "profile/loadout/" + profileId + "/" + soldierId);
            api.prepare();
            return api.call();
        }

        /// <summary>
        /// Obtain CoreStats of selected soldier
        /// </summary>
        public static string getCoreStats(string profileId, string soldierId, string lang = "en")
        {
            ApiCommunication api = new ApiCommunication(lang, "profile/stats/" + profileId + "/" + soldierId + "?g=[%22CoreStats%22]");
            api.prepare();
            return api.call();
        }

        /// <summary>
        /// Obtain BadPlayerStats of selected soldier
        /// </summary>
        public static string getBadPlayerStats(string profileId, string soldierId, string lang = "en")
        {
            ApiCommunication api = new ApiCommunication(lang, "profile/stats/" + profileId + "/" + soldierId + "?g=[%22BadPlayerStats%22]");
            api.prepare();
            return api.call();
        }

        /// <summary>
        /// Obtain VehicleStats of selected soldier
        /// </summary>
        public static string getVehicleStats(string profileId, string soldierId, string lang = "en")
        {
            ApiCommunication api = new ApiCommunication(lang, "profile/stats/" + profileId + "/" + soldierId + "?g=[%22VehicleStats%22]");
            api.prepare();
            return api.call();
        }

        /// <summary>
        /// Obtain MapStats of selected soldier
        /// </summary>
        public static string getMapStats(string profileId, string soldierId, string lang = "en")
        {
            ApiCommunication api = new ApiCommunication(lang, "profile/stats/" + profileId + "/" + soldierId + "?g=[%22MapStats%22]");
            api.prepare();
            return api.call();
        }

        /// <summary>
        /// Obtain GameModeMapStats of selected soldier
        /// </summary>
        public static string getGameModeMapStats(string profileId, string soldierId, string lang = "en")
        {
            ApiCommunication api = new ApiCommunication(lang, "profile/stats/" + profileId + "/" + soldierId + "?g=[%22GameModeMapStats%22]");
            api.prepare();
            return api.call();
        }

        /// <summary>
        /// Obtain WeaponStats of selected soldier
        /// </summary>
        public static string getWeaponStats(string profileId, string soldierId, string lang = "en")
        {
            ApiCommunication api = new ApiCommunication(lang, "profile/stats/" + profileId + "/" + soldierId + "?g=[%22WeaponStats%22]");
            api.prepare();
            return api.call();
        }

        /// <summary>
        /// Obtain GameModeStats of selected soldier
        /// </summary>
        public static string getGameModeStats(string profileId, string soldierId, string lang = "en")
        {
            ApiCommunication api = new ApiCommunication(lang, "profile/stats/" + profileId + "/" + soldierId + "?g=[%22GameModeStats%22]");
            api.prepare();
            return api.call();
        }

        /// <summary>
        /// Obtain RushMapStats of selected soldier
        /// </summary>
        public static string getRushMapStats(string profileId, string soldierId, string lang = "en")
        {
            ApiCommunication api = new ApiCommunication(lang, "profile/stats/" + profileId + "/" + soldierId + "?g=[%22RushMapStats%22]&_?=1351945928776");
            api.prepare();
            return api.call();
        }

        /// <summary>
        /// Obtain GameEventStats of selected soldier
        /// </summary>
        public static string getGameEventStats(string profileId, string soldierId, string lang = "en")
        {
            ApiCommunication api = new ApiCommunication(lang, "profile/stats/" + profileId + "/" + soldierId + "?g=[%22GameEventStats%22]");
            api.prepare();
            return api.call();
        }
    }
}
