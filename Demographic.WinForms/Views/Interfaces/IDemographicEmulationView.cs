using Demographic.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace Demographic.WinForms.Views.Interfaces
{
    internal interface IDemographicEmulationView : IView
    {
        event Action InitialAgeRulesOpenFileClick;

        event Action DeathRulesOpenFileClick;

        event Action<string> CountPersonsStartChange;

        event Action StartEmulationClick;

        event Action<int> StartYearValueChange;

        event Action<int> FinalYearValueChange;

        event Action<uint> KoeffValueChange;

        event Action CancelEmulationClick;

        event Action<uint> YearBarChartsChange;

        void RenderCountTotalAlivePersonsChart(List<UIntValuePair> values);

        void RenderCountTotalDeathPersonsChart(List<UIntValuePair> values);

        void RenderCountTotalMaleFemaleAlivePersonsChart(List<UIntValuePair> valuesMale, List<UIntValuePair> valuesFemale);

        void RenderBirthDeathRateChart(List<UIntValuePair> valuesBirthRate, List<UIntValuePair> valuesDeathRate);

        void RenderCountTotalMaleDeathPersonsChart(List<UIntValuePair> values);

        void RenderCountTotalFemaleDeathPersonsChart(List<UIntValuePair> values);



        void RenderCountBirthPerYearByAge(List<StringUIntValuePair> values);
        
        void RenderCountDeathPerYearByAge(List <StringUIntValuePair> values);

        void RenderCountPersonsAliveByAgeCategories(List<StringUIntValuePair> values);

        void RenderCountMalePersonsAliveByAgeCategories(List<StringUIntValuePair> values);

        void RenderCountFemalePersonsAliveByAgeCategories(List<StringUIntValuePair> values);


        void SetLabelFilePathInitialAgeRules(string value);

        void SetLabelFilePathDeathRules(string value);

        void SetEnabledConditionComboBoxYears(bool enabled);

        void SetEnabledEmulationStartButton(bool enabled);

        void SetEnabledConditionElementsOnEmulation(bool enabled);

        void SetValuesComboBoxYear(List<int> values);

        void SetProgressBarValue(int value);

        void SetStatusProgress(string status);

        void ClearSplineCharts();

        void ClearBarCharts();

        void ClearAllCharts();
    }
}
