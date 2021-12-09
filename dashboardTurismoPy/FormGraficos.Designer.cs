
namespace dashboardTurismoPy
{
    partial class FormGraficos
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
            this.ReserveClient = new System.Windows.Forms.Button();
            this.ReservePrice = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.exportToPdf = new System.Windows.Forms.Button();
            this.graficogen = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.sendEmail = new System.Windows.Forms.Button();
            this.txtEmailTo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.graficogen)).BeginInit();
            this.SuspendLayout();
            // 
            // ReserveClient
            // 
            this.ReserveClient.Location = new System.Drawing.Point(25, 467);
            this.ReserveClient.Name = "ReserveClient";
            this.ReserveClient.Size = new System.Drawing.Size(95, 23);
            this.ReserveClient.TabIndex = 1;
            this.ReserveClient.Text = "Reserva/Cliente";
            this.ReserveClient.UseVisualStyleBackColor = true;
            this.ReserveClient.Click += new System.EventHandler(this.ReserveClient_Click);
            // 
            // ReservePrice
            // 
            this.ReservePrice.Location = new System.Drawing.Point(138, 467);
            this.ReservePrice.Name = "ReservePrice";
            this.ReservePrice.Size = new System.Drawing.Size(94, 23);
            this.ReservePrice.TabIndex = 2;
            this.ReservePrice.Text = "Reserva/Price";
            this.ReservePrice.UseVisualStyleBackColor = true;
            this.ReservePrice.Click += new System.EventHandler(this.ReservePrice_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(250, 467);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(89, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Reserva/Days";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(354, 467);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(116, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "Reserva/Serv extra";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(476, 467);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(116, 23);
            this.button5.TabIndex = 5;
            this.button5.Text = "Reserva/Transporte";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(607, 467);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(168, 23);
            this.button6.TabIndex = 6;
            this.button6.Text = "Reserva/Cliente alto valor";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // exportToPdf
            // 
            this.exportToPdf.Location = new System.Drawing.Point(138, 509);
            this.exportToPdf.Name = "exportToPdf";
            this.exportToPdf.Size = new System.Drawing.Size(168, 23);
            this.exportToPdf.TabIndex = 7;
            this.exportToPdf.Text = "Export to PDF";
            this.exportToPdf.UseVisualStyleBackColor = true;
            this.exportToPdf.Click += new System.EventHandler(this.exportToPdf_Click);
            // 
            // graficogen
            // 
            chartArea1.Name = "ChartArea1";
            this.graficogen.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.graficogen.Legends.Add(legend1);
            this.graficogen.Location = new System.Drawing.Point(25, 41);
            this.graficogen.Name = "graficogen";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.LegendText = "Prueba";
            series1.Name = "ReservaMes";
            this.graficogen.Series.Add(series1);
            this.graficogen.Size = new System.Drawing.Size(763, 404);
            this.graficogen.TabIndex = 8;
            this.graficogen.Text = "chart1";
            // 
            // sendEmail
            // 
            this.sendEmail.Location = new System.Drawing.Point(354, 510);
            this.sendEmail.Name = "sendEmail";
            this.sendEmail.Size = new System.Drawing.Size(168, 23);
            this.sendEmail.TabIndex = 9;
            this.sendEmail.Text = "Send by email";
            this.sendEmail.UseVisualStyleBackColor = true;
            this.sendEmail.Click += new System.EventHandler(this.sendEmail_Click);
            // 
            // txtEmailTo
            // 
            this.txtEmailTo.Location = new System.Drawing.Point(528, 512);
            this.txtEmailTo.Name = "txtEmailTo";
            this.txtEmailTo.Size = new System.Drawing.Size(247, 20);
            this.txtEmailTo.TabIndex = 10;
            // 
            // FormGraficos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 547);
            this.Controls.Add(this.txtEmailTo);
            this.Controls.Add(this.sendEmail);
            this.Controls.Add(this.graficogen);
            this.Controls.Add(this.exportToPdf);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.ReservePrice);
            this.Controls.Add(this.ReserveClient);
            this.Name = "FormGraficos";
            this.Text = "FormGraficos";
            ((System.ComponentModel.ISupportInitialize)(this.graficogen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ReserveClient;
        private System.Windows.Forms.Button ReservePrice;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button exportToPdf;
        private System.Windows.Forms.DataVisualization.Charting.Chart graficogen;
        private System.Windows.Forms.Button sendEmail;
        private System.Windows.Forms.TextBox txtEmailTo;
    }
}