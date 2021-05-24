
namespace FCFS
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.processNumbersTextBox = new System.Windows.Forms.TextBox();
            this.ganttChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.fcfsListView = new System.Windows.Forms.ListView();
            this.processNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.burstTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.waitingTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.turnAroundTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.averageWaitingTimeLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ganttChart)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Algorithm type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Process numbers";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(191, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(138, 22);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "FCFS";
            // 
            // processNumbersTextBox
            // 
            this.processNumbersTextBox.Location = new System.Drawing.Point(191, 68);
            this.processNumbersTextBox.Name = "processNumbersTextBox";
            this.processNumbersTextBox.Size = new System.Drawing.Size(137, 22);
            this.processNumbersTextBox.TabIndex = 3;
            // 
            // ganttChart
            // 
            chartArea1.Name = "ChartArea1";
            this.ganttChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.ganttChart.Legends.Add(legend1);
            this.ganttChart.Location = new System.Drawing.Point(16, 139);
            this.ganttChart.Name = "ganttChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Process scheduling";
            this.ganttChart.Series.Add(series1);
            this.ganttChart.Size = new System.Drawing.Size(735, 376);
            this.ganttChart.TabIndex = 4;
            this.ganttChart.Tag = "";
            this.ganttChart.Text = "Chart1";
            // 
            // fcfsListView
            // 
            this.fcfsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.processNumber,
            this.burstTime,
            this.waitingTime,
            this.turnAroundTime});
            this.fcfsListView.HideSelection = false;
            this.fcfsListView.Location = new System.Drawing.Point(772, 12);
            this.fcfsListView.Name = "fcfsListView";
            this.fcfsListView.Size = new System.Drawing.Size(523, 340);
            this.fcfsListView.TabIndex = 5;
            this.fcfsListView.UseCompatibleStateImageBehavior = false;
            this.fcfsListView.View = System.Windows.Forms.View.Details;
            // 
            // processNumber
            // 
            this.processNumber.Text = "Process Number";
            this.processNumber.Width = 134;
            // 
            // burstTime
            // 
            this.burstTime.Text = "Burst Time";
            this.burstTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.burstTime.Width = 117;
            // 
            // waitingTime
            // 
            this.waitingTime.Text = "Waiting Time";
            this.waitingTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.waitingTime.Width = 135;
            // 
            // turnAroundTime
            // 
            this.turnAroundTime.Text = "Turn Around Time";
            this.turnAroundTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.turnAroundTime.Width = 129;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(769, 385);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Average Waiting Time";
            // 
            // averageWaitingTimeLabel
            // 
            this.averageWaitingTimeLabel.AutoSize = true;
            this.averageWaitingTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.averageWaitingTimeLabel.Location = new System.Drawing.Point(966, 385);
            this.averageWaitingTimeLabel.Name = "averageWaitingTimeLabel";
            this.averageWaitingTimeLabel.Size = new System.Drawing.Size(43, 17);
            this.averageWaitingTimeLabel.TabIndex = 7;
            this.averageWaitingTimeLabel.Text = ".......";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(38, 104);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 8;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(140, 104);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 23);
            this.resetButton.TabIndex = 9;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1307, 527);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.averageWaitingTimeLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fcfsListView);
            this.Controls.Add(this.ganttChart);
            this.Controls.Add(this.processNumbersTextBox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ganttChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox processNumbersTextBox;
        private System.Windows.Forms.DataVisualization.Charting.Chart ganttChart;
        private System.Windows.Forms.ListView fcfsListView;
        private System.Windows.Forms.ColumnHeader processNumber;
        private System.Windows.Forms.ColumnHeader burstTime;
        private System.Windows.Forms.ColumnHeader waitingTime;
        private System.Windows.Forms.ColumnHeader turnAroundTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label averageWaitingTimeLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button resetButton;
    }
}

