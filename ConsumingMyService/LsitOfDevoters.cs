using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsumingMyService
{
    public class LsitOfDevoters
    {
        //[JsonProperty("devLst")]
        //public List<Devoters> devLst { get; set; }
        //public int count { get; set; }

        public List<Devoters> GetListOfDevotersResult { get; set; }
    }
}
