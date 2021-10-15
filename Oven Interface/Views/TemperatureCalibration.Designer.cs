
namespace Oven_Interface.Views
{
    partial class TemperatureCalibration
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.temperatureLabel = new System.Windows.Forms.Label();
            this.sensorValueLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.coefficientB = new System.Windows.Forms.NumericUpDown();
            this.coefficientA = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.saveCoefficientsButton = new System.Windows.Forms.Button();
            this.button55 = new System.Windows.Forms.Button();
            this.coefficientC = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.coefficientB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coefficientA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coefficientC)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.temperatureLabel);
            this.groupBox3.Controls.Add(this.sensorValueLabel);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(268, 102);
            this.groupBox3.TabIndex = 46;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Температура";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(180, 13);
            this.label6.TabIndex = 45;
            this.label6.Text = "Показник Електронного Датчика:";
            // 
            // temperatureLabel
            // 
            this.temperatureLabel.AutoSize = true;
            this.temperatureLabel.Location = new System.Drawing.Point(203, 55);
            this.temperatureLabel.Name = "temperatureLabel";
            this.temperatureLabel.Size = new System.Drawing.Size(29, 13);
            this.temperatureLabel.TabIndex = 43;
            this.temperatureLabel.Text = "25 C";
            // 
            // sensorValueLabel
            // 
            this.sensorValueLabel.AutoSize = true;
            this.sensorValueLabel.Location = new System.Drawing.Point(203, 29);
            this.sensorValueLabel.Name = "sensorValueLabel";
            this.sensorValueLabel.Size = new System.Drawing.Size(25, 13);
            this.sensorValueLabel.TabIndex = 46;
            this.sensorValueLabel.Text = "420";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 13);
            this.label5.TabIndex = 44;
            this.label5.Text = "Поточна Температура:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 24);
            this.label1.TabIndex = 47;
            this.label1.Text = "Y = aX^2 + bX + C";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 13);
            this.label2.TabIndex = 48;
            this.label2.Text = "y - температура (в градусах)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 13);
            this.label3.TabIndex = 49;
            this.label3.Text = "x - одиниці які видав термодатчик";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 13);
            this.label4.TabIndex = 50;
            this.label4.Text = "a - квадратичний коефіцієнт";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 121);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(268, 170);
            this.groupBox1.TabIndex = 51;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Формула";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.coefficientC);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.saveCoefficientsButton);
            this.groupBox2.Controls.Add(this.coefficientB);
            this.groupBox2.Controls.Add(this.coefficientA);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(286, 121);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(196, 170);
            this.groupBox2.TabIndex = 52;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ВВЕДІТЬ НОВІ КОЕФІЦІЄНТИ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "a = ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "b = ";
            // 
            // coefficientB
            // 
            this.coefficientB.DecimalPlaces = 6;
            this.coefficientB.Location = new System.Drawing.Point(38, 61);
            this.coefficientB.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.coefficientB.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.coefficientB.Name = "coefficientB";
            this.coefficientB.Size = new System.Drawing.Size(152, 20);
            this.coefficientB.TabIndex = 39;
            // 
            // coefficientA
            // 
            this.coefficientA.DecimalPlaces = 6;
            this.coefficientA.Location = new System.Drawing.Point(38, 34);
            this.coefficientA.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.coefficientA.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.coefficientA.Name = "coefficientA";
            this.coefficientA.Size = new System.Drawing.Size(152, 20);
            this.coefficientA.TabIndex = 38;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 123);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 13);
            this.label9.TabIndex = 51;
            this.label9.Text = "b - лінійний коефіцієнт";
            // 
            // saveCoefficientsButton
            // 
            this.saveCoefficientsButton.Location = new System.Drawing.Point(5, 130);
            this.saveCoefficientsButton.Margin = new System.Windows.Forms.Padding(2);
            this.saveCoefficientsButton.Name = "saveCoefficientsButton";
            this.saveCoefficientsButton.Size = new System.Drawing.Size(186, 29);
            this.saveCoefficientsButton.TabIndex = 40;
            this.saveCoefficientsButton.Text = "Зберегти";
            this.saveCoefficientsButton.UseVisualStyleBackColor = true;
            this.saveCoefficientsButton.Click += new System.EventHandler(this.saveCoefficientsButton_Click);
            // 
            // button55
            // 
            this.button55.Location = new System.Drawing.Point(358, 297);
            this.button55.Name = "button55";
            this.button55.Size = new System.Drawing.Size(124, 40);
            this.button55.TabIndex = 53;
            this.button55.Text = "Закрити";
            this.button55.UseVisualStyleBackColor = true;
            this.button55.Click += new System.EventHandler(this.button55_Click);
            // 
            // coefficientC
            // 
            this.coefficientC.DecimalPlaces = 6;
            this.coefficientC.Location = new System.Drawing.Point(38, 90);
            this.coefficientC.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.coefficientC.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.coefficientC.Name = "coefficientC";
            this.coefficientC.Size = new System.Drawing.Size(152, 20);
            this.coefficientC.TabIndex = 42;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 92);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(25, 13);
            this.label10.TabIndex = 41;
            this.label10.Text = "c = ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(11, 146);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(142, 13);
            this.label11.TabIndex = 52;
            this.label11.Text = "c - константний коефіцієнт";
            // 
            // TemperatureCalibration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 346);
            this.Controls.Add(this.button55);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Name = "TemperatureCalibration";
            this.Text = "Калібрування Термодатчика";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.coefficientB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coefficientA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coefficientC)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label temperatureLabel;
        private System.Windows.Forms.Label sensorValueLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown coefficientB;
        private System.Windows.Forms.NumericUpDown coefficientA;
        private System.Windows.Forms.Button saveCoefficientsButton;
        private System.Windows.Forms.Button button55;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown coefficientC;
        private System.Windows.Forms.Label label10;
    }
}