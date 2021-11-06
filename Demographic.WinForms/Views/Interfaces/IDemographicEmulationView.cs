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

        void RenderCountTotalAlivePersonsChart(List<UIntValuePair> values);

        void RenderCountTotalDeathPersonsChart(List<UIntValuePair> values);

        void RenderCountTotalMaleAlivePersonsChart(List<UIntValuePair> values);

        void RenderCountTotalFemaleAlivePersonsChart(List<UIntValuePair> values);

        void RenderBirthRateChart(List<UIntValuePair> values);

        void RenderDeathRateChart(List<UIntValuePair> values);

        void SetLabelFilePathInitialAgeRules(string value);

        void SetLabelFilePathDeathRules(string value);

        void SetEnabledEmulationStartButton(bool enabled);

        void SetValuesComboBoxYear(List<int> values);

        void SetProgressBarValue(int value);

        void ClearSplineCharts();
    }
}
