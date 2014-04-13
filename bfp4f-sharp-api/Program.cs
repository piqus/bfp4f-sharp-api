using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bfp4f_sharp_api
{
    class Program
    {
        static void Main(string[] args)
        {
            //ApiStats.getUserInfo("2627733530");
            //ApiStats.getSoldiers("2627733530");
            //Console.WriteLine(ApiStatsSingleton.Instance.getUserInfo("2627733530"));
            //Console.WriteLine(ApiStatsDecoded.getUserInfo("2627733530").data.id.ToString());
            Console.WriteLine(ApiStatsDecoded.getLoadout("2627733530", "609452444").data.apparel[1].buyable.ToString());
            Console.WriteLine(ApiStatsDecoded.getLoadout("2627733530", "778741036").data.apparel[1].buyable.ToString());
            Console.ReadKey();
        }
    }
}
