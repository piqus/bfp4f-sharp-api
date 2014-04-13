using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bfp4f_sharp_api.vos
{
    class GetLoadoutVO
    {
        public string result { get; set; }
        public string status { get; set; }
        public GetLoadoutDataVO data { get; set; }
    }

    class GetLoadoutDataVO
    {
        public List<GetLoadoutDataApparelItemVO> apparel { get; set; }
        public List<GetLoadoutDataAttachmentItemVO> attachments { get; set; }
        public List<GetLoadoutDataEquipmentItemVO> equipment { get; set; }        
    }

    class GetLoadoutDataApparelItemVO
    {
        public bool buyable { get; set; }
        public string category { get; set; }
        public string categoryname { get; set; }
        public string description { get; set; }
        public int equippedSlot { get; set; } // @todo: is it bugged too?
        public bool expireTS { get; set; }
        public bool expired { get; set; }
        public string expiredate { get; set; }
        public string id { get; set; }
        public bool isDefault { get; set; }
        public bool isLocked { get; set; }
        public bool isnew { get; set; }
        public string lockCriteria { get; set; }
        public string lockType { get; set; }
        public int maxNumPockets { get; set; }
        public int minNumPockets { get; set; }
        public string name { get; set; }
        public int numberOfPockets { get; set; }
        public bool owned { get; set; }
        public string ownedPermanent { set; get; }
        public List<string> prices { set; get; }
        public string promotionType { set; get; }
        public string type { set; get; }
        public List<string> upgrades { set; get; }
        public string usecount { set; get; }
        public string validationGroup { set; get; }
    }

    class GetLoadoutDataAttachmentItemVO
    {
        public bool buyable { get; set; }
        public string category { get; set; }
        public string categoryname { get; set; }
        public string description { get; set; }
        //public int equippedSlot { get; set; } // @todo: it is equal "false" if not set so throws an exception because we have int here :( Solution: make something dynamic
        public bool expireTS { get; set; }
        public bool expired { get; set; }
        public string expiredate { get; set; }
        public string fitsSlot { get; set; }
        public string id { get; set; }
        public bool isDefault { get; set; }
        public bool isLocked { get; set; }
        public bool isnew { get; set; }
        public string lockCriteria { get; set; }
        public string lockType { get; set; }
        public string name { get; set; }
        public bool owned { get; set; }
        public string ownedPermanent { set; get; }
        public List<int> parentItems { set; get; }
        public List<string> prices { set; get; }
        public string promotionType { set; get; }
        public string reticleImage { set; get; }
        //public Dictionary<string, GetLoadoutDataAttachmentItemStatsVO> stats { get; set; } // @todo: There is a bug, when it is empty List. Solution: replace Dictionary with Class
        public string type { set; get; }
        public string usecount { set; get; } // @todo: test it. Why does it show null.
        public string validationGroup { set; get; }
    }

    /// <summary>
    /// Such as Accuracy, AccControl, AccPrecision, Damage, MagSizeIncrease, Zoom etc. etc.
    /// </summary>
    class GetLoadoutDataAttachmentItemStatsVO
    {
        public bool isPenalty { get; set; }
        public int value { get; set; }
    }

    class GetLoadoutDataEquipmentItemVO
    {
        public bool buyable { get; set; }
        public string category { get; set; }
        public string categoryname { get; set; }
        public string description { get; set; }
        public int equippedSlot { get; set; }
        public bool expireTS { get; set; }
        public bool expired { get; set; }
        public string expiredate { get; set; }
        public string id { get; set; }
        public bool isLocked { get; set; }
        public bool isnew { get; set; }
        public string lockCriteria { get; set; }
        public string lockType { get; set; }
        public string name { get; set; }
        public bool owned { get; set; }
        public string ownedPermanent { set; get; }
        public List<string> prices { set; get; }
        public string promotionType { set; get; }
        [JsonIgnore]
        public Dictionary<string, GetLoadoutDataWeaponItemStatsVO> stats { get; set; } // @todo: It is buggy when is empty.
        public string type { set; get; }
        public string usecount { set; get; }
        public string validationGroup { set; get; }
    }
    class GetLoadoutDataWeaponItemStatsVO
    {
        public bool isBestInClass { get; set; }
        public int value { get; set; }
    }
}
