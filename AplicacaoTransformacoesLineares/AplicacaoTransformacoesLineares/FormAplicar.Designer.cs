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
            this.comboBoxEspaco = new System.Windows.Forms.ComboBox();
            this.textBoxFTE = new System.Windows.Forms.TextBox();
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
            this.graficoAplicar.Location = new System.Drawing.Point(16, 15);
            this.graficoAplicar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.graficoAplicar.Name = "graficoAplicar";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.graficoAplicar.Series.Add(series1);
            this.graficoAplicar.Size = new System.Drawing.Size(400, 369);
            this.graficoAplicar.TabIndex = 0;
            this.graficoAplicar.Text = "chart1";
            this.graficoAplicar.Click += new System.EventHandler(this.chart1_Click);
            // 
            // comboBoxEspaco
            // 
            this.comboBoxEspaco.FormattingEnabled = true;
            this.comboBoxEspaco.Items.AddRange(new object[] {
            "R",
            "R²",
            "R³"});
            this.comboBoxEspaco.Location = new System.Drawing.Point(436, 106);
            this.comboBoxEspaco.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxEspaco.Name = "comboBoxEspaco";
            this.comboBoxEspaco.Size = new System.Drawing.Size(160, 24);
            this.comboBoxEspaco.TabIndex = 1;
            this.comboBoxEspaco.SelectedValueChanged += new System.EventHandler(this.comboBoxEspaco_SelectedValueChanged);
            // 
            // textBoxFTE
            // 
            this.textBoxFTE.Location = new System.Drawing.Point(400, 188);
            this.textBoxFTE.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxFTE.Name = "textBoxFTE";
            this.textBoxFTE.Size = new System.Drawing.Size(227, 22);
            this.textBoxFTE.TabIndex = 2;
            // 
            // FormAplicar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 391);
            this.Controls.Add(this.textBoxFTE);
            this.Controls.Add(this.comboBoxEspaco);
            this.Controls.Add(this.graficoAplicar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "FormAplicar";
            this.Text = "Aplicação de Transformação Linear";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormAplicar_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.graficoAplicar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart graficoAplicar;
        private System.Windows.Forms.ComboBox comboBoxEspaco;
        private System.Windows.Forms.TextBox textBoxFTE;
    }
}