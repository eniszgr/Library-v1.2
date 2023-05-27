namespace Library_v1._2
{
    partial class frmStatics
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblLoan = new System.Windows.Forms.Label();
            this.lblNotLoan = new System.Windows.Forms.Label();
            this.lblBtotal = new System.Windows.Forms.Label();
            this.lblBLoan = new System.Windows.Forms.Label();
            this.lblBnLoan = new System.Windows.Forms.Label();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lbltitle1 = new System.Windows.Forms.Label();
            this.lbltitle2 = new System.Windows.Forms.Label();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(197, 101);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Genres";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(414, 239);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTotal.Location = new System.Drawing.Point(40, 44);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(54, 21);
            this.lblTotal.TabIndex = 1;
            this.lblTotal.Text = "Total:";
            // 
            // lblLoan
            // 
            this.lblLoan.AutoSize = true;
            this.lblLoan.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLoan.Location = new System.Drawing.Point(39, 108);
            this.lblLoan.Name = "lblLoan";
            this.lblLoan.Size = new System.Drawing.Size(55, 21);
            this.lblLoan.TabIndex = 2;
            this.lblLoan.Text = "Loan:";
            // 
            // lblNotLoan
            // 
            this.lblNotLoan.AutoSize = true;
            this.lblNotLoan.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblNotLoan.Location = new System.Drawing.Point(10, 172);
            this.lblNotLoan.Name = "lblNotLoan";
            this.lblNotLoan.Size = new System.Drawing.Size(88, 21);
            this.lblNotLoan.TabIndex = 3;
            this.lblNotLoan.Text = "Not Loan:";
            // 
            // lblBtotal
            // 
            this.lblBtotal.AutoSize = true;
            this.lblBtotal.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBtotal.Location = new System.Drawing.Point(98, 41);
            this.lblBtotal.Name = "lblBtotal";
            this.lblBtotal.Size = new System.Drawing.Size(0, 23);
            this.lblBtotal.TabIndex = 4;
            // 
            // lblBLoan
            // 
            this.lblBLoan.AutoSize = true;
            this.lblBLoan.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBLoan.Location = new System.Drawing.Point(98, 105);
            this.lblBLoan.Name = "lblBLoan";
            this.lblBLoan.Size = new System.Drawing.Size(0, 23);
            this.lblBLoan.TabIndex = 5;
            // 
            // lblBnLoan
            // 
            this.lblBnLoan.AutoSize = true;
            this.lblBnLoan.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBnLoan.Location = new System.Drawing.Point(98, 172);
            this.lblBnLoan.Name = "lblBnLoan";
            this.lblBnLoan.Size = new System.Drawing.Size(0, 23);
            this.lblBnLoan.TabIndex = 6;
            // 
            // chart2
            // 
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(642, 101);
            this.chart2.Name = "chart2";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Genres";
            this.chart2.Series.Add(series2);
            this.chart2.Size = new System.Drawing.Size(398, 239);
            this.chart2.TabIndex = 7;
            this.chart2.Text = "chart2";
            // 
            // lbltitle1
            // 
            this.lbltitle1.AutoSize = true;
            this.lbltitle1.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbltitle1.Location = new System.Drawing.Point(342, 59);
            this.lbltitle1.Name = "lbltitle1";
            this.lbltitle1.Size = new System.Drawing.Size(114, 27);
            this.lbltitle1.TabIndex = 8;
            this.lbltitle1.Text = "TOTALLY";
            // 
            // lbltitle2
            // 
            this.lbltitle2.AutoSize = true;
            this.lbltitle2.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbltitle2.Location = new System.Drawing.Point(773, 59);
            this.lbltitle2.Name = "lbltitle2";
            this.lbltitle2.Size = new System.Drawing.Size(144, 27);
            this.lbltitle2.TabIndex = 9;
            this.lbltitle2.Text = "IN LIBRARY";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblTotal);
            this.panel1.Controls.Add(this.lblLoan);
            this.panel1.Controls.Add(this.lblNotLoan);
            this.panel1.Controls.Add(this.lblBtotal);
            this.panel1.Controls.Add(this.lblBnLoan);
            this.panel1.Controls.Add(this.lblBLoan);
            this.panel1.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.panel1.Location = new System.Drawing.Point(18, 101);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(161, 239);
            this.panel1.TabIndex = 10;
            // 
            // frmStatics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 359);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbltitle2);
            this.Controls.Add(this.lbltitle1);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.chart1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmStatics";
            this.Text = "frmStatics";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblLoan;
        private System.Windows.Forms.Label lblNotLoan;
        private System.Windows.Forms.Label lblBtotal;
        private System.Windows.Forms.Label lblBLoan;
        private System.Windows.Forms.Label lblBnLoan;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Label lbltitle1;
        private System.Windows.Forms.Label lbltitle2;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.Panel panel1;
    }
}