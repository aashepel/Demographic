using System;
using System.Collections.Generic;
using Demographic.Services;
using Demographic.Core;
using System.Linq;
using System.ComponentModel;

namespace Demographic
{
    public class Engine : IEngine
    {
        public event Action YearTick;

        private List<Person> _persons = new List<Person>();

        private uint _currentYear = 1970;

        private uint _rightLimitYear = 2021;

        private uint _leftLimitYear = 1970;

        private UInt64 _counterPepolesId = 0;

        private uint _startCountPeoples;

        private InitialAgeRuleService _initialAgeRuleService;

        private DeathProbablilityService _deathProbablilityService;

        private string _filePathDeathRule;

        private string _filePathInitialAgeRules;

        private uint _koeff = 1000;

        private List<SnapshotYear> _snapshotYears = new List<SnapshotYear>();

        private bool _isInitializing = false;

        public Engine(EngineConfig config)
        {
            InitEngine(config);
            _isInitializing = true;
        }
        
        public Engine()
        {
            _isInitializing = false;
        }

        public void InitEngine(EngineConfig config)
        {
            _counterPepolesId = 0;
            _persons.Clear();
            _snapshotYears.Clear();

            _filePathDeathRule = config.FilePathDeathRule;
            _filePathInitialAgeRules = config.FilePathInitialAge;
            _currentYear = config.LeftLimitYear;
            _leftLimitYear = config.LeftLimitYear;
            _rightLimitYear = config.RightLimitYear;
            _koeff = config.Koeff;
            _startCountPeoples = config.StartCountPeoples / _koeff;

            _isInitializing = true;

            _deathProbablilityService = new DeathProbablilityService(_filePathDeathRule);
            _initialAgeRuleService = new InitialAgeRuleService(_filePathInitialAgeRules);
            foreach(var rule in _initialAgeRuleService.Rules)
            {
                int currentCountMales = (int)(rule.Percent / 2d / 1000d * _startCountPeoples);
                int currentCountFemales = (int)(rule.Percent / 2d / 1000d * _startCountPeoples);
                for (int i = 0; i < currentCountMales; i++)
                {
                    _persons.Add(new Person(Enums.Gender.Male, null, this, rule.Age));
                }

                for (int i = 0; i < currentCountFemales; i++)
                {
                    _persons.Add(new Person(Enums.Gender.Female, null, this, rule.Age));
                }
            }
        }

        public void StartImitation(BackgroundWorker backgroundWorker, DoWorkEventArgs e)
        {
            if (!_isInitializing)
            {
                throw new Exception("Движок не иницииализрован");
            }

            _snapshotYears.Add(SnapshotYearService.GetSnapshot(_currentYear, _persons, _koeff));

            while (TickYear())
            {
                int percantage = (int)((double)(_currentYear - _leftLimitYear) / (double)(_rightLimitYear - _leftLimitYear) * 100d);
                Console.WriteLine(percantage);
                backgroundWorker.ReportProgress(percantage, $"{_currentYear} year");
                if (backgroundWorker.CancellationPending)
                {
                    e.Cancel = true;
                    return;
                }
            }
        }

        public DeathProbablilityService DeathProbablilityService
        {
            get
            {
                return _deathProbablilityService;
            }
        }

        public void OnChildBirth(Person person)
        {
            _persons.Add(person);
        }

        public bool TickYear()
        {
            _currentYear++;
            YearTick?.Invoke();
            _snapshotYears.Add(SnapshotYearService.GetSnapshot(_currentYear, _persons, _koeff));
            return _currentYear <= _rightLimitYear;
        }

        public uint CurrentYear
        {
            get { return _currentYear; }
        }

        public UInt64 CounterPepoles
        {
            get
            {
                _counterPepolesId++;
                return _counterPepolesId;
            }
        }

        public List<Person> Persons
        {
            get { return _persons; }
        }

        public List<SnapshotYear> SnapshotYears { get => _snapshotYears; }
    }
}
