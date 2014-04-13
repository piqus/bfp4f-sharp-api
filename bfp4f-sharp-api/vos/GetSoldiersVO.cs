using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bfp4f_sharp_api.vos
{
    class GetSoldiersVO
    {
        public string result { get; set; }
        public string status { get; set; }
        public List<GetSoldiersDataItemVO> data { get; set; }
    }

    class GetSoldiersDataItemVO
    {
        public int id { get; set; }
        public bool isMain { get; set; }
        public bool isMaxLevel { get; set; }
        public string kit { get; set; }
        public string kitName { get; set; }
        public int level { get; set; }
        public string levelDescription { get; set; }
        public int levelUpProgression { get; set; }
        public string mugShot { get; set; }
        public string name { get; set; }
        public int xp { get; set; }
        public int xpForNextLevel { get; set; }
    }
}
