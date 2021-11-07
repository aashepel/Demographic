namespace Demographic.WinForms
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title5 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title6 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title7 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title8 = new System.Windows.Forms.DataVisualization.Charting.Title();
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.chartCountTotalFemaleDeathPersons = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartCountTotalMaleDeathPersons = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartDeathPerYear = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartCountTotalMaleAlivePersons = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartBirthPerYear = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartCountTotalAlivePersons = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartCountTotalDeathPersons = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartCountTotalFemaleAlivePersons = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPageBarCharts = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.buttonCancelEmulation = new System.Windows.Forms.Button();
            this.lblProgressStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStartYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFinalYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKoeff)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPageSplineCharts.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartCountTotalFemaleDeathPersons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCountTotalMaleDeathPersons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDeathPerYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCountTotalMaleAlivePersons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartBirthPerYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCountTotalAlivePersons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCountTotalDeathPersons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCountTotalFemaleAlivePersons)).BeginInit();
            this.tabPageBarCharts.SuspendLayout();
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
            // chartCountTotalFemaleDeathPersons
            // 
            chartArea1.Name = "ChartArea1";
            this.chartCountTotalFemaleDeathPersons.ChartAreas.Add(chartArea1);
            this.chartCountTotalFemaleDeathPersons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartCountTotalFemaleDeathPersons.Location = new System.Drawing.Point(3, 1403);
            this.chartCountTotalFemaleDeathPersons.Name = "chartCountTotalFemaleDeathPersons";
            series1.BorderWidth = 5;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.MarkerBorderWidth = 10;
            series1.MarkerSize = 10;
            series1.Name = "Series1";
            this.chartCountTotalFemaleDeathPersons.Series.Add(series1);
            this.chartCountTotalFemaleDeathPersons.Size = new System.Drawing.Size(1880, 194);
            this.chartCountTotalFemaleDeathPersons.TabIndex = 17;
            this.chartCountTotalFemaleDeathPersons.Text = "chart1";
            title1.Name = "MainTitle";
            title1.Text = "Общее количество умерших женщин";
            this.chartCountTotalFemaleDeathPersons.Titles.Add(title1);
            // 
            // chartCountTotalMaleDeathPersons
            // 
            chartArea2.Name = "ChartArea1";
            this.chartCountTotalMaleDeathPersons.ChartAreas.Add(chartArea2);
            this.chartCountTotalMaleDeathPersons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartCountTotalMaleDeathPersons.Location = new System.Drawing.Point(3, 1203);
            this.chartCountTotalMaleDeathPersons.Name = "chartCountTotalMaleDeathPersons";
            series2.BorderWidth = 5;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.MarkerBorderWidth = 10;
            series2.MarkerSize = 10;
            series2.Name = "Series1";
            this.chartCountTotalMaleDeathPersons.Series.Add(series2);
            this.chartCountTotalMaleDeathPersons.Size = new System.Drawing.Size(1880, 194);
            this.chartCountTotalMaleDeathPersons.TabIndex = 16;
            this.chartCountTotalMaleDeathPersons.Text = "chart1";
            title2.Name = "MainTitle";
            title2.Text = "Общее количество умерших мужчин";
            this.chartCountTotalMaleDeathPersons.Titles.Add(title2);
            // 
            // chartDeathPerYear
            // 
            chartArea3.Name = "ChartArea1";
            this.chartDeathPerYear.ChartAreas.Add(chartArea3);
            this.chartDeathPerYear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartDeathPerYear.Location = new System.Drawing.Point(3, 1003);
            this.chartDeathPerYear.Name = "chartDeathPerYear";
            series3.BorderWidth = 5;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Name = "Series1";
            this.chartDeathPerYear.Series.Add(series3);
            this.chartDeathPerYear.Size = new System.Drawing.Size(1880, 194);
            this.chartDeathPerYear.TabIndex = 15;
            this.chartDeathPerYear.Text = "chart1";
            title3.Name = "MainTitle";
            title3.Text = "Смертность";
            this.chartDeathPerYear.Titles.Add(title3);
            // 
            // chartCountTotalMaleAlivePersons
            // 
            chartArea4.Name = "ChartArea1";
            this.chartCountTotalMaleAlivePersons.ChartAreas.Add(chartArea4);
            this.chartCountTotalMaleAlivePersons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartCountTotalMaleAlivePersons.Location = new System.Drawing.Point(3, 403);
            this.chartCountTotalMaleAlivePersons.Name = "chartCountTotalMaleAlivePersons";
            series4.BorderWidth = 5;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.MarkerBorderWidth = 10;
            series4.MarkerSize = 10;
            series4.Name = "Series1";
            this.chartCountTotalMaleAlivePersons.Series.Add(series4);
            this.chartCountTotalMaleAlivePersons.Size = new System.Drawing.Size(1880, 194);
            this.chartCountTotalMaleAlivePersons.TabIndex = 2;
            this.chartCountTotalMaleAlivePersons.Text = "chart1";
            title4.Name = "MainTitle";
            title4.Text = "Динамика населения мужского пола";
            this.chartCountTotalMaleAlivePersons.Titles.Add(title4);
            // 
            // chartBirthPerYear
            // 
            chartArea5.Name = "ChartArea1";
            this.chartBirthPerYear.ChartAreas.Add(chartArea5);
            this.chartBirthPerYear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartBirthPerYear.Location = new System.Drawing.Point(3, 803);
            this.chartBirthPerYear.Name = "chartBirthPerYear";
            series5.BorderWidth = 5;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series5.Name = "Series1";
            this.chartBirthPerYear.Series.Add(series5);
            this.chartBirthPerYear.Size = new System.Drawing.Size(1880, 194);
            this.chartBirthPerYear.TabIndex = 13;
            this.chartBirthPerYear.Text = "chart1";
            title5.Name = "MainTitle";
            title5.Text = "Рождаемость";
            this.chartBirthPerYear.Titles.Add(title5);
            // 
            // chartCountTotalAlivePersons
            // 
            chartArea6.Name = "ChartArea1";
            this.chartCountTotalAlivePersons.ChartAreas.Add(chartArea6);
            this.chartCountTotalAlivePersons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartCountTotalAlivePersons.Location = new System.Drawing.Point(3, 3);
            this.chartCountTotalAlivePersons.Name = "chartCountTotalAlivePersons";
            series6.BorderWidth = 5;
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series6.MarkerBorderWidth = 10;
            series6.MarkerSize = 10;
            series6.Name = "Series1";
            this.chartCountTotalAlivePersons.Series.Add(series6);
            this.chartCountTotalAlivePersons.Size = new System.Drawing.Size(1880, 194);
            this.chartCountTotalAlivePersons.TabIndex = 0;
            this.chartCountTotalAlivePersons.Text = "chartCountTotalAlivePersons";
            title6.Name = "MainTitle";
            title6.Text = "Динамика населения по годам";
            this.chartCountTotalAlivePersons.Titles.Add(title6);
            // 
            // chartCountTotalDeathPersons
            // 
            chartArea7.Name = "ChartArea1";
            this.chartCountTotalDeathPersons.ChartAreas.Add(chartArea7);
            this.chartCountTotalDeathPersons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartCountTotalDeathPersons.Location = new System.Drawing.Point(3, 203);
            this.chartCountTotalDeathPersons.Name = "chartCountTotalDeathPersons";
            series7.BorderWidth = 5;
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series7.MarkerBorderWidth = 10;
            series7.MarkerSize = 10;
            series7.Name = "Series1";
            this.chartCountTotalDeathPersons.Series.Add(series7);
            this.chartCountTotalDeathPersons.Size = new System.Drawing.Size(1880, 194);
            this.chartCountTotalDeathPersons.TabIndex = 1;
            this.chartCountTotalDeathPersons.Text = "chart1";
            title7.Name = "MainTitle";
            title7.Text = "Общее кол-во умерших людей";
            this.chartCountTotalDeathPersons.Titles.Add(title7);
            // 
            // chartCountTotalFemaleAlivePersons
            // 
            chartArea8.Name = "ChartArea1";
            this.chartCountTotalFemaleAlivePersons.ChartAreas.Add(chartArea8);
            this.chartCountTotalFemaleAlivePersons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartCountTotalFemaleAlivePersons.Location = new System.Drawing.Point(3, 603);
            this.chartCountTotalFemaleAlivePersons.Name = "chartCountTotalFemaleAlivePersons";
            series8.BorderWidth = 5;
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series8.MarkerBorderWidth = 10;
            series8.MarkerSize = 10;
            series8.Name = "Series1";
            this.chartCountTotalFemaleAlivePersons.Series.Add(series8);
            this.chartCountTotalFemaleAlivePersons.Size = new System.Drawing.Size(1880, 194);
            this.chartCountTotalFemaleAlivePersons.TabIndex = 3;
            this.chartCountTotalFemaleAlivePersons.Text = "chart1";
            title8.Name = "MainTitle";
            title8.Text = "Динамика населения женского пола";
            this.chartCountTotalFemaleAlivePersons.Titles.Add(title8);
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
            // buttonCancelEmulation
            // 
            this.buttonCancelEmulation.Location = new System.Drawing.Point(12, 110);
            this.buttonCancelEmulation.Name = "buttonCancelEmulation";
            this.buttonCancelEmulation.Size = new System.Drawing.Size(298, 23);
            this.buttonCancelEmulation.TabIndex = 26;
            this.buttonCancelEmulation.Text = "Отменить процесс моделирования";
            this.buttonCancelEmulation.UseVisualStyleBackColor = true;
            // 
            // lblProgressStatus
            // 
            this.lblProgressStatus.AutoSize = true;
            this.lblProgressStatus.Location = new System.Drawing.Point(343, 115);
            this.lblProgressStatus.Name = "lblProgressStatus";
            this.lblProgressStatus.Size = new System.Drawing.Size(0, 13);
            this.lblProgressStatus.TabIndex = 27;
            // 
            // DemographicEmulationView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1904, 1061);
            this.Controls.Add(this.lblProgressStatus);
            this.Controls.Add(this.buttonCancelEmulation);
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
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartCountTotalFemaleDeathPersons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCountTotalMaleDeathPersons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDeathPerYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCountTotalMaleAlivePersons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartBirthPerYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCountTotalAlivePersons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCountTotalDeathPersons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCountTotalFemaleAlivePersons)).EndInit();
            this.tabPageBarCharts.ResumeLayout(false);
            this.tabPageBarCharts.PerformLayout();
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
        private System.Windows.Forms.Button buttonCancelEmulation;
        private System.Windows.Forms.Label lblProgressStatus;
    }
}

