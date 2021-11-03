
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
            this.allowChangeTempAfter = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.turnOffRelaysAfter = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.saveCoefficientsButton = new System.Windows.Forms.Button();
            this.button55 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.allowChangeTempAfter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.turnOffRelaysAfter)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // allowChangeTempAfter
            // 
            this.allowChangeTempAfter.Location = new System.Drawing.Point(560, 62);
            this.allowChangeTempAfter.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.allowChangeTempAfter.Name = "allowChangeTempAfter";
            this.allowChangeTempAfter.Size = new System.Drawing.Size(88, 20);
            this.allowChangeTempAfter.TabIndex = 44;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(7, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(547, 13);
            this.label2.TabIndex = 43;
            this.label2.Text = "Дозволити знов змінити температуру через Х мілісекунд після попередньої зміни інт" +
    "енсивності нагрівачів";
            // 
            // turnOffRelaysAfter
            // 
            this.turnOffRelaysAfter.Location = new System.Drawing.Point(560, 31);
            this.turnOffRelaysAfter.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.turnOffRelaysAfter.Name = "turnOffRelaysAfter";
            this.turnOffRelaysAfter.Size = new System.Drawing.Size(88, 20);
            this.turnOffRelaysAfter.TabIndex = 38;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(7, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(359, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Виключити терморегулюючі реле через Х мілісекунд після включення";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.allowChangeTempAfter);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.turnOffRelaysAfter);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(666, 100);
            this.groupBox2.TabIndex = 59;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Налаштування Хістерезису";
            // 
            // saveCoefficientsButton
            // 
            this.saveCoefficientsButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.saveCoefficientsButton.Location = new System.Drawing.Point(423, 118);
            this.saveCoefficientsButton.Margin = new System.Windows.Forms.Padding(2);
            this.saveCoefficientsButton.Name = "saveCoefficientsButton";
            this.saveCoefficientsButton.Size = new System.Drawing.Size(116, 41);
            this.saveCoefficientsButton.TabIndex = 58;
            this.saveCoefficientsButton.Text = "Зберегти";
            this.saveCoefficientsButton.UseVisualStyleBackColor = true;
            this.saveCoefficientsButton.Click += new System.EventHandler(this.saveCoefficientsButton_Click);
            // 
            // button55
            // 
            this.button55.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button55.Location = new System.Drawing.Point(554, 118);
            this.button55.Name = "button55";
            this.button55.Size = new System.Drawing.Size(124, 40);
            this.button55.TabIndex = 60;
            this.button55.Text = "Закрити";
            this.button55.UseVisualStyleBackColor = true;
            this.button55.Click += new System.EventHandler(this.button55_Click);
            // 
            // Histeresis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 167);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.saveCoefficientsButton);
            this.Controls.Add(this.button55);
            this.Name = "Histeresis";
            this.Text = "Histeresis";
            ((System.ComponentModel.ISupportInitialize)(this.allowChangeTempAfter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.turnOffRelaysAfter)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
    }
}