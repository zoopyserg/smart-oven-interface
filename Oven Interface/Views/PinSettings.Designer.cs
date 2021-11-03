
namespace Oven_Interface.Views
{
    partial class PinSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PinSettings));
            this.button55 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.saveCoefficientsButton = new System.Windows.Forms.Button();
            this.thermalIncreaseRelayPin = new System.Windows.Forms.NumericUpDown();
            this.thermalSensorChannel = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lightsRelayPin = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.powerplantRelayPin = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.thermalDecreaseRelayPin = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.ventilationOpenRelayPin = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.ventilationCloseRelayPin = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.waterValveOpenRelayPin = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.waterCounterPin = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thermalIncreaseRelayPin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thermalSensorChannel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lightsRelayPin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.powerplantRelayPin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thermalDecreaseRelayPin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventilationOpenRelayPin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventilationCloseRelayPin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.waterValveOpenRelayPin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.waterCounterPin)).BeginInit();
            this.SuspendLayout();
            // 
            // button55
            // 
            resources.ApplyResources(this.button55, "button55");
            this.button55.Name = "button55";
            this.button55.UseVisualStyleBackColor = true;
            this.button55.Click += new System.EventHandler(this.button55_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.waterCounterPin);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.waterValveOpenRelayPin);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.ventilationCloseRelayPin);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.ventilationOpenRelayPin);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.thermalDecreaseRelayPin);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.powerplantRelayPin);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.lightsRelayPin);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.thermalIncreaseRelayPin);
            this.groupBox2.Controls.Add(this.thermalSensorChannel);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // saveCoefficientsButton
            // 
            resources.ApplyResources(this.saveCoefficientsButton, "saveCoefficientsButton");
            this.saveCoefficientsButton.Name = "saveCoefficientsButton";
            this.saveCoefficientsButton.UseVisualStyleBackColor = true;
            this.saveCoefficientsButton.Click += new System.EventHandler(this.saveCoefficientsButton_Click);
            // 
            // thermalIncreaseRelayPin
            // 
            resources.ApplyResources(this.thermalIncreaseRelayPin, "thermalIncreaseRelayPin");
            this.thermalIncreaseRelayPin.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.thermalIncreaseRelayPin.Name = "thermalIncreaseRelayPin";
            // 
            // thermalSensorChannel
            // 
            resources.ApplyResources(this.thermalSensorChannel, "thermalSensorChannel");
            this.thermalSensorChannel.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.thermalSensorChannel.Name = "thermalSensorChannel";
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
            // lightsRelayPin
            // 
            resources.ApplyResources(this.lightsRelayPin, "lightsRelayPin");
            this.lightsRelayPin.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.lightsRelayPin.Name = "lightsRelayPin";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // powerplantRelayPin
            // 
            resources.ApplyResources(this.powerplantRelayPin, "powerplantRelayPin");
            this.powerplantRelayPin.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.powerplantRelayPin.Name = "powerplantRelayPin";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // thermalDecreaseRelayPin
            // 
            resources.ApplyResources(this.thermalDecreaseRelayPin, "thermalDecreaseRelayPin");
            this.thermalDecreaseRelayPin.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.thermalDecreaseRelayPin.Name = "thermalDecreaseRelayPin";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // ventilationOpenRelayPin
            // 
            resources.ApplyResources(this.ventilationOpenRelayPin, "ventilationOpenRelayPin");
            this.ventilationOpenRelayPin.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.ventilationOpenRelayPin.Name = "ventilationOpenRelayPin";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // ventilationCloseRelayPin
            // 
            resources.ApplyResources(this.ventilationCloseRelayPin, "ventilationCloseRelayPin");
            this.ventilationCloseRelayPin.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.ventilationCloseRelayPin.Name = "ventilationCloseRelayPin";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // waterValveOpenRelayPin
            // 
            resources.ApplyResources(this.waterValveOpenRelayPin, "waterValveOpenRelayPin");
            this.waterValveOpenRelayPin.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.waterValveOpenRelayPin.Name = "waterValveOpenRelayPin";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // waterCounterPin
            // 
            resources.ApplyResources(this.waterCounterPin, "waterCounterPin");
            this.waterCounterPin.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.waterCounterPin.Name = "waterCounterPin";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // PinSettings
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button55);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.saveCoefficientsButton);
            this.Name = "PinSettings";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thermalIncreaseRelayPin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thermalSensorChannel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lightsRelayPin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.powerplantRelayPin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thermalDecreaseRelayPin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventilationOpenRelayPin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventilationCloseRelayPin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.waterValveOpenRelayPin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.waterCounterPin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button55;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button saveCoefficientsButton;
        private System.Windows.Forms.NumericUpDown thermalIncreaseRelayPin;
        private System.Windows.Forms.NumericUpDown thermalSensorChannel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown powerplantRelayPin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown lightsRelayPin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown thermalDecreaseRelayPin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown ventilationCloseRelayPin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown ventilationOpenRelayPin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown waterValveOpenRelayPin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown waterCounterPin;
        private System.Windows.Forms.Label label9;
    }
}