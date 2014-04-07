using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bfp4f_sharp_api
{
    public sealed class ApiStatsSingleton : ApiCommunication
    {
        private static ApiStatsSingleton instance;

        private ApiStatsSingleton() { }

        public static ApiStatsSingleton Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ApiStatsSingleton();
                }
                return instance;
            }
        }

        #region Some methods to obtain stats data from EAsy

        /// <summary>
        /// Get user info of selected profileID
        /// </summary>
        public string getUserInfo(string profileId, string lang = "en")
        {
            instance.setLang(lang);
            instance.setPath("profile/userInfo/" + profileId);
            instance.prepare();
            return instance.call();
        }

        /// <summary>
        /// Get all soldiers connected with profileID
        /// </summary>
        public string getSoldiers(string profileId, string lang = "en")
        {
            instance.setLang(lang);
            instance.setPath("profile/soldiers/" + profileId);
            instance.prepare();
            return instance.call();
        }

        /// <summary>
        /// Obtain loadout of selected soldier
        /// </summary>
        public string getLoadout(string profileId, string soldierId, string lang = "en")
        {
            instance.setLang(lang);
            instance.setPath("profile/loadout/" + profileId + "/" + soldierId);
            instance.prepare();
            return instance.call();
        }

        /// <summary>
        /// Obtain CoreStats of selected soldier
        /// </summary>
        public string getCoreStats(string profileId, string soldierId, string lang = "en")
        {
            instance.setLang(lang);
            instance.setPath("profile/stats/" + profileId + "/" + soldierId + "?g=[%22CoreStats%22]");
            instance.prepare();
            return instance.call();
        }

        /// <summary>
        /// Obtain BadPlayerStats of selected soldier
        /// </summary>
        public string getBadPlayerStats(string profileId, string soldierId, string lang = "en")
        {
            instance.setLang(lang);
            instance.setPath("profile/stats/" + profileId + "/" + soldierId + "?g=[%22BadPlayerStats%22]");
            instance.prepare();
            return instance.call();
        }

        /// <summary>
        /// Obtain VehicleStats of selected soldier
        /// </summary>
        public string getVehicleStats(string profileId, string soldierId, string lang = "en")
        {
            instance.setLang(lang);
            instance.setPath("profile/stats/" + profileId + "/" + soldierId + "?g=[%22VehicleStats%22]");
            instance.prepare();
            return instance.call();
        }

        /// <summary>
        /// Obtain MapStats of selected soldier
        /// </summary>
        public string getMapStats(string profileId, string soldierId, string lang = "en")
        {
            instance.setLang(lang);
            instance.setPath("profile/stats/" + profileId + "/" + soldierId + "?g=[%22MapStats%22]");
            instance.prepare();
            return instance.call();
        }

        /// <summary>
        /// Obtain GameModeMapStats of selected soldier
        /// </summary>
        public string getGameModeMapStats(string profileId, string soldierId, string lang = "en")
        {
            instance.setLang(lang);
            instance.setPath("profile/stats/" + profileId + "/" + soldierId + "?g=[%22GameModeMapStats%22]");
            instance.prepare();
            return instance.call();
        }

        /// <summary>
        /// Obtain WeaponStats of selected soldier
        /// </summary>
        public string getWeaponStats(string profileId, string soldierId, string lang = "en")
        {
            instance.setLang(lang);
            instance.setPath("profile/stats/" + profileId + "/" + soldierId + "?g=[%22WeaponStats%22]");
            instance.prepare();
            return instance.call();
        }

        /// <summary>
        /// Obtain GameModeStats of selected soldier
        /// </summary>
        public string getGameModeStats(string profileId, string soldierId, string lang = "en")
        {
            instance.setLang(lang);
            instance.setPath("profile/stats/" + profileId + "/" + soldierId + "?g=[%22GameModeStats%22]");
            instance.prepare();
            return instance.call();
        }

        /// <summary>
        /// Obtain RushMapStats of selected soldier
        /// </summary>
        public string getRushMapStats(string profileId, string soldierId, string lang = "en")
        {
            instance.setLang(lang);
            instance.setPath("profile/stats/" + profileId + "/" + soldierId + "?g=[%22RushMapStats%22]&_?=1351945928776");
            instance.prepare();
            return instance.call();
        }

        /// <summary>
        /// Obtain GameEventStats of selected soldier
        /// </summary>
        public string getGameEventStats(string profileId, string soldierId, string lang = "en")
        {
            instance.setLang(lang);
            instance.setPath("profile/stats/" + profileId + "/" + soldierId + "?g=[%22GameEventStats%22]");
            instance.prepare();
            return instance.call();
        }

        #endregion
    }
}

