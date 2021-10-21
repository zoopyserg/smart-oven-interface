
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TemperatureCalibration));
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
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.coefficientC = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.saveCoefficientsButton = new System.Windows.Forms.Button();
            this.coefficientB = new System.Windows.Forms.NumericUpDown();
            this.coefficientA = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button55 = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.coefficientC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coefficientB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coefficientA)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.temperatureLabel);
            this.groupBox3.Controls.Add(this.sensorValueLabel);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // temperatureLabel
            // 
            resources.ApplyResources(this.temperatureLabel, "temperatureLabel");
            this.temperatureLabel.Name = "temperatureLabel";
            // 
            // sensorValueLabel
            // 
            resources.ApplyResources(this.sensorValueLabel, "sensorValueLabel");
            this.sensorValueLabel.Name = "sensorValueLabel";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // groupBox2
            // 
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Controls.Add(this.coefficientC);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.saveCoefficientsButton);
            this.groupBox2.Controls.Add(this.coefficientB);
            this.groupBox2.Controls.Add(this.coefficientA);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // coefficientC
            // 
            resources.ApplyResources(this.coefficientC, "coefficientC");
            this.coefficientC.DecimalPlaces = 6;
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
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // saveCoefficientsButton
            // 
            resources.ApplyResources(this.saveCoefficientsButton, "saveCoefficientsButton");
            this.saveCoefficientsButton.Name = "saveCoefficientsButton";
            this.saveCoefficientsButton.UseVisualStyleBackColor = true;
            this.saveCoefficientsButton.Click += new System.EventHandler(this.saveCoefficientsButton_Click);
            // 
            // coefficientB
            // 
            resources.ApplyResources(this.coefficientB, "coefficientB");
            this.coefficientB.DecimalPlaces = 6;
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
            // 
            // coefficientA
            // 
            resources.ApplyResources(this.coefficientA, "coefficientA");
            this.coefficientA.DecimalPlaces = 6;
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
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // button55
            // 
            resources.ApplyResources(this.button55, "button55");
            this.button55.Name = "button55";
            this.button55.UseVisualStyleBackColor = true;
            this.button55.Click += new System.EventHandler(this.button55_Click);
            // 
            // TemperatureCalibration
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button55);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Name = "TemperatureCalibration";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.coefficientC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coefficientB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coefficientA)).EndInit();
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