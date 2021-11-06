using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demographic.Core
{
    public class SnapshotYear
    {
        public uint Year { get; set; }

        #region CountTotal

        public uint CountTotalAlivePersons { get; set; }

        public uint CountTotalDeathPersons { get; set; }

        public uint CountTotalMaleAlivePersons { get; set; }

        public uint CountTotalFemaleAlivePersons { get; set; }

        public uint CountTotalMaleDeathPersons { get; set; }

        public uint CountTotalFemaleDeathPersons { get; set; }

        #endregion

        #region PerYear

        public uint CountBirthPerYear { get; set; }

        public List<UIntValuePair> CountBirthPerYearByAge { get; set; }

        public uint CountDeathPerYear { get; set; }

        public List<UIntValuePair> CountDeathPerYearByAge { get; set; }

        #endregion

        #region AgeCategoriesCount

        public Dictionary<string, uint> CountPersonsAliveByAgeCategories { get; set; } // 0-18, 19-44, 45-65, 66-100 
        public Dictionary<string, uint> CountMalePersonsAliveByAgeCategories { get; set; } // 0-18, 19-44, 45-65, 66-100
        public Dictionary<string, uint> CountFemalePersonsAliveByAgeCategories { get; set; } // 0-18, 19-44, 45-65, 66-100

        #endregion
    }
}
