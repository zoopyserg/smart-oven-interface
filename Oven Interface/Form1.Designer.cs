
namespace Oven_Interface
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            ((System.ComponentModel.ISupportInitialize)(this.chartTemperatures)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartWaterPressures)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartVaperPressures)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(607, 550);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(187, 69);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "СТАРТ";
            this.buttonStart.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(79, 314);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(516, 23);
            this.progressBar1.TabIndex = 1;
            // 
            // buttonNextProgram
            // 
            this.buttonNextProgram.Location = new System.Drawing.Point(693, 12);
            this.buttonNextProgram.Name = "buttonNextProgram";
            this.buttonNextProgram.Size = new System.Drawing.Size(95, 287);
            this.buttonNextProgram.TabIndex = 2;
            this.buttonNextProgram.Text = "Наступна >";
            this.buttonNextProgram.UseVisualStyleBackColor = true;
            this.buttonNextProgram.Click += new System.EventHandler(this.button2_Click);
            // 
            // chartTemperatures
            // 
            chartArea1.Name = "ChartArea1";
            this.chartTemperatures.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartTemperatures.Legends.Add(legend1);
            this.chartTemperatures.Location = new System.Drawing.Point(209, 80);
            this.chartTemperatures.Name = "chartTemperatures";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Temperature";
            this.chartTemperatures.Series.Add(series1);
            this.chartTemperatures.Size = new System.Drawing.Size(478, 69);
            this.chartTemperatures.TabIndex = 4;
            this.chartTemperatures.Text = "chart1";
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(414, 550);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(187, 69);
            this.buttonStop.TabIndex = 5;
            this.buttonStop.Text = "СТОП";
            this.buttonStop.UseVisualStyleBackColor = true;
            // 
            // buttonContinue
            // 
            this.buttonContinue.Location = new System.Drawing.Point(221, 550);
            this.buttonContinue.Name = "buttonContinue";
            this.buttonContinue.Size = new System.Drawing.Size(187, 69);
            this.buttonContinue.TabIndex = 6;
            this.buttonContinue.Text = "ПРОДОВЖИТИ";
            this.buttonContinue.UseVisualStyleBackColor = true;
            // 
            // buttonPause
            // 
            this.buttonPause.Location = new System.Drawing.Point(28, 550);
            this.buttonPause.Name = "buttonPause";
            this.buttonPause.Size = new System.Drawing.Size(187, 69);
            this.buttonPause.TabIndex = 7;
            this.buttonPause.Text = "ПАУЗА";
            this.buttonPause.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 324);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Прогрес:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(601, 324);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "12";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(626, 324);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "хвилин до закінчення";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(110, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Температура (С):";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(113, 112);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(83, 20);
            this.textBox1.TabIndex = 12;
            this.textBox1.Text = "120";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(113, 179);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(83, 20);
            this.textBox2.TabIndex = 15;
            this.textBox2.Text = "90";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(113, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Тиск Води (%)";
            // 
            // chartWaterPressures
            // 
            chartArea2.Name = "ChartArea1";
            this.chartWaterPressures.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartWaterPressures.Legends.Add(legend2);
            this.chartWaterPressures.Location = new System.Drawing.Point(209, 155);
            this.chartWaterPressures.Name = "chartWaterPressures";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "Water Pressure";
            this.chartWaterPressures.Series.Add(series2);
            this.chartWaterPressures.Size = new System.Drawing.Size(478, 69);
            this.chartWaterPressures.TabIndex = 13;
            this.chartWaterPressures.Text = "chart2";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(113, 253);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(83, 20);
            this.textBox3.TabIndex = 18;
            this.textBox3.Text = "120";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(113, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Тиск Пари (%)";
            // 
            // chartVaperPressures
            // 
            chartArea3.Name = "ChartArea1";
            this.chartVaperPressures.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartVaperPressures.Legends.Add(legend3);
            this.chartVaperPressures.Location = new System.Drawing.Point(209, 230);
            this.chartVaperPressures.Name = "chartVaperPressures";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Legend = "Legend1";
            series3.Name = "Vaper Pressure";
            this.chartVaperPressures.Series.Add(series3);
            this.chartVaperPressures.Size = new System.Drawing.Size(478, 69);
            this.chartVaperPressures.TabIndex = 16;
            this.chartVaperPressures.Text = "chart3";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(601, 340);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(86, 23);
            this.button7.TabIndex = 19;
            this.button7.Text = "ВКЛ 13й пін";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(693, 340);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(95, 23);
            this.button8.TabIndex = 20;
            this.button8.Text = "ВИКЛ 13й пін";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 349);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Статус контролера:";
            // 
            // labelConnectionStatus
            // 
            this.labelConnectionStatus.AutoSize = true;
            this.labelConnectionStatus.Location = new System.Drawing.Point(168, 348);
            this.labelConnectionStatus.Name = "labelConnectionStatus";
            this.labelConnectionStatus.Size = new System.Drawing.Size(35, 13);
            this.labelConnectionStatus.TabIndex = 22;
            this.labelConnectionStatus.Text = "label8";
            // 
            // labelLastCommandStatus
            // 
            this.labelLastCommandStatus.AutoSize = true;
            this.labelLastCommandStatus.Location = new System.Drawing.Point(168, 371);
            this.labelLastCommandStatus.Name = "labelLastCommandStatus";
            this.labelLastCommandStatus.Size = new System.Drawing.Size(35, 13);
            this.labelLastCommandStatus.TabIndex = 23;
            this.labelLastCommandStatus.Text = "label9";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(25, 371);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(137, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Статус поточної команди:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(145, 12);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(179, 37);
            this.label11.TabIndex = 25;
            this.label11.Text = "Програма:";
            // 
            // labelProgramName
            // 
            this.labelProgramName.AutoSize = true;
            this.labelProgramName.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProgramName.Location = new System.Drawing.Point(330, 12);
            this.labelProgramName.Name = "labelProgramName";
            this.labelProgramName.Size = new System.Drawing.Size(328, 37);
            this.labelProgramName.TabIndex = 26;
            this.labelProgramName.Text = "Хліб \"Бородинський\"";
            // 
            // buttonPrevioussProgram
            // 
            this.buttonPrevioussProgram.Location = new System.Drawing.Point(12, 12);
            this.buttonPrevioussProgram.Name = "buttonPrevioussProgram";
            this.buttonPrevioussProgram.Size = new System.Drawing.Size(95, 287);
            this.buttonPrevioussProgram.TabIndex = 27;
            this.buttonPrevioussProgram.Text = "< Попередня";
            this.buttonPrevioussProgram.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 631);
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
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartTemperatures)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartWaterPressures)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartVaperPressures)).EndInit();
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
    }
}

