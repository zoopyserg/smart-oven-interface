
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
            this.projectNameLabel = new System.Windows.Forms.Label();
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
            this.progressGroupBox = new System.Windows.Forms.GroupBox();
            this.allActionsTabControl = new System.Windows.Forms.TabControl();
            this.temperaturesPage = new System.Windows.Forms.TabPage();
            this.temperaturePointsTabControl = new System.Windows.Forms.TabControl();
            this.temperatureChartTabPage = new System.Windows.Forms.TabPage();
            this.chartTemperatures = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.temperatureTableTabPage = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.deleteTemperaturePointButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.temperaturePointsListBox = new System.Windows.Forms.ListBox();
            this.pressuresPage = new System.Windows.Forms.TabPage();
            this.pressurePointsTabControl = new System.Windows.Forms.TabControl();
            this.pressureChartTabPage = new System.Windows.Forms.TabPage();
            this.pressuresChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pressureTableTabPage = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.deletePressurePointButton = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.pressurePointsListBox = new System.Windows.Forms.ListBox();
            this.valvesPage = new System.Windows.Forms.TabPage();
            this.valvePointsTabControl = new System.Windows.Forms.TabControl();
            this.valveChartTabPage = new System.Windows.Forms.TabPage();
            this.valveChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.valveTableTabPage = new System.Windows.Forms.TabPage();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.deleteSteamPointButton = new System.Windows.Forms.Button();
            this.valvePointsListBox = new System.Windows.Forms.ListBox();
            this.historyPage = new System.Windows.Forms.TabPage();
            this.historyListBox = new System.Windows.Forms.ListBox();
            this.statusPage = new System.Windows.Forms.TabPage();
            this.statusListBox = new System.Windows.Forms.ListBox();
            this.temperaturePointFormGroupBox = new System.Windows.Forms.GroupBox();
            this.newTemperaturePointValueTextBox = new System.Windows.Forms.NumericUpDown();
            this.newTemperaturePointMinuteTextBox = new System.Windows.Forms.NumericUpDown();
            this.temperaturePointValueLabel = new System.Windows.Forms.Label();
            this.createTemperaturePointButton = new System.Windows.Forms.Button();
            this.temperaturePointMinuteLabel = new System.Windows.Forms.Label();
            this.programsIndexGroupBox = new System.Windows.Forms.GroupBox();
            this.buttonDeleteProgram = new System.Windows.Forms.Button();
            this.expectedTemperatureLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.sensorValueLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.temperatureLabel = new System.Windows.Forms.Label();
            this.actionGroupBox = new System.Windows.Forms.GroupBox();
            this.LaunchedProgramLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.програмаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вихідToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.діагностикаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.перевіркаПінівToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оновитиІнформаціюПроДоступніПіниToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.режимиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оновитиІнформаціюПроДоступніРежимиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.налаштуванняToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.калібруванняТермодатчикаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.роліПінівToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.breadBindingSource)).BeginInit();
            this.programFormGroupBox.SuspendLayout();
            this.allInformationGroupBox.SuspendLayout();
            this.valvePointFormGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.newValvePointValueTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newValvePointMinuteTextBox)).BeginInit();
            this.pressurePointFormGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.newPressurePointValueTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newPressurePointMinuteTextBox)).BeginInit();
            this.progressGroupBox.SuspendLayout();
            this.allActionsTabControl.SuspendLayout();
            this.temperaturesPage.SuspendLayout();
            this.temperaturePointsTabControl.SuspendLayout();
            this.temperatureChartTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartTemperatures)).BeginInit();
            this.temperatureTableTabPage.SuspendLayout();
            this.pressuresPage.SuspendLayout();
            this.pressurePointsTabControl.SuspendLayout();
            this.pressureChartTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pressuresChart)).BeginInit();
            this.pressureTableTabPage.SuspendLayout();
            this.valvesPage.SuspendLayout();
            this.valvePointsTabControl.SuspendLayout();
            this.valveChartTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.valveChart)).BeginInit();
            this.valveTableTabPage.SuspendLayout();
            this.historyPage.SuspendLayout();
            this.statusPage.SuspendLayout();
            this.temperaturePointFormGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.newTemperaturePointValueTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newTemperaturePointMinuteTextBox)).BeginInit();
            this.programsIndexGroupBox.SuspendLayout();
            this.actionGroupBox.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // startProgramButton
            // 
            this.startProgramButton.Location = new System.Drawing.Point(6, 171);
            this.startProgramButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.startProgramButton.Name = "startProgramButton";
            this.startProgramButton.Size = new System.Drawing.Size(205, 107);
            this.startProgramButton.TabIndex = 0;
            this.startProgramButton.Text = "СТАРТ";
            this.startProgramButton.UseVisualStyleBackColor = true;
            this.startProgramButton.Click += new System.EventHandler(this.startProgramButton_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(112, 20);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(554, 26);
            this.progressBar1.TabIndex = 1;
            // 
            // stopProgramButton
            // 
            this.stopProgramButton.Location = new System.Drawing.Point(6, 120);
            this.stopProgramButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.stopProgramButton.Name = "stopProgramButton";
            this.stopProgramButton.Size = new System.Drawing.Size(205, 40);
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
            this.continueProgramButton.Size = new System.Drawing.Size(205, 40);
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
            this.pauseProgramButton.Size = new System.Drawing.Size(205, 40);
            this.pauseProgramButton.TabIndex = 7;
            this.pauseProgramButton.Text = "ПАУЗА";
            this.pauseProgramButton.UseVisualStyleBackColor = true;
            this.pauseProgramButton.Click += new System.EventHandler(this.pauseProgramButton_Click);
            // 
            // minutesLeftLabel
            // 
            this.minutesLeftLabel.AutoSize = true;
            this.minutesLeftLabel.Location = new System.Drawing.Point(685, 20);
            this.minutesLeftLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.minutesLeftLabel.Name = "minutesLeftLabel";
            this.minutesLeftLabel.Size = new System.Drawing.Size(23, 15);
            this.minutesLeftLabel.TabIndex = 9;
            this.minutesLeftLabel.Text = "12";
            // 
            // minutesLeftInfoLabel
            // 
            this.minutesLeftInfoLabel.AutoSize = true;
            this.minutesLeftInfoLabel.Location = new System.Drawing.Point(728, 20);
            this.minutesLeftInfoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.minutesLeftInfoLabel.Name = "minutesLeftInfoLabel";
            this.minutesLeftInfoLabel.Size = new System.Drawing.Size(119, 15);
            this.minutesLeftInfoLabel.TabIndex = 10;
            this.minutesLeftInfoLabel.Text = "хв до закінчення";
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
            this.newProgramNameTextBox.Size = new System.Drawing.Size(273, 21);
            this.newProgramNameTextBox.TabIndex = 31;
            // 
            // createProgramButton
            // 
            this.createProgramButton.Location = new System.Drawing.Point(189, 102);
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
            this.programFormGroupBox.Size = new System.Drawing.Size(285, 140);
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
            this.allInformationGroupBox.Controls.Add(this.progressGroupBox);
            this.allInformationGroupBox.Controls.Add(this.allActionsTabControl);
            this.allInformationGroupBox.Controls.Add(this.temperaturePointFormGroupBox);
            this.allInformationGroupBox.Controls.Add(this.programsIndexGroupBox);
            this.allInformationGroupBox.Controls.Add(this.programFormGroupBox);
            this.allInformationGroupBox.Location = new System.Drawing.Point(10, 48);
            this.allInformationGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.allInformationGroupBox.Name = "allInformationGroupBox";
            this.allInformationGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.allInformationGroupBox.Size = new System.Drawing.Size(1029, 535);
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
            this.valvePointFormGroupBox.Size = new System.Drawing.Size(161, 111);
            this.valvePointFormGroupBox.TabIndex = 43;
            this.valvePointFormGroupBox.TabStop = false;
            this.valvePointFormGroupBox.Text = "Точка Подачі Пари";
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
            this.newValvePointValueTextBox.Size = new System.Drawing.Size(59, 21);
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
            this.newValvePointMinuteTextBox.Size = new System.Drawing.Size(59, 21);
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
            this.createValvePointButton.Location = new System.Drawing.Point(8, 78);
            this.createValvePointButton.Margin = new System.Windows.Forms.Padding(2);
            this.createValvePointButton.Name = "createValvePointButton";
            this.createValvePointButton.Size = new System.Drawing.Size(146, 29);
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
            this.pressurePointFormGroupBox.Size = new System.Drawing.Size(165, 111);
            this.pressurePointFormGroupBox.TabIndex = 42;
            this.pressurePointFormGroupBox.TabStop = false;
            this.pressurePointFormGroupBox.Text = "Точка Тиску Води";
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
            this.newPressurePointValueTextBox.Size = new System.Drawing.Size(59, 21);
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
            this.newPressurePointMinuteTextBox.Size = new System.Drawing.Size(59, 21);
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
            this.createPressurePointButton.Location = new System.Drawing.Point(8, 78);
            this.createPressurePointButton.Margin = new System.Windows.Forms.Padding(2);
            this.createPressurePointButton.Name = "createPressurePointButton";
            this.createPressurePointButton.Size = new System.Drawing.Size(144, 29);
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
            // progressGroupBox
            // 
            this.progressGroupBox.Controls.Add(this.progressBar1);
            this.progressGroupBox.Controls.Add(this.minutesLeftLabel);
            this.progressGroupBox.Controls.Add(this.minutesLeftInfoLabel);
            this.progressGroupBox.Location = new System.Drawing.Point(0, 465);
            this.progressGroupBox.Name = "progressGroupBox";
            this.progressGroupBox.Size = new System.Drawing.Size(853, 60);
            this.progressGroupBox.TabIndex = 39;
            this.progressGroupBox.TabStop = false;
            this.progressGroupBox.Text = "Прогрес";
            // 
            // allActionsTabControl
            // 
            this.allActionsTabControl.Controls.Add(this.temperaturesPage);
            this.allActionsTabControl.Controls.Add(this.pressuresPage);
            this.allActionsTabControl.Controls.Add(this.valvesPage);
            this.allActionsTabControl.Controls.Add(this.historyPage);
            this.allActionsTabControl.Controls.Add(this.statusPage);
            this.allActionsTabControl.Location = new System.Drawing.Point(10, 164);
            this.allActionsTabControl.Margin = new System.Windows.Forms.Padding(2);
            this.allActionsTabControl.Name = "allActionsTabControl";
            this.allActionsTabControl.SelectedIndex = 0;
            this.allActionsTabControl.Size = new System.Drawing.Size(843, 285);
            this.allActionsTabControl.TabIndex = 41;
            // 
            // temperaturesPage
            // 
            this.temperaturesPage.Controls.Add(this.temperaturePointsTabControl);
            this.temperaturesPage.Location = new System.Drawing.Point(4, 24);
            this.temperaturesPage.Name = "temperaturesPage";
            this.temperaturesPage.Size = new System.Drawing.Size(835, 257);
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
            this.temperaturePointsTabControl.Size = new System.Drawing.Size(827, 250);
            this.temperaturePointsTabControl.TabIndex = 42;
            // 
            // temperatureChartTabPage
            // 
            this.temperatureChartTabPage.Controls.Add(this.chartTemperatures);
            this.temperatureChartTabPage.Location = new System.Drawing.Point(4, 24);
            this.temperatureChartTabPage.Margin = new System.Windows.Forms.Padding(2);
            this.temperatureChartTabPage.Name = "temperatureChartTabPage";
            this.temperatureChartTabPage.Padding = new System.Windows.Forms.Padding(2);
            this.temperatureChartTabPage.Size = new System.Drawing.Size(819, 222);
            this.temperatureChartTabPage.TabIndex = 1;
            this.temperatureChartTabPage.Text = "Графік Температур";
            this.temperatureChartTabPage.UseVisualStyleBackColor = true;
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
            this.chartTemperatures.Location = new System.Drawing.Point(0, 0);
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
            this.chartTemperatures.Size = new System.Drawing.Size(815, 217);
            this.chartTemperatures.TabIndex = 4;
            this.chartTemperatures.Text = "chart1";
            title1.Name = "Text";
            this.chartTemperatures.Titles.Add(title1);
            // 
            // temperatureTableTabPage
            // 
            this.temperatureTableTabPage.Controls.Add(this.button1);
            this.temperatureTableTabPage.Controls.Add(this.deleteTemperaturePointButton);
            this.temperatureTableTabPage.Controls.Add(this.button2);
            this.temperatureTableTabPage.Controls.Add(this.temperaturePointsListBox);
            this.temperatureTableTabPage.Location = new System.Drawing.Point(4, 24);
            this.temperatureTableTabPage.Margin = new System.Windows.Forms.Padding(2);
            this.temperatureTableTabPage.Name = "temperatureTableTabPage";
            this.temperatureTableTabPage.Padding = new System.Windows.Forms.Padding(2);
            this.temperatureTableTabPage.Size = new System.Drawing.Size(819, 222);
            this.temperatureTableTabPage.TabIndex = 0;
            this.temperatureTableTabPage.Text = "Таблиця Температур";
            this.temperatureTableTabPage.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(497, 185);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 29);
            this.button1.TabIndex = 45;
            this.button1.Text = "< Попередній";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.previousTemperaturePointButton_Click);
            // 
            // deleteTemperaturePointButton
            // 
            this.deleteTemperaturePointButton.Location = new System.Drawing.Point(721, 185);
            this.deleteTemperaturePointButton.Margin = new System.Windows.Forms.Padding(2);
            this.deleteTemperaturePointButton.Name = "deleteTemperaturePointButton";
            this.deleteTemperaturePointButton.Size = new System.Drawing.Size(92, 29);
            this.deleteTemperaturePointButton.TabIndex = 34;
            this.deleteTemperaturePointButton.Text = "Видалити";
            this.deleteTemperaturePointButton.UseVisualStyleBackColor = true;
            this.deleteTemperaturePointButton.Click += new System.EventHandler(this.deleteTemperaturePointButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(610, 185);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 29);
            this.button2.TabIndex = 44;
            this.button2.Text = "Наступний >";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.nextTemperaturePointButton_Click);
            // 
            // temperaturePointsListBox
            // 
            this.temperaturePointsListBox.ColumnWidth = 2;
            this.temperaturePointsListBox.FormattingEnabled = true;
            this.temperaturePointsListBox.ItemHeight = 15;
            this.temperaturePointsListBox.Location = new System.Drawing.Point(2, 0);
            this.temperaturePointsListBox.Margin = new System.Windows.Forms.Padding(2);
            this.temperaturePointsListBox.Name = "temperaturePointsListBox";
            this.temperaturePointsListBox.Size = new System.Drawing.Size(813, 214);
            this.temperaturePointsListBox.TabIndex = 29;
            // 
            // pressuresPage
            // 
            this.pressuresPage.Controls.Add(this.pressurePointsTabControl);
            this.pressuresPage.Location = new System.Drawing.Point(4, 24);
            this.pressuresPage.Name = "pressuresPage";
            this.pressuresPage.Size = new System.Drawing.Size(835, 257);
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
            this.pressurePointsTabControl.Size = new System.Drawing.Size(831, 252);
            this.pressurePointsTabControl.TabIndex = 42;
            // 
            // pressureChartTabPage
            // 
            this.pressureChartTabPage.Controls.Add(this.pressuresChart);
            this.pressureChartTabPage.Location = new System.Drawing.Point(4, 24);
            this.pressureChartTabPage.Margin = new System.Windows.Forms.Padding(2);
            this.pressureChartTabPage.Name = "pressureChartTabPage";
            this.pressureChartTabPage.Padding = new System.Windows.Forms.Padding(2);
            this.pressureChartTabPage.Size = new System.Drawing.Size(823, 224);
            this.pressureChartTabPage.TabIndex = 1;
            this.pressureChartTabPage.Text = "Графік Тиску Води";
            this.pressureChartTabPage.UseVisualStyleBackColor = true;
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
            this.pressuresChart.Location = new System.Drawing.Point(4, 2);
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
            this.pressuresChart.Size = new System.Drawing.Size(813, 217);
            this.pressuresChart.TabIndex = 4;
            this.pressuresChart.Text = "chart1";
            title2.Name = "Text";
            this.pressuresChart.Titles.Add(title2);
            // 
            // pressureTableTabPage
            // 
            this.pressureTableTabPage.Controls.Add(this.button3);
            this.pressureTableTabPage.Controls.Add(this.deletePressurePointButton);
            this.pressureTableTabPage.Controls.Add(this.button4);
            this.pressureTableTabPage.Controls.Add(this.pressurePointsListBox);
            this.pressureTableTabPage.Location = new System.Drawing.Point(4, 24);
            this.pressureTableTabPage.Margin = new System.Windows.Forms.Padding(2);
            this.pressureTableTabPage.Name = "pressureTableTabPage";
            this.pressureTableTabPage.Padding = new System.Windows.Forms.Padding(2);
            this.pressureTableTabPage.Size = new System.Drawing.Size(823, 224);
            this.pressureTableTabPage.TabIndex = 0;
            this.pressureTableTabPage.Text = "Таблиця Тиску Води";
            this.pressureTableTabPage.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(501, 191);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(105, 27);
            this.button3.TabIndex = 47;
            this.button3.Text = "< Попередній";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.previousPressurePointButton_Click);
            // 
            // deletePressurePointButton
            // 
            this.deletePressurePointButton.Location = new System.Drawing.Point(725, 191);
            this.deletePressurePointButton.Margin = new System.Windows.Forms.Padding(2);
            this.deletePressurePointButton.Name = "deletePressurePointButton";
            this.deletePressurePointButton.Size = new System.Drawing.Size(92, 27);
            this.deletePressurePointButton.TabIndex = 44;
            this.deletePressurePointButton.Text = "Видалити";
            this.deletePressurePointButton.UseVisualStyleBackColor = true;
            this.deletePressurePointButton.Click += new System.EventHandler(this.deletePressurePointButton_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(614, 191);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(105, 27);
            this.button4.TabIndex = 46;
            this.button4.Text = "Наступний >";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.nextPressurePointButton_Click);
            // 
            // pressurePointsListBox
            // 
            this.pressurePointsListBox.ColumnWidth = 2;
            this.pressurePointsListBox.FormattingEnabled = true;
            this.pressurePointsListBox.ItemHeight = 15;
            this.pressurePointsListBox.Location = new System.Drawing.Point(2, 4);
            this.pressurePointsListBox.Margin = new System.Windows.Forms.Padding(2);
            this.pressurePointsListBox.Name = "pressurePointsListBox";
            this.pressurePointsListBox.Size = new System.Drawing.Size(817, 214);
            this.pressurePointsListBox.TabIndex = 29;
            // 
            // valvesPage
            // 
            this.valvesPage.Controls.Add(this.valvePointsTabControl);
            this.valvesPage.Location = new System.Drawing.Point(4, 24);
            this.valvesPage.Name = "valvesPage";
            this.valvesPage.Size = new System.Drawing.Size(835, 257);
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
            this.valvePointsTabControl.Size = new System.Drawing.Size(827, 252);
            this.valvePointsTabControl.TabIndex = 42;
            // 
            // valveChartTabPage
            // 
            this.valveChartTabPage.Controls.Add(this.valveChart);
            this.valveChartTabPage.Location = new System.Drawing.Point(4, 24);
            this.valveChartTabPage.Margin = new System.Windows.Forms.Padding(2);
            this.valveChartTabPage.Name = "valveChartTabPage";
            this.valveChartTabPage.Padding = new System.Windows.Forms.Padding(2);
            this.valveChartTabPage.Size = new System.Drawing.Size(819, 224);
            this.valveChartTabPage.TabIndex = 1;
            this.valveChartTabPage.Text = "Графік Рівня Пари";
            this.valveChartTabPage.UseVisualStyleBackColor = true;
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
            this.valveChart.Location = new System.Drawing.Point(4, 5);
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
            this.valveChart.Size = new System.Drawing.Size(811, 214);
            this.valveChart.TabIndex = 4;
            this.valveChart.Text = "chart1";
            title3.Name = "Text";
            this.valveChart.Titles.Add(title3);
            // 
            // valveTableTabPage
            // 
            this.valveTableTabPage.Controls.Add(this.button5);
            this.valveTableTabPage.Controls.Add(this.button6);
            this.valveTableTabPage.Controls.Add(this.deleteSteamPointButton);
            this.valveTableTabPage.Controls.Add(this.valvePointsListBox);
            this.valveTableTabPage.Location = new System.Drawing.Point(4, 24);
            this.valveTableTabPage.Margin = new System.Windows.Forms.Padding(2);
            this.valveTableTabPage.Name = "valveTableTabPage";
            this.valveTableTabPage.Padding = new System.Windows.Forms.Padding(2);
            this.valveTableTabPage.Size = new System.Drawing.Size(819, 224);
            this.valveTableTabPage.TabIndex = 0;
            this.valveTableTabPage.Text = "Таблиця Рівня Пари";
            this.valveTableTabPage.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(498, 189);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(105, 29);
            this.button5.TabIndex = 47;
            this.button5.Text = "< Попередній";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.previousValvePointButton_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(611, 189);
            this.button6.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(105, 29);
            this.button6.TabIndex = 46;
            this.button6.Text = "Наступний >";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.nextValvePointButton_Click);
            // 
            // deleteSteamPointButton
            // 
            this.deleteSteamPointButton.Location = new System.Drawing.Point(721, 189);
            this.deleteSteamPointButton.Margin = new System.Windows.Forms.Padding(2);
            this.deleteSteamPointButton.Name = "deleteSteamPointButton";
            this.deleteSteamPointButton.Size = new System.Drawing.Size(92, 29);
            this.deleteSteamPointButton.TabIndex = 45;
            this.deleteSteamPointButton.Text = "Видалити";
            this.deleteSteamPointButton.UseVisualStyleBackColor = true;
            this.deleteSteamPointButton.Click += new System.EventHandler(this.deleteValvePointButton_Click);
            // 
            // valvePointsListBox
            // 
            this.valvePointsListBox.ColumnWidth = 2;
            this.valvePointsListBox.FormattingEnabled = true;
            this.valvePointsListBox.ItemHeight = 15;
            this.valvePointsListBox.Location = new System.Drawing.Point(4, 4);
            this.valvePointsListBox.Margin = new System.Windows.Forms.Padding(2);
            this.valvePointsListBox.Name = "valvePointsListBox";
            this.valvePointsListBox.Size = new System.Drawing.Size(811, 214);
            this.valvePointsListBox.TabIndex = 29;
            // 
            // historyPage
            // 
            this.historyPage.Controls.Add(this.historyListBox);
            this.historyPage.Location = new System.Drawing.Point(4, 24);
            this.historyPage.Margin = new System.Windows.Forms.Padding(2);
            this.historyPage.Name = "historyPage";
            this.historyPage.Size = new System.Drawing.Size(835, 257);
            this.historyPage.TabIndex = 2;
            this.historyPage.Text = "Історія Запусків";
            this.historyPage.UseVisualStyleBackColor = true;
            // 
            // historyListBox
            // 
            this.historyListBox.ColumnWidth = 2;
            this.historyListBox.FormattingEnabled = true;
            this.historyListBox.ItemHeight = 15;
            this.historyListBox.Location = new System.Drawing.Point(6, 4);
            this.historyListBox.Margin = new System.Windows.Forms.Padding(2);
            this.historyListBox.Name = "historyListBox";
            this.historyListBox.Size = new System.Drawing.Size(827, 244);
            this.historyListBox.TabIndex = 29;
            // 
            // statusPage
            // 
            this.statusPage.Controls.Add(this.statusListBox);
            this.statusPage.Location = new System.Drawing.Point(4, 24);
            this.statusPage.Name = "statusPage";
            this.statusPage.Padding = new System.Windows.Forms.Padding(3);
            this.statusPage.Size = new System.Drawing.Size(835, 257);
            this.statusPage.TabIndex = 6;
            this.statusPage.Text = "Статус";
            this.statusPage.UseVisualStyleBackColor = true;
            // 
            // statusListBox
            // 
            this.statusListBox.ColumnWidth = 2;
            this.statusListBox.FormattingEnabled = true;
            this.statusListBox.ItemHeight = 15;
            this.statusListBox.Location = new System.Drawing.Point(6, 5);
            this.statusListBox.Margin = new System.Windows.Forms.Padding(2);
            this.statusListBox.Name = "statusListBox";
            this.statusListBox.Size = new System.Drawing.Size(824, 244);
            this.statusListBox.TabIndex = 30;
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
            this.temperaturePointFormGroupBox.Size = new System.Drawing.Size(165, 111);
            this.temperaturePointFormGroupBox.TabIndex = 40;
            this.temperaturePointFormGroupBox.TabStop = false;
            this.temperaturePointFormGroupBox.Text = "Точка Температури";
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
            this.newTemperaturePointValueTextBox.Size = new System.Drawing.Size(59, 21);
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
            this.newTemperaturePointMinuteTextBox.Size = new System.Drawing.Size(59, 21);
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
            this.createTemperaturePointButton.Location = new System.Drawing.Point(8, 72);
            this.createTemperaturePointButton.Margin = new System.Windows.Forms.Padding(2);
            this.createTemperaturePointButton.Name = "createTemperaturePointButton";
            this.createTemperaturePointButton.Size = new System.Drawing.Size(146, 29);
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
            // expectedTemperatureLabel
            // 
            this.expectedTemperatureLabel.AutoSize = true;
            this.expectedTemperatureLabel.Location = new System.Drawing.Point(102, 78);
            this.expectedTemperatureLabel.Name = "expectedTemperatureLabel";
            this.expectedTemperatureLabel.Size = new System.Drawing.Size(12, 15);
            this.expectedTemperatureLabel.TabIndex = 48;
            this.expectedTemperatureLabel.Text = "-";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 15);
            this.label7.TabIndex = 47;
            this.label7.Text = "Очікувана:";
            // 
            // sensorValueLabel
            // 
            this.sensorValueLabel.AutoSize = true;
            this.sensorValueLabel.Location = new System.Drawing.Point(102, 27);
            this.sensorValueLabel.Name = "sensorValueLabel";
            this.sensorValueLabel.Size = new System.Drawing.Size(31, 15);
            this.sensorValueLabel.TabIndex = 46;
            this.sensorValueLabel.Text = "420";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 15);
            this.label6.TabIndex = 45;
            this.label6.Text = "Датчик";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 15);
            this.label5.TabIndex = 44;
            this.label5.Text = "Поточна:";
            // 
            // temperatureLabel
            // 
            this.temperatureLabel.AutoSize = true;
            this.temperatureLabel.Location = new System.Drawing.Point(102, 53);
            this.temperatureLabel.Name = "temperatureLabel";
            this.temperatureLabel.Size = new System.Drawing.Size(36, 15);
            this.temperatureLabel.TabIndex = 43;
            this.temperatureLabel.Text = "25 C";
            // 
            // actionGroupBox
            // 
            this.actionGroupBox.Controls.Add(this.pauseProgramButton);
            this.actionGroupBox.Controls.Add(this.startProgramButton);
            this.actionGroupBox.Controls.Add(this.stopProgramButton);
            this.actionGroupBox.Controls.Add(this.continueProgramButton);
            this.actionGroupBox.Location = new System.Drawing.Point(1042, 212);
            this.actionGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.actionGroupBox.Name = "actionGroupBox";
            this.actionGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.actionGroupBox.Size = new System.Drawing.Size(217, 285);
            this.actionGroupBox.TabIndex = 38;
            this.actionGroupBox.TabStop = false;
            this.actionGroupBox.Text = "Дії";
            // 
            // LaunchedProgramLabel
            // 
            this.LaunchedProgramLabel.AutoSize = true;
            this.LaunchedProgramLabel.Location = new System.Drawing.Point(6, 27);
            this.LaunchedProgramLabel.Name = "LaunchedProgramLabel";
            this.LaunchedProgramLabel.Size = new System.Drawing.Size(12, 15);
            this.LaunchedProgramLabel.TabIndex = 12;
            this.LaunchedProgramLabel.Text = "-";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.програмаToolStripMenuItem,
            this.діагностикаToolStripMenuItem,
            this.режимиToolStripMenuItem,
            this.налаштуванняToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1269, 24);
            this.menuStrip1.TabIndex = 43;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // програмаToolStripMenuItem
            // 
            this.програмаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.вихідToolStripMenuItem});
            this.програмаToolStripMenuItem.Name = "програмаToolStripMenuItem";
            this.програмаToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.програмаToolStripMenuItem.Text = "Програма";
            // 
            // вихідToolStripMenuItem
            // 
            this.вихідToolStripMenuItem.Name = "вихідToolStripMenuItem";
            this.вихідToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.вихідToolStripMenuItem.Text = "Вихід";
            this.вихідToolStripMenuItem.Click += new System.EventHandler(this.вихідToolStripMenuItem_Click);
            // 
            // діагностикаToolStripMenuItem
            // 
            this.діагностикаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.перевіркаПінівToolStripMenuItem,
            this.оновитиІнформаціюПроДоступніПіниToolStripMenuItem});
            this.діагностикаToolStripMenuItem.Name = "діагностикаToolStripMenuItem";
            this.діагностикаToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.діагностикаToolStripMenuItem.Text = "Піни";
            // 
            // перевіркаПінівToolStripMenuItem
            // 
            this.перевіркаПінівToolStripMenuItem.Name = "перевіркаПінівToolStripMenuItem";
            this.перевіркаПінівToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.перевіркаПінівToolStripMenuItem.Text = "Перевірка Пінів";
            this.перевіркаПінівToolStripMenuItem.Click += new System.EventHandler(this.перевіркаПінівToolStripMenuItem_Click);
            // 
            // оновитиІнформаціюПроДоступніПіниToolStripMenuItem
            // 
            this.оновитиІнформаціюПроДоступніПіниToolStripMenuItem.Name = "оновитиІнформаціюПроДоступніПіниToolStripMenuItem";
            this.оновитиІнформаціюПроДоступніПіниToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.оновитиІнформаціюПроДоступніПіниToolStripMenuItem.Text = "Інформація Про Піни";
            this.оновитиІнформаціюПроДоступніПіниToolStripMenuItem.Click += new System.EventHandler(this.оновитиІнформаціюПроДоступніПіниToolStripMenuItem_Click);
            // 
            // режимиToolStripMenuItem
            // 
            this.режимиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оновитиІнформаціюПроДоступніРежимиToolStripMenuItem});
            this.режимиToolStripMenuItem.Name = "режимиToolStripMenuItem";
            this.режимиToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.режимиToolStripMenuItem.Text = "Режими";
            // 
            // оновитиІнформаціюПроДоступніРежимиToolStripMenuItem
            // 
            this.оновитиІнформаціюПроДоступніРежимиToolStripMenuItem.Name = "оновитиІнформаціюПроДоступніРежимиToolStripMenuItem";
            this.оновитиІнформаціюПроДоступніРежимиToolStripMenuItem.Size = new System.Drawing.Size(319, 22);
            this.оновитиІнформаціюПроДоступніРежимиToolStripMenuItem.Text = "Оновити Інформацію Про Доступні Режими";
            this.оновитиІнформаціюПроДоступніРежимиToolStripMenuItem.Click += new System.EventHandler(this.оновитиІнформаціюПроДоступніРежимиToolStripMenuItem_Click);
            // 
            // налаштуванняToolStripMenuItem
            // 
            this.налаштуванняToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.калібруванняТермодатчикаToolStripMenuItem,
            this.роліПінівToolStripMenuItem});
            this.налаштуванняToolStripMenuItem.Name = "налаштуванняToolStripMenuItem";
            this.налаштуванняToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.налаштуванняToolStripMenuItem.Text = "Налаштування";
            // 
            // калібруванняТермодатчикаToolStripMenuItem
            // 
            this.калібруванняТермодатчикаToolStripMenuItem.Name = "калібруванняТермодатчикаToolStripMenuItem";
            this.калібруванняТермодатчикаToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.калібруванняТермодатчикаToolStripMenuItem.Text = "Калібрування Термодатчика";
            this.калібруванняТермодатчикаToolStripMenuItem.Click += new System.EventHandler(this.калібруванняТермодатчикаToolStripMenuItem_Click);
            // 
            // роліПінівToolStripMenuItem
            // 
            this.роліПінівToolStripMenuItem.Name = "роліПінівToolStripMenuItem";
            this.роліПінівToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.роліПінівToolStripMenuItem.Text = "Ролі Пінів";
            this.роліПінівToolStripMenuItem.Click += new System.EventHandler(this.роліПінівToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LaunchedProgramLabel);
            this.groupBox1.Location = new System.Drawing.Point(1044, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(205, 51);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Запущена Програма";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.expectedTemperatureLabel);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.temperatureLabel);
            this.groupBox3.Controls.Add(this.sensorValueLabel);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(1042, 105);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(207, 102);
            this.groupBox3.TabIndex = 45;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Температура";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1269, 591);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.allInformationGroupBox);
            this.Controls.Add(this.projectNameLabel);
            this.Controls.Add(this.actionGroupBox);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
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
            this.progressGroupBox.ResumeLayout(false);
            this.progressGroupBox.PerformLayout();
            this.allActionsTabControl.ResumeLayout(false);
            this.temperaturesPage.ResumeLayout(false);
            this.temperaturePointsTabControl.ResumeLayout(false);
            this.temperatureChartTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartTemperatures)).EndInit();
            this.temperatureTableTabPage.ResumeLayout(false);
            this.pressuresPage.ResumeLayout(false);
            this.pressurePointsTabControl.ResumeLayout(false);
            this.pressureChartTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pressuresChart)).EndInit();
            this.pressureTableTabPage.ResumeLayout(false);
            this.valvesPage.ResumeLayout(false);
            this.valvePointsTabControl.ResumeLayout(false);
            this.valveChartTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.valveChart)).EndInit();
            this.valveTableTabPage.ResumeLayout(false);
            this.historyPage.ResumeLayout(false);
            this.statusPage.ResumeLayout(false);
            this.temperaturePointFormGroupBox.ResumeLayout(false);
            this.temperaturePointFormGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.newTemperaturePointValueTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newTemperaturePointMinuteTextBox)).EndInit();
            this.programsIndexGroupBox.ResumeLayout(false);
            this.actionGroupBox.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
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
        private System.Windows.Forms.Label projectNameLabel;
        private System.Windows.Forms.ListBox programsListBox;
        private System.Windows.Forms.TextBox newProgramNameTextBox;
        private System.Windows.Forms.Button createProgramButton;
        private System.Windows.Forms.Label programNameLabel;
        private System.Windows.Forms.GroupBox programFormGroupBox;
        private System.Windows.Forms.Button buttonPreviousProgram;
        private System.Windows.Forms.Button buttonNextProgram;
        private System.Windows.Forms.GroupBox allInformationGroupBox;
        private System.Windows.Forms.GroupBox programsIndexGroupBox;
        private System.Windows.Forms.GroupBox actionGroupBox;
        private System.Windows.Forms.GroupBox temperaturePointFormGroupBox;
        private System.Windows.Forms.Button createTemperaturePointButton;
        private System.Windows.Forms.Label temperaturePointMinuteLabel;
        private System.Windows.Forms.Label temperaturePointValueLabel;
        private System.Windows.Forms.Button buttonDeleteProgram;
        private System.Windows.Forms.TabControl allActionsTabControl;
        private System.Windows.Forms.TabPage historyPage;
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
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTemperatures;
        private System.Windows.Forms.TabPage temperatureTableTabPage;
        private System.Windows.Forms.ListBox temperaturePointsListBox;
        private System.Windows.Forms.TabPage pressuresPage;
        private System.Windows.Forms.TabControl pressurePointsTabControl;
        private System.Windows.Forms.TabPage pressureChartTabPage;
        private System.Windows.Forms.DataVisualization.Charting.Chart pressuresChart;
        private System.Windows.Forms.TabPage pressureTableTabPage;
        private System.Windows.Forms.ListBox pressurePointsListBox;
        private System.Windows.Forms.TabPage valvesPage;
        private System.Windows.Forms.TabControl valvePointsTabControl;
        private System.Windows.Forms.TabPage valveChartTabPage;
        private System.Windows.Forms.DataVisualization.Charting.Chart valveChart;
        private System.Windows.Forms.TabPage valveTableTabPage;
        private System.Windows.Forms.ListBox valvePointsListBox;
        private System.Windows.Forms.NumericUpDown newValvePointValueTextBox;
        private System.Windows.Forms.NumericUpDown newValvePointMinuteTextBox;
        private System.Windows.Forms.NumericUpDown newPressurePointValueTextBox;
        private System.Windows.Forms.NumericUpDown newPressurePointMinuteTextBox;
        private System.Windows.Forms.NumericUpDown newTemperaturePointValueTextBox;
        private System.Windows.Forms.NumericUpDown newTemperaturePointMinuteTextBox;
        private System.Windows.Forms.BindingSource breadBindingSource;
        private System.Windows.Forms.GroupBox progressGroupBox;
        private System.Windows.Forms.TabPage statusPage;
        private System.Windows.Forms.ListBox statusListBox;
        private System.Windows.Forms.Label temperatureLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label sensorValueLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label expectedTemperatureLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem програмаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вихідToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem діагностикаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem перевіркаПінівToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оновитиІнформаціюПроДоступніПіниToolStripMenuItem;
        private System.Windows.Forms.Label LaunchedProgramLabel;
        private System.Windows.Forms.ToolStripMenuItem режимиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оновитиІнформаціюПроДоступніРежимиToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ToolStripMenuItem налаштуванняToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem калібруванняТермодатчикаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem роліПінівToolStripMenuItem;
        private System.Windows.Forms.Button deleteTemperaturePointButton;
        private System.Windows.Forms.Button deletePressurePointButton;
        private System.Windows.Forms.Button deleteSteamPointButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}

