
namespace Oven_Interface.Views
{
    partial class Histeresis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Histeresis));
            this.allowChangeTempAfter = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.turnOffRelaysAfter = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.howOftenToCheckSensors = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.saveCoefficientsButton = new System.Windows.Forms.Button();
            this.button55 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.allowChangeTempAfter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.turnOffRelaysAfter)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.howOftenToCheckSensors)).BeginInit();
            this.SuspendLayout();
            // 
            // allowChangeTempAfter
            // 
            resources.ApplyResources(this.allowChangeTempAfter, "allowChangeTempAfter");
            this.allowChangeTempAfter.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.allowChangeTempAfter.Name = "allowChangeTempAfter";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // turnOffRelaysAfter
            // 
            resources.ApplyResources(this.turnOffRelaysAfter, "turnOffRelaysAfter");
            this.turnOffRelaysAfter.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.turnOffRelaysAfter.Name = "turnOffRelaysAfter";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // groupBox2
            // 
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Controls.Add(this.howOftenToCheckSensors);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.allowChangeTempAfter);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.turnOffRelaysAfter);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // howOftenToCheckSensors
            // 
            resources.ApplyResources(this.howOftenToCheckSensors, "howOftenToCheckSensors");
            this.howOftenToCheckSensors.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.howOftenToCheckSensors.Name = "howOftenToCheckSensors";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // saveCoefficientsButton
            // 
            resources.ApplyResources(this.saveCoefficientsButton, "saveCoefficientsButton");
            this.saveCoefficientsButton.Name = "saveCoefficientsButton";
            this.saveCoefficientsButton.UseVisualStyleBackColor = true;
            this.saveCoefficientsButton.Click += new System.EventHandler(this.saveCoefficientsButton_Click);
            // 
            // button55
            // 
            resources.ApplyResources(this.button55, "button55");
            this.button55.Name = "button55";
            this.button55.UseVisualStyleBackColor = true;
            this.button55.Click += new System.EventHandler(this.button55_Click);
            // 
            // Histeresis
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.saveCoefficientsButton);
            this.Controls.Add(this.button55);
            this.Name = "Histeresis";
            ((System.ComponentModel.ISupportInitialize)(this.allowChangeTempAfter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.turnOffRelaysAfter)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.howOftenToCheckSensors)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.NumericUpDown allowChangeTempAfter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown turnOffRelaysAfter;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button saveCoefficientsButton;
        private System.Windows.Forms.Button button55;
        private System.Windows.Forms.NumericUpDown howOftenToCheckSensors;
        private System.Windows.Forms.Label label1;
    }
}