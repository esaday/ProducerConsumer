namespace TK_Cons_F_v0
{
    partial class frmDataFlow
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
            System.Windows.Forms.DataVisualization.Charting.LegendItem legendItem1 = new System.Windows.Forms.DataVisualization.Charting.LegendItem();
            System.Windows.Forms.DataVisualization.Charting.LegendItem legendItem2 = new System.Windows.Forms.DataVisualization.Charting.LegendItem();
            System.Windows.Forms.DataVisualization.Charting.LegendItem legendItem3 = new System.Windows.Forms.DataVisualization.Charting.LegendItem();
            System.Windows.Forms.DataVisualization.Charting.LegendItem legendItem4 = new System.Windows.Forms.DataVisualization.Charting.LegendItem();
            System.Windows.Forms.DataVisualization.Charting.LegendItem legendItem5 = new System.Windows.Forms.DataVisualization.Charting.LegendItem();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartData = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonDFlow = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColDateCreated = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSomeText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColErrorMode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // chartData
            // 
            this.chartData.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.chartData.BackColor = System.Drawing.Color.DimGray;
            chartArea1.Name = "ChartArea1";
            this.chartData.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.White;
            legendItem1.Color = System.Drawing.Color.Red;
            legendItem1.ImageStyle = System.Windows.Forms.DataVisualization.Charting.LegendImageStyle.Line;
            legendItem1.Name = "Ust Lim";
            legendItem1.SeparatorColor = System.Drawing.Color.Maroon;
            legendItem2.Color = System.Drawing.Color.Black;
            legendItem2.ImageStyle = System.Windows.Forms.DataVisualization.Charting.LegendImageStyle.Line;
            legendItem2.Name = "Normal";
            legendItem3.Color = System.Drawing.Color.Gray;
            legendItem3.ImageStyle = System.Windows.Forms.DataVisualization.Charting.LegendImageStyle.Line;
            legendItem3.Name = "Gecersiz";
            legendItem4.Color = System.Drawing.Color.Lime;
            legendItem4.ImageStyle = System.Windows.Forms.DataVisualization.Charting.LegendImageStyle.Line;
            legendItem4.Name = "AltLim";
            legendItem5.ImageStyle = System.Windows.Forms.DataVisualization.Charting.LegendImageStyle.Marker;
            legend1.CustomItems.Add(legendItem1);
            legend1.CustomItems.Add(legendItem2);
            legend1.CustomItems.Add(legendItem3);
            legend1.CustomItems.Add(legendItem4);
            legend1.CustomItems.Add(legendItem5);
            legend1.Name = "Inc. Data";
            legend1.Title = "Inc. Data";
            this.chartData.Legends.Add(legend1);
            this.chartData.Location = new System.Drawing.Point(12, 47);
            this.chartData.Name = "chartData";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Inc. Data";
            series1.Name = "Some Val";
            this.chartData.Series.Add(series1);
            this.chartData.Size = new System.Drawing.Size(811, 254);
            this.chartData.TabIndex = 3;
            this.chartData.Text = "chart1";
            // 
            // buttonDFlow
            // 
            this.buttonDFlow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDFlow.Location = new System.Drawing.Point(630, 320);
            this.buttonDFlow.Name = "buttonDFlow";
            this.buttonDFlow.Size = new System.Drawing.Size(96, 67);
            this.buttonDFlow.TabIndex = 5;
            this.buttonDFlow.Text = "BASLA";
            this.buttonDFlow.UseVisualStyleBackColor = true;
            this.buttonDFlow.Click += new System.EventHandler(this.btnFlowData_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColDateCreated,
            this.ColValue,
            this.ColSomeText,
            this.ColErrorMode});
            this.dataGridView1.Location = new System.Drawing.Point(12, 307);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(566, 119);
            this.dataGridView1.TabIndex = 4;
            // 
            // ColDateCreated
            // 
            this.ColDateCreated.HeaderText = "Gel. Tar.";
            this.ColDateCreated.Name = "ColDateCreated";
            this.ColDateCreated.Width = 150;
            // 
            // ColValue
            // 
            this.ColValue.HeaderText = "Deger";
            this.ColValue.Name = "ColValue";
            // 
            // ColSomeText
            // 
            this.ColSomeText.HeaderText = "Gelen String";
            this.ColSomeText.Name = "ColSomeText";
            this.ColSomeText.Width = 170;
            // 
            // ColErrorMode
            // 
            this.ColErrorMode.HeaderText = "Hata Kontrol";
            this.ColErrorMode.Name = "ColErrorMode";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(330, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 39);
            this.label1.TabIndex = 6;
            this.label1.Text = "&Veri Akışı";
            // 
            // frmDataFlow
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(835, 455);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chartData);
            this.Controls.Add(this.buttonDFlow);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDataFlow";
            this.Text = "DataFlow";
            this.VisibleChanged += new System.EventHandler(this.frmDataFlow_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.chartData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartData;
        private System.Windows.Forms.Button buttonDFlow;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDateCreated;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSomeText;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColErrorMode;
    }
}

