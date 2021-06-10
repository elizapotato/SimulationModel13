
namespace Simulation_9
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.P0box = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.startB = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.NExp = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.labAverage = new System.Windows.Forms.Label();
            this.labVariance = new System.Windows.Forms.Label();
            this.labChi = new System.Windows.Forms.Label();
            this.labChiBool = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.P0box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NExp)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea4.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea4);
            legend4.Enabled = false;
            legend4.Name = "Legend1";
            this.chart1.Legends.Add(legend4);
            this.chart1.Location = new System.Drawing.Point(336, 12);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series4.ChartArea = "ChartArea1";
            series4.IsValueShownAsLabel = true;
            series4.Legend = "Legend1";
            series4.Name = "P1";
            series4.YValuesPerPoint = 6;
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(421, 347);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // P0box
            // 
            this.P0box.DecimalPlaces = 2;
            this.P0box.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.P0box.Location = new System.Drawing.Point(140, 34);
            this.P0box.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.P0box.Name = "P0box";
            this.P0box.Size = new System.Drawing.Size(82, 22);
            this.P0box.TabIndex = 1;
            this.P0box.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "p(0) =";
            // 
            // startB
            // 
            this.startB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.startB.Location = new System.Drawing.Point(80, 316);
            this.startB.Name = "startB";
            this.startB.Size = new System.Drawing.Size(169, 71);
            this.startB.TabIndex = 3;
            this.startB.Text = "Старт";
            this.startB.UseVisualStyleBackColor = false;
            this.startB.Click += new System.EventHandler(this.startB_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // NExp
            // 
            this.NExp.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NExp.Location = new System.Drawing.Point(140, 93);
            this.NExp.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.NExp.Name = "NExp";
            this.NExp.Size = new System.Drawing.Size(82, 22);
            this.NExp.TabIndex = 4;
            this.NExp.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 51);
            this.label6.TabIndex = 2;
            this.label6.Text = "      Number\r\nof experiments:\r\n\r\n";
            // 
            // labAverage
            // 
            this.labAverage.AutoSize = true;
            this.labAverage.Location = new System.Drawing.Point(396, 370);
            this.labAverage.Name = "labAverage";
            this.labAverage.Size = new System.Drawing.Size(27, 17);
            this.labAverage.TabIndex = 6;
            this.labAverage.Text = "lab";
            // 
            // labVariance
            // 
            this.labVariance.AutoSize = true;
            this.labVariance.Location = new System.Drawing.Point(618, 370);
            this.labVariance.Name = "labVariance";
            this.labVariance.Size = new System.Drawing.Size(27, 17);
            this.labVariance.TabIndex = 7;
            this.labVariance.Text = "lab";
            // 
            // labChi
            // 
            this.labChi.AutoSize = true;
            this.labChi.Location = new System.Drawing.Point(396, 403);
            this.labChi.Name = "labChi";
            this.labChi.Size = new System.Drawing.Size(27, 17);
            this.labChi.TabIndex = 8;
            this.labChi.Text = "lab";
            // 
            // labChiBool
            // 
            this.labChiBool.AutoSize = true;
            this.labChiBool.Location = new System.Drawing.Point(564, 403);
            this.labChiBool.Name = "labChiBool";
            this.labChiBool.Size = new System.Drawing.Size(27, 17);
            this.labChiBool.TabIndex = 9;
            this.labChiBool.Text = "lab";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.groupBox1.Controls.Add(this.NExp);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.P0box);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(41, 92);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(245, 160);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parameters";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 435);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labChiBool);
            this.Controls.Add(this.labChi);
            this.Controls.Add(this.labVariance);
            this.Controls.Add(this.labAverage);
            this.Controls.Add(this.startB);
            this.Controls.Add(this.chart1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Statistic";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.P0box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NExp)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.NumericUpDown P0box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button startB;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.NumericUpDown NExp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labAverage;
        private System.Windows.Forms.Label labVariance;
        private System.Windows.Forms.Label labChi;
        private System.Windows.Forms.Label labChiBool;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

