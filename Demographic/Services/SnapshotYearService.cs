using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demographic.Core;

namespace Demographic.Services
{
    public static class SnapshotYearService
    {
        public static SnapshotYear GetSnapshot(uint year, List<Person> persons, uint koeff)
        {
            SnapshotYear snapshotYear = new SnapshotYear();
            snapshotYear.Year = year;

            #region CountTotal

            snapshotYear.CountTotalAlivePersons = (uint)persons.Count(p => p.LifeStatus == Enums.LifeStatus.Alive) * koeff;

            snapshotYear.CountTotalDeathPersons = (uint)persons.Count(p => p.LifeStatus == Enums.LifeStatus.Dead) * koeff;

            snapshotYear.CountTotalMaleAlivePersons = (uint)persons.Count(p => p.LifeStatus == Enums.LifeStatus.Alive && p.Gender == Enums.Gender.Male) * koeff;

            snapshotYear.CountTotalFemaleAlivePersons = (uint)persons.Count(p => p.LifeStatus == Enums.LifeStatus.Alive && p.Gender == Enums.Gender.Female) * koeff;

            snapshotYear.CountTotalMaleDeathPersons = (uint)persons.Count(p => p.LifeStatus == Enums.LifeStatus.Dead && p.Gender == Enums.Gender.Male) * koeff;

            snapshotYear.CountTotalFemaleDeathPersons = (uint)persons.Count(p => p.LifeStatus == Enums.LifeStatus.Dead && p.Gender == Enums.Gender.Female) * koeff;

            #endregion

            #region PerYear

            var personsBornThisYear = persons.Where(p => p.YearOfBirth == year && p.MotherId != null).ToList();

            snapshotYear.CountBirthPerYear = (uint)personsBornThisYear.Count() * koeff;

            snapshotYear.CountBirthPerYearByAge = new List<StringUIntValuePair>();

            foreach(var person in personsBornThisYear)
            {
                var motherPerson = persons.FirstOrDefault(p => p.Id == person.MotherId);

                if (motherPerson == null) continue;

                try
                {
                    var itemDictionary = snapshotYear.CountBirthPerYearByAge.First(p => p.Key == motherPerson.Age.ToString());
                    itemDictionary.Value += koeff;
                }
                catch
                {
                    snapshotYear.CountBirthPerYearByAge.Add(new StringUIntValuePair { Key = motherPerson.Age.ToString(), Value = koeff});
                }
            }

            snapshotYear.CountBirthPerYearByAge = snapshotYear.CountBirthPerYearByAge.OrderBy(p => uint.Parse(p.Key)).ToList();

            var personsDiedThisYear = persons.Where(p => p.YearOfDeath != null && p.YearOfDeath == year).ToList();

            snapshotYear.CountDeathPerYear = (uint)personsDiedThisYear.Count() * koeff;

            snapshotYear.CountDeathPerYearByAge = new List<StringUIntValuePair>();

            foreach (var person in personsDiedThisYear)
            {
                try
                {
                    var itemDictionary = snapshotYear.CountDeathPerYearByAge.First(p => p.Key == person.Age.ToString());
                    itemDictionary.Value += koeff;
                }
                catch
                {
                    snapshotYear.CountDeathPerYearByAge.Add(new StringUIntValuePair { Key = person.Age.ToString(), Value = koeff});
                }
            }

            snapshotYear.CountDeathPerYearByAge = snapshotYear.CountDeathPerYearByAge.OrderBy(p => uint.Parse(p.Key)).ToList();

            #endregion

            #region AgeCategoriesCount

            Dictionary<string, List<Person>> personsByAgeCategories = new Dictionary<string, List<Person>>();

            personsByAgeCategories.Add("0-17", persons.Where(p => p.LifeStatus == Enums.LifeStatus.Alive && p.Age >= 0 && p.Age <= 17).ToList());
            personsByAgeCategories.Add("18-45", persons.Where(p => p.LifeStatus == Enums.LifeStatus.Alive && p.Age >= 18 && p.Age <= 45).ToList());
            personsByAgeCategories.Add("46-65", persons.Where(p => p.LifeStatus == Enums.LifeStatus.Alive && p.Age >= 46 && p.Age <= 65).ToList());
            personsByAgeCategories.Add("66+", persons.Where(p => p.LifeStatus == Enums.LifeStatus.Alive && p.Age >= 66).ToList());

            snapshotYear.CountPersonsAliveByAgeCategories = new List<StringUIntValuePair>();

            foreach (var item in personsByAgeCategories)
            {
                snapshotYear.CountPersonsAliveByAgeCategories.Add(new StringUIntValuePair { Key = item.Key, Value = (uint)item.Value.Count() * koeff });
            }

            snapshotYear.CountMalePersonsAliveByAgeCategories = new List<StringUIntValuePair>();

            foreach (var item in personsByAgeCategories)
            {
                snapshotYear.CountMalePersonsAliveByAgeCategories.Add(new StringUIntValuePair { Key = item.Key, Value = (uint)item.Value.Count(p => p.Gender == Enums.Gender.Male) * koeff });
            }

            snapshotYear.CountFemalePersonsAliveByAgeCategories = new List<StringUIntValuePair>();

            foreach (var item in personsByAgeCategories)
            {
                snapshotYear.CountFemalePersonsAliveByAgeCategories.Add(new StringUIntValuePair { Key = item.Key, Value = (uint)item.Value.Count(p => p.Gender == Enums.Gender.Female) * koeff });
            }

            #endregion

            return snapshotYear;
        }
    }
}
