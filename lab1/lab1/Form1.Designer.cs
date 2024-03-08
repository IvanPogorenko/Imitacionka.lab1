namespace lab1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edSize = new System.Windows.Forms.NumericUpDown();
            this.edWeight = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btStart = new System.Windows.Forms.Button();
            this.edHeight = new System.Windows.Forms.NumericUpDown();
            this.edAngle = new System.Windows.Forms.NumericUpDown();
            this.edSpeed = new System.Windows.Forms.NumericUpDown();
            this.text3 = new System.Windows.Forms.Label();
            this.text2 = new System.Windows.Forms.Label();
            this.text1 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.edStep = new System.Windows.Forms.NumericUpDown();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edAngle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edStep)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.edStep);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.edSize);
            this.panel1.Controls.Add(this.edWeight);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btStart);
            this.panel1.Controls.Add(this.edHeight);
            this.panel1.Controls.Add(this.edAngle);
            this.panel1.Controls.Add(this.edSpeed);
            this.panel1.Controls.Add(this.text3);
            this.panel1.Controls.Add(this.text2);
            this.panel1.Controls.Add(this.text1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1379, 177);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1.Location = new System.Drawing.Point(485, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(884, 150);
            this.dataGridView1.TabIndex = 11;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "TimeStep";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Distance";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "maxHeight";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.Width = 150;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "EndSpeed";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.Width = 150;
            // 
            // edSize
            // 
            this.edSize.DecimalPlaces = 1;
            this.edSize.Location = new System.Drawing.Point(291, 20);
            this.edSize.Name = "edSize";
            this.edSize.Size = new System.Drawing.Size(120, 26);
            this.edSize.TabIndex = 10;
            this.edSize.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // edWeight
            // 
            this.edWeight.DecimalPlaces = 1;
            this.edWeight.Location = new System.Drawing.Point(291, 58);
            this.edWeight.Name = "edWeight";
            this.edWeight.Size = new System.Drawing.Size(120, 26);
            this.edWeight.TabIndex = 9;
            this.edWeight.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(220, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Вес";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(220, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Размер";
            // 
            // btStart
            // 
            this.btStart.Location = new System.Drawing.Point(224, 90);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(220, 68);
            this.btStart.TabIndex = 6;
            this.btStart.Text = "Start";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // edHeight
            // 
            this.edHeight.Location = new System.Drawing.Point(94, 18);
            this.edHeight.Name = "edHeight";
            this.edHeight.Size = new System.Drawing.Size(120, 26);
            this.edHeight.TabIndex = 5;
            // 
            // edAngle
            // 
            this.edAngle.Location = new System.Drawing.Point(94, 56);
            this.edAngle.Name = "edAngle";
            this.edAngle.Size = new System.Drawing.Size(120, 26);
            this.edAngle.TabIndex = 4;
            this.edAngle.Value = new decimal(new int[] {
            35,
            0,
            0,
            0});
            // 
            // edSpeed
            // 
            this.edSpeed.Location = new System.Drawing.Point(94, 95);
            this.edSpeed.Name = "edSpeed";
            this.edSpeed.Size = new System.Drawing.Size(120, 26);
            this.edSpeed.TabIndex = 3;
            this.edSpeed.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // text3
            // 
            this.text3.AutoSize = true;
            this.text3.Location = new System.Drawing.Point(12, 97);
            this.text3.Name = "text3";
            this.text3.Size = new System.Drawing.Size(81, 20);
            this.text3.TabIndex = 2;
            this.text3.Text = "Скорость";
            // 
            // text2
            // 
            this.text2.AutoSize = true;
            this.text2.Location = new System.Drawing.Point(12, 56);
            this.text2.Name = "text2";
            this.text2.Size = new System.Drawing.Size(45, 20);
            this.text2.TabIndex = 1;
            this.text2.Text = "Угол";
            // 
            // text1
            // 
            this.text1.AutoSize = true;
            this.text1.Location = new System.Drawing.Point(12, 18);
            this.text1.Name = "text1";
            this.text1.Size = new System.Drawing.Size(66, 20);
            this.text1.TabIndex = 0;
            this.text1.Text = "Высота";
            // 
            // chart1
            // 
            chartArea1.AxisX.Maximum = 25D;
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.AxisY.Maximum = 6D;
            chartArea1.AxisY.Minimum = 0D;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Location = new System.Drawing.Point(3, 183);
            this.chart1.Name = "chart1";
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(1366, 651);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Шаг";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // edStep
            // 
            this.edStep.DecimalPlaces = 5;
            this.edStep.Location = new System.Drawing.Point(94, 132);
            this.edStep.Name = "edStep";
            this.edStep.Size = new System.Drawing.Size(120, 26);
            this.edStep.TabIndex = 13;
            this.edStep.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1381, 856);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edAngle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edStep)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.NumericUpDown edHeight;
        private System.Windows.Forms.NumericUpDown edAngle;
        private System.Windows.Forms.NumericUpDown edSpeed;
        private System.Windows.Forms.Label text3;
        private System.Windows.Forms.Label text2;
        private System.Windows.Forms.Label text1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.NumericUpDown edSize;
        private System.Windows.Forms.NumericUpDown edWeight;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown edStep;
    }
}

