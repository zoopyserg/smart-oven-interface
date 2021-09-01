
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.startProgramButton = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.chartTemperatures = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.stopProgramButton = new System.Windows.Forms.Button();
            this.continueProgramButton = new System.Windows.Forms.Button();
            this.pauseProgramButton = new System.Windows.Forms.Button();
            this.progressInfoLabel = new System.Windows.Forms.Label();
            this.minutesLeftLabel = new System.Windows.Forms.Label();
            this.minutesLeftInfoLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.turnOnTestDiodButton = new System.Windows.Forms.Button();
            this.turnOffTestDiodButton = new System.Windows.Forms.Button();
            this.connectionStatusInfoLabel = new System.Windows.Forms.Label();
            this.labelConnectionStatus = new System.Windows.Forms.Label();
            this.labelLastCommandStatus = new System.Windows.Forms.Label();
            this.commandStatusInfoLabel = new System.Windows.Forms.Label();
            this.projectNameLabel = new System.Windows.Forms.Label();
            this.testPinInfoLabel = new System.Windows.Forms.Label();
            this.programsListBox = new System.Windows.Forms.ListBox();
            this.buttonShowProgram = new System.Windows.Forms.Button();
            this.newProgramNameTextBox = new System.Windows.Forms.TextBox();
            this.createProgramButton = new System.Windows.Forms.Button();
            this.programNameLabel = new System.Windows.Forms.Label();
            this.programFormGroupBox = new System.Windows.Forms.GroupBox();
            this.buttonPreviousProgram = new System.Windows.Forms.Button();
            this.buttonNextProgram = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.programsIndexGroupBox = new System.Windows.Forms.GroupBox();
            this.statusGroupBox = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.actionGroupBox = new System.Windows.Forms.GroupBox();
            this.temperaturePointChartGroupBox = new System.Windows.Forms.GroupBox();
            this.temperaturePointsIndexGroupBox = new System.Windows.Forms.GroupBox();
            this.temperaturePointsListBox = new System.Windows.Forms.ListBox();
            this.showTemperaturePointsButton = new System.Windows.Forms.Button();
            this.previousTemperaturePointButton = new System.Windows.Forms.Button();
            this.nextTemperaturePointButton = new System.Windows.Forms.Button();
            this.temperaturePointFormGroupBox = new System.Windows.Forms.GroupBox();
            this.createTemperaturePointButton = new System.Windows.Forms.Button();
            this.temperaturePointMinuteLabel = new System.Windows.Forms.Label();
            this.newTemperaturePointMinuteTextBox = new System.Windows.Forms.TextBox();
            this.temperaturePointValueLabel = new System.Windows.Forms.Label();
            this.newTemperaturePointValueTextBox = new System.Windows.Forms.TextBox();
            this.buttonDeleteProgram = new System.Windows.Forms.Button();
            this.deleteTemperaturePointButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartTemperatures)).BeginInit();
            this.programFormGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.programsIndexGroupBox.SuspendLayout();
            this.statusGroupBox.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.actionGroupBox.SuspendLayout();
            this.temperaturePointChartGroupBox.SuspendLayout();
            this.temperaturePointsIndexGroupBox.SuspendLayout();
            this.temperaturePointFormGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // startProgramButton
            // 
            this.startProgramButton.Location = new System.Drawing.Point(557, 22);
            this.startProgramButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.startProgramButton.Name = "startProgramButton";
            this.startProgramButton.Size = new System.Drawing.Size(173, 42);
            this.startProgramButton.TabIndex = 0;
            this.startProgramButton.Text = "СТАРТ";
            this.startProgramButton.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(104, 24);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(343, 31);
            this.progressBar1.TabIndex = 1;
            // 
            // chartTemperatures
            // 
            chartArea3.Name = "ChartArea1";
            this.chartTemperatures.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartTemperatures.Legends.Add(legend3);
            this.chartTemperatures.Location = new System.Drawing.Point(296, 24);
            this.chartTemperatures.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.chartTemperatures.Name = "chartTemperatures";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Legend = "Legend1";
            series3.Name = "Temperature";
            this.chartTemperatures.Series.Add(series3);
            this.chartTemperatures.Size = new System.Drawing.Size(779, 166);
            this.chartTemperatures.TabIndex = 4;
            this.chartTemperatures.Text = "chart1";
            // 
            // stopProgramButton
            // 
            this.stopProgramButton.Location = new System.Drawing.Point(374, 22);
            this.stopProgramButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.stopProgramButton.Name = "stopProgramButton";
            this.stopProgramButton.Size = new System.Drawing.Size(173, 42);
            this.stopProgramButton.TabIndex = 5;
            this.stopProgramButton.Text = "СТОП";
            this.stopProgramButton.UseVisualStyleBackColor = true;
            // 
            // continueProgramButton
            // 
            this.continueProgramButton.Location = new System.Drawing.Point(191, 22);
            this.continueProgramButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.continueProgramButton.Name = "continueProgramButton";
            this.continueProgramButton.Size = new System.Drawing.Size(173, 42);
            this.continueProgramButton.TabIndex = 6;
            this.continueProgramButton.Text = "ПРОДОВЖИТИ";
            this.continueProgramButton.UseVisualStyleBackColor = true;
            // 
            // pauseProgramButton
            // 
            this.pauseProgramButton.Location = new System.Drawing.Point(8, 22);
            this.pauseProgramButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.pauseProgramButton.Name = "pauseProgramButton";
            this.pauseProgramButton.Size = new System.Drawing.Size(173, 42);
            this.pauseProgramButton.TabIndex = 7;
            this.pauseProgramButton.Text = "ПАУЗА";
            this.pauseProgramButton.UseVisualStyleBackColor = true;
            // 
            // progressInfoLabel
            // 
            this.progressInfoLabel.AutoSize = true;
            this.progressInfoLabel.Location = new System.Drawing.Point(9, 38);
            this.progressInfoLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.progressInfoLabel.Name = "progressInfoLabel";
            this.progressInfoLabel.Size = new System.Drawing.Size(78, 18);
            this.progressInfoLabel.TabIndex = 8;
            this.progressInfoLabel.Text = "Прогрес:";
            // 
            // minutesLeftLabel
            // 
            this.minutesLeftLabel.AutoSize = true;
            this.minutesLeftLabel.Location = new System.Drawing.Point(457, 38);
            this.minutesLeftLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.minutesLeftLabel.Name = "minutesLeftLabel";
            this.minutesLeftLabel.Size = new System.Drawing.Size(26, 18);
            this.minutesLeftLabel.TabIndex = 9;
            this.minutesLeftLabel.Text = "12";
            this.minutesLeftLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // minutesLeftInfoLabel
            // 
            this.minutesLeftInfoLabel.AutoSize = true;
            this.minutesLeftInfoLabel.Location = new System.Drawing.Point(498, 38);
            this.minutesLeftInfoLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.minutesLeftInfoLabel.Name = "minutesLeftInfoLabel";
            this.minutesLeftInfoLabel.Size = new System.Drawing.Size(177, 18);
            this.minutesLeftInfoLabel.TabIndex = 10;
            this.minutesLeftInfoLabel.Text = "хвилин до закінчення";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 29);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 18);
            this.label4.TabIndex = 11;
            this.label4.Text = "Температура (С):";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(19, 50);
            this.textBox1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(136, 24);
            this.textBox1.TabIndex = 12;
            this.textBox1.Text = "120";
            // 
            // turnOnTestDiodButton
            // 
            this.turnOnTestDiodButton.Location = new System.Drawing.Point(121, 57);
            this.turnOnTestDiodButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.turnOnTestDiodButton.Name = "turnOnTestDiodButton";
            this.turnOnTestDiodButton.Size = new System.Drawing.Size(71, 31);
            this.turnOnTestDiodButton.TabIndex = 19;
            this.turnOnTestDiodButton.Text = "ВКЛ";
            this.turnOnTestDiodButton.UseVisualStyleBackColor = true;
            this.turnOnTestDiodButton.Click += new System.EventHandler(this.button7_Click);
            // 
            // turnOffTestDiodButton
            // 
            this.turnOffTestDiodButton.Location = new System.Drawing.Point(121, 89);
            this.turnOffTestDiodButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.turnOffTestDiodButton.Name = "turnOffTestDiodButton";
            this.turnOffTestDiodButton.Size = new System.Drawing.Size(71, 31);
            this.turnOffTestDiodButton.TabIndex = 20;
            this.turnOffTestDiodButton.Text = "ВИКЛ";
            this.turnOffTestDiodButton.UseVisualStyleBackColor = true;
            this.turnOffTestDiodButton.Click += new System.EventHandler(this.button8_Click);
            // 
            // connectionStatusInfoLabel
            // 
            this.connectionStatusInfoLabel.AutoSize = true;
            this.connectionStatusInfoLabel.Location = new System.Drawing.Point(14, 71);
            this.connectionStatusInfoLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.connectionStatusInfoLabel.Name = "connectionStatusInfoLabel";
            this.connectionStatusInfoLabel.Size = new System.Drawing.Size(149, 18);
            this.connectionStatusInfoLabel.TabIndex = 21;
            this.connectionStatusInfoLabel.Text = "Статус з\'єднання:";
            // 
            // labelConnectionStatus
            // 
            this.labelConnectionStatus.AutoSize = true;
            this.labelConnectionStatus.Location = new System.Drawing.Point(252, 71);
            this.labelConnectionStatus.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelConnectionStatus.Name = "labelConnectionStatus";
            this.labelConnectionStatus.Size = new System.Drawing.Size(52, 18);
            this.labelConnectionStatus.TabIndex = 22;
            this.labelConnectionStatus.Text = "label8";
            // 
            // labelLastCommandStatus
            // 
            this.labelLastCommandStatus.AutoSize = true;
            this.labelLastCommandStatus.Location = new System.Drawing.Point(252, 103);
            this.labelLastCommandStatus.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelLastCommandStatus.Name = "labelLastCommandStatus";
            this.labelLastCommandStatus.Size = new System.Drawing.Size(52, 18);
            this.labelLastCommandStatus.TabIndex = 23;
            this.labelLastCommandStatus.Text = "label9";
            // 
            // commandStatusInfoLabel
            // 
            this.commandStatusInfoLabel.AutoSize = true;
            this.commandStatusInfoLabel.Location = new System.Drawing.Point(14, 103);
            this.commandStatusInfoLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.commandStatusInfoLabel.Name = "commandStatusInfoLabel";
            this.commandStatusInfoLabel.Size = new System.Drawing.Size(214, 18);
            this.commandStatusInfoLabel.TabIndex = 24;
            this.commandStatusInfoLabel.Text = "Статус поточної команди:";
            // 
            // projectNameLabel
            // 
            this.projectNameLabel.AutoSize = true;
            this.projectNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projectNameLabel.Location = new System.Drawing.Point(397, 9);
            this.projectNameLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.projectNameLabel.Name = "projectNameLabel";
            this.projectNameLabel.Size = new System.Drawing.Size(358, 37);
            this.projectNameLabel.TabIndex = 26;
            this.projectNameLabel.Text = "Терморегулятор Пічки";
            // 
            // testPinInfoLabel
            // 
            this.testPinInfoLabel.AutoSize = true;
            this.testPinInfoLabel.Location = new System.Drawing.Point(9, 78);
            this.testPinInfoLabel.Name = "testPinInfoLabel";
            this.testPinInfoLabel.Size = new System.Drawing.Size(67, 18);
            this.testPinInfoLabel.TabIndex = 28;
            this.testPinInfoLabel.Text = "13й пін:";
            // 
            // programsListBox
            // 
            this.programsListBox.FormattingEnabled = true;
            this.programsListBox.ItemHeight = 18;
            this.programsListBox.Location = new System.Drawing.Point(10, 22);
            this.programsListBox.Name = "programsListBox";
            this.programsListBox.Size = new System.Drawing.Size(621, 94);
            this.programsListBox.TabIndex = 29;
            // 
            // buttonShowProgram
            // 
            this.buttonShowProgram.Location = new System.Drawing.Point(473, 122);
            this.buttonShowProgram.Name = "buttonShowProgram";
            this.buttonShowProgram.Size = new System.Drawing.Size(158, 35);
            this.buttonShowProgram.TabIndex = 30;
            this.buttonShowProgram.Text = "Оновити Список";
            this.buttonShowProgram.UseVisualStyleBackColor = true;
            this.buttonShowProgram.Click += new System.EventHandler(this.showBreadsButton_Click);
            // 
            // newProgramNameTextBox
            // 
            this.newProgramNameTextBox.Location = new System.Drawing.Point(10, 55);
            this.newProgramNameTextBox.Name = "newProgramNameTextBox";
            this.newProgramNameTextBox.Size = new System.Drawing.Size(424, 24);
            this.newProgramNameTextBox.TabIndex = 31;
            // 
            // createProgramButton
            // 
            this.createProgramButton.Location = new System.Drawing.Point(317, 122);
            this.createProgramButton.Name = "createProgramButton";
            this.createProgramButton.Size = new System.Drawing.Size(115, 35);
            this.createProgramButton.TabIndex = 32;
            this.createProgramButton.Text = "Створити";
            this.createProgramButton.UseVisualStyleBackColor = true;
            this.createProgramButton.Click += new System.EventHandler(this.createBread_Click);
            // 
            // programNameLabel
            // 
            this.programNameLabel.AutoSize = true;
            this.programNameLabel.Location = new System.Drawing.Point(6, 34);
            this.programNameLabel.Name = "programNameLabel";
            this.programNameLabel.Size = new System.Drawing.Size(61, 18);
            this.programNameLabel.TabIndex = 33;
            this.programNameLabel.Text = "Назва:";
            // 
            // programFormGroupBox
            // 
            this.programFormGroupBox.Controls.Add(this.createProgramButton);
            this.programFormGroupBox.Controls.Add(this.programNameLabel);
            this.programFormGroupBox.Controls.Add(this.newProgramNameTextBox);
            this.programFormGroupBox.Location = new System.Drawing.Point(658, 23);
            this.programFormGroupBox.Name = "programFormGroupBox";
            this.programFormGroupBox.Size = new System.Drawing.Size(440, 168);
            this.programFormGroupBox.TabIndex = 34;
            this.programFormGroupBox.TabStop = false;
            this.programFormGroupBox.Text = "Створити Режим";
            // 
            // buttonPreviousProgram
            // 
            this.buttonPreviousProgram.Location = new System.Drawing.Point(10, 121);
            this.buttonPreviousProgram.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.buttonPreviousProgram.Name = "buttonPreviousProgram";
            this.buttonPreviousProgram.Size = new System.Drawing.Size(131, 36);
            this.buttonPreviousProgram.TabIndex = 27;
            this.buttonPreviousProgram.Text = "< Попередній";
            this.buttonPreviousProgram.UseVisualStyleBackColor = true;
            // 
            // buttonNextProgram
            // 
            this.buttonNextProgram.Location = new System.Drawing.Point(151, 121);
            this.buttonNextProgram.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.buttonNextProgram.Name = "buttonNextProgram";
            this.buttonNextProgram.Size = new System.Drawing.Size(131, 36);
            this.buttonNextProgram.TabIndex = 2;
            this.buttonNextProgram.Text = "Наступний >";
            this.buttonNextProgram.UseVisualStyleBackColor = true;
            this.buttonNextProgram.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.temperaturePointChartGroupBox);
            this.groupBox1.Controls.Add(this.temperaturePointFormGroupBox);
            this.groupBox1.Controls.Add(this.temperaturePointsIndexGroupBox);
            this.groupBox1.Controls.Add(this.actionGroupBox);
            this.groupBox1.Controls.Add(this.programsIndexGroupBox);
            this.groupBox1.Controls.Add(this.programFormGroupBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1104, 656);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Режими Роботи";
            // 
            // programsIndexGroupBox
            // 
            this.programsIndexGroupBox.Controls.Add(this.buttonDeleteProgram);
            this.programsIndexGroupBox.Controls.Add(this.programsListBox);
            this.programsIndexGroupBox.Controls.Add(this.buttonShowProgram);
            this.programsIndexGroupBox.Controls.Add(this.buttonPreviousProgram);
            this.programsIndexGroupBox.Controls.Add(this.buttonNextProgram);
            this.programsIndexGroupBox.Location = new System.Drawing.Point(15, 23);
            this.programsIndexGroupBox.Name = "programsIndexGroupBox";
            this.programsIndexGroupBox.Size = new System.Drawing.Size(637, 168);
            this.programsIndexGroupBox.TabIndex = 35;
            this.programsIndexGroupBox.TabStop = false;
            this.programsIndexGroupBox.Text = "Список Режимів";
            // 
            // statusGroupBox
            // 
            this.statusGroupBox.Controls.Add(this.progressBar1);
            this.statusGroupBox.Controls.Add(this.progressInfoLabel);
            this.statusGroupBox.Controls.Add(this.minutesLeftLabel);
            this.statusGroupBox.Controls.Add(this.minutesLeftInfoLabel);
            this.statusGroupBox.Controls.Add(this.connectionStatusInfoLabel);
            this.statusGroupBox.Controls.Add(this.labelConnectionStatus);
            this.statusGroupBox.Controls.Add(this.commandStatusInfoLabel);
            this.statusGroupBox.Controls.Add(this.labelLastCommandStatus);
            this.statusGroupBox.Location = new System.Drawing.Point(12, 720);
            this.statusGroupBox.Name = "statusGroupBox";
            this.statusGroupBox.Size = new System.Drawing.Size(885, 143);
            this.statusGroupBox.TabIndex = 36;
            this.statusGroupBox.TabStop = false;
            this.statusGroupBox.Text = "Статус";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.testPinInfoLabel);
            this.groupBox4.Controls.Add(this.turnOnTestDiodButton);
            this.groupBox4.Controls.Add(this.turnOffTestDiodButton);
            this.groupBox4.Location = new System.Drawing.Point(903, 720);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(213, 143);
            this.groupBox4.TabIndex = 37;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Перевірка З\'єднання";
            // 
            // actionGroupBox
            // 
            this.actionGroupBox.Controls.Add(this.pauseProgramButton);
            this.actionGroupBox.Controls.Add(this.startProgramButton);
            this.actionGroupBox.Controls.Add(this.stopProgramButton);
            this.actionGroupBox.Controls.Add(this.continueProgramButton);
            this.actionGroupBox.Location = new System.Drawing.Point(13, 573);
            this.actionGroupBox.Name = "actionGroupBox";
            this.actionGroupBox.Size = new System.Drawing.Size(1083, 77);
            this.actionGroupBox.TabIndex = 38;
            this.actionGroupBox.TabStop = false;
            this.actionGroupBox.Text = "Дії";
            // 
            // temperaturePointChartGroupBox
            // 
            this.temperaturePointChartGroupBox.Controls.Add(this.label4);
            this.temperaturePointChartGroupBox.Controls.Add(this.chartTemperatures);
            this.temperaturePointChartGroupBox.Controls.Add(this.textBox1);
            this.temperaturePointChartGroupBox.Location = new System.Drawing.Point(15, 371);
            this.temperaturePointChartGroupBox.Name = "temperaturePointChartGroupBox";
            this.temperaturePointChartGroupBox.Size = new System.Drawing.Size(1083, 197);
            this.temperaturePointChartGroupBox.TabIndex = 38;
            this.temperaturePointChartGroupBox.TabStop = false;
            this.temperaturePointChartGroupBox.Text = "Графік Температур";
            // 
            // temperaturePointsIndexGroupBox
            // 
            this.temperaturePointsIndexGroupBox.Controls.Add(this.deleteTemperaturePointButton);
            this.temperaturePointsIndexGroupBox.Controls.Add(this.temperaturePointsListBox);
            this.temperaturePointsIndexGroupBox.Controls.Add(this.showTemperaturePointsButton);
            this.temperaturePointsIndexGroupBox.Controls.Add(this.previousTemperaturePointButton);
            this.temperaturePointsIndexGroupBox.Controls.Add(this.nextTemperaturePointButton);
            this.temperaturePointsIndexGroupBox.Location = new System.Drawing.Point(15, 197);
            this.temperaturePointsIndexGroupBox.Name = "temperaturePointsIndexGroupBox";
            this.temperaturePointsIndexGroupBox.Size = new System.Drawing.Size(637, 168);
            this.temperaturePointsIndexGroupBox.TabIndex = 39;
            this.temperaturePointsIndexGroupBox.TabStop = false;
            this.temperaturePointsIndexGroupBox.Text = "Список Точок Температур";
            // 
            // temperaturePointsListBox
            // 
            this.temperaturePointsListBox.FormattingEnabled = true;
            this.temperaturePointsListBox.ItemHeight = 18;
            this.temperaturePointsListBox.Location = new System.Drawing.Point(10, 22);
            this.temperaturePointsListBox.Name = "temperaturePointsListBox";
            this.temperaturePointsListBox.Size = new System.Drawing.Size(621, 94);
            this.temperaturePointsListBox.TabIndex = 29;
            // 
            // showTemperaturePointsButton
            // 
            this.showTemperaturePointsButton.Location = new System.Drawing.Point(473, 124);
            this.showTemperaturePointsButton.Name = "showTemperaturePointsButton";
            this.showTemperaturePointsButton.Size = new System.Drawing.Size(158, 35);
            this.showTemperaturePointsButton.TabIndex = 30;
            this.showTemperaturePointsButton.Text = "Оновити Список";
            this.showTemperaturePointsButton.UseVisualStyleBackColor = true;
            // 
            // previousTemperaturePointButton
            // 
            this.previousTemperaturePointButton.Location = new System.Drawing.Point(10, 123);
            this.previousTemperaturePointButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.previousTemperaturePointButton.Name = "previousTemperaturePointButton";
            this.previousTemperaturePointButton.Size = new System.Drawing.Size(131, 36);
            this.previousTemperaturePointButton.TabIndex = 27;
            this.previousTemperaturePointButton.Text = "< Попередній";
            this.previousTemperaturePointButton.UseVisualStyleBackColor = true;
            // 
            // nextTemperaturePointButton
            // 
            this.nextTemperaturePointButton.Location = new System.Drawing.Point(151, 123);
            this.nextTemperaturePointButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.nextTemperaturePointButton.Name = "nextTemperaturePointButton";
            this.nextTemperaturePointButton.Size = new System.Drawing.Size(131, 36);
            this.nextTemperaturePointButton.TabIndex = 2;
            this.nextTemperaturePointButton.Text = "Наступний >";
            this.nextTemperaturePointButton.UseVisualStyleBackColor = true;
            // 
            // temperaturePointFormGroupBox
            // 
            this.temperaturePointFormGroupBox.Controls.Add(this.temperaturePointValueLabel);
            this.temperaturePointFormGroupBox.Controls.Add(this.newTemperaturePointValueTextBox);
            this.temperaturePointFormGroupBox.Controls.Add(this.createTemperaturePointButton);
            this.temperaturePointFormGroupBox.Controls.Add(this.temperaturePointMinuteLabel);
            this.temperaturePointFormGroupBox.Controls.Add(this.newTemperaturePointMinuteTextBox);
            this.temperaturePointFormGroupBox.Location = new System.Drawing.Point(658, 197);
            this.temperaturePointFormGroupBox.Name = "temperaturePointFormGroupBox";
            this.temperaturePointFormGroupBox.Size = new System.Drawing.Size(440, 168);
            this.temperaturePointFormGroupBox.TabIndex = 40;
            this.temperaturePointFormGroupBox.TabStop = false;
            this.temperaturePointFormGroupBox.Text = "Створити Точку Температури";
            // 
            // createTemperaturePointButton
            // 
            this.createTemperaturePointButton.Location = new System.Drawing.Point(317, 124);
            this.createTemperaturePointButton.Name = "createTemperaturePointButton";
            this.createTemperaturePointButton.Size = new System.Drawing.Size(115, 35);
            this.createTemperaturePointButton.TabIndex = 32;
            this.createTemperaturePointButton.Text = "Створити";
            this.createTemperaturePointButton.UseVisualStyleBackColor = true;
            this.createTemperaturePointButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // temperaturePointMinuteLabel
            // 
            this.temperaturePointMinuteLabel.AutoSize = true;
            this.temperaturePointMinuteLabel.Location = new System.Drawing.Point(6, 34);
            this.temperaturePointMinuteLabel.Name = "temperaturePointMinuteLabel";
            this.temperaturePointMinuteLabel.Size = new System.Drawing.Size(79, 18);
            this.temperaturePointMinuteLabel.TabIndex = 33;
            this.temperaturePointMinuteLabel.Text = "Хвилина:";
            // 
            // newTemperaturePointMinuteTextBox
            // 
            this.newTemperaturePointMinuteTextBox.Location = new System.Drawing.Point(108, 29);
            this.newTemperaturePointMinuteTextBox.Name = "newTemperaturePointMinuteTextBox";
            this.newTemperaturePointMinuteTextBox.Size = new System.Drawing.Size(326, 24);
            this.newTemperaturePointMinuteTextBox.TabIndex = 31;
            // 
            // temperaturePointValueLabel
            // 
            this.temperaturePointValueLabel.AutoSize = true;
            this.temperaturePointValueLabel.Location = new System.Drawing.Point(6, 66);
            this.temperaturePointValueLabel.Name = "temperaturePointValueLabel";
            this.temperaturePointValueLabel.Size = new System.Drawing.Size(87, 18);
            this.temperaturePointValueLabel.TabIndex = 35;
            this.temperaturePointValueLabel.Text = "Значення:";
            // 
            // newTemperaturePointValueTextBox
            // 
            this.newTemperaturePointValueTextBox.Location = new System.Drawing.Point(108, 60);
            this.newTemperaturePointValueTextBox.Name = "newTemperaturePointValueTextBox";
            this.newTemperaturePointValueTextBox.Size = new System.Drawing.Size(326, 24);
            this.newTemperaturePointValueTextBox.TabIndex = 34;
            // 
            // buttonDeleteProgram
            // 
            this.buttonDeleteProgram.Location = new System.Drawing.Point(375, 121);
            this.buttonDeleteProgram.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.buttonDeleteProgram.Name = "buttonDeleteProgram";
            this.buttonDeleteProgram.Size = new System.Drawing.Size(93, 36);
            this.buttonDeleteProgram.TabIndex = 31;
            this.buttonDeleteProgram.Text = "Видалити";
            this.buttonDeleteProgram.UseVisualStyleBackColor = true;
            // 
            // deleteTemperaturePointButton
            // 
            this.deleteTemperaturePointButton.Location = new System.Drawing.Point(372, 123);
            this.deleteTemperaturePointButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.deleteTemperaturePointButton.Name = "deleteTemperaturePointButton";
            this.deleteTemperaturePointButton.Size = new System.Drawing.Size(93, 36);
            this.deleteTemperaturePointButton.TabIndex = 32;
            this.deleteTemperaturePointButton.Text = "Видалити";
            this.deleteTemperaturePointButton.UseVisualStyleBackColor = true;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 874);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.statusGroupBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.projectNameLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Dashboard";
            this.Text = "Терморегулятор Пічки";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartTemperatures)).EndInit();
            this.programFormGroupBox.ResumeLayout(false);
            this.programFormGroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.programsIndexGroupBox.ResumeLayout(false);
            this.statusGroupBox.ResumeLayout(false);
            this.statusGroupBox.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.actionGroupBox.ResumeLayout(false);
            this.temperaturePointChartGroupBox.ResumeLayout(false);
            this.temperaturePointChartGroupBox.PerformLayout();
            this.temperaturePointsIndexGroupBox.ResumeLayout(false);
            this.temperaturePointFormGroupBox.ResumeLayout(false);
            this.temperaturePointFormGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startProgramButton;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button stopProgramButton;
        private System.Windows.Forms.Button continueProgramButton;
        private System.Windows.Forms.Button pauseProgramButton;
        private System.Windows.Forms.Label progressInfoLabel;
        private System.Windows.Forms.Label minutesLeftLabel;
        private System.Windows.Forms.Label minutesLeftInfoLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button turnOnTestDiodButton;
        private System.Windows.Forms.Button turnOffTestDiodButton;
        private System.Windows.Forms.Label connectionStatusInfoLabel;
        private System.Windows.Forms.Label labelConnectionStatus;
        private System.Windows.Forms.Label labelLastCommandStatus;
        private System.Windows.Forms.Label commandStatusInfoLabel;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTemperatures;
        private System.Windows.Forms.Label projectNameLabel;
        private System.Windows.Forms.Label testPinInfoLabel;
        private System.Windows.Forms.ListBox programsListBox;
        private System.Windows.Forms.Button buttonShowProgram;
        private System.Windows.Forms.TextBox newProgramNameTextBox;
        private System.Windows.Forms.Button createProgramButton;
        private System.Windows.Forms.Label programNameLabel;
        private System.Windows.Forms.GroupBox programFormGroupBox;
        private System.Windows.Forms.Button buttonPreviousProgram;
        private System.Windows.Forms.Button buttonNextProgram;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox programsIndexGroupBox;
        private System.Windows.Forms.GroupBox statusGroupBox;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox actionGroupBox;
        private System.Windows.Forms.GroupBox temperaturePointChartGroupBox;
        private System.Windows.Forms.GroupBox temperaturePointFormGroupBox;
        private System.Windows.Forms.Button createTemperaturePointButton;
        private System.Windows.Forms.Label temperaturePointMinuteLabel;
        private System.Windows.Forms.TextBox newTemperaturePointMinuteTextBox;
        private System.Windows.Forms.GroupBox temperaturePointsIndexGroupBox;
        private System.Windows.Forms.ListBox temperaturePointsListBox;
        private System.Windows.Forms.Button showTemperaturePointsButton;
        private System.Windows.Forms.Button previousTemperaturePointButton;
        private System.Windows.Forms.Button nextTemperaturePointButton;
        private System.Windows.Forms.Label temperaturePointValueLabel;
        private System.Windows.Forms.TextBox newTemperaturePointValueTextBox;
        private System.Windows.Forms.Button buttonDeleteProgram;
        private System.Windows.Forms.Button deleteTemperaturePointButton;
    }
}

