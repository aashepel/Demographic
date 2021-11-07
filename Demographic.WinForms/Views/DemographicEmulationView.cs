using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Demographic.Core;
using Demographic.WinForms.Views.Interfaces;
using Demographic.Core.Services;

namespace Demographic.WinForms
{
    public partial class DemographicEmulationView : Form, IDemographicEmulationView
    {

        private List<Chart> _splineCharts = new List<Chart>();
        private List<Chart> _barCharts = new List<Chart>();
        private System.Windows.Forms.ToolTip _toolTip = new System.Windows.Forms.ToolTip();


        public event Action InitialAgeRulesOpenFileClick;

        public event Action DeathRulesOpenFileClick;

        public event Action<string> CountPersonsStartChange;

        public event Action StartEmulationClick;

        public event Action<int> StartYearValueChange;

        public event Action<int> FinalYearValueChange;

        public event Action<uint> KoeffValueChange;

        public event Action CancelEmulationClick;

        public event Action<uint> YearBarChartsChange;

        public DemographicEmulationView()
        {
            InitializeComponent();

            _splineCharts.Add(chartBirthDeathRate);
            _splineCharts.Add(chartCountTotalAlivePersons);
            _splineCharts.Add(chartCountTotalDeathPersons);
            _splineCharts.Add(chartCountTotalFemaleDeathPersons);
            _splineCharts.Add(chartCountTotalMaleFemaleAlivePersons);
            _splineCharts.Add(chartCountTotalMaleDeathPersons);
            _splineCharts.Add(chartBirthDeathRate);

            _barCharts.Add(chartCountBirthPerYearByAge);
            _barCharts.Add(chartCountDeathPerYearByAge);
            _barCharts.Add(chartCountFemalePersonsAliveByAgeCategories);
            _barCharts.Add(chartCountMalePersonsAliveByAgeCategories);
            _barCharts.Add(chartCountPersonsAliveByAgeCategories);


            btnStartEmulation.Click += (sender, e) => StartEmulationClick?.Invoke();
            btnOpenInitialAgeRulesFile.Click += (sender, e) => InitialAgeRulesOpenFileClick?.Invoke();
            btnDeathRuleFileOpen.Click += (sender, e) => DeathRulesOpenFileClick?.Invoke();
            buttonCancelEmulation.Click += (sender, e) => CancelEmulationClick?.Invoke();

            textBoxCountPersonsStart.TextChanged += (sender, e) => CountPersonsStartChange?.Invoke(textBoxCountPersonsStart.Text);
            numericUpDownStartYear.ValueChanged += (sender, e) => StartYearValueChange?.Invoke((int)numericUpDownStartYear.Value);
            numericUpDownFinalYear.ValueChanged += (sender, e) => FinalYearValueChange?.Invoke((int)numericUpDownFinalYear.Value);
            numericUpDownKoeff.ValueChanged += (sender, e) => KoeffValueChange?.Invoke((uint)numericUpDownKoeff.Value);

            comboBoxYearValues.SelectedValueChanged += (sender, e) => YearBarChartsChange?.Invoke(uint.Parse(comboBoxYearValues.Text));
        }

        void IDemographicEmulationView.RenderCountTotalAlivePersonsChart(List<UIntValuePair> values)
        {
            RenderSplineChart(chartCountTotalAlivePersons, values);
        }

        void IDemographicEmulationView.RenderCountTotalDeathPersonsChart(List<UIntValuePair> values)
        {
            RenderSplineChart(chartCountTotalDeathPersons, values);
        }

        void IDemographicEmulationView.RenderCountTotalMaleFemaleAlivePersonsChart(List<UIntValuePair> valuesMale, List<UIntValuePair> valuesFemale)
        {
            RenderSplineChart(chartCountTotalMaleFemaleAlivePersons, valuesMale, 0, "Мужчины");
            RenderSplineChart(chartCountTotalMaleFemaleAlivePersons, valuesFemale, 1, "Женщины");
        }

        void IView.ShowErrorMessage(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        void IView.ShowDialogYesNo(string message)
        {
            throw new NotImplementedException();
        }

        KeyValuePair<DialogResult, string> IView.ShowFileSelector()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = false;
            openFileDialog.Filter = "Файлы csv|*.csv";
            openFileDialog.InitialDirectory = Application.StartupPath;
            DialogResult dialogResult = openFileDialog.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                return new KeyValuePair<DialogResult, string>(DialogResult.OK, openFileDialog.FileName);
            }
            return new KeyValuePair<DialogResult, string>(DialogResult.Cancel, null);
        }

        void IDemographicEmulationView.SetLabelFilePathInitialAgeRules(string value)
        {
            lblInitialAgeRuleFilePath.Text = value;
        }

        void IDemographicEmulationView.SetLabelFilePathDeathRules(string value)
        {
            lblDeathRuleFilePath.Text = value;
        }

        void IDemographicEmulationView.SetEnabledEmulationStartButton(bool enabled)
        {
            btnStartEmulation.Enabled = enabled;
        }

        void IView.Show()
        {
            this.Show();
        }

        void IView.Close()
        {
            this.Close();
        }

        void IView.ShowInfoMessage(string message)
        {
            MessageBox.Show(message);
        }

        private void ConfiguringSplineChart(Chart chart)
        {
            chart.ChartAreas[0].AxisX.LabelStyle.Angle = 45;
            chart.ChartAreas[0].AxisX.LabelStyle.Interval = 1;
            chart.ChartAreas[0].AxisX.Interval = 1;
        }

        private void ConfiguringBarChart(Chart chart)
        {
            chart.ChartAreas[0].AxisX.LabelStyle.Interval = 1;
            chart.ChartAreas[0].AxisX.Interval = 1;
        }

        private void RenderSplineChart(Chart chart, List<UIntValuePair> values, uint seriesIndex = 0, string seriesText = "")
        {
            if (seriesIndex == 0)
            {
                ConfiguringSplineChart(chart);
            }
            else
            {
                if (chart.Series.Count == seriesIndex)
                {
                    chart.Series.Add($"series {seriesIndex}");
                    chart.Legends.Add("Legend");
                }
                else
                {
                    throw new Exception("Error");
                }
            }

            var series = chart.Series[(int)seriesIndex];
            series.ChartType = SeriesChartType.Spline;
            series.Points.Clear();
            series.BorderWidth = 5;
            series.LegendText = seriesText;
            foreach (var point in values)
            {
                series.Points.AddXY(point.Key, point.Value);
            }
        }

        private void RenderBarChart(Chart chart, List<StringUIntValuePair> values)
        {
            ConfiguringBarChart(chart);

            var series = chart.Series[0];
            uint sum = 0;
            series.Points.Clear();
            foreach(var point in values)
            {
                int indexPoint = series.Points.AddXY(point.Key, point.Value);
                series.Points[indexPoint].Label = LabelPointService.GetShortLabel(point.Value);
                sum += point.Value;
            }

            _toolTip.SetToolTip(chart, $"Сумма: {LabelPointService.GetDividedNumberString(sum)}");
        }

        void IDemographicEmulationView.RenderBirthDeathRateChart(List<UIntValuePair> valuesBirthRate, List<UIntValuePair> valuesDeathRate)
        {
            RenderSplineChart(chartBirthDeathRate, valuesBirthRate, 0, "Рождаемость");
            RenderSplineChart(chartBirthDeathRate, valuesDeathRate, 1, "Смертность");
        }

        void IDemographicEmulationView.SetValuesComboBoxYear(List<int> values)
        {
            comboBoxYearValues.Items.Clear();
            comboBoxYearValues.Items.AddRange(values.Select(x => x.ToString()).ToArray());
        }

        void IDemographicEmulationView.SetProgressBarValue(int value)
        {
            progressBar1.Value = value;
        }

        private void ClearChart(Chart chart)
        {
            foreach(var series in chart.Series)
            {
                series.Points.Clear();
            }
            chart.Legends.Clear();
        }

        public void ClearSplineCharts()
        {
            foreach(var chart in _splineCharts)
            {
                ClearChart(chart);
            }
        }

        void IDemographicEmulationView.SetStatusProgress(string status)
        {
            lblProgressStatus.Text = status;
        }

        void IDemographicEmulationView.RenderCountTotalMaleDeathPersonsChart(List<UIntValuePair> values)
        {
            RenderSplineChart(chartCountTotalMaleDeathPersons, values);
        }

        void IDemographicEmulationView.RenderCountTotalFemaleDeathPersonsChart(List<UIntValuePair> values)
        {
            RenderSplineChart(chartCountTotalFemaleDeathPersons, values);
        }

        void IDemographicEmulationView.RenderCountBirthPerYearByAge(List<StringUIntValuePair> values)
        {
            RenderBarChart(chartCountBirthPerYearByAge, values);
        }

        void IDemographicEmulationView.RenderCountDeathPerYearByAge(List<StringUIntValuePair> values)
        {
            RenderBarChart(chartCountDeathPerYearByAge, values);
        }

        void IDemographicEmulationView.RenderCountPersonsAliveByAgeCategories(List<StringUIntValuePair> values)
        {
            RenderBarChart(chartCountPersonsAliveByAgeCategories, values);
        }

        void IDemographicEmulationView.RenderCountMalePersonsAliveByAgeCategories(List<StringUIntValuePair> values)
        {
            RenderBarChart(chartCountMalePersonsAliveByAgeCategories, values);
        }

        void IDemographicEmulationView.RenderCountFemalePersonsAliveByAgeCategories(List<StringUIntValuePair> values)
        {
            RenderBarChart(chartCountFemalePersonsAliveByAgeCategories, values);
        }

        void IDemographicEmulationView.SetEnabledConditionComboBoxYears(bool enabled)
        {
            comboBoxYearValues.Enabled = enabled;
        }

        public void ClearBarCharts()
        {
            foreach (var chart in _barCharts)
            {
                ClearChart(chart);
            }
        }

        void IDemographicEmulationView.ClearAllCharts()
        {
            ClearBarCharts();
            ClearSplineCharts();
        }

        void IDemographicEmulationView.SetEnabledConditionElementsOnEmulation(bool enabled)
        {
            btnDeathRuleFileOpen.Enabled = enabled;
            btnOpenInitialAgeRulesFile.Enabled = enabled;
            btnStartEmulation.Enabled = enabled;
            comboBoxYearValues.Enabled = enabled;
            textBoxCountPersonsStart.Enabled = enabled;
            numericUpDownStartYear.Enabled = enabled;
            numericUpDownKoeff.Enabled = enabled;
            numericUpDownFinalYear.Enabled = enabled;
        }
    }
}
