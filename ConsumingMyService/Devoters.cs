using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsumingMyService
{
    public class Devoters
    {
        public string Address { get; set; }
        public string Age { get; set; }
        public string Doj { get; set; }
        public string Id { get; set; }
        public string Name { get; set; }
        public string Phoneno { get; set; }
        public List<Devoters> GetListOfDevotersResult { get; set; }
    }
}
