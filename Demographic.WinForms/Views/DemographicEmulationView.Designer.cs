﻿namespace Demographic.WinForms
{
    partial class DemographicEmulationView
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea25 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series25 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title25 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea26 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series26 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title26 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea27 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series27 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title27 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea28 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series28 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title28 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea29 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series29 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title29 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea30 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series30 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title30 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea31 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series31 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title31 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea32 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series32 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title32 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.comboBoxYearValues = new System.Windows.Forms.ComboBox();
            this.btnOpenInitialAgeRulesFile = new System.Windows.Forms.Button();
            this.lblDeathRuleFilePath = new System.Windows.Forms.Label();
            this.lblInitialAgeRuleFilePath = new System.Windows.Forms.Label();
            this.btnDeathRuleFileOpen = new System.Windows.Forms.Button();
            this.lblYear = new System.Windows.Forms.Label();
            this.btnStartEmulation = new System.Windows.Forms.Button();
            this.numericUpDownStartYear = new System.Windows.Forms.NumericUpDown();
            this.lblStartYear = new System.Windows.Forms.Label();
            this.lblFinalYear = new System.Windows.Forms.Label();
            this.numericUpDownFinalYear = new System.Windows.Forms.NumericUpDown();
            this.lblCountStartPersons = new System.Windows.Forms.Label();
            this.textBoxCountPersonsStart = new System.Windows.Forms.TextBox();
            this.lblKoeff = new System.Windows.Forms.Label();
            this.numericUpDownKoeff = new System.Windows.Forms.NumericUpDown();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageSplineCharts = new System.Windows.Forms.TabPage();
            this.tabPageBarCharts = new System.Windows.Forms.TabPage();
            this.chartCountTotalFemaleAlivePersons = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartCountTotalDeathPersons = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartCountTotalAlivePersons = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartBirthPerYear = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartCountTotalMaleAlivePersons = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartDeathPerYear = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartCountTotalMaleDeathPersons = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartCountTotalFemaleDeathPersons = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStartYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFinalYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKoeff)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPageSplineCharts.SuspendLayout();
            this.tabPageBarCharts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartCountTotalFemaleAlivePersons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCountTotalDeathPersons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCountTotalAlivePersons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartBirthPerYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCountTotalMaleAlivePersons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDeathPerYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCountTotalMaleDeathPersons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCountTotalFemaleDeathPersons)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxYearValues
            // 
            this.comboBoxYearValues.FormattingEnabled = true;
            this.comboBoxYearValues.Location = new System.Drawing.Point(36, 6);
            this.comboBoxYearValues.Name = "comboBoxYearValues";
            this.comboBoxYearValues.Size = new System.Drawing.Size(121, 21);
            this.comboBoxYearValues.TabIndex = 6;
            // 
            // btnOpenInitialAgeRulesFile
            // 
            this.btnOpenInitialAgeRulesFile.Location = new System.Drawing.Point(12, 12);
            this.btnOpenInitialAgeRulesFile.Name = "btnOpenInitialAgeRulesFile";
            this.btnOpenInitialAgeRulesFile.Size = new System.Drawing.Size(325, 23);
            this.btnOpenInitialAgeRulesFile.TabIndex = 7;
            this.btnOpenInitialAgeRulesFile.Text = "Открыть файл с первоначальным возрастным составом населения";
            this.btnOpenInitialAgeRulesFile.UseVisualStyleBackColor = true;
            // 
            // lblDeathRuleFilePath
            // 
            this.lblDeathRuleFilePath.AutoSize = true;
            this.lblDeathRuleFilePath.Location = new System.Drawing.Point(343, 46);
            this.lblDeathRuleFilePath.Name = "lblDeathRuleFilePath";
            this.lblDeathRuleFilePath.Size = new System.Drawing.Size(89, 13);
            this.lblDeathRuleFilePath.TabIndex = 8;
            this.lblDeathRuleFilePath.Text = "Файл не указан";
            // 
            // lblInitialAgeRuleFilePath
            // 
            this.lblInitialAgeRuleFilePath.AutoSize = true;
            this.lblInitialAgeRuleFilePath.Location = new System.Drawing.Point(343, 17);
            this.lblInitialAgeRuleFilePath.Name = "lblInitialAgeRuleFilePath";
            this.lblInitialAgeRuleFilePath.Size = new System.Drawing.Size(89, 13);
            this.lblInitialAgeRuleFilePath.TabIndex = 9;
            this.lblInitialAgeRuleFilePath.Text = "Файл не указан";
            // 
            // btnDeathRuleFileOpen
            // 
            this.btnDeathRuleFileOpen.Location = new System.Drawing.Point(12, 41);
            this.btnDeathRuleFileOpen.Name = "btnDeathRuleFileOpen";
            this.btnDeathRuleFileOpen.Size = new System.Drawing.Size(325, 23);
            this.btnDeathRuleFileOpen.TabIndex = 10;
            this.btnDeathRuleFileOpen.Text = "Открыть файл с правилами вероятности смерти";
            this.btnDeathRuleFileOpen.UseVisualStyleBackColor = true;
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(5, 9);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(25, 13);
            this.lblYear.TabIndex = 11;
            this.lblYear.Text = "Год";
            // 
            // btnStartEmulation
            // 
            this.btnStartEmulation.Location = new System.Drawing.Point(12, 81);
            this.btnStartEmulation.Name = "btnStartEmulation";
            this.btnStartEmulation.Size = new System.Drawing.Size(298, 23);
            this.btnStartEmulation.TabIndex = 12;
            this.btnStartEmulation.Text = "Начать процесс моделирования";
            this.btnStartEmulation.UseVisualStyleBackColor = true;
            // 
            // numericUpDownStartYear
            // 
            this.numericUpDownStartYear.Location = new System.Drawing.Point(1282, 10);
            this.numericUpDownStartYear.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownStartYear.Name = "numericUpDownStartYear";
            this.numericUpDownStartYear.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownStartYear.TabIndex = 15;
            this.numericUpDownStartYear.Value = new decimal(new int[] {
            1970,
            0,
            0,
            0});
            // 
            // lblStartYear
            // 
            this.lblStartYear.AutoSize = true;
            this.lblStartYear.Location = new System.Drawing.Point(1112, 12);
            this.lblStartYear.Name = "lblStartYear";
            this.lblStartYear.Size = new System.Drawing.Size(146, 13);
            this.lblStartYear.TabIndex = 16;
            this.lblStartYear.Text = "Год начала моделирования";
            // 
            // lblFinalYear
            // 
            this.lblFinalYear.AutoSize = true;
            this.lblFinalYear.Location = new System.Drawing.Point(1112, 38);
            this.lblFinalYear.Name = "lblFinalYear";
            this.lblFinalYear.Size = new System.Drawing.Size(164, 13);
            this.lblFinalYear.TabIndex = 18;
            this.lblFinalYear.Text = "Год окончания моделирования";
            // 
            // numericUpDownFinalYear
            // 
            this.numericUpDownFinalYear.Location = new System.Drawing.Point(1282, 36);
            this.numericUpDownFinalYear.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownFinalYear.Name = "numericUpDownFinalYear";
            this.numericUpDownFinalYear.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownFinalYear.TabIndex = 17;
            this.numericUpDownFinalYear.Value = new decimal(new int[] {
            2021,
            0,
            0,
            0});
            // 
            // lblCountStartPersons
            // 
            this.lblCountStartPersons.AutoSize = true;
            this.lblCountStartPersons.Location = new System.Drawing.Point(1434, 12);
            this.lblCountStartPersons.Name = "lblCountStartPersons";
            this.lblCountStartPersons.Size = new System.Drawing.Size(231, 13);
            this.lblCountStartPersons.TabIndex = 19;
            this.lblCountStartPersons.Text = "Количетсво людей в начале моделирования";
            // 
            // textBoxCountPersonsStart
            // 
            this.textBoxCountPersonsStart.Location = new System.Drawing.Point(1671, 9);
            this.textBoxCountPersonsStart.Name = "textBoxCountPersonsStart";
            this.textBoxCountPersonsStart.Size = new System.Drawing.Size(216, 20);
            this.textBoxCountPersonsStart.TabIndex = 20;
            this.textBoxCountPersonsStart.Text = "130000000";
            // 
            // lblKoeff
            // 
            this.lblKoeff.AutoSize = true;
            this.lblKoeff.Location = new System.Drawing.Point(1434, 36);
            this.lblKoeff.Name = "lblKoeff";
            this.lblKoeff.Size = new System.Drawing.Size(77, 13);
            this.lblKoeff.TabIndex = 21;
            this.lblKoeff.Text = "Коэффициент";
            // 
            // numericUpDownKoeff
            // 
            this.numericUpDownKoeff.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownKoeff.Location = new System.Drawing.Point(1517, 34);
            this.numericUpDownKoeff.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownKoeff.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownKoeff.Name = "numericUpDownKoeff";
            this.numericUpDownKoeff.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownKoeff.TabIndex = 22;
            this.numericUpDownKoeff.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageSplineCharts);
            this.tabControl1.Controls.Add(this.tabPageBarCharts);
            this.tabControl1.Location = new System.Drawing.Point(12, 144);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1880, 905);
            this.tabControl1.TabIndex = 24;
            // 
            // tabPageSplineCharts
            // 
            this.tabPageSplineCharts.AutoScroll = true;
            this.tabPageSplineCharts.Controls.Add(this.tableLayoutPanel1);
            this.tabPageSplineCharts.Location = new System.Drawing.Point(4, 22);
            this.tabPageSplineCharts.Name = "tabPageSplineCharts";
            this.tabPageSplineCharts.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSplineCharts.Size = new System.Drawing.Size(1872, 879);
            this.tabPageSplineCharts.TabIndex = 0;
            this.tabPageSplineCharts.Text = "Spline Charts";
            this.tabPageSplineCharts.UseVisualStyleBackColor = true;
            // 
            // tabPageBarCharts
            // 
            this.tabPageBarCharts.Controls.Add(this.tableLayoutPanel2);
            this.tabPageBarCharts.Controls.Add(this.comboBoxYearValues);
            this.tabPageBarCharts.Controls.Add(this.lblYear);
            this.tabPageBarCharts.Location = new System.Drawing.Point(4, 22);
            this.tabPageBarCharts.Name = "tabPageBarCharts";
            this.tabPageBarCharts.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBarCharts.Size = new System.Drawing.Size(1872, 879);
            this.tabPageBarCharts.TabIndex = 1;
            this.tabPageBarCharts.Text = "BarCharts";
            this.tabPageBarCharts.UseVisualStyleBackColor = true;
            // 
            // chartCountTotalFemaleAlivePersons
            // 
            chartArea25.Name = "ChartArea1";
            this.chartCountTotalFemaleAlivePersons.ChartAreas.Add(chartArea25);
            this.chartCountTotalFemaleAlivePersons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartCountTotalFemaleAlivePersons.Location = new System.Drawing.Point(3, 603);
            this.chartCountTotalFemaleAlivePersons.Name = "chartCountTotalFemaleAlivePersons";
            series25.BorderWidth = 5;
            series25.ChartArea = "ChartArea1";
            series25.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series25.MarkerBorderWidth = 10;
            series25.MarkerSize = 10;
            series25.Name = "Series1";
            this.chartCountTotalFemaleAlivePersons.Series.Add(series25);
            this.chartCountTotalFemaleAlivePersons.Size = new System.Drawing.Size(1880, 194);
            this.chartCountTotalFemaleAlivePersons.TabIndex = 3;
            this.chartCountTotalFemaleAlivePersons.Text = "chart1";
            title25.Name = "MainTitle";
            title25.Text = "Динамика населения женского пола по годам";
            this.chartCountTotalFemaleAlivePersons.Titles.Add(title25);
            // 
            // chartCountTotalDeathPersons
            // 
            chartArea26.Name = "ChartArea1";
            this.chartCountTotalDeathPersons.ChartAreas.Add(chartArea26);
            this.chartCountTotalDeathPersons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartCountTotalDeathPersons.Location = new System.Drawing.Point(3, 203);
            this.chartCountTotalDeathPersons.Name = "chartCountTotalDeathPersons";
            series26.BorderWidth = 5;
            series26.ChartArea = "ChartArea1";
            series26.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series26.MarkerBorderWidth = 10;
            series26.MarkerSize = 10;
            series26.Name = "Series1";
            this.chartCountTotalDeathPersons.Series.Add(series26);
            this.chartCountTotalDeathPersons.Size = new System.Drawing.Size(1880, 194);
            this.chartCountTotalDeathPersons.TabIndex = 1;
            this.chartCountTotalDeathPersons.Text = "chart1";
            title26.Name = "MainTitle";
            title26.Text = "Динамика умершего населения по годам";
            this.chartCountTotalDeathPersons.Titles.Add(title26);
            // 
            // chartCountTotalAlivePersons
            // 
            chartArea27.Name = "ChartArea1";
            this.chartCountTotalAlivePersons.ChartAreas.Add(chartArea27);
            this.chartCountTotalAlivePersons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartCountTotalAlivePersons.Location = new System.Drawing.Point(3, 3);
            this.chartCountTotalAlivePersons.Name = "chartCountTotalAlivePersons";
            series27.BorderWidth = 5;
            series27.ChartArea = "ChartArea1";
            series27.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series27.MarkerBorderWidth = 10;
            series27.MarkerSize = 10;
            series27.Name = "Series1";
            this.chartCountTotalAlivePersons.Series.Add(series27);
            this.chartCountTotalAlivePersons.Size = new System.Drawing.Size(1880, 194);
            this.chartCountTotalAlivePersons.TabIndex = 0;
            this.chartCountTotalAlivePersons.Text = "chartCountTotalAlivePersons";
            title27.Name = "MainTitle";
            title27.Text = "Динамика населения по годам";
            this.chartCountTotalAlivePersons.Titles.Add(title27);
            // 
            // chartBirthPerYear
            // 
            chartArea28.Name = "ChartArea1";
            this.chartBirthPerYear.ChartAreas.Add(chartArea28);
            this.chartBirthPerYear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartBirthPerYear.Location = new System.Drawing.Point(3, 803);
            this.chartBirthPerYear.Name = "chartBirthPerYear";
            series28.BorderWidth = 5;
            series28.ChartArea = "ChartArea1";
            series28.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series28.Name = "Series1";
            this.chartBirthPerYear.Series.Add(series28);
            this.chartBirthPerYear.Size = new System.Drawing.Size(1880, 194);
            this.chartBirthPerYear.TabIndex = 13;
            this.chartBirthPerYear.Text = "chart1";
            title28.Name = "MainTitle";
            title28.Text = "Рождаемость";
            this.chartBirthPerYear.Titles.Add(title28);
            // 
            // chartCountTotalMaleAlivePersons
            // 
            chartArea29.Name = "ChartArea1";
            this.chartCountTotalMaleAlivePersons.ChartAreas.Add(chartArea29);
            this.chartCountTotalMaleAlivePersons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartCountTotalMaleAlivePersons.Location = new System.Drawing.Point(3, 403);
            this.chartCountTotalMaleAlivePersons.Name = "chartCountTotalMaleAlivePersons";
            series29.BorderWidth = 5;
            series29.ChartArea = "ChartArea1";
            series29.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series29.MarkerBorderWidth = 10;
            series29.MarkerSize = 10;
            series29.Name = "Series1";
            this.chartCountTotalMaleAlivePersons.Series.Add(series29);
            this.chartCountTotalMaleAlivePersons.Size = new System.Drawing.Size(1880, 194);
            this.chartCountTotalMaleAlivePersons.TabIndex = 2;
            this.chartCountTotalMaleAlivePersons.Text = "chart1";
            title29.Name = "MainTitle";
            title29.Text = "Динамика населения мужского пола по годам";
            this.chartCountTotalMaleAlivePersons.Titles.Add(title29);
            // 
            // chartDeathPerYear
            // 
            chartArea30.Name = "ChartArea1";
            this.chartDeathPerYear.ChartAreas.Add(chartArea30);
            this.chartDeathPerYear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartDeathPerYear.Location = new System.Drawing.Point(3, 1003);
            this.chartDeathPerYear.Name = "chartDeathPerYear";
            series30.BorderWidth = 5;
            series30.ChartArea = "ChartArea1";
            series30.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series30.Name = "Series1";
            this.chartDeathPerYear.Series.Add(series30);
            this.chartDeathPerYear.Size = new System.Drawing.Size(1880, 194);
            this.chartDeathPerYear.TabIndex = 15;
            this.chartDeathPerYear.Text = "chart1";
            title30.Name = "MainTitle";
            title30.Text = "Смертность";
            this.chartDeathPerYear.Titles.Add(title30);
            // 
            // chartCountTotalMaleDeathPersons
            // 
            chartArea31.Name = "ChartArea1";
            this.chartCountTotalMaleDeathPersons.ChartAreas.Add(chartArea31);
            this.chartCountTotalMaleDeathPersons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartCountTotalMaleDeathPersons.Location = new System.Drawing.Point(3, 1203);
            this.chartCountTotalMaleDeathPersons.Name = "chartCountTotalMaleDeathPersons";
            series31.BorderWidth = 5;
            series31.ChartArea = "ChartArea1";
            series31.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series31.MarkerBorderWidth = 10;
            series31.MarkerSize = 10;
            series31.Name = "Series1";
            this.chartCountTotalMaleDeathPersons.Series.Add(series31);
            this.chartCountTotalMaleDeathPersons.Size = new System.Drawing.Size(1880, 194);
            this.chartCountTotalMaleDeathPersons.TabIndex = 16;
            this.chartCountTotalMaleDeathPersons.Text = "chart1";
            title31.Name = "MainTitle";
            title31.Text = "Количество умерших мужчин по годам";
            this.chartCountTotalMaleDeathPersons.Titles.Add(title31);
            // 
            // chartCountTotalFemaleDeathPersons
            // 
            chartArea32.Name = "ChartArea1";
            this.chartCountTotalFemaleDeathPersons.ChartAreas.Add(chartArea32);
            this.chartCountTotalFemaleDeathPersons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartCountTotalFemaleDeathPersons.Location = new System.Drawing.Point(3, 1403);
            this.chartCountTotalFemaleDeathPersons.Name = "chartCountTotalFemaleDeathPersons";
            series32.BorderWidth = 5;
            series32.ChartArea = "ChartArea1";
            series32.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series32.MarkerBorderWidth = 10;
            series32.MarkerSize = 10;
            series32.Name = "Series1";
            this.chartCountTotalFemaleDeathPersons.Series.Add(series32);
            this.chartCountTotalFemaleDeathPersons.Size = new System.Drawing.Size(1880, 194);
            this.chartCountTotalFemaleDeathPersons.TabIndex = 17;
            this.chartCountTotalFemaleDeathPersons.Text = "chart1";
            title32.Name = "MainTitle";
            title32.Text = "Количество умерших женщин по годам";
            this.chartCountTotalFemaleDeathPersons.Titles.Add(title32);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.chartCountTotalFemaleDeathPersons, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.chartCountTotalMaleDeathPersons, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.chartDeathPerYear, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.chartCountTotalMaleAlivePersons, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.chartBirthPerYear, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.chartCountTotalAlivePersons, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.chartCountTotalDeathPersons, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.chartCountTotalFemaleAlivePersons, 0, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1886, 1600);
            this.tableLayoutPanel1.TabIndex = 23;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Location = new System.Drawing.Point(8, 33);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1858, 100);
            this.tableLayoutPanel2.TabIndex = 12;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(346, 81);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(320, 23);
            this.progressBar1.TabIndex = 25;
            // 
            // DemographicEmulationView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1904, 1061);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.numericUpDownKoeff);
            this.Controls.Add(this.lblKoeff);
            this.Controls.Add(this.textBoxCountPersonsStart);
            this.Controls.Add(this.lblCountStartPersons);
            this.Controls.Add(this.lblFinalYear);
            this.Controls.Add(this.numericUpDownFinalYear);
            this.Controls.Add(this.lblStartYear);
            this.Controls.Add(this.numericUpDownStartYear);
            this.Controls.Add(this.btnStartEmulation);
            this.Controls.Add(this.btnDeathRuleFileOpen);
            this.Controls.Add(this.lblInitialAgeRuleFilePath);
            this.Controls.Add(this.lblDeathRuleFilePath);
            this.Controls.Add(this.btnOpenInitialAgeRulesFile);
            this.Name = "DemographicEmulationView";
            this.Text = "DemographicEmulation";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStartYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFinalYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKoeff)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPageSplineCharts.ResumeLayout(false);
            this.tabPageSplineCharts.PerformLayout();
            this.tabPageBarCharts.ResumeLayout(false);
            this.tabPageBarCharts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartCountTotalFemaleAlivePersons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCountTotalDeathPersons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCountTotalAlivePersons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartBirthPerYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCountTotalMaleAlivePersons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDeathPerYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCountTotalMaleDeathPersons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCountTotalFemaleDeathPersons)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBoxYearValues;
        private System.Windows.Forms.Button btnOpenInitialAgeRulesFile;
        private System.Windows.Forms.Label lblDeathRuleFilePath;
        private System.Windows.Forms.Label lblInitialAgeRuleFilePath;
        private System.Windows.Forms.Button btnDeathRuleFileOpen;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Button btnStartEmulation;
        private System.Windows.Forms.NumericUpDown numericUpDownStartYear;
        private System.Windows.Forms.Label lblStartYear;
        private System.Windows.Forms.Label lblFinalYear;
        private System.Windows.Forms.NumericUpDown numericUpDownFinalYear;
        private System.Windows.Forms.Label lblCountStartPersons;
        private System.Windows.Forms.TextBox textBoxCountPersonsStart;
        private System.Windows.Forms.Label lblKoeff;
        private System.Windows.Forms.NumericUpDown numericUpDownKoeff;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageBarCharts;
        private System.Windows.Forms.TabPage tabPageSplineCharts;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCountTotalFemaleAlivePersons;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCountTotalDeathPersons;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCountTotalAlivePersons;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartBirthPerYear;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCountTotalMaleAlivePersons;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDeathPerYear;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCountTotalMaleDeathPersons;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCountTotalFemaleDeathPersons;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}
