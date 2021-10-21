
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
            this.thermalRelayPin = new System.Windows.Forms.NumericUpDown();
            this.thermalSensorChannel = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thermalRelayPin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thermalSensorChannel)).BeginInit();
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
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Controls.Add(this.saveCoefficientsButton);
            this.groupBox2.Controls.Add(this.thermalRelayPin);
            this.groupBox2.Controls.Add(this.thermalSensorChannel);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
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
            // thermalRelayPin
            // 
            resources.ApplyResources(this.thermalRelayPin, "thermalRelayPin");
            this.thermalRelayPin.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.thermalRelayPin.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.thermalRelayPin.Name = "thermalRelayPin";
            // 
            // thermalSensorChannel
            // 
            resources.ApplyResources(this.thermalSensorChannel, "thermalSensorChannel");
            this.thermalSensorChannel.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.thermalSensorChannel.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
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
            // PinSettings
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button55);
            this.Controls.Add(this.groupBox2);
            this.Name = "PinSettings";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thermalRelayPin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thermalSensorChannel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button55;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button saveCoefficientsButton;
        private System.Windows.Forms.NumericUpDown thermalRelayPin;
        private System.Windows.Forms.NumericUpDown thermalSensorChannel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
    }
}