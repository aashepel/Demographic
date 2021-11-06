using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demographic.Core.Rules
{
    public class InitialAgeRule
    {
        private uint _age;
        private double _percent;

        public InitialAgeRule()
        {

        }

        public InitialAgeRule(InitialAgeRule rule)
        {
            _age = rule.Age;
            _percent = rule.Percent;
        }

        public InitialAgeRule(uint age, double percent)
        {
            _age = age;
            _percent = percent;
        }

        public uint Age { get => _age; set => _age = value; }
        public double Percent { get => _percent; set => _percent = value; }
    }
}
