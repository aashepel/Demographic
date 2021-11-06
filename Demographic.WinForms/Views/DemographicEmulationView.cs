using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Demographic.Core;
using Demographic.WinForms.Views.Interfaces;

namespace Demographic.WinForms
{
    public partial class DemographicEmulationView : Form, IDemographicEmulationView
    {

        public event Action InitialAgeRulesOpenFileClick;

        public event Action DeathRulesOpenFileClick;

        public event Action<string> CountPersonsStartChange;

        public event Action StartEmulationClick;

        public event Action<int> StartYearValueChange;

        public event Action<int> FinalYearValueChange;

        public event Action<uint> KoeffValueChange;

        public DemographicEmulationView()
        {
            InitializeComponent();

            btnStartEmulation.Click += (sender, e) => StartEmulationClick?.Invoke();
            btnOpenInitialAgeRulesFile.Click += (sender, e) => InitialAgeRulesOpenFileClick?.Invoke();
            btnDeathRuleFileOpen.Click += (sender, e) => DeathRulesOpenFileClick?.Invoke();

            textBoxCountPersonsStart.TextChanged += (sender, e) => CountPersonsStartChange?.Invoke(textBoxCountPersonsStart.Text);
            numericUpDownStartYear.ValueChanged += (sender, e) => StartYearValueChange?.Invoke((int)numericUpDownStartYear.Value);
            numericUpDownFinalYear.ValueChanged += (sender, e) => FinalYearValueChange?.Invoke((int)numericUpDownFinalYear.Value);
            numericUpDownKoeff.ValueChanged += (sender, e) => KoeffValueChange?.Invoke((uint)numericUpDownKoeff.Value);
        }

        void IDemographicEmulationView.RenderCountTotalAlivePersonsChart(List<UIntValuePair> values)
        {
            RenderSplineChart(chartCountTotalAlivePersons, values);
        }

        void IDemographicEmulationView.RenderCountTotalDeathPersonsChart(List<UIntValuePair> values)
        {
            RenderSplineChart(chartCountTotalDeathPersons, values);
        }

        void IDemographicEmulationView.RenderCountTotalMaleAlivePersonsChart(List<UIntValuePair> values)
        {
            RenderSplineChart(chartCountTotalMaleAlivePersons, values);
        }

        void IDemographicEmulationView.RenderCountTotalFemaleAlivePersonsChart(List<UIntValuePair> values)
        {
            RenderSplineChart(chartCountTotalFemaleAlivePersons, values);
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

        private void RenderSplineChart(Chart chart, List<UIntValuePair> values)
        {
            ConfiguringSplineChart(chart);

            var series = chart.Series[0];
            series.Points.Clear();
            foreach (var point in values)
            {
                series.Points.AddXY(point.Key, point.Value);
            }
        }

        void IDemographicEmulationView.RenderBirthRateChart(List<UIntValuePair> values)
        {
            RenderSplineChart(chartBirthPerYear, values);
        }

        void IDemographicEmulationView.RenderDeathRateChart(List<UIntValuePair> values)
        {
            RenderSplineChart(chartDeathPerYear, values);
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
    }
}
