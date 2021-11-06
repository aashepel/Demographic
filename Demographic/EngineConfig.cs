using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demographic
{
    public class EngineConfig
    {
        public uint LeftLimitYear { get; set; }
        public uint RightLimitYear { get; set; }
        public uint StartCountPeoples { get; set; }
        public string FilePathInitialAge { get; set; }
        public string FilePathDeathRule { get; set; }
        public uint Koeff { get; set; }
    }
}
