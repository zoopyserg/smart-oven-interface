
namespace Oven_Interface.Views
{
    partial class ValveOpenCalibration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ValveOpenCalibration));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.timeToFullyOpenVentilation = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.saveCoefficientsButton = new System.Windows.Forms.Button();
            this.button55 = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeToFullyOpenVentilation)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.timeToFullyOpenVentilation);
            this.groupBox2.Controls.Add(this.label7);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // timeToFullyOpenVentilation
            // 
            resources.ApplyResources(this.timeToFullyOpenVentilation, "timeToFullyOpenVentilation");
            this.timeToFullyOpenVentilation.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.timeToFullyOpenVentilation.Name = "timeToFullyOpenVentilation";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
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
            // ValveOpenCalibration
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.saveCoefficientsButton);
            this.Controls.Add(this.button55);
            this.Name = "ValveOpenCalibration";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeToFullyOpenVentilation)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown timeToFullyOpenVentilation;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button saveCoefficientsButton;
        private System.Windows.Forms.Button button55;
    }
}