namespace InfiniTimer
{
    partial class InfiniTimer
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
            this.components = new System.ComponentModel.Container();
            this.attributesList = new System.Windows.Forms.ListBox();
            this.optionsList = new System.Windows.Forms.ListBox();
            this.addAttribute = new System.Windows.Forms.Button();
            this.removeAttribute = new System.Windows.Forms.Button();
            this.addOption = new System.Windows.Forms.Button();
            this.removeOption = new System.Windows.Forms.Button();
            this.timerStop = new System.Windows.Forms.Button();
            this.timerStart = new System.Windows.Forms.Button();
            this.timerUnit = new System.Windows.Forms.ComboBox();
            this.timerMin = new System.Windows.Forms.NumericUpDown();
            this.timerMax = new System.Windows.Forms.NumericUpDown();
            this.attributeName = new System.Windows.Forms.TextBox();
            this.optionName = new System.Windows.Forms.TextBox();
            this.attributeMax = new System.Windows.Forms.NumericUpDown();
            this.attributeMin = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.timerLabel = new System.Windows.Forms.Label();
            this.clockTimer = new System.Windows.Forms.Timer(this.components);
            this.randomTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.timerMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timerMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attributeMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attributeMin)).BeginInit();
            this.SuspendLayout();
            // 
            // attributesList
            // 
            this.attributesList.FormattingEnabled = true;
            this.attributesList.Location = new System.Drawing.Point(141, 103);
            this.attributesList.Name = "attributesList";
            this.attributesList.Size = new System.Drawing.Size(120, 121);
            this.attributesList.TabIndex = 8;
            // 
            // optionsList
            // 
            this.optionsList.FormattingEnabled = true;
            this.optionsList.Location = new System.Drawing.Point(267, 51);
            this.optionsList.Name = "optionsList";
            this.optionsList.Size = new System.Drawing.Size(120, 173);
            this.optionsList.TabIndex = 12;
            // 
            // addAttribute
            // 
            this.addAttribute.Location = new System.Drawing.Point(204, 230);
            this.addAttribute.Name = "addAttribute";
            this.addAttribute.Size = new System.Drawing.Size(57, 23);
            this.addAttribute.TabIndex = 9;
            this.addAttribute.Text = "Add";
            this.addAttribute.UseVisualStyleBackColor = true;
            this.addAttribute.Click += new System.EventHandler(this.AddAttribute_Click);
            // 
            // removeAttribute
            // 
            this.removeAttribute.Location = new System.Drawing.Point(141, 230);
            this.removeAttribute.Name = "removeAttribute";
            this.removeAttribute.Size = new System.Drawing.Size(57, 23);
            this.removeAttribute.TabIndex = 10;
            this.removeAttribute.Text = "Remove";
            this.removeAttribute.UseVisualStyleBackColor = true;
            this.removeAttribute.Click += new System.EventHandler(this.RemoveAttribute_Click);
            // 
            // addOption
            // 
            this.addOption.Location = new System.Drawing.Point(330, 230);
            this.addOption.Name = "addOption";
            this.addOption.Size = new System.Drawing.Size(57, 23);
            this.addOption.TabIndex = 13;
            this.addOption.Text = "Add";
            this.addOption.UseVisualStyleBackColor = true;
            this.addOption.Click += new System.EventHandler(this.AddOption_Click);
            // 
            // removeOption
            // 
            this.removeOption.Location = new System.Drawing.Point(267, 230);
            this.removeOption.Name = "removeOption";
            this.removeOption.Size = new System.Drawing.Size(57, 23);
            this.removeOption.TabIndex = 14;
            this.removeOption.Text = "Remove";
            this.removeOption.UseVisualStyleBackColor = true;
            this.removeOption.Click += new System.EventHandler(this.RemoveOption_Click);
            // 
            // timerStop
            // 
            this.timerStop.Location = new System.Drawing.Point(12, 230);
            this.timerStop.Name = "timerStop";
            this.timerStop.Size = new System.Drawing.Size(42, 23);
            this.timerStop.TabIndex = 4;
            this.timerStop.Text = "Stop";
            this.timerStop.UseVisualStyleBackColor = true;
            this.timerStop.Click += new System.EventHandler(this.StopTimer);
            // 
            // timerStart
            // 
            this.timerStart.Location = new System.Drawing.Point(60, 230);
            this.timerStart.Name = "timerStart";
            this.timerStart.Size = new System.Drawing.Size(42, 23);
            this.timerStart.TabIndex = 3;
            this.timerStart.Text = "Start";
            this.timerStart.UseVisualStyleBackColor = true;
            this.timerStart.Click += new System.EventHandler(this.StartTimer);
            // 
            // timerUnit
            // 
            this.timerUnit.FormattingEnabled = true;
            this.timerUnit.Items.AddRange(new object[] {
            "Milliseconds",
            "Seconds",
            "Minutes",
            "Hours"});
            this.timerUnit.Location = new System.Drawing.Point(12, 178);
            this.timerUnit.Name = "timerUnit";
            this.timerUnit.Size = new System.Drawing.Size(90, 21);
            this.timerUnit.TabIndex = 2;
            this.timerUnit.Text = "Seconds";
            // 
            // timerMin
            // 
            this.timerMin.Location = new System.Drawing.Point(12, 151);
            this.timerMin.Name = "timerMin";
            this.timerMin.Size = new System.Drawing.Size(42, 20);
            this.timerMin.TabIndex = 0;
            this.timerMin.ValueChanged += new System.EventHandler(this.TimerMin_ValueChanged);
            // 
            // timerMax
            // 
            this.timerMax.Location = new System.Drawing.Point(60, 152);
            this.timerMax.Name = "timerMax";
            this.timerMax.Size = new System.Drawing.Size(42, 20);
            this.timerMax.TabIndex = 1;
            this.timerMax.ValueChanged += new System.EventHandler(this.TimerMax_ValueChanged);
            // 
            // attributeName
            // 
            this.attributeName.Location = new System.Drawing.Point(141, 25);
            this.attributeName.Name = "attributeName";
            this.attributeName.Size = new System.Drawing.Size(120, 20);
            this.attributeName.TabIndex = 7;
            // 
            // optionName
            // 
            this.optionName.Location = new System.Drawing.Point(267, 25);
            this.optionName.Name = "optionName";
            this.optionName.Size = new System.Drawing.Size(120, 20);
            this.optionName.TabIndex = 11;
            // 
            // attributeMax
            // 
            this.attributeMax.Location = new System.Drawing.Point(204, 77);
            this.attributeMax.Name = "attributeMax";
            this.attributeMax.Size = new System.Drawing.Size(57, 20);
            this.attributeMax.TabIndex = 6;
            // 
            // attributeMin
            // 
            this.attributeMin.Location = new System.Drawing.Point(141, 77);
            this.attributeMin.Name = "attributeMin";
            this.attributeMin.Size = new System.Drawing.Size(57, 20);
            this.attributeMin.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 99;
            this.label1.Text = "From";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 99;
            this.label2.Text = "To";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(138, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 99;
            this.label3.Text = "Attribute Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(138, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 99;
            this.label4.Text = "Min";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(201, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 99;
            this.label5.Text = "Max";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(264, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 99;
            this.label6.Text = "Option Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(138, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 99;
            this.label7.Text = "Attribute Range";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Miriam Libre", 16F);
            this.label8.Location = new System.Drawing.Point(12, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 123);
            this.label8.TabIndex = 99;
            this.label8.Text = "Random Infinitron Timer";
            // 
            // timerLabel
            // 
            this.timerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timerLabel.Location = new System.Drawing.Point(12, 202);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(90, 25);
            this.timerLabel.TabIndex = 99;
            this.timerLabel.Text = "0:00.00";
            this.timerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // clockTimer
            // 
            this.clockTimer.Interval = 10;
            this.clockTimer.Tick += new System.EventHandler(this.ClockTimer_Tick);
            // 
            // randomTimer
            // 
            this.randomTimer.Tick += new System.EventHandler(this.RandomTimer_Tick);
            // 
            // InfiniTimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 265);
            this.Controls.Add(this.timerLabel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.attributeMin);
            this.Controls.Add(this.attributeMax);
            this.Controls.Add(this.optionName);
            this.Controls.Add(this.attributeName);
            this.Controls.Add(this.timerMax);
            this.Controls.Add(this.timerMin);
            this.Controls.Add(this.timerUnit);
            this.Controls.Add(this.timerStart);
            this.Controls.Add(this.timerStop);
            this.Controls.Add(this.removeOption);
            this.Controls.Add(this.addOption);
            this.Controls.Add(this.removeAttribute);
            this.Controls.Add(this.addAttribute);
            this.Controls.Add(this.optionsList);
            this.Controls.Add(this.attributesList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "InfiniTimer";
            this.Text = "InfiniTimer";
            this.Load += new System.EventHandler(this.Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.timerMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timerMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attributeMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attributeMin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox attributesList;
        private System.Windows.Forms.ListBox optionsList;
        private System.Windows.Forms.Button addAttribute;
        private System.Windows.Forms.Button removeAttribute;
        private System.Windows.Forms.Button addOption;
        private System.Windows.Forms.Button removeOption;
        private System.Windows.Forms.Button timerStop;
        private System.Windows.Forms.Button timerStart;
        private System.Windows.Forms.ComboBox timerUnit;
        private System.Windows.Forms.NumericUpDown timerMin;
        private System.Windows.Forms.NumericUpDown timerMax;
        private System.Windows.Forms.TextBox attributeName;
        private System.Windows.Forms.TextBox optionName;
        private System.Windows.Forms.NumericUpDown attributeMax;
        private System.Windows.Forms.NumericUpDown attributeMin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label timerLabel;
        private System.Windows.Forms.Timer clockTimer;
        private System.Windows.Forms.Timer randomTimer;
    }
}

