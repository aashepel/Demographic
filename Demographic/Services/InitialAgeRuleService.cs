using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demographic.Core.Rules;
using Demographic.FileOperations.Parsers;
using Demographic.FileOperations.Parsers.Interfaces;

namespace Demographic.Services
{
    public class InitialAgeRuleService
    {
        readonly List<InitialAgeRule> _rules;
        public InitialAgeRuleService(string filePath)
        {
            IParser<InitialAgeRule> parser = new InitialAgeRuleCsvParser(filePath);
            parser.Parse();
            _rules = new List<InitialAgeRule>(parser.Records.Select(rule => new InitialAgeRule(rule)));
            parser = null;
        }

        public List<InitialAgeRule> Rules => _rules;
    }
}
