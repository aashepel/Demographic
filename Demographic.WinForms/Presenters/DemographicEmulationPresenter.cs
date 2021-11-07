using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Demographic.Core;
using Demographic.WinForms.Views.Interfaces;

namespace Demographic.WinForms.Presenters
{
    internal class DemographicEmulationPresenter
    {
        IDemographicEmulationView _view;
        IEngine _engine;
        EngineConfig _engineConfig = new EngineConfig();
        List<SnapshotYear> _snapshots;
        BackgroundWorker _backgroundWorker;

        internal DemographicEmulationPresenter(IDemographicEmulationView view, IEngine engine)
        {
            _view = view;
            _engine = engine;

            _engineConfig.LeftLimitYear = 1970;
            _engineConfig.RightLimitYear = 2021;
            _engineConfig.StartCountPeoples = 130000000;
            _engineConfig.Koeff = 1000;

            _view.StartEmulationClick += OnStartEmulationClicked;
            _view.InitialAgeRulesOpenFileClick += OnInitialAgeRulesOpenFileClicked;
            _view.DeathRulesOpenFileClick += OnDeathRulesOpenFileClicked;
            _view.StartYearValueChange += (year) => OnStartYearValueChanged(year);
            _view.FinalYearValueChange += (year) => OnFinalYearValueChanged(year);
            _view.CountPersonsStartChange += (value) => OnCountPersonsValueChanged(value);
            _view.KoeffValueChange += (value) => OnKoeffValueChange(value);
            _view.CancelEmulationClick += OnCancelEmulationClick;
        }

        public void OnCancelEmulationClick()
        {
            if (_backgroundWorker != null && _backgroundWorker.IsBusy)
            {
                _backgroundWorker.CancelAsync();
                _view.SetProgressBarValue(0);
            }
        }

        public void OnKoeffValueChange(uint value)
        {
            _engineConfig.Koeff = value;
        }

        public void OnCountPersonsValueChanged(string value)
        {
            uint iValue;
            if (uint.TryParse(value, out iValue))
            {
                _engineConfig.StartCountPeoples = iValue;
                _view.SetEnabledEmulationStartButton(true);
            }
            else
            {
                _view.SetEnabledEmulationStartButton(false);
            }
        }

        public void OnFinalYearValueChanged(int year)
        {
            _engineConfig.RightLimitYear = (uint)year;
        }

        public void OnStartYearValueChanged(int year)
        {
            _engineConfig.LeftLimitYear = (uint)year;
        }

        public void OnStartEmulationClicked()
        {
            if (_engineConfig.FilePathDeathRule == null || _engineConfig.FilePathInitialAge == null)
            {
                _view.ShowErrorMessage("Сначала выберите все файлы");
                return;
            }
            _backgroundWorker = new BackgroundWorker();
            _backgroundWorker.WorkerReportsProgress = true;
            _backgroundWorker.WorkerSupportsCancellation = true;
            _backgroundWorker.DoWork += new DoWorkEventHandler(worker_doWork);
            _backgroundWorker.ProgressChanged += (o, e) =>
            {
                _snapshots = _engine.SnapshotYears;
                _view.SetProgressBarValue(e.ProgressPercentage);
                _view.SetStatusProgress(e.UserState as string);
            };
            _backgroundWorker.RunWorkerCompleted += (o, e) => OnEmulationEnd(e.Cancelled);
            _backgroundWorker.RunWorkerAsync();
        }

        private void worker_doWork(object sender, DoWorkEventArgs e)
        {
            _engine.InitEngine(_engineConfig);
            _backgroundWorker.ReportProgress(0, $"0% - Движок проинициализирован");
            _engine.StartImitation(_backgroundWorker, e);

            if (e.Cancel) return;

            _view.ShowInfoMessage("Моделирование окончено");
            _snapshots = _engine.SnapshotYears;
        }

        private void OnEmulationEnd(bool cancelled)
        {
            _view.SetProgressBarValue(0);
            _view.SetStatusProgress("");
            _view.ClearSplineCharts();
            if (cancelled)
            {
                _view.ShowInfoMessage("Операция была прервана");
                return;
            }
            RenderCharts();
        }

        private void RenderCharts()
        {
            var values1 = _snapshots.Select(p => new UIntValuePair { Key = p.Year, Value = p.CountTotalAlivePersons }).ToList();
            _view.RenderCountTotalAlivePersonsChart(values1);
            var values2 = _snapshots.Select(p => new UIntValuePair { Key = p.Year, Value = p.CountTotalDeathPersons }).ToList();
            _view.RenderCountTotalDeathPersonsChart(values2);
            var values3 = _snapshots.Select(p => new UIntValuePair { Key = p.Year, Value = p.CountTotalMaleAlivePersons }).ToList();
            _view.RenderCountTotalMaleAlivePersonsChart(values3);
            var values4 = _snapshots.Select(p => new UIntValuePair { Key = p.Year, Value = p.CountTotalFemaleAlivePersons }).ToList();
            _view.RenderCountTotalFemaleAlivePersonsChart(values4);
            var values5 = _snapshots.Select(p => new UIntValuePair { Key = p.Year, Value = p.CountBirthPerYear }).ToList();
            _view.RenderBirthRateChart(values5);
            var values6 = _snapshots.Select(p => new UIntValuePair { Key = p.Year, Value = p.CountDeathPerYear }).ToList();
            _view.RenderDeathRateChart(values6);
            var values7 = _snapshots.Select(p => new UIntValuePair { Key = p.Year, Value = p.CountTotalMaleDeathPersons }).ToList();
            _view.RenderCountTotalMaleDeathPersonsChart(values7);
            var values8 = _snapshots.Select(p => new UIntValuePair { Key = p.Year, Value = p.CountTotalFemaleDeathPersons }).ToList();
            _view.RenderCountTotalFemaleDeathPersonsChart(values8);
            var comboBoxYearValues = Enumerable.Range((int)_engineConfig.LeftLimitYear, (int)(_engineConfig.RightLimitYear - _engineConfig.LeftLimitYear + 1)).ToList();
            _view.SetValuesComboBoxYear(comboBoxYearValues);
        }

        public void OnInitialAgeRulesOpenFileClicked()
        {
            var result = _view.ShowFileSelector();
            if (result.Key == System.Windows.Forms.DialogResult.OK)
            {
                OnInitialAgeRulesFilePathChanged(result.Value);
            }
        }

        public void OnDeathRulesOpenFileClicked()
        {
            var result = _view.ShowFileSelector();
            if (result.Key == System.Windows.Forms.DialogResult.OK)
            {
                OnDeathRulesFilePathChanged(result.Value);
            }
        }

        public void OnInitialAgeRulesFilePathChanged(string filePath)
        {
            _engineConfig.FilePathInitialAge = filePath;
            _view.SetLabelFilePathInitialAgeRules(filePath);
        }

        public void OnDeathRulesFilePathChanged(string filePath)
        {
            _engineConfig.FilePathDeathRule = filePath;
            _view.SetLabelFilePathDeathRules(filePath);
        }

    }
}
