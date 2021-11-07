using Demographic.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demographic
{
    public class Person
    {
        private readonly Gender _gender;
        private uint _age = 0;
        private readonly uint _yearOfBirth;
        private uint? _yearOfDeath = null;
        private readonly UInt64 _id;
        private readonly UInt64? _motherId;
        private LifeStatus _lifeStatus = LifeStatus.Alive;
        private IEngine _engine;

        public Person(Gender gender, UInt64? motherId, IEngine engine, uint age = 0)
        {
            _age = age;
            _gender = gender;
            _motherId = motherId;
            _engine = engine;
            _id = _engine.CounterPepoles;
            _yearOfBirth = engine.CurrentYear - _age;
            _engine.YearTick += yearPlusPlus;
        }

        public Gender Gender
        {
            get { return _gender; }
        }

        public UInt64 Id
        { 
            get { return _id; }
        }

        public UInt64? MotherId
        {
            get { return _motherId; }
        }

        public uint Age
        {
            get { return _age; }
        }

        public LifeStatus LifeStatus
        {
            get { return _lifeStatus; }
        }

        public uint YearOfBirth
        {
            get { return _yearOfBirth; }
        }

        public uint? YearOfDeath
        { 
            get { return _yearOfDeath; }
        }

        private void yearPlusPlus()
        {
            if (_lifeStatus == LifeStatus.Dead)
            {
                throw new Exception("Did not unsubscribe");
            }
            _age++;
            if (_engine.DeathProbablilityService.IsDeath(this))
            {
                _yearOfDeath = _engine.CurrentYear;
                _lifeStatus = LifeStatus.Dead;
                _engine.YearTick -= yearPlusPlus;
            }
            else
            {
                BirthChild();
            }
        }

        private void BirthChild()
        {   
            if (_lifeStatus == LifeStatus.Alive && _gender == Gender.Female && _age >= 18 && _age <= 45 && ProbabilityCalculator.IsEventHappened(0.151))
            {
                Gender gender;
                if (ProbabilityCalculator.IsEventHappened(0.55))
                {
                    gender = Gender.Male;
                }
                else
                {
                    gender = Gender.Female;
                }
                var person = new Person(gender, this.Id, _engine);
                _engine.OnChildBirth(person);
            }
        }
    }
}
