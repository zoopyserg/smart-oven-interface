
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
            this.button55.Location = new System.Drawing.Point(152, 147);
            this.button55.Name = "button55";
            this.button55.Size = new System.Drawing.Size(124, 40);
            this.button55.TabIndex = 57;
            this.button55.Text = "Закрити";
            this.button55.UseVisualStyleBackColor = true;
            this.button55.Click += new System.EventHandler(this.button55_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.saveCoefficientsButton);
            this.groupBox2.Controls.Add(this.thermalRelayPin);
            this.groupBox2.Controls.Add(this.thermalSensorChannel);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(263, 129);
            this.groupBox2.TabIndex = 56;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ЯКИЙ ПІН ЗА ЩО ВІДПОВІДАЄ";
            // 
            // saveCoefficientsButton
            // 
            this.saveCoefficientsButton.Location = new System.Drawing.Point(150, 94);
            this.saveCoefficientsButton.Margin = new System.Windows.Forms.Padding(2);
            this.saveCoefficientsButton.Name = "saveCoefficientsButton";
            this.saveCoefficientsButton.Size = new System.Drawing.Size(108, 29);
            this.saveCoefficientsButton.TabIndex = 40;
            this.saveCoefficientsButton.Text = "Зберегти";
            this.saveCoefficientsButton.UseVisualStyleBackColor = true;
            this.saveCoefficientsButton.Click += new System.EventHandler(this.saveCoefficientsButton_Click);
            // 
            // thermalRelayPin
            // 
            this.thermalRelayPin.Location = new System.Drawing.Point(201, 58);
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
            this.thermalRelayPin.Size = new System.Drawing.Size(46, 20);
            this.thermalRelayPin.TabIndex = 39;
            // 
            // thermalSensorChannel
            // 
            this.thermalSensorChannel.Location = new System.Drawing.Point(201, 31);
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
            this.thermalSensorChannel.Size = new System.Drawing.Size(46, 20);
            this.thermalSensorChannel.TabIndex = 38;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(176, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Реле Нагрівача: Цифровий Пін №";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(188, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Термодатчик: Аналоговий Канал №";
            // 
            // PinSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 190);
            this.Controls.Add(this.button55);
            this.Controls.Add(this.groupBox2);
            this.Name = "PinSettings";
            this.Text = "Налаштування який пін за що відповідає";
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