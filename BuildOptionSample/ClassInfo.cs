using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuildOptionSample
{
    public class ClassInfo
    {
        public string className { get; set; }
        public long classNo { get; set; }
        public List<Info> Info { get; set; }
    }

    public class Info
    {
        public string name { get; set; }
        public long age { get; set; }
    }
}
