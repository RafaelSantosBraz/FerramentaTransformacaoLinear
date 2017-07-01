namespace AplicacaoTransformacoesLineares
{
    partial class FormAplicar
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
            this.graficoAplicar = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.textBoxFTE = new System.Windows.Forms.TextBox();
            this.textBoxVetorInicial = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.graficoAplicar)).BeginInit();
            this.SuspendLayout();
            // 
            // graficoAplicar
            // 
            this.graficoAplicar.BackColor = System.Drawing.Color.Transparent;
            this.graficoAplicar.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.graficoAplicar.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.graficoAplicar.Legends.Add(legend1);
            this.graficoAplicar.Location = new System.Drawing.Point(12, 12);
            this.graficoAplicar.Name = "graficoAplicar";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.graficoAplicar.Series.Add(series1);
            this.graficoAplicar.Size = new System.Drawing.Size(300, 300);
            this.graficoAplicar.TabIndex = 0;
            this.graficoAplicar.Text = "chart1";
            this.graficoAplicar.Click += new System.EventHandler(this.chart1_Click);
            // 
            // textBoxFTE
            // 
            this.textBoxFTE.Location = new System.Drawing.Point(300, 153);
            this.textBoxFTE.Name = "textBoxFTE";
            this.textBoxFTE.Size = new System.Drawing.Size(171, 20);
            this.textBoxFTE.TabIndex = 2;
            // 
            // textBoxVetorInicial
            // 
            this.textBoxVetorInicial.Location = new System.Drawing.Point(300, 127);
            this.textBoxVetorInicial.Name = "textBoxVetorInicial";
            this.textBoxVetorInicial.Size = new System.Drawing.Size(82, 20);
            this.textBoxVetorInicial.TabIndex = 3;
            // 
            // FormAplicar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 318);
            this.Controls.Add(this.textBoxVetorInicial);
            this.Controls.Add(this.textBoxFTE);
            this.Controls.Add(this.graficoAplicar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "FormAplicar";
            this.Text = "Aplicação de Transformação Linear";
            ((System.ComponentModel.ISupportInitialize)(this.graficoAplicar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart graficoAplicar;
        private System.Windows.Forms.TextBox textBoxFTE;
        private System.Windows.Forms.TextBox textBoxVetorInicial;
    }
}