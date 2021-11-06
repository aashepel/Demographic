using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demographic.Core.Rules;
using Demographic.FileOperations.Parsers.Interfaces;
using Demographic.FileOperations.Parsers;

namespace Demographic.Services
{
    public class DeathProbablilityService
    {
        private readonly List<DeathRule> _deathRules;
        
        public DeathProbablilityService(string filePath)
        {
            IParser<DeathRule> parser = new DeathRuleCsvParser(filePath);
            parser.Parse();
            _deathRules = new List<DeathRule>(parser.Records.Select(rule => new DeathRule(rule)));
            parser = null;
        }

        public bool IsDeath(Person person)
        {
            var rule = _deathRules.FirstOrDefault(p => person.Age >= p.LeftLimit && person.Age <= p.RightLimit);
            if (rule == null)
            {
                rule = _deathRules.FirstOrDefault(p => p.ProbabilityDeathFemale == _deathRules.Max(r => r.ProbabilityDeathFemale));
            }

            if (person.Gender == Enums.Gender.Male)
            {
                return ProbabilityCalculator.IsEventHappened(rule.ProbabilityDeathMale);
            }
            else
            {
                return ProbabilityCalculator.IsEventHappened(rule.ProbabilityDeathFemale);
            }
        }
    }
}
