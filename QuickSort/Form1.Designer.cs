namespace QuickSort
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.insertText = new System.Windows.Forms.TextBox();
            this.sortBut = new System.Windows.Forms.Button();
            this.openBut = new System.Windows.Forms.Button();
            this.mainChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.outputText = new System.Windows.Forms.TextBox();
            this.timeText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.RandButton = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.mainChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // insertText
            // 
            this.insertText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.insertText.Location = new System.Drawing.Point(12, 12);
            this.insertText.Multiline = true;
            this.insertText.Name = "insertText";
            this.insertText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.insertText.Size = new System.Drawing.Size(274, 87);
            this.insertText.TabIndex = 0;
            // 
            // sortBut
            // 
            this.sortBut.Location = new System.Drawing.Point(12, 106);
            this.sortBut.Name = "sortBut";
            this.sortBut.Size = new System.Drawing.Size(103, 23);
            this.sortBut.TabIndex = 1;
            this.sortBut.Text = "Сортировать";
            this.sortBut.UseVisualStyleBackColor = true;
            this.sortBut.Click += new System.EventHandler(this.sortBut_Click);
            // 
            // openBut
            // 
            this.openBut.Location = new System.Drawing.Point(121, 105);
            this.openBut.Name = "openBut";
            this.openBut.Size = new System.Drawing.Size(166, 23);
            this.openBut.TabIndex = 2;
            this.openBut.Text = "Загрузить данные из файла";
            this.openBut.UseVisualStyleBackColor = true;
            this.openBut.Click += new System.EventHandler(this.openBut_Click);
            // 
            // mainChart
            // 
            this.mainChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.mainChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.mainChart.Legends.Add(legend1);
            this.mainChart.Location = new System.Drawing.Point(12, 174);
            this.mainChart.Name = "mainChart";
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Color = System.Drawing.Color.LimeGreen;
            series1.Legend = "Legend1";
            series1.Name = "Кол-во Операций";
            series1.XValueMember = "Элементы";
            series1.YValueMembers = "Время";
            series1.YValuesPerPoint = 4;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "X^2";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Legend = "Legend1";
            series3.Name = "NlogN";
            this.mainChart.Series.Add(series1);
            this.mainChart.Series.Add(series2);
            this.mainChart.Series.Add(series3);
            this.mainChart.Size = new System.Drawing.Size(439, 268);
            this.mainChart.TabIndex = 3;
            this.mainChart.Text = "chart1";
            // 
            // outputText
            // 
            this.outputText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.outputText.Location = new System.Drawing.Point(457, 174);
            this.outputText.Multiline = true;
            this.outputText.Name = "outputText";
            this.outputText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.outputText.Size = new System.Drawing.Size(331, 268);
            this.outputText.TabIndex = 4;
            // 
            // timeText
            // 
            this.timeText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.timeText.Location = new System.Drawing.Point(506, 48);
            this.timeText.Multiline = true;
            this.timeText.Name = "timeText";
            this.timeText.Size = new System.Drawing.Size(282, 80);
            this.timeText.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(594, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 31);
            this.label1.TabIndex = 6;
            this.label1.Text = "Время работы:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(293, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 85);
            this.label2.TabIndex = 7;
            this.label2.Text = "Введите элементы массива \r\nчерез пробел или загрузить\r\nих файла с раширением \".tx" +
    "t\",\r\nзатем нажмите на кнопку \r\nсортировать";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(609, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Отсортированный массив";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(434, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "График зависимости времени от количества операций:\r\n";
            // 
            // RandButton
            // 
            this.RandButton.Location = new System.Drawing.Point(294, 104);
            this.RandButton.Name = "RandButton";
            this.RandButton.Size = new System.Drawing.Size(75, 23);
            this.RandButton.TabIndex = 10;
            this.RandButton.Text = "Random";
            this.RandButton.UseVisualStyleBackColor = true;
            this.RandButton.Click += new System.EventHandler(this.RandButton_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(376, 106);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(70, 20);
            this.numericUpDown1.TabIndex = 11;
            this.numericUpDown1.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 454);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.RandButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.timeText);
            this.Controls.Add(this.outputText);
            this.Controls.Add(this.mainChart);
            this.Controls.Add(this.openBut);
            this.Controls.Add(this.sortBut);
            this.Controls.Add(this.insertText);
            this.Name = "Form1";
            this.Text = "Quck Sort";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mainChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox insertText;
        private System.Windows.Forms.Button sortBut;
        private System.Windows.Forms.Button openBut;
        private System.Windows.Forms.DataVisualization.Charting.Chart mainChart;
        private System.Windows.Forms.TextBox outputText;
        private System.Windows.Forms.TextBox timeText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button RandButton;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}

