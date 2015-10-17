namespace Monochromator
{
    partial class MainForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.textBoxL0 = new System.Windows.Forms.TextBox();
            this.textBoxL1 = new System.Windows.Forms.TextBox();
            this.labelLambdaRange = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.labelL0 = new System.Windows.Forms.Label();
            this.labelL1 = new System.Windows.Forms.Label();
            this.labelL0Units = new System.Windows.Forms.Label();
            this.labelL1Units = new System.Windows.Forms.Label();
            this.labelEncoderStep = new System.Windows.Forms.Label();
            this.textBoxEncoderStep = new System.Windows.Forms.TextBox();
            this.labelEncoderStepUnits = new System.Windows.Forms.Label();
            this.labelA0 = new System.Windows.Forms.Label();
            this.textBoxA0 = new System.Windows.Forms.TextBox();
            this.labelA0Units = new System.Windows.Forms.Label();
            this.labelPort = new System.Windows.Forms.Label();
            this.comboBoxPort = new System.Windows.Forms.ComboBox();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.buttonSaveImage = new System.Windows.Forms.Button();
            this.saveImage = new System.Windows.Forms.SaveFileDialog();
            this.buttonSaveData = new System.Windows.Forms.Button();
            this.saveData = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.SuspendLayout();
            // 
            // chart
            // 
            this.chart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea2.AxisX.Title = "Длина волны, нм";
            chartArea2.AxisY.Title = "Данные";
            chartArea2.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea2);
            legend2.Enabled = false;
            legend2.Name = "Legend1";
            this.chart.Legends.Add(legend2);
            this.chart.Location = new System.Drawing.Point(158, 12);
            this.chart.Name = "chart";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.LabelAngle = 90;
            series2.Legend = "Legend1";
            series2.Name = "Данные";
            this.chart.Series.Add(series2);
            this.chart.Size = new System.Drawing.Size(694, 481);
            this.chart.TabIndex = 0;
            this.chart.Text = "Снимаемые измерения";
            // 
            // textBoxL0
            // 
            this.textBoxL0.Location = new System.Drawing.Point(32, 32);
            this.textBoxL0.Name = "textBoxL0";
            this.textBoxL0.Size = new System.Drawing.Size(71, 20);
            this.textBoxL0.TabIndex = 1;
            this.textBoxL0.Text = "415";
            this.textBoxL0.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxL1
            // 
            this.textBoxL1.Location = new System.Drawing.Point(32, 58);
            this.textBoxL1.Name = "textBoxL1";
            this.textBoxL1.Size = new System.Drawing.Size(71, 20);
            this.textBoxL1.TabIndex = 2;
            this.textBoxL1.Text = "875";
            this.textBoxL1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelLambdaRange
            // 
            this.labelLambdaRange.AutoSize = true;
            this.labelLambdaRange.Location = new System.Drawing.Point(9, 12);
            this.labelLambdaRange.Name = "labelLambdaRange";
            this.labelLambdaRange.Size = new System.Drawing.Size(66, 13);
            this.labelLambdaRange.TabIndex = 3;
            this.labelLambdaRange.Text = "Диапазон λ";
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(12, 205);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(118, 23);
            this.buttonStart.TabIndex = 4;
            this.buttonStart.Text = "Начать измерение";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // labelL0
            // 
            this.labelL0.AutoSize = true;
            this.labelL0.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelL0.Location = new System.Drawing.Point(9, 34);
            this.labelL0.Name = "labelL0";
            this.labelL0.Size = new System.Drawing.Size(17, 15);
            this.labelL0.TabIndex = 5;
            this.labelL0.Text = "λ₀";
            // 
            // labelL1
            // 
            this.labelL1.AutoSize = true;
            this.labelL1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelL1.Location = new System.Drawing.Point(9, 60);
            this.labelL1.Name = "labelL1";
            this.labelL1.Size = new System.Drawing.Size(17, 15);
            this.labelL1.TabIndex = 6;
            this.labelL1.Text = "λ₁";
            // 
            // labelL0Units
            // 
            this.labelL0Units.AutoSize = true;
            this.labelL0Units.Location = new System.Drawing.Point(109, 35);
            this.labelL0Units.Name = "labelL0Units";
            this.labelL0Units.Size = new System.Drawing.Size(21, 13);
            this.labelL0Units.TabIndex = 7;
            this.labelL0Units.Text = "нм";
            // 
            // labelL1Units
            // 
            this.labelL1Units.AutoSize = true;
            this.labelL1Units.Location = new System.Drawing.Point(109, 61);
            this.labelL1Units.Name = "labelL1Units";
            this.labelL1Units.Size = new System.Drawing.Size(21, 13);
            this.labelL1Units.TabIndex = 8;
            this.labelL1Units.Text = "нм";
            // 
            // labelEncoderStep
            // 
            this.labelEncoderStep.AutoSize = true;
            this.labelEncoderStep.Location = new System.Drawing.Point(9, 87);
            this.labelEncoderStep.Name = "labelEncoderStep";
            this.labelEncoderStep.Size = new System.Drawing.Size(78, 13);
            this.labelEncoderStep.TabIndex = 9;
            this.labelEncoderStep.Text = "Шаг энкодера";
            // 
            // textBoxEncoderStep
            // 
            this.textBoxEncoderStep.Location = new System.Drawing.Point(93, 84);
            this.textBoxEncoderStep.Name = "textBoxEncoderStep";
            this.textBoxEncoderStep.Size = new System.Drawing.Size(37, 20);
            this.textBoxEncoderStep.TabIndex = 10;
            this.textBoxEncoderStep.Text = "1,8";
            this.textBoxEncoderStep.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelEncoderStepUnits
            // 
            this.labelEncoderStepUnits.AutoSize = true;
            this.labelEncoderStepUnits.Location = new System.Drawing.Point(136, 87);
            this.labelEncoderStepUnits.Name = "labelEncoderStepUnits";
            this.labelEncoderStepUnits.Size = new System.Drawing.Size(11, 13);
            this.labelEncoderStepUnits.TabIndex = 11;
            this.labelEncoderStepUnits.Text = "°";
            // 
            // labelA0
            // 
            this.labelA0.AutoSize = true;
            this.labelA0.Location = new System.Drawing.Point(9, 113);
            this.labelA0.Name = "labelA0";
            this.labelA0.Size = new System.Drawing.Size(54, 13);
            this.labelA0.TabIndex = 12;
            this.labelA0.Text = "Нач. угол";
            // 
            // textBoxA0
            // 
            this.textBoxA0.Location = new System.Drawing.Point(93, 110);
            this.textBoxA0.Name = "textBoxA0";
            this.textBoxA0.Size = new System.Drawing.Size(37, 20);
            this.textBoxA0.TabIndex = 13;
            this.textBoxA0.Text = "300";
            this.textBoxA0.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelA0Units
            // 
            this.labelA0Units.AutoSize = true;
            this.labelA0Units.Location = new System.Drawing.Point(136, 113);
            this.labelA0Units.Name = "labelA0Units";
            this.labelA0Units.Size = new System.Drawing.Size(11, 13);
            this.labelA0Units.TabIndex = 14;
            this.labelA0Units.Text = "°";
            // 
            // labelPort
            // 
            this.labelPort.AutoSize = true;
            this.labelPort.Location = new System.Drawing.Point(9, 139);
            this.labelPort.Name = "labelPort";
            this.labelPort.Size = new System.Drawing.Size(32, 13);
            this.labelPort.TabIndex = 15;
            this.labelPort.Text = "Порт";
            // 
            // comboBoxPort
            // 
            this.comboBoxPort.FormattingEnabled = true;
            this.comboBoxPort.Location = new System.Drawing.Point(47, 136);
            this.comboBoxPort.Name = "comboBoxPort";
            this.comboBoxPort.Size = new System.Drawing.Size(83, 21);
            this.comboBoxPort.TabIndex = 16;
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(12, 163);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(118, 23);
            this.buttonRefresh.TabIndex = 17;
            this.buttonRefresh.Text = "Обновить порты";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // buttonSaveImage
            // 
            this.buttonSaveImage.Location = new System.Drawing.Point(12, 257);
            this.buttonSaveImage.Name = "buttonSaveImage";
            this.buttonSaveImage.Size = new System.Drawing.Size(118, 23);
            this.buttonSaveImage.TabIndex = 18;
            this.buttonSaveImage.Text = "Сохранить график";
            this.buttonSaveImage.UseVisualStyleBackColor = true;
            this.buttonSaveImage.Click += new System.EventHandler(this.buttonSaveImage_Click);
            // 
            // saveImage
            // 
            this.saveImage.FileName = "data.png";
            this.saveImage.Filter = "PNG|*.png";
            this.saveImage.Title = "Сохранить график...";
            // 
            // buttonSaveData
            // 
            this.buttonSaveData.Location = new System.Drawing.Point(12, 287);
            this.buttonSaveData.Name = "buttonSaveData";
            this.buttonSaveData.Size = new System.Drawing.Size(118, 23);
            this.buttonSaveData.TabIndex = 20;
            this.buttonSaveData.Text = "Сохранить данные";
            this.buttonSaveData.UseVisualStyleBackColor = true;
            this.buttonSaveData.Click += new System.EventHandler(this.buttonSaveData_Click);
            // 
            // saveData
            // 
            this.saveData.FileName = "data.csv";
            this.saveData.Filter = "CSV|*.csv";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 505);
            this.Controls.Add(this.buttonSaveData);
            this.Controls.Add(this.buttonSaveImage);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.comboBoxPort);
            this.Controls.Add(this.labelPort);
            this.Controls.Add(this.labelA0Units);
            this.Controls.Add(this.textBoxA0);
            this.Controls.Add(this.labelA0);
            this.Controls.Add(this.labelEncoderStepUnits);
            this.Controls.Add(this.textBoxEncoderStep);
            this.Controls.Add(this.labelEncoderStep);
            this.Controls.Add(this.labelL1Units);
            this.Controls.Add(this.labelL0Units);
            this.Controls.Add(this.labelL1);
            this.Controls.Add(this.labelL0);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.labelLambdaRange);
            this.Controls.Add(this.textBoxL1);
            this.Controls.Add(this.textBoxL0);
            this.Controls.Add(this.chart);
            this.Name = "MainForm";
            this.Text = "Монохроматор";
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.TextBox textBoxL0;
        private System.Windows.Forms.TextBox textBoxL1;
        private System.Windows.Forms.Label labelLambdaRange;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label labelL0;
        private System.Windows.Forms.Label labelL1;
        private System.Windows.Forms.Label labelL0Units;
        private System.Windows.Forms.Label labelL1Units;
        private System.Windows.Forms.Label labelEncoderStep;
        private System.Windows.Forms.TextBox textBoxEncoderStep;
        private System.Windows.Forms.Label labelEncoderStepUnits;
        private System.Windows.Forms.Label labelA0;
        private System.Windows.Forms.TextBox textBoxA0;
        private System.Windows.Forms.Label labelA0Units;
        private System.Windows.Forms.Label labelPort;
        private System.Windows.Forms.ComboBox comboBoxPort;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Button buttonSaveImage;
        private System.Windows.Forms.SaveFileDialog saveImage;
        private System.Windows.Forms.Button buttonSaveData;
        private System.Windows.Forms.SaveFileDialog saveData;
    }
}

