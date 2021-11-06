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

            var personsBornThisYear = persons.Where(p => p.YearOfBirth == year).ToList();

            snapshotYear.CountBirthPerYear = (uint)personsBornThisYear.Count() * koeff;

            snapshotYear.CountBirthPerYearByAge = new List<UIntValuePair>();

            foreach(var person in personsBornThisYear)
            {
                if (person.MotherId == null) continue;
                var motherPerson = persons.FirstOrDefault(p => p.Id == person.MotherId);

                if (motherPerson == null) continue;

                try
                {
                    var itemDictionary = snapshotYear.CountBirthPerYearByAge.First(p => p.Key == motherPerson.Age);
                    itemDictionary.Value += koeff;
                }
                catch
                {
                    snapshotYear.CountBirthPerYearByAge.Add(new UIntValuePair { Key = motherPerson.Age, Value = koeff});
                }
            }

            var personsDiedThisYear = persons.Where(p => p.YearOfDeath != null && p.YearOfDeath == year).ToList();

            snapshotYear.CountDeathPerYear = (uint)personsDiedThisYear.Count() * koeff;

            snapshotYear.CountDeathPerYearByAge = new List<UIntValuePair>();

            foreach (var person in personsDiedThisYear)
            {
                try
                {
                    var itemDictionary = snapshotYear.CountDeathPerYearByAge.First(p => p.Key == person.Age);
                    itemDictionary.Value += koeff;
                }
                catch
                {
                    snapshotYear.CountDeathPerYearByAge.Add(new UIntValuePair { Key = person.Age, Value = koeff});
                }
            }

            #endregion

            #region AgeCategoriesCount

            Dictionary<string, List<Person>> personsByAgeCategories = new Dictionary<string, List<Person>>();

            personsByAgeCategories.Add("0-18", persons.Where(p => p.LifeStatus == Enums.LifeStatus.Alive && p.Age >= 0 && p.Age <= 18).ToList());
            personsByAgeCategories.Add("19-44", persons.Where(p => p.LifeStatus == Enums.LifeStatus.Alive && p.Age >= 19 && p.Age <= 44).ToList());
            personsByAgeCategories.Add("45-65", persons.Where(p => p.LifeStatus == Enums.LifeStatus.Alive && p.Age >= 45 && p.Age <= 65).ToList());
            personsByAgeCategories.Add("66+", persons.Where(p => p.LifeStatus == Enums.LifeStatus.Alive && p.Age >= 66).ToList());

            snapshotYear.CountPersonsAliveByAgeCategories = new Dictionary<string, uint>();

            foreach (var item in personsByAgeCategories)
            {
                snapshotYear.CountPersonsAliveByAgeCategories.Add(item.Key, (uint)item.Value.Count() * koeff);
            }

            snapshotYear.CountMalePersonsAliveByAgeCategories = new Dictionary<string, uint>();

            foreach (var item in personsByAgeCategories)
            {
                snapshotYear.CountMalePersonsAliveByAgeCategories.Add(item.Key, (uint)item.Value.Count(p => p.Gender == Enums.Gender.Male) * koeff);
            }

            snapshotYear.CountFemalePersonsAliveByAgeCategories = new Dictionary<string, uint>();

            foreach (var item in personsByAgeCategories)
            {
                snapshotYear.CountFemalePersonsAliveByAgeCategories.Add(item.Key, (uint)item.Value.Count(p => p.Gender == Enums.Gender.Female) * koeff);
            }

            #endregion

            return snapshotYear;
        }
    }
}
