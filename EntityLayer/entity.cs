using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class entityLayerReg
    {
        public int vid { get; set; }
        public string name { get; set; }
        public string ent { get; set; }
        public string ext { get; set; }
        public string slot { get; set; }
        public long charge { get; set; }
        public string type { get; set; }
        public string duration { get; set; }

    }

    public class avalslotLight
    {
        public int slot { get; set;}
    }
    public class avalslotHeavy
    {
        public int slot { get; set; }
    }
}
