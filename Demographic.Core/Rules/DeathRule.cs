using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demographic.Core.Rules
{
    public class DeathRule
    {
        private uint _leftLimit;
        private uint _rightLimit;
        private double _probabilityDeathMale;
        private double _probabilityDeathFemale;

        public DeathRule(uint leftLimit, uint rightLimit, double probabilityDeathMale, double probabilityDeathFemale)
        {
            _leftLimit = leftLimit;
            _rightLimit = rightLimit;
            _probabilityDeathMale = probabilityDeathMale;
            _probabilityDeathFemale = probabilityDeathFemale;
        }

        public DeathRule(DeathRule deathRule)
        {
            _leftLimit = deathRule.LeftLimit;
            _rightLimit = deathRule.RightLimit;
            _probabilityDeathFemale = deathRule.ProbabilityDeathFemale;
            _probabilityDeathMale = deathRule.ProbabilityDeathMale;
        }

        public DeathRule()
        {

        }

        public uint LeftLimit { get => _leftLimit; set => _leftLimit = value; }
        public uint RightLimit { get => _rightLimit; set => _rightLimit = value; }
        public double ProbabilityDeathMale { get => _probabilityDeathMale; set => _probabilityDeathMale = value; }
        public double ProbabilityDeathFemale { get => _probabilityDeathFemale; set => _probabilityDeathFemale = value; }
    }
}
