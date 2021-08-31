
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea13 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend13 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series13 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea14 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend14 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series14 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea15 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend15 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series15 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.buttonStart = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.buttonNextProgram = new System.Windows.Forms.Button();
            this.chartTemperatures = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonContinue = new System.Windows.Forms.Button();
            this.buttonPause = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.chartWaterPressures = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.chartVaperPressures = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.labelConnectionStatus = new System.Windows.Forms.Label();
            this.labelLastCommandStatus = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.labelProgramName = new System.Windows.Forms.Label();
            this.buttonPrevioussProgram = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.breadsListBox = new System.Windows.Forms.ListBox();
            this.showBreadsButton = new System.Windows.Forms.Button();
            this.newBreadNameTextBox = new System.Windows.Forms.TextBox();
            this.createBread = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.createBreadGroupBox = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.chartTemperatures)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartWaterPressures)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartVaperPressures)).BeginInit();
            this.createBreadGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(596, 905);
            this.buttonStart.Margin = new System.Windows.Forms.Padding(5);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(173, 47);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "СТАРТ";
            this.buttonStart.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(132, 483);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(5);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(343, 35);
            this.progressBar1.TabIndex = 1;
            // 
            // buttonNextProgram
            // 
            this.buttonNextProgram.Location = new System.Drawing.Point(1155, 18);
            this.buttonNextProgram.Margin = new System.Windows.Forms.Padding(5);
            this.buttonNextProgram.Name = "buttonNextProgram";
            this.buttonNextProgram.Size = new System.Drawing.Size(158, 442);
            this.buttonNextProgram.TabIndex = 2;
            this.buttonNextProgram.Text = "Наступна >";
            this.buttonNextProgram.UseVisualStyleBackColor = true;
            this.buttonNextProgram.Click += new System.EventHandler(this.button2_Click);
            // 
            // chartTemperatures
            // 
            chartArea13.Name = "ChartArea1";
            this.chartTemperatures.ChartAreas.Add(chartArea13);
            legend13.Name = "Legend1";
            this.chartTemperatures.Legends.Add(legend13);
            this.chartTemperatures.Location = new System.Drawing.Point(348, 123);
            this.chartTemperatures.Margin = new System.Windows.Forms.Padding(5);
            this.chartTemperatures.Name = "chartTemperatures";
            series13.ChartArea = "ChartArea1";
            series13.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series13.Legend = "Legend1";
            series13.Name = "Temperature";
            this.chartTemperatures.Series.Add(series13);
            this.chartTemperatures.Size = new System.Drawing.Size(797, 106);
            this.chartTemperatures.TabIndex = 4;
            this.chartTemperatures.Text = "chart1";
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(413, 905);
            this.buttonStop.Margin = new System.Windows.Forms.Padding(5);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(173, 47);
            this.buttonStop.TabIndex = 5;
            this.buttonStop.Text = "СТОП";
            this.buttonStop.UseVisualStyleBackColor = true;
            // 
            // buttonContinue
            // 
            this.buttonContinue.Location = new System.Drawing.Point(230, 905);
            this.buttonContinue.Margin = new System.Windows.Forms.Padding(5);
            this.buttonContinue.Name = "buttonContinue";
            this.buttonContinue.Size = new System.Drawing.Size(173, 47);
            this.buttonContinue.TabIndex = 6;
            this.buttonContinue.Text = "ПРОДОВЖИТИ";
            this.buttonContinue.UseVisualStyleBackColor = true;
            // 
            // buttonPause
            // 
            this.buttonPause.Location = new System.Drawing.Point(47, 905);
            this.buttonPause.Margin = new System.Windows.Forms.Padding(5);
            this.buttonPause.Name = "buttonPause";
            this.buttonPause.Size = new System.Drawing.Size(173, 47);
            this.buttonPause.TabIndex = 7;
            this.buttonPause.Text = "ПАУЗА";
            this.buttonPause.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 498);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Прогрес:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(485, 498);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "12";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(526, 498);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "хвилин до закінчення";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(183, 148);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Температура (С):";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(188, 172);
            this.textBox1.Margin = new System.Windows.Forms.Padding(5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(136, 26);
            this.textBox1.TabIndex = 12;
            this.textBox1.Text = "120";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(188, 275);
            this.textBox2.Margin = new System.Windows.Forms.Padding(5);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(136, 26);
            this.textBox2.TabIndex = 15;
            this.textBox2.Text = "90";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(188, 251);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Тиск Води (%)";
            // 
            // chartWaterPressures
            // 
            chartArea14.Name = "ChartArea1";
            this.chartWaterPressures.ChartAreas.Add(chartArea14);
            legend14.Name = "Legend1";
            this.chartWaterPressures.Legends.Add(legend14);
            this.chartWaterPressures.Location = new System.Drawing.Point(348, 238);
            this.chartWaterPressures.Margin = new System.Windows.Forms.Padding(5);
            this.chartWaterPressures.Name = "chartWaterPressures";
            series14.ChartArea = "ChartArea1";
            series14.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series14.Legend = "Legend1";
            series14.Name = "Water Pressure";
            this.chartWaterPressures.Series.Add(series14);
            this.chartWaterPressures.Size = new System.Drawing.Size(797, 106);
            this.chartWaterPressures.TabIndex = 13;
            this.chartWaterPressures.Text = "chart2";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(188, 389);
            this.textBox3.Margin = new System.Windows.Forms.Padding(5);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(136, 26);
            this.textBox3.TabIndex = 18;
            this.textBox3.Text = "120";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(188, 365);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "Тиск Пари (%)";
            // 
            // chartVaperPressures
            // 
            chartArea15.Name = "ChartArea1";
            this.chartVaperPressures.ChartAreas.Add(chartArea15);
            legend15.Name = "Legend1";
            this.chartVaperPressures.Legends.Add(legend15);
            this.chartVaperPressures.Location = new System.Drawing.Point(348, 354);
            this.chartVaperPressures.Margin = new System.Windows.Forms.Padding(5);
            this.chartVaperPressures.Name = "chartVaperPressures";
            series15.ChartArea = "ChartArea1";
            series15.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series15.Legend = "Legend1";
            series15.Name = "Vaper Pressure";
            this.chartVaperPressures.Series.Add(series15);
            this.chartVaperPressures.Size = new System.Drawing.Size(797, 106);
            this.chartVaperPressures.TabIndex = 16;
            this.chartVaperPressures.Text = "chart3";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(984, 881);
            this.button7.Margin = new System.Windows.Forms.Padding(5);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(79, 35);
            this.button7.TabIndex = 19;
            this.button7.Text = "ВКЛ";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(984, 917);
            this.button8.Margin = new System.Windows.Forms.Padding(5);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(79, 35);
            this.button8.TabIndex = 20;
            this.button8.Text = "ВИКЛ";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(42, 537);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(163, 20);
            this.label7.TabIndex = 21;
            this.label7.Text = "Статус з\'єднання:";
            // 
            // labelConnectionStatus
            // 
            this.labelConnectionStatus.AutoSize = true;
            this.labelConnectionStatus.Location = new System.Drawing.Point(280, 535);
            this.labelConnectionStatus.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelConnectionStatus.Name = "labelConnectionStatus";
            this.labelConnectionStatus.Size = new System.Drawing.Size(57, 20);
            this.labelConnectionStatus.TabIndex = 22;
            this.labelConnectionStatus.Text = "label8";
            // 
            // labelLastCommandStatus
            // 
            this.labelLastCommandStatus.AutoSize = true;
            this.labelLastCommandStatus.Location = new System.Drawing.Point(280, 571);
            this.labelLastCommandStatus.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelLastCommandStatus.Name = "labelLastCommandStatus";
            this.labelLastCommandStatus.Size = new System.Drawing.Size(57, 20);
            this.labelLastCommandStatus.TabIndex = 23;
            this.labelLastCommandStatus.Text = "label9";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(42, 571);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(230, 20);
            this.label10.TabIndex = 24;
            this.label10.Text = "Статус поточної команди:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(242, 18);
            this.label11.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(179, 37);
            this.label11.TabIndex = 25;
            this.label11.Text = "Програма:";
            // 
            // labelProgramName
            // 
            this.labelProgramName.AutoSize = true;
            this.labelProgramName.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProgramName.Location = new System.Drawing.Point(550, 18);
            this.labelProgramName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelProgramName.Name = "labelProgramName";
            this.labelProgramName.Size = new System.Drawing.Size(328, 37);
            this.labelProgramName.TabIndex = 26;
            this.labelProgramName.Text = "Хліб \"Бородинський\"";
            // 
            // buttonPrevioussProgram
            // 
            this.buttonPrevioussProgram.Location = new System.Drawing.Point(20, 18);
            this.buttonPrevioussProgram.Margin = new System.Windows.Forms.Padding(5);
            this.buttonPrevioussProgram.Name = "buttonPrevioussProgram";
            this.buttonPrevioussProgram.Size = new System.Drawing.Size(158, 442);
            this.buttonPrevioussProgram.TabIndex = 27;
            this.buttonPrevioussProgram.Text = "< Попередня";
            this.buttonPrevioussProgram.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(852, 905);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 20);
            this.label8.TabIndex = 28;
            this.label8.Text = "Тест (13й пін):";
            // 
            // breadsListBox
            // 
            this.breadsListBox.FormattingEnabled = true;
            this.breadsListBox.ItemHeight = 20;
            this.breadsListBox.Location = new System.Drawing.Point(20, 603);
            this.breadsListBox.Name = "breadsListBox";
            this.breadsListBox.Size = new System.Drawing.Size(604, 184);
            this.breadsListBox.TabIndex = 29;
            // 
            // showBreadsButton
            // 
            this.showBreadsButton.Location = new System.Drawing.Point(640, 748);
            this.showBreadsButton.Name = "showBreadsButton";
            this.showBreadsButton.Size = new System.Drawing.Size(185, 39);
            this.showBreadsButton.TabIndex = 30;
            this.showBreadsButton.Text = "Оновити Список";
            this.showBreadsButton.UseVisualStyleBackColor = true;
            this.showBreadsButton.Click += new System.EventHandler(this.showBreadsButton_Click);
            // 
            // newBreadNameTextBox
            // 
            this.newBreadNameTextBox.Location = new System.Drawing.Point(78, 32);
            this.newBreadNameTextBox.Name = "newBreadNameTextBox";
            this.newBreadNameTextBox.Size = new System.Drawing.Size(345, 26);
            this.newBreadNameTextBox.TabIndex = 31;
            // 
            // createBread
            // 
            this.createBread.Location = new System.Drawing.Point(308, 64);
            this.createBread.Name = "createBread";
            this.createBread.Size = new System.Drawing.Size(115, 39);
            this.createBread.TabIndex = 32;
            this.createBread.Text = "Створити";
            this.createBread.UseVisualStyleBackColor = true;
            this.createBread.Click += new System.EventHandler(this.createBread_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 20);
            this.label9.TabIndex = 33;
            this.label9.Text = "Назва:";
            // 
            // createBreadGroupBox
            // 
            this.createBreadGroupBox.Controls.Add(this.createBread);
            this.createBreadGroupBox.Controls.Add(this.label9);
            this.createBreadGroupBox.Controls.Add(this.newBreadNameTextBox);
            this.createBreadGroupBox.Location = new System.Drawing.Point(640, 603);
            this.createBreadGroupBox.Name = "createBreadGroupBox";
            this.createBreadGroupBox.Size = new System.Drawing.Size(440, 113);
            this.createBreadGroupBox.TabIndex = 34;
            this.createBreadGroupBox.TabStop = false;
            this.createBreadGroupBox.Text = "Створити Програму";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 971);
            this.Controls.Add(this.createBreadGroupBox);
            this.Controls.Add(this.showBreadsButton);
            this.Controls.Add(this.breadsListBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.buttonPrevioussProgram);
            this.Controls.Add(this.labelProgramName);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.labelLastCommandStatus);
            this.Controls.Add(this.labelConnectionStatus);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.chartVaperPressures);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.chartWaterPressures);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonPause);
            this.Controls.Add(this.buttonContinue);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.chartTemperatures);
            this.Controls.Add(this.buttonNextProgram);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.buttonStart);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Dashboard";
            this.Text = "Терморегулятор Пічки";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartTemperatures)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartWaterPressures)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartVaperPressures)).EndInit();
            this.createBreadGroupBox.ResumeLayout(false);
            this.createBreadGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button buttonNextProgram;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button buttonContinue;
        private System.Windows.Forms.Button buttonPause;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartWaterPressures;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartVaperPressures;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelConnectionStatus;
        private System.Windows.Forms.Label labelLastCommandStatus;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTemperatures;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label labelProgramName;
        private System.Windows.Forms.Button buttonPrevioussProgram;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox breadsListBox;
        private System.Windows.Forms.Button showBreadsButton;
        private System.Windows.Forms.TextBox newBreadNameTextBox;
        private System.Windows.Forms.Button createBread;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox createBreadGroupBox;
    }
}

