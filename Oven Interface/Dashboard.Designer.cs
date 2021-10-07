
namespace Oven_Interface
{
    partial class Dashboard
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.startProgramButton = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.stopProgramButton = new System.Windows.Forms.Button();
            this.continueProgramButton = new System.Windows.Forms.Button();
            this.pauseProgramButton = new System.Windows.Forms.Button();
            this.minutesLeftLabel = new System.Windows.Forms.Label();
            this.minutesLeftInfoLabel = new System.Windows.Forms.Label();
            this.turnOnTestDiodButton = new System.Windows.Forms.Button();
            this.turnOffTestDiodButton = new System.Windows.Forms.Button();
            this.connectionStatusInfoLabel = new System.Windows.Forms.Label();
            this.labelConnectionStatus = new System.Windows.Forms.Label();
            this.labelLastCommandStatus = new System.Windows.Forms.Label();
            this.commandStatusInfoLabel = new System.Windows.Forms.Label();
            this.projectNameLabel = new System.Windows.Forms.Label();
            this.testPin13InfoLabel = new System.Windows.Forms.Label();
            this.programsListBox = new System.Windows.Forms.ListBox();
            this.breadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.newProgramNameTextBox = new System.Windows.Forms.TextBox();
            this.createProgramButton = new System.Windows.Forms.Button();
            this.programNameLabel = new System.Windows.Forms.Label();
            this.programFormGroupBox = new System.Windows.Forms.GroupBox();
            this.buttonPreviousProgram = new System.Windows.Forms.Button();
            this.buttonNextProgram = new System.Windows.Forms.Button();
            this.allInformationGroupBox = new System.Windows.Forms.GroupBox();
            this.valvePointFormGroupBox = new System.Windows.Forms.GroupBox();
            this.newValvePointValueTextBox = new System.Windows.Forms.NumericUpDown();
            this.newValvePointMinuteTextBox = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.createValvePointButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.pressurePointFormGroupBox = new System.Windows.Forms.GroupBox();
            this.newPressurePointValueTextBox = new System.Windows.Forms.NumericUpDown();
            this.newPressurePointMinuteTextBox = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.createPressurePointButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.allActionsTabControl = new System.Windows.Forms.TabControl();
            this.temperaturesPage = new System.Windows.Forms.TabPage();
            this.temperaturePointsTabControl = new System.Windows.Forms.TabControl();
            this.temperatureChartTabPage = new System.Windows.Forms.TabPage();
            this.temperaturePointsChartGroupBox = new System.Windows.Forms.GroupBox();
            this.chartTemperatures = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.temperatureTableTabPage = new System.Windows.Forms.TabPage();
            this.temperaturePointsTableGroupBox = new System.Windows.Forms.GroupBox();
            this.deleteTemperaturePointButton = new System.Windows.Forms.Button();
            this.temperaturePointsListBox = new System.Windows.Forms.ListBox();
            this.previousTemperaturePointButton = new System.Windows.Forms.Button();
            this.nextTemperaturePointButton = new System.Windows.Forms.Button();
            this.pressuresPage = new System.Windows.Forms.TabPage();
            this.pressurePointsTabControl = new System.Windows.Forms.TabControl();
            this.pressureChartTabPage = new System.Windows.Forms.TabPage();
            this.pressurePointsChartGroupBox = new System.Windows.Forms.GroupBox();
            this.pressuresChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pressureTableTabPage = new System.Windows.Forms.TabPage();
            this.pressurePointsTableGroupBox = new System.Windows.Forms.GroupBox();
            this.deletePressurePointButton = new System.Windows.Forms.Button();
            this.pressurePointsListBox = new System.Windows.Forms.ListBox();
            this.previousPressurePointButton = new System.Windows.Forms.Button();
            this.nextPressurePointButton = new System.Windows.Forms.Button();
            this.valvesPage = new System.Windows.Forms.TabPage();
            this.valvePointsTabControl = new System.Windows.Forms.TabControl();
            this.valveChartTabPage = new System.Windows.Forms.TabPage();
            this.valvePointsChartGroupBox = new System.Windows.Forms.GroupBox();
            this.valveChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.valveTableTabPage = new System.Windows.Forms.TabPage();
            this.valvePointsTableGroupBox = new System.Windows.Forms.GroupBox();
            this.deleteValvePointButton = new System.Windows.Forms.Button();
            this.valvePointsListBox = new System.Windows.Forms.ListBox();
            this.previousValvePointButton = new System.Windows.Forms.Button();
            this.nextValvePointButton = new System.Windows.Forms.Button();
            this.historyPage = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.historyListBox = new System.Windows.Forms.ListBox();
            this.temperaturePointFormGroupBox = new System.Windows.Forms.GroupBox();
            this.newTemperaturePointValueTextBox = new System.Windows.Forms.NumericUpDown();
            this.newTemperaturePointMinuteTextBox = new System.Windows.Forms.NumericUpDown();
            this.temperaturePointValueLabel = new System.Windows.Forms.Label();
            this.createTemperaturePointButton = new System.Windows.Forms.Button();
            this.temperaturePointMinuteLabel = new System.Windows.Forms.Label();
            this.programsIndexGroupBox = new System.Windows.Forms.GroupBox();
            this.buttonDeleteProgram = new System.Windows.Forms.Button();
            this.actionGroupBox = new System.Windows.Forms.GroupBox();
            this.statusGroupBox = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.testPin2InfoLabel = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.testPin3InfoLabel = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.testPin4InfoLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.refreshInfoButton = new System.Windows.Forms.Button();
            this.progressGroupBox = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.breadBindingSource)).BeginInit();
            this.programFormGroupBox.SuspendLayout();
            this.allInformationGroupBox.SuspendLayout();
            this.valvePointFormGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.newValvePointValueTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newValvePointMinuteTextBox)).BeginInit();
            this.pressurePointFormGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.newPressurePointValueTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newPressurePointMinuteTextBox)).BeginInit();
            this.allActionsTabControl.SuspendLayout();
            this.temperaturesPage.SuspendLayout();
            this.temperaturePointsTabControl.SuspendLayout();
            this.temperatureChartTabPage.SuspendLayout();
            this.temperaturePointsChartGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartTemperatures)).BeginInit();
            this.temperatureTableTabPage.SuspendLayout();
            this.temperaturePointsTableGroupBox.SuspendLayout();
            this.pressuresPage.SuspendLayout();
            this.pressurePointsTabControl.SuspendLayout();
            this.pressureChartTabPage.SuspendLayout();
            this.pressurePointsChartGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pressuresChart)).BeginInit();
            this.pressureTableTabPage.SuspendLayout();
            this.pressurePointsTableGroupBox.SuspendLayout();
            this.valvesPage.SuspendLayout();
            this.valvePointsTabControl.SuspendLayout();
            this.valveChartTabPage.SuspendLayout();
            this.valvePointsChartGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.valveChart)).BeginInit();
            this.valveTableTabPage.SuspendLayout();
            this.valvePointsTableGroupBox.SuspendLayout();
            this.historyPage.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.temperaturePointFormGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.newTemperaturePointValueTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newTemperaturePointMinuteTextBox)).BeginInit();
            this.programsIndexGroupBox.SuspendLayout();
            this.actionGroupBox.SuspendLayout();
            this.statusGroupBox.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.progressGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // startProgramButton
            // 
            this.startProgramButton.Location = new System.Drawing.Point(6, 171);
            this.startProgramButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.startProgramButton.Name = "startProgramButton";
            this.startProgramButton.Size = new System.Drawing.Size(138, 107);
            this.startProgramButton.TabIndex = 0;
            this.startProgramButton.Text = "СТАРТ";
            this.startProgramButton.UseVisualStyleBackColor = true;
            this.startProgramButton.Click += new System.EventHandler(this.startProgramButton_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(7, 30);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(194, 26);
            this.progressBar1.TabIndex = 1;
            // 
            // stopProgramButton
            // 
            this.stopProgramButton.Location = new System.Drawing.Point(6, 120);
            this.stopProgramButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.stopProgramButton.Name = "stopProgramButton";
            this.stopProgramButton.Size = new System.Drawing.Size(138, 40);
            this.stopProgramButton.TabIndex = 5;
            this.stopProgramButton.Text = "СТОП";
            this.stopProgramButton.UseVisualStyleBackColor = true;
            this.stopProgramButton.Click += new System.EventHandler(this.stopProgramButton_Click);
            // 
            // continueProgramButton
            // 
            this.continueProgramButton.Location = new System.Drawing.Point(8, 74);
            this.continueProgramButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.continueProgramButton.Name = "continueProgramButton";
            this.continueProgramButton.Size = new System.Drawing.Size(138, 40);
            this.continueProgramButton.TabIndex = 6;
            this.continueProgramButton.Text = "ПРОДОВЖИТИ";
            this.continueProgramButton.UseVisualStyleBackColor = true;
            this.continueProgramButton.Click += new System.EventHandler(this.continueProgramButton_Click);
            // 
            // pauseProgramButton
            // 
            this.pauseProgramButton.Location = new System.Drawing.Point(6, 28);
            this.pauseProgramButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pauseProgramButton.Name = "pauseProgramButton";
            this.pauseProgramButton.Size = new System.Drawing.Size(138, 40);
            this.pauseProgramButton.TabIndex = 7;
            this.pauseProgramButton.Text = "ПАУЗА";
            this.pauseProgramButton.UseVisualStyleBackColor = true;
            this.pauseProgramButton.Click += new System.EventHandler(this.pauseProgramButton_Click);
            // 
            // minutesLeftLabel
            // 
            this.minutesLeftLabel.AutoSize = true;
            this.minutesLeftLabel.Location = new System.Drawing.Point(7, 69);
            this.minutesLeftLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.minutesLeftLabel.Name = "minutesLeftLabel";
            this.minutesLeftLabel.Size = new System.Drawing.Size(23, 15);
            this.minutesLeftLabel.TabIndex = 9;
            this.minutesLeftLabel.Text = "12";
            // 
            // minutesLeftInfoLabel
            // 
            this.minutesLeftInfoLabel.AutoSize = true;
            this.minutesLeftInfoLabel.Location = new System.Drawing.Point(50, 69);
            this.minutesLeftInfoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.minutesLeftInfoLabel.Name = "minutesLeftInfoLabel";
            this.minutesLeftInfoLabel.Size = new System.Drawing.Size(151, 15);
            this.minutesLeftInfoLabel.TabIndex = 10;
            this.minutesLeftInfoLabel.Text = "хвилин до закінчення";
            // 
            // turnOnTestDiodButton
            // 
            this.turnOnTestDiodButton.Location = new System.Drawing.Point(79, 120);
            this.turnOnTestDiodButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.turnOnTestDiodButton.Name = "turnOnTestDiodButton";
            this.turnOnTestDiodButton.Size = new System.Drawing.Size(57, 26);
            this.turnOnTestDiodButton.TabIndex = 19;
            this.turnOnTestDiodButton.Text = "ВКЛ";
            this.turnOnTestDiodButton.UseVisualStyleBackColor = true;
            this.turnOnTestDiodButton.Click += new System.EventHandler(this.button7_Click);
            // 
            // turnOffTestDiodButton
            // 
            this.turnOffTestDiodButton.Location = new System.Drawing.Point(142, 120);
            this.turnOffTestDiodButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.turnOffTestDiodButton.Name = "turnOffTestDiodButton";
            this.turnOffTestDiodButton.Size = new System.Drawing.Size(57, 26);
            this.turnOffTestDiodButton.TabIndex = 20;
            this.turnOffTestDiodButton.Text = "ВИКЛ";
            this.turnOffTestDiodButton.UseVisualStyleBackColor = true;
            this.turnOffTestDiodButton.Click += new System.EventHandler(this.button8_Click);
            // 
            // connectionStatusInfoLabel
            // 
            this.connectionStatusInfoLabel.AutoSize = true;
            this.connectionStatusInfoLabel.Location = new System.Drawing.Point(2, 16);
            this.connectionStatusInfoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.connectionStatusInfoLabel.Name = "connectionStatusInfoLabel";
            this.connectionStatusInfoLabel.Size = new System.Drawing.Size(127, 15);
            this.connectionStatusInfoLabel.TabIndex = 21;
            this.connectionStatusInfoLabel.Text = "Статус з\'єднання:";
            // 
            // labelConnectionStatus
            // 
            this.labelConnectionStatus.AutoSize = true;
            this.labelConnectionStatus.Location = new System.Drawing.Point(193, 16);
            this.labelConnectionStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelConnectionStatus.Name = "labelConnectionStatus";
            this.labelConnectionStatus.Size = new System.Drawing.Size(47, 15);
            this.labelConnectionStatus.TabIndex = 22;
            this.labelConnectionStatus.Text = "label8";
            // 
            // labelLastCommandStatus
            // 
            this.labelLastCommandStatus.AutoSize = true;
            this.labelLastCommandStatus.Location = new System.Drawing.Point(193, 31);
            this.labelLastCommandStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLastCommandStatus.Name = "labelLastCommandStatus";
            this.labelLastCommandStatus.Size = new System.Drawing.Size(47, 15);
            this.labelLastCommandStatus.TabIndex = 23;
            this.labelLastCommandStatus.Text = "label9";
            // 
            // commandStatusInfoLabel
            // 
            this.commandStatusInfoLabel.AutoSize = true;
            this.commandStatusInfoLabel.Location = new System.Drawing.Point(2, 31);
            this.commandStatusInfoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.commandStatusInfoLabel.Name = "commandStatusInfoLabel";
            this.commandStatusInfoLabel.Size = new System.Drawing.Size(181, 15);
            this.commandStatusInfoLabel.TabIndex = 24;
            this.commandStatusInfoLabel.Text = "Статус поточної команди:";
            // 
            // projectNameLabel
            // 
            this.projectNameLabel.AutoSize = true;
            this.projectNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projectNameLabel.Location = new System.Drawing.Point(318, 7);
            this.projectNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.projectNameLabel.Name = "projectNameLabel";
            this.projectNameLabel.Size = new System.Drawing.Size(358, 37);
            this.projectNameLabel.TabIndex = 26;
            this.projectNameLabel.Text = "Терморегулятор Пічки";
            // 
            // testPin13InfoLabel
            // 
            this.testPin13InfoLabel.AutoSize = true;
            this.testPin13InfoLabel.Location = new System.Drawing.Point(10, 126);
            this.testPin13InfoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.testPin13InfoLabel.Name = "testPin13InfoLabel";
            this.testPin13InfoLabel.Size = new System.Drawing.Size(59, 15);
            this.testPin13InfoLabel.TabIndex = 28;
            this.testPin13InfoLabel.Text = "13й пін:";
            // 
            // programsListBox
            // 
            this.programsListBox.DataSource = this.breadBindingSource;
            this.programsListBox.FormattingEnabled = true;
            this.programsListBox.ItemHeight = 15;
            this.programsListBox.Location = new System.Drawing.Point(8, 18);
            this.programsListBox.Margin = new System.Windows.Forms.Padding(2);
            this.programsListBox.Name = "programsListBox";
            this.programsListBox.Size = new System.Drawing.Size(709, 79);
            this.programsListBox.TabIndex = 29;
            this.programsListBox.SelectedIndexChanged += new System.EventHandler(this.programsListBox_SelectedIndexChanged);
            // 
            // breadBindingSource
            // 
            this.breadBindingSource.DataSource = typeof(Oven_Interface.Bread);
            // 
            // newProgramNameTextBox
            // 
            this.newProgramNameTextBox.Location = new System.Drawing.Point(8, 46);
            this.newProgramNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.newProgramNameTextBox.Name = "newProgramNameTextBox";
            this.newProgramNameTextBox.Size = new System.Drawing.Size(340, 21);
            this.newProgramNameTextBox.TabIndex = 31;
            // 
            // createProgramButton
            // 
            this.createProgramButton.Location = new System.Drawing.Point(254, 102);
            this.createProgramButton.Margin = new System.Windows.Forms.Padding(2);
            this.createProgramButton.Name = "createProgramButton";
            this.createProgramButton.Size = new System.Drawing.Size(92, 29);
            this.createProgramButton.TabIndex = 32;
            this.createProgramButton.Text = "Створити";
            this.createProgramButton.UseVisualStyleBackColor = true;
            this.createProgramButton.Click += new System.EventHandler(this.createBread_Click);
            // 
            // programNameLabel
            // 
            this.programNameLabel.AutoSize = true;
            this.programNameLabel.Location = new System.Drawing.Point(5, 28);
            this.programNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.programNameLabel.Name = "programNameLabel";
            this.programNameLabel.Size = new System.Drawing.Size(52, 15);
            this.programNameLabel.TabIndex = 33;
            this.programNameLabel.Text = "Назва:";
            // 
            // programFormGroupBox
            // 
            this.programFormGroupBox.Controls.Add(this.createProgramButton);
            this.programFormGroupBox.Controls.Add(this.programNameLabel);
            this.programFormGroupBox.Controls.Add(this.newProgramNameTextBox);
            this.programFormGroupBox.Location = new System.Drawing.Point(737, 19);
            this.programFormGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.programFormGroupBox.Name = "programFormGroupBox";
            this.programFormGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.programFormGroupBox.Size = new System.Drawing.Size(352, 140);
            this.programFormGroupBox.TabIndex = 34;
            this.programFormGroupBox.TabStop = false;
            this.programFormGroupBox.Text = "Створити Режим";
            // 
            // buttonPreviousProgram
            // 
            this.buttonPreviousProgram.Location = new System.Drawing.Point(8, 101);
            this.buttonPreviousProgram.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonPreviousProgram.Name = "buttonPreviousProgram";
            this.buttonPreviousProgram.Size = new System.Drawing.Size(105, 30);
            this.buttonPreviousProgram.TabIndex = 27;
            this.buttonPreviousProgram.Text = "< Попередній";
            this.buttonPreviousProgram.UseVisualStyleBackColor = true;
            this.buttonPreviousProgram.Click += new System.EventHandler(this.buttonPreviousProgram_Click);
            // 
            // buttonNextProgram
            // 
            this.buttonNextProgram.Location = new System.Drawing.Point(121, 101);
            this.buttonNextProgram.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonNextProgram.Name = "buttonNextProgram";
            this.buttonNextProgram.Size = new System.Drawing.Size(105, 30);
            this.buttonNextProgram.TabIndex = 2;
            this.buttonNextProgram.Text = "Наступний >";
            this.buttonNextProgram.UseVisualStyleBackColor = true;
            this.buttonNextProgram.Click += new System.EventHandler(this.nextProgram_Click);
            // 
            // allInformationGroupBox
            // 
            this.allInformationGroupBox.Controls.Add(this.valvePointFormGroupBox);
            this.allInformationGroupBox.Controls.Add(this.pressurePointFormGroupBox);
            this.allInformationGroupBox.Controls.Add(this.allActionsTabControl);
            this.allInformationGroupBox.Controls.Add(this.temperaturePointFormGroupBox);
            this.allInformationGroupBox.Controls.Add(this.programsIndexGroupBox);
            this.allInformationGroupBox.Controls.Add(this.programFormGroupBox);
            this.allInformationGroupBox.Location = new System.Drawing.Point(10, 48);
            this.allInformationGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.allInformationGroupBox.Name = "allInformationGroupBox";
            this.allInformationGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.allInformationGroupBox.Size = new System.Drawing.Size(1093, 619);
            this.allInformationGroupBox.TabIndex = 35;
            this.allInformationGroupBox.TabStop = false;
            this.allInformationGroupBox.Text = "Режими Роботи";
            // 
            // valvePointFormGroupBox
            // 
            this.valvePointFormGroupBox.Controls.Add(this.newValvePointValueTextBox);
            this.valvePointFormGroupBox.Controls.Add(this.newValvePointMinuteTextBox);
            this.valvePointFormGroupBox.Controls.Add(this.label3);
            this.valvePointFormGroupBox.Controls.Add(this.createValvePointButton);
            this.valvePointFormGroupBox.Controls.Add(this.label4);
            this.valvePointFormGroupBox.Location = new System.Drawing.Point(857, 418);
            this.valvePointFormGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.valvePointFormGroupBox.Name = "valvePointFormGroupBox";
            this.valvePointFormGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.valvePointFormGroupBox.Size = new System.Drawing.Size(232, 111);
            this.valvePointFormGroupBox.TabIndex = 43;
            this.valvePointFormGroupBox.TabStop = false;
            this.valvePointFormGroupBox.Text = "Створити Точку Подачі Пари";
            // 
            // newValvePointValueTextBox
            // 
            this.newValvePointValueTextBox.Location = new System.Drawing.Point(94, 52);
            this.newValvePointValueTextBox.Maximum = new decimal(new int[] {
            6000,
            0,
            0,
            0});
            this.newValvePointValueTextBox.Minimum = new decimal(new int[] {
            500,
            0,
            0,
            -2147483648});
            this.newValvePointValueTextBox.Name = "newValvePointValueTextBox";
            this.newValvePointValueTextBox.Size = new System.Drawing.Size(106, 21);
            this.newValvePointValueTextBox.TabIndex = 41;
            // 
            // newValvePointMinuteTextBox
            // 
            this.newValvePointMinuteTextBox.Location = new System.Drawing.Point(95, 26);
            this.newValvePointMinuteTextBox.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.newValvePointMinuteTextBox.Name = "newValvePointMinuteTextBox";
            this.newValvePointMinuteTextBox.Size = new System.Drawing.Size(106, 21);
            this.newValvePointMinuteTextBox.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 55);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 15);
            this.label3.TabIndex = 35;
            this.label3.Text = "Значення:";
            // 
            // createValvePointButton
            // 
            this.createValvePointButton.Location = new System.Drawing.Point(109, 78);
            this.createValvePointButton.Margin = new System.Windows.Forms.Padding(2);
            this.createValvePointButton.Name = "createValvePointButton";
            this.createValvePointButton.Size = new System.Drawing.Size(92, 29);
            this.createValvePointButton.TabIndex = 32;
            this.createValvePointButton.Text = "Створити";
            this.createValvePointButton.UseVisualStyleBackColor = true;
            this.createValvePointButton.Click += new System.EventHandler(this.createValvePointButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 28);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 15);
            this.label4.TabIndex = 33;
            this.label4.Text = "Хвилина:";
            // 
            // pressurePointFormGroupBox
            // 
            this.pressurePointFormGroupBox.Controls.Add(this.newPressurePointValueTextBox);
            this.pressurePointFormGroupBox.Controls.Add(this.newPressurePointMinuteTextBox);
            this.pressurePointFormGroupBox.Controls.Add(this.label1);
            this.pressurePointFormGroupBox.Controls.Add(this.createPressurePointButton);
            this.pressurePointFormGroupBox.Controls.Add(this.label2);
            this.pressurePointFormGroupBox.Location = new System.Drawing.Point(857, 303);
            this.pressurePointFormGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.pressurePointFormGroupBox.Name = "pressurePointFormGroupBox";
            this.pressurePointFormGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.pressurePointFormGroupBox.Size = new System.Drawing.Size(236, 111);
            this.pressurePointFormGroupBox.TabIndex = 42;
            this.pressurePointFormGroupBox.TabStop = false;
            this.pressurePointFormGroupBox.Text = "Створити Точку Тиску Води";
            // 
            // newPressurePointValueTextBox
            // 
            this.newPressurePointValueTextBox.Location = new System.Drawing.Point(93, 51);
            this.newPressurePointValueTextBox.Maximum = new decimal(new int[] {
            6000,
            0,
            0,
            0});
            this.newPressurePointValueTextBox.Minimum = new decimal(new int[] {
            500,
            0,
            0,
            -2147483648});
            this.newPressurePointValueTextBox.Name = "newPressurePointValueTextBox";
            this.newPressurePointValueTextBox.Size = new System.Drawing.Size(106, 21);
            this.newPressurePointValueTextBox.TabIndex = 39;
            // 
            // newPressurePointMinuteTextBox
            // 
            this.newPressurePointMinuteTextBox.Location = new System.Drawing.Point(94, 26);
            this.newPressurePointMinuteTextBox.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.newPressurePointMinuteTextBox.Name = "newPressurePointMinuteTextBox";
            this.newPressurePointMinuteTextBox.Size = new System.Drawing.Size(106, 21);
            this.newPressurePointMinuteTextBox.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 15);
            this.label1.TabIndex = 35;
            this.label1.Text = "Значення:";
            // 
            // createPressurePointButton
            // 
            this.createPressurePointButton.Location = new System.Drawing.Point(109, 77);
            this.createPressurePointButton.Margin = new System.Windows.Forms.Padding(2);
            this.createPressurePointButton.Name = "createPressurePointButton";
            this.createPressurePointButton.Size = new System.Drawing.Size(92, 29);
            this.createPressurePointButton.TabIndex = 32;
            this.createPressurePointButton.Text = "Створити";
            this.createPressurePointButton.UseVisualStyleBackColor = true;
            this.createPressurePointButton.Click += new System.EventHandler(this.createPressurePointButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 15);
            this.label2.TabIndex = 33;
            this.label2.Text = "Хвилина:";
            // 
            // allActionsTabControl
            // 
            this.allActionsTabControl.Controls.Add(this.temperaturesPage);
            this.allActionsTabControl.Controls.Add(this.pressuresPage);
            this.allActionsTabControl.Controls.Add(this.valvesPage);
            this.allActionsTabControl.Controls.Add(this.historyPage);
            this.allActionsTabControl.Location = new System.Drawing.Point(10, 164);
            this.allActionsTabControl.Margin = new System.Windows.Forms.Padding(2);
            this.allActionsTabControl.Name = "allActionsTabControl";
            this.allActionsTabControl.SelectedIndex = 0;
            this.allActionsTabControl.Size = new System.Drawing.Size(843, 451);
            this.allActionsTabControl.TabIndex = 41;
            // 
            // temperaturesPage
            // 
            this.temperaturesPage.Controls.Add(this.temperaturePointsTabControl);
            this.temperaturesPage.Location = new System.Drawing.Point(4, 24);
            this.temperaturesPage.Name = "temperaturesPage";
            this.temperaturesPage.Size = new System.Drawing.Size(835, 423);
            this.temperaturesPage.TabIndex = 3;
            this.temperaturesPage.Text = "Температури";
            this.temperaturesPage.UseVisualStyleBackColor = true;
            // 
            // temperaturePointsTabControl
            // 
            this.temperaturePointsTabControl.Controls.Add(this.temperatureChartTabPage);
            this.temperaturePointsTabControl.Controls.Add(this.temperatureTableTabPage);
            this.temperaturePointsTabControl.Location = new System.Drawing.Point(6, 4);
            this.temperaturePointsTabControl.Margin = new System.Windows.Forms.Padding(2);
            this.temperaturePointsTabControl.Name = "temperaturePointsTabControl";
            this.temperaturePointsTabControl.SelectedIndex = 0;
            this.temperaturePointsTabControl.Size = new System.Drawing.Size(827, 405);
            this.temperaturePointsTabControl.TabIndex = 42;
            // 
            // temperatureChartTabPage
            // 
            this.temperatureChartTabPage.Controls.Add(this.temperaturePointsChartGroupBox);
            this.temperatureChartTabPage.Location = new System.Drawing.Point(4, 24);
            this.temperatureChartTabPage.Margin = new System.Windows.Forms.Padding(2);
            this.temperatureChartTabPage.Name = "temperatureChartTabPage";
            this.temperatureChartTabPage.Padding = new System.Windows.Forms.Padding(2);
            this.temperatureChartTabPage.Size = new System.Drawing.Size(819, 377);
            this.temperatureChartTabPage.TabIndex = 1;
            this.temperatureChartTabPage.Text = "Графік Температур";
            this.temperatureChartTabPage.UseVisualStyleBackColor = true;
            // 
            // temperaturePointsChartGroupBox
            // 
            this.temperaturePointsChartGroupBox.Controls.Add(this.chartTemperatures);
            this.temperaturePointsChartGroupBox.Location = new System.Drawing.Point(5, 6);
            this.temperaturePointsChartGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.temperaturePointsChartGroupBox.Name = "temperaturePointsChartGroupBox";
            this.temperaturePointsChartGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.temperaturePointsChartGroupBox.Size = new System.Drawing.Size(818, 387);
            this.temperaturePointsChartGroupBox.TabIndex = 38;
            this.temperaturePointsChartGroupBox.TabStop = false;
            this.temperaturePointsChartGroupBox.Text = "Графік Температур";
            // 
            // chartTemperatures
            // 
            chartArea1.Area3DStyle.PointDepth = 5;
            chartArea1.Area3DStyle.Rotation = 20;
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.AxisX.Title = "Час (хв)";
            chartArea1.AxisY.Title = "Температура (С)";
            chartArea1.Name = "ChartArea1";
            this.chartTemperatures.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartTemperatures.Legends.Add(legend1);
            this.chartTemperatures.Location = new System.Drawing.Point(6, 20);
            this.chartTemperatures.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chartTemperatures.Name = "chartTemperatures";
            series1.BorderWidth = 4;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StepLine;
            series1.IsValueShownAsLabel = true;
            series1.LabelForeColor = System.Drawing.Color.DimGray;
            series1.Legend = "Legend1";
            series1.Name = "Температура";
            series1.XValueMember = "Minute";
            series1.YValueMembers = "Value";
            series1.YValuesPerPoint = 6;
            this.chartTemperatures.Series.Add(series1);
            this.chartTemperatures.Size = new System.Drawing.Size(802, 346);
            this.chartTemperatures.TabIndex = 4;
            this.chartTemperatures.Text = "chart1";
            title1.Name = "Text";
            this.chartTemperatures.Titles.Add(title1);
            // 
            // temperatureTableTabPage
            // 
            this.temperatureTableTabPage.Controls.Add(this.temperaturePointsTableGroupBox);
            this.temperatureTableTabPage.Location = new System.Drawing.Point(4, 24);
            this.temperatureTableTabPage.Margin = new System.Windows.Forms.Padding(2);
            this.temperatureTableTabPage.Name = "temperatureTableTabPage";
            this.temperatureTableTabPage.Padding = new System.Windows.Forms.Padding(2);
            this.temperatureTableTabPage.Size = new System.Drawing.Size(819, 377);
            this.temperatureTableTabPage.TabIndex = 0;
            this.temperatureTableTabPage.Text = "Таблиця Температур";
            this.temperatureTableTabPage.UseVisualStyleBackColor = true;
            // 
            // temperaturePointsTableGroupBox
            // 
            this.temperaturePointsTableGroupBox.Controls.Add(this.deleteTemperaturePointButton);
            this.temperaturePointsTableGroupBox.Controls.Add(this.temperaturePointsListBox);
            this.temperaturePointsTableGroupBox.Controls.Add(this.previousTemperaturePointButton);
            this.temperaturePointsTableGroupBox.Controls.Add(this.nextTemperaturePointButton);
            this.temperaturePointsTableGroupBox.Location = new System.Drawing.Point(8, 5);
            this.temperaturePointsTableGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.temperaturePointsTableGroupBox.Name = "temperaturePointsTableGroupBox";
            this.temperaturePointsTableGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.temperaturePointsTableGroupBox.Size = new System.Drawing.Size(807, 364);
            this.temperaturePointsTableGroupBox.TabIndex = 39;
            this.temperaturePointsTableGroupBox.TabStop = false;
            this.temperaturePointsTableGroupBox.Text = "Список Точок Температур";
            // 
            // deleteTemperaturePointButton
            // 
            this.deleteTemperaturePointButton.Location = new System.Drawing.Point(716, 327);
            this.deleteTemperaturePointButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.deleteTemperaturePointButton.Name = "deleteTemperaturePointButton";
            this.deleteTemperaturePointButton.Size = new System.Drawing.Size(85, 30);
            this.deleteTemperaturePointButton.TabIndex = 32;
            this.deleteTemperaturePointButton.Text = "Видалити";
            this.deleteTemperaturePointButton.UseVisualStyleBackColor = true;
            this.deleteTemperaturePointButton.Click += new System.EventHandler(this.deleteTemperaturePointButton_Click);
            // 
            // temperaturePointsListBox
            // 
            this.temperaturePointsListBox.ColumnWidth = 2;
            this.temperaturePointsListBox.FormattingEnabled = true;
            this.temperaturePointsListBox.ItemHeight = 15;
            this.temperaturePointsListBox.Location = new System.Drawing.Point(8, 18);
            this.temperaturePointsListBox.Margin = new System.Windows.Forms.Padding(2);
            this.temperaturePointsListBox.Name = "temperaturePointsListBox";
            this.temperaturePointsListBox.Size = new System.Drawing.Size(795, 304);
            this.temperaturePointsListBox.TabIndex = 29;
            // 
            // previousTemperaturePointButton
            // 
            this.previousTemperaturePointButton.Location = new System.Drawing.Point(6, 327);
            this.previousTemperaturePointButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.previousTemperaturePointButton.Name = "previousTemperaturePointButton";
            this.previousTemperaturePointButton.Size = new System.Drawing.Size(105, 30);
            this.previousTemperaturePointButton.TabIndex = 27;
            this.previousTemperaturePointButton.Text = "< Попередній";
            this.previousTemperaturePointButton.UseVisualStyleBackColor = true;
            this.previousTemperaturePointButton.Click += new System.EventHandler(this.previousTemperaturePointButton_Click);
            // 
            // nextTemperaturePointButton
            // 
            this.nextTemperaturePointButton.Location = new System.Drawing.Point(119, 327);
            this.nextTemperaturePointButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.nextTemperaturePointButton.Name = "nextTemperaturePointButton";
            this.nextTemperaturePointButton.Size = new System.Drawing.Size(105, 30);
            this.nextTemperaturePointButton.TabIndex = 2;
            this.nextTemperaturePointButton.Text = "Наступний >";
            this.nextTemperaturePointButton.UseVisualStyleBackColor = true;
            this.nextTemperaturePointButton.Click += new System.EventHandler(this.nextTemperaturePointButton_Click);
            // 
            // pressuresPage
            // 
            this.pressuresPage.Controls.Add(this.pressurePointsTabControl);
            this.pressuresPage.Location = new System.Drawing.Point(4, 24);
            this.pressuresPage.Name = "pressuresPage";
            this.pressuresPage.Size = new System.Drawing.Size(835, 423);
            this.pressuresPage.TabIndex = 4;
            this.pressuresPage.Text = "Тиск Води";
            this.pressuresPage.UseVisualStyleBackColor = true;
            // 
            // pressurePointsTabControl
            // 
            this.pressurePointsTabControl.Controls.Add(this.pressureChartTabPage);
            this.pressurePointsTabControl.Controls.Add(this.pressureTableTabPage);
            this.pressurePointsTabControl.Location = new System.Drawing.Point(2, 2);
            this.pressurePointsTabControl.Margin = new System.Windows.Forms.Padding(2);
            this.pressurePointsTabControl.Name = "pressurePointsTabControl";
            this.pressurePointsTabControl.SelectedIndex = 0;
            this.pressurePointsTabControl.Size = new System.Drawing.Size(831, 419);
            this.pressurePointsTabControl.TabIndex = 42;
            // 
            // pressureChartTabPage
            // 
            this.pressureChartTabPage.Controls.Add(this.pressurePointsChartGroupBox);
            this.pressureChartTabPage.Location = new System.Drawing.Point(4, 24);
            this.pressureChartTabPage.Margin = new System.Windows.Forms.Padding(2);
            this.pressureChartTabPage.Name = "pressureChartTabPage";
            this.pressureChartTabPage.Padding = new System.Windows.Forms.Padding(2);
            this.pressureChartTabPage.Size = new System.Drawing.Size(823, 391);
            this.pressureChartTabPage.TabIndex = 1;
            this.pressureChartTabPage.Text = "Графік Тиску Води";
            this.pressureChartTabPage.UseVisualStyleBackColor = true;
            // 
            // pressurePointsChartGroupBox
            // 
            this.pressurePointsChartGroupBox.Controls.Add(this.pressuresChart);
            this.pressurePointsChartGroupBox.Location = new System.Drawing.Point(5, 6);
            this.pressurePointsChartGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.pressurePointsChartGroupBox.Name = "pressurePointsChartGroupBox";
            this.pressurePointsChartGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.pressurePointsChartGroupBox.Size = new System.Drawing.Size(814, 381);
            this.pressurePointsChartGroupBox.TabIndex = 38;
            this.pressurePointsChartGroupBox.TabStop = false;
            this.pressurePointsChartGroupBox.Text = "Графік Тисків Води";
            // 
            // pressuresChart
            // 
            chartArea2.Area3DStyle.PointDepth = 5;
            chartArea2.Area3DStyle.Rotation = 20;
            chartArea2.AxisX.Minimum = 0D;
            chartArea2.AxisX.Title = "Час (хв)";
            chartArea2.AxisY.Title = "Тиск Води (Па)";
            chartArea2.Name = "ChartArea1";
            this.pressuresChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.pressuresChart.Legends.Add(legend2);
            this.pressuresChart.Location = new System.Drawing.Point(6, 20);
            this.pressuresChart.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pressuresChart.Name = "pressuresChart";
            series2.BorderWidth = 4;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StepLine;
            series2.IsValueShownAsLabel = true;
            series2.LabelForeColor = System.Drawing.Color.DimGray;
            series2.Legend = "Legend1";
            series2.Name = "Тиск Води";
            series2.XValueMember = "Minute";
            series2.YValueMembers = "Value";
            series2.YValuesPerPoint = 6;
            this.pressuresChart.Series.Add(series2);
            this.pressuresChart.Size = new System.Drawing.Size(802, 356);
            this.pressuresChart.TabIndex = 4;
            this.pressuresChart.Text = "chart1";
            title2.Name = "Text";
            this.pressuresChart.Titles.Add(title2);
            // 
            // pressureTableTabPage
            // 
            this.pressureTableTabPage.Controls.Add(this.pressurePointsTableGroupBox);
            this.pressureTableTabPage.Location = new System.Drawing.Point(4, 24);
            this.pressureTableTabPage.Margin = new System.Windows.Forms.Padding(2);
            this.pressureTableTabPage.Name = "pressureTableTabPage";
            this.pressureTableTabPage.Padding = new System.Windows.Forms.Padding(2);
            this.pressureTableTabPage.Size = new System.Drawing.Size(823, 391);
            this.pressureTableTabPage.TabIndex = 0;
            this.pressureTableTabPage.Text = "Таблиця Тиску Води";
            this.pressureTableTabPage.UseVisualStyleBackColor = true;
            // 
            // pressurePointsTableGroupBox
            // 
            this.pressurePointsTableGroupBox.Controls.Add(this.deletePressurePointButton);
            this.pressurePointsTableGroupBox.Controls.Add(this.pressurePointsListBox);
            this.pressurePointsTableGroupBox.Controls.Add(this.previousPressurePointButton);
            this.pressurePointsTableGroupBox.Controls.Add(this.nextPressurePointButton);
            this.pressurePointsTableGroupBox.Location = new System.Drawing.Point(8, 5);
            this.pressurePointsTableGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.pressurePointsTableGroupBox.Name = "pressurePointsTableGroupBox";
            this.pressurePointsTableGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.pressurePointsTableGroupBox.Size = new System.Drawing.Size(811, 382);
            this.pressurePointsTableGroupBox.TabIndex = 39;
            this.pressurePointsTableGroupBox.TabStop = false;
            this.pressurePointsTableGroupBox.Text = "Список Точок Температур";
            // 
            // deletePressurePointButton
            // 
            this.deletePressurePointButton.Location = new System.Drawing.Point(717, 347);
            this.deletePressurePointButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.deletePressurePointButton.Name = "deletePressurePointButton";
            this.deletePressurePointButton.Size = new System.Drawing.Size(85, 30);
            this.deletePressurePointButton.TabIndex = 32;
            this.deletePressurePointButton.Text = "Видалити";
            this.deletePressurePointButton.UseVisualStyleBackColor = true;
            this.deletePressurePointButton.Click += new System.EventHandler(this.deletePressurePointButton_Click);
            // 
            // pressurePointsListBox
            // 
            this.pressurePointsListBox.ColumnWidth = 2;
            this.pressurePointsListBox.FormattingEnabled = true;
            this.pressurePointsListBox.ItemHeight = 15;
            this.pressurePointsListBox.Location = new System.Drawing.Point(8, 18);
            this.pressurePointsListBox.Margin = new System.Windows.Forms.Padding(2);
            this.pressurePointsListBox.Name = "pressurePointsListBox";
            this.pressurePointsListBox.Size = new System.Drawing.Size(794, 304);
            this.pressurePointsListBox.TabIndex = 29;
            // 
            // previousPressurePointButton
            // 
            this.previousPressurePointButton.Location = new System.Drawing.Point(8, 347);
            this.previousPressurePointButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.previousPressurePointButton.Name = "previousPressurePointButton";
            this.previousPressurePointButton.Size = new System.Drawing.Size(105, 30);
            this.previousPressurePointButton.TabIndex = 27;
            this.previousPressurePointButton.Text = "< Попередній";
            this.previousPressurePointButton.UseVisualStyleBackColor = true;
            this.previousPressurePointButton.Click += new System.EventHandler(this.previousPressurePointButton_Click);
            // 
            // nextPressurePointButton
            // 
            this.nextPressurePointButton.Location = new System.Drawing.Point(121, 347);
            this.nextPressurePointButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.nextPressurePointButton.Name = "nextPressurePointButton";
            this.nextPressurePointButton.Size = new System.Drawing.Size(105, 30);
            this.nextPressurePointButton.TabIndex = 2;
            this.nextPressurePointButton.Text = "Наступний >";
            this.nextPressurePointButton.UseVisualStyleBackColor = true;
            this.nextPressurePointButton.Click += new System.EventHandler(this.nextPressurePointButton_Click);
            // 
            // valvesPage
            // 
            this.valvesPage.Controls.Add(this.valvePointsTabControl);
            this.valvesPage.Location = new System.Drawing.Point(4, 24);
            this.valvesPage.Name = "valvesPage";
            this.valvesPage.Size = new System.Drawing.Size(835, 423);
            this.valvesPage.TabIndex = 5;
            this.valvesPage.Text = "Клапан Пари";
            this.valvesPage.UseVisualStyleBackColor = true;
            // 
            // valvePointsTabControl
            // 
            this.valvePointsTabControl.Controls.Add(this.valveChartTabPage);
            this.valvePointsTabControl.Controls.Add(this.valveTableTabPage);
            this.valvePointsTabControl.Location = new System.Drawing.Point(6, 2);
            this.valvePointsTabControl.Margin = new System.Windows.Forms.Padding(2);
            this.valvePointsTabControl.Name = "valvePointsTabControl";
            this.valvePointsTabControl.SelectedIndex = 0;
            this.valvePointsTabControl.Size = new System.Drawing.Size(827, 419);
            this.valvePointsTabControl.TabIndex = 42;
            // 
            // valveChartTabPage
            // 
            this.valveChartTabPage.Controls.Add(this.valvePointsChartGroupBox);
            this.valveChartTabPage.Location = new System.Drawing.Point(4, 24);
            this.valveChartTabPage.Margin = new System.Windows.Forms.Padding(2);
            this.valveChartTabPage.Name = "valveChartTabPage";
            this.valveChartTabPage.Padding = new System.Windows.Forms.Padding(2);
            this.valveChartTabPage.Size = new System.Drawing.Size(819, 391);
            this.valveChartTabPage.TabIndex = 1;
            this.valveChartTabPage.Text = "Графік Рівня Пари";
            this.valveChartTabPage.UseVisualStyleBackColor = true;
            // 
            // valvePointsChartGroupBox
            // 
            this.valvePointsChartGroupBox.Controls.Add(this.valveChart);
            this.valvePointsChartGroupBox.Location = new System.Drawing.Point(5, 6);
            this.valvePointsChartGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.valvePointsChartGroupBox.Name = "valvePointsChartGroupBox";
            this.valvePointsChartGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.valvePointsChartGroupBox.Size = new System.Drawing.Size(810, 381);
            this.valvePointsChartGroupBox.TabIndex = 38;
            this.valvePointsChartGroupBox.TabStop = false;
            this.valvePointsChartGroupBox.Text = "Графік Рівня Пари";
            // 
            // valveChart
            // 
            chartArea3.Area3DStyle.PointDepth = 5;
            chartArea3.Area3DStyle.Rotation = 20;
            chartArea3.AxisX.Minimum = 0D;
            chartArea3.AxisX.Title = "Час (хв)";
            chartArea3.AxisY.Title = "Відкритість Клапану Пари (%)";
            chartArea3.Name = "ChartArea1";
            this.valveChart.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.valveChart.Legends.Add(legend3);
            this.valveChart.Location = new System.Drawing.Point(6, 20);
            this.valveChart.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.valveChart.Name = "valveChart";
            series3.BorderWidth = 4;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StepLine;
            series3.IsValueShownAsLabel = true;
            series3.LabelForeColor = System.Drawing.Color.DimGray;
            series3.Legend = "Legend1";
            series3.Name = "Рівень Пари";
            series3.XValueMember = "Minute";
            series3.YValueMembers = "Value";
            series3.YValuesPerPoint = 6;
            this.valveChart.Series.Add(series3);
            this.valveChart.Size = new System.Drawing.Size(802, 356);
            this.valveChart.TabIndex = 4;
            this.valveChart.Text = "chart1";
            title3.Name = "Text";
            this.valveChart.Titles.Add(title3);
            // 
            // valveTableTabPage
            // 
            this.valveTableTabPage.Controls.Add(this.valvePointsTableGroupBox);
            this.valveTableTabPage.Location = new System.Drawing.Point(4, 24);
            this.valveTableTabPage.Margin = new System.Windows.Forms.Padding(2);
            this.valveTableTabPage.Name = "valveTableTabPage";
            this.valveTableTabPage.Padding = new System.Windows.Forms.Padding(2);
            this.valveTableTabPage.Size = new System.Drawing.Size(819, 391);
            this.valveTableTabPage.TabIndex = 0;
            this.valveTableTabPage.Text = "Таблиця Рівня Пари";
            this.valveTableTabPage.UseVisualStyleBackColor = true;
            // 
            // valvePointsTableGroupBox
            // 
            this.valvePointsTableGroupBox.Controls.Add(this.deleteValvePointButton);
            this.valvePointsTableGroupBox.Controls.Add(this.valvePointsListBox);
            this.valvePointsTableGroupBox.Controls.Add(this.previousValvePointButton);
            this.valvePointsTableGroupBox.Controls.Add(this.nextValvePointButton);
            this.valvePointsTableGroupBox.Location = new System.Drawing.Point(8, 5);
            this.valvePointsTableGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.valvePointsTableGroupBox.Name = "valvePointsTableGroupBox";
            this.valvePointsTableGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.valvePointsTableGroupBox.Size = new System.Drawing.Size(807, 382);
            this.valvePointsTableGroupBox.TabIndex = 39;
            this.valvePointsTableGroupBox.TabStop = false;
            this.valvePointsTableGroupBox.Text = "Список Точок Температур";
            // 
            // deleteValvePointButton
            // 
            this.deleteValvePointButton.Location = new System.Drawing.Point(716, 347);
            this.deleteValvePointButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.deleteValvePointButton.Name = "deleteValvePointButton";
            this.deleteValvePointButton.Size = new System.Drawing.Size(85, 30);
            this.deleteValvePointButton.TabIndex = 32;
            this.deleteValvePointButton.Text = "Видалити";
            this.deleteValvePointButton.UseVisualStyleBackColor = true;
            this.deleteValvePointButton.Click += new System.EventHandler(this.deleteValvePointButton_Click);
            // 
            // valvePointsListBox
            // 
            this.valvePointsListBox.ColumnWidth = 2;
            this.valvePointsListBox.FormattingEnabled = true;
            this.valvePointsListBox.ItemHeight = 15;
            this.valvePointsListBox.Location = new System.Drawing.Point(8, 18);
            this.valvePointsListBox.Margin = new System.Windows.Forms.Padding(2);
            this.valvePointsListBox.Name = "valvePointsListBox";
            this.valvePointsListBox.Size = new System.Drawing.Size(791, 319);
            this.valvePointsListBox.TabIndex = 29;
            // 
            // previousValvePointButton
            // 
            this.previousValvePointButton.Location = new System.Drawing.Point(1, 347);
            this.previousValvePointButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.previousValvePointButton.Name = "previousValvePointButton";
            this.previousValvePointButton.Size = new System.Drawing.Size(105, 30);
            this.previousValvePointButton.TabIndex = 27;
            this.previousValvePointButton.Text = "< Попередній";
            this.previousValvePointButton.UseVisualStyleBackColor = true;
            this.previousValvePointButton.Click += new System.EventHandler(this.previousValvePointButton_Click);
            // 
            // nextValvePointButton
            // 
            this.nextValvePointButton.Location = new System.Drawing.Point(114, 347);
            this.nextValvePointButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.nextValvePointButton.Name = "nextValvePointButton";
            this.nextValvePointButton.Size = new System.Drawing.Size(105, 30);
            this.nextValvePointButton.TabIndex = 2;
            this.nextValvePointButton.Text = "Наступний >";
            this.nextValvePointButton.UseVisualStyleBackColor = true;
            this.nextValvePointButton.Click += new System.EventHandler(this.nextValvePointButton_Click);
            // 
            // historyPage
            // 
            this.historyPage.Controls.Add(this.groupBox2);
            this.historyPage.Location = new System.Drawing.Point(4, 24);
            this.historyPage.Margin = new System.Windows.Forms.Padding(2);
            this.historyPage.Name = "historyPage";
            this.historyPage.Size = new System.Drawing.Size(835, 423);
            this.historyPage.TabIndex = 2;
            this.historyPage.Text = "Історія Запусків";
            this.historyPage.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.historyListBox);
            this.groupBox2.Location = new System.Drawing.Point(6, 7);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(827, 416);
            this.groupBox2.TabIndex = 42;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Історія Запусків";
            // 
            // historyListBox
            // 
            this.historyListBox.ColumnWidth = 2;
            this.historyListBox.FormattingEnabled = true;
            this.historyListBox.ItemHeight = 15;
            this.historyListBox.Location = new System.Drawing.Point(8, 18);
            this.historyListBox.Margin = new System.Windows.Forms.Padding(2);
            this.historyListBox.Name = "historyListBox";
            this.historyListBox.Size = new System.Drawing.Size(815, 394);
            this.historyListBox.TabIndex = 29;
            // 
            // temperaturePointFormGroupBox
            // 
            this.temperaturePointFormGroupBox.Controls.Add(this.newTemperaturePointValueTextBox);
            this.temperaturePointFormGroupBox.Controls.Add(this.newTemperaturePointMinuteTextBox);
            this.temperaturePointFormGroupBox.Controls.Add(this.temperaturePointValueLabel);
            this.temperaturePointFormGroupBox.Controls.Add(this.createTemperaturePointButton);
            this.temperaturePointFormGroupBox.Controls.Add(this.temperaturePointMinuteLabel);
            this.temperaturePointFormGroupBox.Location = new System.Drawing.Point(857, 188);
            this.temperaturePointFormGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.temperaturePointFormGroupBox.Name = "temperaturePointFormGroupBox";
            this.temperaturePointFormGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.temperaturePointFormGroupBox.Size = new System.Drawing.Size(236, 111);
            this.temperaturePointFormGroupBox.TabIndex = 40;
            this.temperaturePointFormGroupBox.TabStop = false;
            this.temperaturePointFormGroupBox.Text = "Створити Точку Температури";
            // 
            // newTemperaturePointValueTextBox
            // 
            this.newTemperaturePointValueTextBox.Location = new System.Drawing.Point(94, 49);
            this.newTemperaturePointValueTextBox.Maximum = new decimal(new int[] {
            6000,
            0,
            0,
            0});
            this.newTemperaturePointValueTextBox.Minimum = new decimal(new int[] {
            500,
            0,
            0,
            -2147483648});
            this.newTemperaturePointValueTextBox.Name = "newTemperaturePointValueTextBox";
            this.newTemperaturePointValueTextBox.Size = new System.Drawing.Size(106, 21);
            this.newTemperaturePointValueTextBox.TabIndex = 37;
            // 
            // newTemperaturePointMinuteTextBox
            // 
            this.newTemperaturePointMinuteTextBox.Location = new System.Drawing.Point(95, 23);
            this.newTemperaturePointMinuteTextBox.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.newTemperaturePointMinuteTextBox.Name = "newTemperaturePointMinuteTextBox";
            this.newTemperaturePointMinuteTextBox.Size = new System.Drawing.Size(106, 21);
            this.newTemperaturePointMinuteTextBox.TabIndex = 36;
            // 
            // temperaturePointValueLabel
            // 
            this.temperaturePointValueLabel.AutoSize = true;
            this.temperaturePointValueLabel.Location = new System.Drawing.Point(5, 55);
            this.temperaturePointValueLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.temperaturePointValueLabel.Name = "temperaturePointValueLabel";
            this.temperaturePointValueLabel.Size = new System.Drawing.Size(75, 15);
            this.temperaturePointValueLabel.TabIndex = 35;
            this.temperaturePointValueLabel.Text = "Значення:";
            // 
            // createTemperaturePointButton
            // 
            this.createTemperaturePointButton.Location = new System.Drawing.Point(109, 75);
            this.createTemperaturePointButton.Margin = new System.Windows.Forms.Padding(2);
            this.createTemperaturePointButton.Name = "createTemperaturePointButton";
            this.createTemperaturePointButton.Size = new System.Drawing.Size(92, 29);
            this.createTemperaturePointButton.TabIndex = 32;
            this.createTemperaturePointButton.Text = "Створити";
            this.createTemperaturePointButton.UseVisualStyleBackColor = true;
            this.createTemperaturePointButton.Click += new System.EventHandler(this.createTemperatureButton_Click);
            // 
            // temperaturePointMinuteLabel
            // 
            this.temperaturePointMinuteLabel.AutoSize = true;
            this.temperaturePointMinuteLabel.Location = new System.Drawing.Point(5, 28);
            this.temperaturePointMinuteLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.temperaturePointMinuteLabel.Name = "temperaturePointMinuteLabel";
            this.temperaturePointMinuteLabel.Size = new System.Drawing.Size(68, 15);
            this.temperaturePointMinuteLabel.TabIndex = 33;
            this.temperaturePointMinuteLabel.Text = "Хвилина:";
            // 
            // programsIndexGroupBox
            // 
            this.programsIndexGroupBox.Controls.Add(this.buttonDeleteProgram);
            this.programsIndexGroupBox.Controls.Add(this.programsListBox);
            this.programsIndexGroupBox.Controls.Add(this.buttonPreviousProgram);
            this.programsIndexGroupBox.Controls.Add(this.buttonNextProgram);
            this.programsIndexGroupBox.Location = new System.Drawing.Point(12, 19);
            this.programsIndexGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.programsIndexGroupBox.Name = "programsIndexGroupBox";
            this.programsIndexGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.programsIndexGroupBox.Size = new System.Drawing.Size(721, 140);
            this.programsIndexGroupBox.TabIndex = 35;
            this.programsIndexGroupBox.TabStop = false;
            this.programsIndexGroupBox.Text = "Список Режимів";
            // 
            // buttonDeleteProgram
            // 
            this.buttonDeleteProgram.Location = new System.Drawing.Point(632, 101);
            this.buttonDeleteProgram.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonDeleteProgram.Name = "buttonDeleteProgram";
            this.buttonDeleteProgram.Size = new System.Drawing.Size(83, 30);
            this.buttonDeleteProgram.TabIndex = 31;
            this.buttonDeleteProgram.Text = "Видалити";
            this.buttonDeleteProgram.UseVisualStyleBackColor = true;
            this.buttonDeleteProgram.Click += new System.EventHandler(this.buttonDeleteProgram_Click);
            // 
            // actionGroupBox
            // 
            this.actionGroupBox.Controls.Add(this.pauseProgramButton);
            this.actionGroupBox.Controls.Add(this.startProgramButton);
            this.actionGroupBox.Controls.Add(this.stopProgramButton);
            this.actionGroupBox.Controls.Add(this.continueProgramButton);
            this.actionGroupBox.Location = new System.Drawing.Point(1107, 352);
            this.actionGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.actionGroupBox.Name = "actionGroupBox";
            this.actionGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.actionGroupBox.Size = new System.Drawing.Size(217, 316);
            this.actionGroupBox.TabIndex = 38;
            this.actionGroupBox.TabStop = false;
            this.actionGroupBox.Text = "Дії";
            // 
            // statusGroupBox
            // 
            this.statusGroupBox.Controls.Add(this.connectionStatusInfoLabel);
            this.statusGroupBox.Controls.Add(this.labelConnectionStatus);
            this.statusGroupBox.Controls.Add(this.commandStatusInfoLabel);
            this.statusGroupBox.Controls.Add(this.labelLastCommandStatus);
            this.statusGroupBox.Location = new System.Drawing.Point(11, 671);
            this.statusGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.statusGroupBox.Name = "statusGroupBox";
            this.statusGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.statusGroupBox.Size = new System.Drawing.Size(1313, 53);
            this.statusGroupBox.TabIndex = 36;
            this.statusGroupBox.TabStop = false;
            this.statusGroupBox.Text = "Статус";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.testPin2InfoLabel);
            this.groupBox4.Controls.Add(this.button5);
            this.groupBox4.Controls.Add(this.button6);
            this.groupBox4.Controls.Add(this.testPin3InfoLabel);
            this.groupBox4.Controls.Add(this.button3);
            this.groupBox4.Controls.Add(this.button4);
            this.groupBox4.Controls.Add(this.testPin4InfoLabel);
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Controls.Add(this.button2);
            this.groupBox4.Controls.Add(this.testPin13InfoLabel);
            this.groupBox4.Controls.Add(this.turnOnTestDiodButton);
            this.groupBox4.Controls.Add(this.turnOffTestDiodButton);
            this.groupBox4.Location = new System.Drawing.Point(1115, 48);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(203, 159);
            this.groupBox4.TabIndex = 37;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Перевірка З\'єднання";
            // 
            // testPin2InfoLabel
            // 
            this.testPin2InfoLabel.AutoSize = true;
            this.testPin2InfoLabel.Location = new System.Drawing.Point(10, 30);
            this.testPin2InfoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.testPin2InfoLabel.Name = "testPin2InfoLabel";
            this.testPin2InfoLabel.Size = new System.Drawing.Size(51, 15);
            this.testPin2InfoLabel.TabIndex = 37;
            this.testPin2InfoLabel.Text = "2й пін:";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(79, 24);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(57, 26);
            this.button5.TabIndex = 35;
            this.button5.Text = "ВКЛ";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(142, 24);
            this.button6.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(57, 26);
            this.button6.TabIndex = 36;
            this.button6.Text = "ВИКЛ";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // testPin3InfoLabel
            // 
            this.testPin3InfoLabel.AutoSize = true;
            this.testPin3InfoLabel.Location = new System.Drawing.Point(10, 62);
            this.testPin3InfoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.testPin3InfoLabel.Name = "testPin3InfoLabel";
            this.testPin3InfoLabel.Size = new System.Drawing.Size(51, 15);
            this.testPin3InfoLabel.TabIndex = 34;
            this.testPin3InfoLabel.Text = "3й пін:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(79, 56);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(57, 26);
            this.button3.TabIndex = 32;
            this.button3.Text = "ВКЛ";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(142, 56);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(57, 26);
            this.button4.TabIndex = 33;
            this.button4.Text = "ВИКЛ";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // testPin4InfoLabel
            // 
            this.testPin4InfoLabel.AutoSize = true;
            this.testPin4InfoLabel.Location = new System.Drawing.Point(10, 94);
            this.testPin4InfoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.testPin4InfoLabel.Name = "testPin4InfoLabel";
            this.testPin4InfoLabel.Size = new System.Drawing.Size(51, 15);
            this.testPin4InfoLabel.TabIndex = 31;
            this.testPin4InfoLabel.Text = "4й пін:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(79, 88);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(57, 26);
            this.button1.TabIndex = 29;
            this.button1.Text = "ВКЛ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(142, 88);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(57, 26);
            this.button2.TabIndex = 30;
            this.button2.Text = "ВИКЛ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // refreshInfoButton
            // 
            this.refreshInfoButton.Location = new System.Drawing.Point(1117, 212);
            this.refreshInfoButton.Margin = new System.Windows.Forms.Padding(2);
            this.refreshInfoButton.Name = "refreshInfoButton";
            this.refreshInfoButton.Size = new System.Drawing.Size(186, 29);
            this.refreshInfoButton.TabIndex = 32;
            this.refreshInfoButton.Text = "Оновити Інформацію";
            this.refreshInfoButton.UseVisualStyleBackColor = true;
            this.refreshInfoButton.Click += new System.EventHandler(this.refreshInfoButton_Click);
            // 
            // progressGroupBox
            // 
            this.progressGroupBox.Controls.Add(this.progressBar1);
            this.progressGroupBox.Controls.Add(this.minutesLeftLabel);
            this.progressGroupBox.Controls.Add(this.minutesLeftInfoLabel);
            this.progressGroupBox.Location = new System.Drawing.Point(1107, 247);
            this.progressGroupBox.Name = "progressGroupBox";
            this.progressGroupBox.Size = new System.Drawing.Size(217, 100);
            this.progressGroupBox.TabIndex = 39;
            this.progressGroupBox.TabStop = false;
            this.progressGroupBox.Text = "Прогрес";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1336, 745);
            this.Controls.Add(this.refreshInfoButton);
            this.Controls.Add(this.progressGroupBox);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.statusGroupBox);
            this.Controls.Add(this.allInformationGroupBox);
            this.Controls.Add(this.projectNameLabel);
            this.Controls.Add(this.actionGroupBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Dashboard";
            this.Text = "Терморегулятор Пічки";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Dashboard_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.breadBindingSource)).EndInit();
            this.programFormGroupBox.ResumeLayout(false);
            this.programFormGroupBox.PerformLayout();
            this.allInformationGroupBox.ResumeLayout(false);
            this.valvePointFormGroupBox.ResumeLayout(false);
            this.valvePointFormGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.newValvePointValueTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newValvePointMinuteTextBox)).EndInit();
            this.pressurePointFormGroupBox.ResumeLayout(false);
            this.pressurePointFormGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.newPressurePointValueTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newPressurePointMinuteTextBox)).EndInit();
            this.allActionsTabControl.ResumeLayout(false);
            this.temperaturesPage.ResumeLayout(false);
            this.temperaturePointsTabControl.ResumeLayout(false);
            this.temperatureChartTabPage.ResumeLayout(false);
            this.temperaturePointsChartGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartTemperatures)).EndInit();
            this.temperatureTableTabPage.ResumeLayout(false);
            this.temperaturePointsTableGroupBox.ResumeLayout(false);
            this.pressuresPage.ResumeLayout(false);
            this.pressurePointsTabControl.ResumeLayout(false);
            this.pressureChartTabPage.ResumeLayout(false);
            this.pressurePointsChartGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pressuresChart)).EndInit();
            this.pressureTableTabPage.ResumeLayout(false);
            this.pressurePointsTableGroupBox.ResumeLayout(false);
            this.valvesPage.ResumeLayout(false);
            this.valvePointsTabControl.ResumeLayout(false);
            this.valveChartTabPage.ResumeLayout(false);
            this.valvePointsChartGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.valveChart)).EndInit();
            this.valveTableTabPage.ResumeLayout(false);
            this.valvePointsTableGroupBox.ResumeLayout(false);
            this.historyPage.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.temperaturePointFormGroupBox.ResumeLayout(false);
            this.temperaturePointFormGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.newTemperaturePointValueTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newTemperaturePointMinuteTextBox)).EndInit();
            this.programsIndexGroupBox.ResumeLayout(false);
            this.actionGroupBox.ResumeLayout(false);
            this.statusGroupBox.ResumeLayout(false);
            this.statusGroupBox.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.progressGroupBox.ResumeLayout(false);
            this.progressGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startProgramButton;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button stopProgramButton;
        private System.Windows.Forms.Button continueProgramButton;
        private System.Windows.Forms.Button pauseProgramButton;
        private System.Windows.Forms.Label minutesLeftLabel;
        private System.Windows.Forms.Label minutesLeftInfoLabel;
        private System.Windows.Forms.Button turnOnTestDiodButton;
        private System.Windows.Forms.Button turnOffTestDiodButton;
        private System.Windows.Forms.Label connectionStatusInfoLabel;
        private System.Windows.Forms.Label labelConnectionStatus;
        private System.Windows.Forms.Label labelLastCommandStatus;
        private System.Windows.Forms.Label commandStatusInfoLabel;
        private System.Windows.Forms.Label projectNameLabel;
        private System.Windows.Forms.Label testPin13InfoLabel;
        private System.Windows.Forms.ListBox programsListBox;
        private System.Windows.Forms.TextBox newProgramNameTextBox;
        private System.Windows.Forms.Button createProgramButton;
        private System.Windows.Forms.Label programNameLabel;
        private System.Windows.Forms.GroupBox programFormGroupBox;
        private System.Windows.Forms.Button buttonPreviousProgram;
        private System.Windows.Forms.Button buttonNextProgram;
        private System.Windows.Forms.GroupBox allInformationGroupBox;
        private System.Windows.Forms.GroupBox programsIndexGroupBox;
        private System.Windows.Forms.GroupBox statusGroupBox;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox actionGroupBox;
        private System.Windows.Forms.GroupBox temperaturePointFormGroupBox;
        private System.Windows.Forms.Button createTemperaturePointButton;
        private System.Windows.Forms.Label temperaturePointMinuteLabel;
        private System.Windows.Forms.Label temperaturePointValueLabel;
        private System.Windows.Forms.Button buttonDeleteProgram;
        private System.Windows.Forms.TabControl allActionsTabControl;
        private System.Windows.Forms.TabPage historyPage;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox historyListBox;
        private System.Windows.Forms.GroupBox valvePointFormGroupBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button createValvePointButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox pressurePointFormGroupBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button createPressurePointButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage temperaturesPage;
        private System.Windows.Forms.TabControl temperaturePointsTabControl;
        private System.Windows.Forms.TabPage temperatureChartTabPage;
        private System.Windows.Forms.GroupBox temperaturePointsChartGroupBox;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTemperatures;
        private System.Windows.Forms.TabPage temperatureTableTabPage;
        private System.Windows.Forms.GroupBox temperaturePointsTableGroupBox;
        private System.Windows.Forms.Button deleteTemperaturePointButton;
        private System.Windows.Forms.ListBox temperaturePointsListBox;
        private System.Windows.Forms.Button previousTemperaturePointButton;
        private System.Windows.Forms.Button nextTemperaturePointButton;
        private System.Windows.Forms.TabPage pressuresPage;
        private System.Windows.Forms.TabControl pressurePointsTabControl;
        private System.Windows.Forms.TabPage pressureChartTabPage;
        private System.Windows.Forms.GroupBox pressurePointsChartGroupBox;
        private System.Windows.Forms.DataVisualization.Charting.Chart pressuresChart;
        private System.Windows.Forms.TabPage pressureTableTabPage;
        private System.Windows.Forms.GroupBox pressurePointsTableGroupBox;
        private System.Windows.Forms.Button deletePressurePointButton;
        private System.Windows.Forms.ListBox pressurePointsListBox;
        private System.Windows.Forms.Button previousPressurePointButton;
        private System.Windows.Forms.Button nextPressurePointButton;
        private System.Windows.Forms.TabPage valvesPage;
        private System.Windows.Forms.TabControl valvePointsTabControl;
        private System.Windows.Forms.TabPage valveChartTabPage;
        private System.Windows.Forms.GroupBox valvePointsChartGroupBox;
        private System.Windows.Forms.DataVisualization.Charting.Chart valveChart;
        private System.Windows.Forms.TabPage valveTableTabPage;
        private System.Windows.Forms.GroupBox valvePointsTableGroupBox;
        private System.Windows.Forms.Button deleteValvePointButton;
        private System.Windows.Forms.ListBox valvePointsListBox;
        private System.Windows.Forms.Button previousValvePointButton;
        private System.Windows.Forms.Button nextValvePointButton;
        private System.Windows.Forms.NumericUpDown newValvePointValueTextBox;
        private System.Windows.Forms.NumericUpDown newValvePointMinuteTextBox;
        private System.Windows.Forms.NumericUpDown newPressurePointValueTextBox;
        private System.Windows.Forms.NumericUpDown newPressurePointMinuteTextBox;
        private System.Windows.Forms.NumericUpDown newTemperaturePointValueTextBox;
        private System.Windows.Forms.NumericUpDown newTemperaturePointMinuteTextBox;
        private System.Windows.Forms.BindingSource breadBindingSource;
        private System.Windows.Forms.Button refreshInfoButton;
        private System.Windows.Forms.GroupBox progressGroupBox;
        private System.Windows.Forms.Label testPin2InfoLabel;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label testPin3InfoLabel;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label testPin4InfoLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

