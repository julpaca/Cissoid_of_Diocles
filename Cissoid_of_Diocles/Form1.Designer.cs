namespace Cissoid_of_Diocles
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.graph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbStep = new System.Windows.Forms.TextBox();
            this.tbCoefficient = new System.Windows.Forms.TextBox();
            this.tbEndPoint = new System.Windows.Forms.TextBox();
            this.tbStartPoint = new System.Windows.Forms.TextBox();
            this.cbGreeting = new System.Windows.Forms.CheckBox();
            this.btnMakeGraph = new System.Windows.Forms.Button();
            this.gridCoordinates = new System.Windows.Forms.DataGridView();
            this.x = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.y1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.y2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.graph)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCoordinates)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // graph
            // 
            chartArea1.Name = "ChartArea1";
            this.graph.ChartAreas.Add(chartArea1);
            this.graph.Location = new System.Drawing.Point(12, 131);
            this.graph.Name = "graph";
            this.graph.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Color = System.Drawing.Color.DarkOrchid;
            series1.LabelBorderWidth = 3;
            series1.MarkerBorderColor = System.Drawing.Color.White;
            series1.Name = "Series1";
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Color = System.Drawing.Color.Teal;
            series2.Name = "Series2";
            this.graph.Series.Add(series1);
            this.graph.Series.Add(series2);
            this.graph.Size = new System.Drawing.Size(446, 267);
            this.graph.TabIndex = 0;
            this.graph.Text = "chart";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(274, 69);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Шаг";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(221, 31);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Кэффициент а";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 68);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Конечная точка х";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Начальная точка x";
            // 
            // tbStep
            // 
            this.tbStep.Location = new System.Drawing.Point(305, 69);
            this.tbStep.Margin = new System.Windows.Forms.Padding(2);
            this.tbStep.Name = "tbStep";
            this.tbStep.Size = new System.Drawing.Size(76, 20);
            this.tbStep.TabIndex = 11;
            // 
            // tbCoefficient
            // 
            this.tbCoefficient.Location = new System.Drawing.Point(305, 31);
            this.tbCoefficient.Margin = new System.Windows.Forms.Padding(2);
            this.tbCoefficient.Name = "tbCoefficient";
            this.tbCoefficient.Size = new System.Drawing.Size(76, 20);
            this.tbCoefficient.TabIndex = 10;
            // 
            // tbEndPoint
            // 
            this.tbEndPoint.Location = new System.Drawing.Point(116, 68);
            this.tbEndPoint.Margin = new System.Windows.Forms.Padding(2);
            this.tbEndPoint.Name = "tbEndPoint";
            this.tbEndPoint.Size = new System.Drawing.Size(76, 20);
            this.tbEndPoint.TabIndex = 9;
            // 
            // tbStartPoint
            // 
            this.tbStartPoint.Location = new System.Drawing.Point(116, 31);
            this.tbStartPoint.Margin = new System.Windows.Forms.Padding(2);
            this.tbStartPoint.Name = "tbStartPoint";
            this.tbStartPoint.Size = new System.Drawing.Size(76, 20);
            this.tbStartPoint.TabIndex = 8;
            // 
            // cbGreeting
            // 
            this.cbGreeting.AutoSize = true;
            this.cbGreeting.Location = new System.Drawing.Point(643, 8);
            this.cbGreeting.Name = "cbGreeting";
            this.cbGreeting.Size = new System.Drawing.Size(154, 17);
            this.cbGreeting.TabIndex = 16;
            this.cbGreeting.Text = "Отключить приветствие?";
            this.cbGreeting.UseVisualStyleBackColor = true;
            // 
            // btnMakeGraph
            // 
            this.btnMakeGraph.Location = new System.Drawing.Point(12, 404);
            this.btnMakeGraph.Name = "btnMakeGraph";
            this.btnMakeGraph.Size = new System.Drawing.Size(446, 58);
            this.btnMakeGraph.TabIndex = 17;
            this.btnMakeGraph.Text = "Построить график!";
            this.btnMakeGraph.UseVisualStyleBackColor = true;
            this.btnMakeGraph.Click += new System.EventHandler(this.btnMakeGraph_Click);
            // 
            // gridCoordinates
            // 
            this.gridCoordinates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCoordinates.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.x,
            this.y1,
            this.y2});
            this.gridCoordinates.Location = new System.Drawing.Point(464, 131);
            this.gridCoordinates.Name = "gridCoordinates";
            this.gridCoordinates.RowHeadersWidth = 31;
            this.gridCoordinates.Size = new System.Drawing.Size(333, 331);
            this.gridCoordinates.TabIndex = 18;
            // 
            // x
            // 
            this.x.HeaderText = "x";
            this.x.Name = "x";
            // 
            // y1
            // 
            this.y1.HeaderText = "y1";
            this.y1.Name = "y1";
            // 
            // y2
            // 
            this.y2.HeaderText = "y2";
            this.y2.Name = "y2";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(643, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(154, 79);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 470);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gridCoordinates);
            this.Controls.Add(this.btnMakeGraph);
            this.Controls.Add(this.cbGreeting);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbStep);
            this.Controls.Add(this.tbCoefficient);
            this.Controls.Add(this.tbEndPoint);
            this.Controls.Add(this.tbStartPoint);
            this.Controls.Add(this.graph);
            this.Name = "MainForm";
            this.Text = "Cissoid of Diocles";
            ((System.ComponentModel.ISupportInitialize)(this.graph)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCoordinates)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart graph;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbStep;
        private System.Windows.Forms.TextBox tbCoefficient;
        private System.Windows.Forms.TextBox tbEndPoint;
        private System.Windows.Forms.TextBox tbStartPoint;
        private System.Windows.Forms.CheckBox cbGreeting;
        private System.Windows.Forms.Button btnMakeGraph;
        private System.Windows.Forms.DataGridView gridCoordinates;
        private System.Windows.Forms.DataGridViewTextBoxColumn x;
        private System.Windows.Forms.DataGridViewTextBoxColumn y1;
        private System.Windows.Forms.DataGridViewTextBoxColumn y2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

