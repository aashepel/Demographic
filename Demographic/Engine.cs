using System;
using System.Collections.Generic;
using Demographic.Services;
using Demographic.Core;
using System.Linq;
using System.ComponentModel;
using Demographic.Core.Services;

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

        private BackgroundWorker _backgroundWorker;

        //public Engine(EngineConfig config)
        //{
        //    InitEngine(config, null, null);
        //    _isInitializing = true;
        //}
        
        public Engine()
        {
            _isInitializing = false;
        }

        public void InitEngine(EngineConfig config, BackgroundWorker backgroundWorker, DoWorkEventArgs e)
        {
            _backgroundWorker = backgroundWorker;
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
                uint currentCountMales = (uint)(rule.Percent / 1000d / 2d * _startCountPeoples);
                uint currentCountFemales = (uint)(rule.Percent / 1000d / 2d * _startCountPeoples);
                for (int i = 0; i < currentCountMales; i++)
                {
                    if (i % 10000 == 0)
                    {
                        _backgroundWorker?.ReportProgress(0, $"Инициализация жителя. ID жителя = {LabelPointService.GetDividedNumberString(_counterPepolesId)}");
                        if (_backgroundWorker.CancellationPending)
                        {
                            e.Cancel = true;
                            return;
                        }
                    }
                    _persons.Add(new Person(Enums.Gender.Male, null, this, _currentYear - rule.Age));
                }

                for (int i = 0; i < currentCountFemales; i++)
                {
                    if (i % 10000 == 0)
                    {
                        _backgroundWorker?.ReportProgress(0, $"Инициализация жителя. ID жителя = {LabelPointService.GetDividedNumberString(_counterPepolesId)}");
                        if (_backgroundWorker.CancellationPending)
                        {
                            e.Cancel = true;
                            return;
                        }
                    }
                    _persons.Add(new Person(Enums.Gender.Female, null, this, _currentYear - rule.Age));
                }
            }
        }

        public void StartImitation(DoWorkEventArgs e)
        {
            if (!_isInitializing)
            {
                throw new Exception("Движок не иницииализрован");
            }

            YearTick?.Invoke();
            int percantage = (int)((_currentYear - _leftLimitYear) / (double)(_rightLimitYear - _leftLimitYear) * 100d);
            _backgroundWorker.ReportProgress(percantage, $"{percantage}% - {_currentYear} year");
            _snapshotYears.Add(SnapshotYearService.GetSnapshot(_currentYear, _persons, _koeff));

            while (TickYear())
            {
                percantage = (int)((_currentYear - _leftLimitYear) / (double)(_rightLimitYear - _leftLimitYear) * 100d);
                _backgroundWorker.ReportProgress(percantage, $"{percantage}% - {_currentYear} year");
                if (_backgroundWorker.CancellationPending)
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
