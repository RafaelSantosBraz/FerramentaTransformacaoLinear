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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.graficoAplicar = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.comboBoxEspaco = new System.Windows.Forms.ComboBox();
            this.panelR = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panelR2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.panelR3 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.graficoAplicar)).BeginInit();
            this.panelR.SuspendLayout();
            this.panelR2.SuspendLayout();
            this.panelR3.SuspendLayout();
            this.SuspendLayout();
            // 
            // graficoAplicar
            // 
            this.graficoAplicar.BackColor = System.Drawing.Color.Transparent;
            this.graficoAplicar.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea2.Name = "ChartArea1";
            this.graficoAplicar.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.graficoAplicar.Legends.Add(legend2);
            this.graficoAplicar.Location = new System.Drawing.Point(12, 12);
            this.graficoAplicar.Name = "graficoAplicar";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.graficoAplicar.Series.Add(series2);
            this.graficoAplicar.Size = new System.Drawing.Size(300, 300);
            this.graficoAplicar.TabIndex = 0;
            this.graficoAplicar.Text = "chart1";
            this.graficoAplicar.Click += new System.EventHandler(this.chart1_Click);
            // 
            // comboBoxEspaco
            // 
            this.comboBoxEspaco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEspaco.FormattingEnabled = true;
            this.comboBoxEspaco.Items.AddRange(new object[] {
            "R",
            "R²",
            "R³"});
            this.comboBoxEspaco.Location = new System.Drawing.Point(300, 68);
            this.comboBoxEspaco.Name = "comboBoxEspaco";
            this.comboBoxEspaco.Size = new System.Drawing.Size(58, 21);
            this.comboBoxEspaco.TabIndex = 1;
            this.comboBoxEspaco.DropDown += new System.EventHandler(this.chart1_Click);
            this.comboBoxEspaco.SelectedIndexChanged += new System.EventHandler(this.comboBoxEspaco_SelectedIndexChanged);
            this.comboBoxEspaco.SelectedValueChanged += new System.EventHandler(this.comboBoxEspaco_SelectedValueChanged);
            // 
            // panelR
            // 
            this.panelR.Controls.Add(this.textBox1);
            this.panelR.Controls.Add(this.label2);
            this.panelR.Controls.Add(this.label1);
            this.panelR.Location = new System.Drawing.Point(300, 114);
            this.panelR.Name = "panelR";
            this.panelR.Size = new System.Drawing.Size(87, 34);
            this.panelR.TabIndex = 2;
            this.panelR.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(35, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(23, 20);
            this.textBox1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = ")";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "U = (";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 0;
            // 
            // panelR2
            // 
            this.panelR2.Controls.Add(this.textBox3);
            this.panelR2.Controls.Add(this.textBox2);
            this.panelR2.Controls.Add(this.label6);
            this.panelR2.Controls.Add(this.label5);
            this.panelR2.Controls.Add(this.label4);
            this.panelR2.Controls.Add(this.label3);
            this.panelR2.Location = new System.Drawing.Point(300, 114);
            this.panelR2.Name = "panelR2";
            this.panelR2.Size = new System.Drawing.Size(140, 43);
            this.panelR2.TabIndex = 3;
            this.panelR2.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "U = (";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(77, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(10, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = ",";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(118, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(10, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = ")";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(46, 12);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(25, 20);
            this.textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(89, 12);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(23, 20);
            this.textBox3.TabIndex = 4;
            // 
            // panelR3
            // 
            this.panelR3.Controls.Add(this.textBox6);
            this.panelR3.Controls.Add(this.textBox5);
            this.panelR3.Controls.Add(this.textBox4);
            this.panelR3.Controls.Add(this.label10);
            this.panelR3.Controls.Add(this.label9);
            this.panelR3.Controls.Add(this.label8);
            this.panelR3.Controls.Add(this.label7);
            this.panelR3.Location = new System.Drawing.Point(300, 114);
            this.panelR3.Name = "panelR3";
            this.panelR3.Size = new System.Drawing.Size(154, 43);
            this.panelR3.TabIndex = 5;
            this.panelR3.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "U = (";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(61, 6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(10, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = ",";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(93, 6);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(10, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = ",";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(130, 6);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(10, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = ")";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(39, 3);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(19, 20);
            this.textBox4.TabIndex = 4;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(71, 3);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(16, 20);
            this.textBox5.TabIndex = 5;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(101, 3);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(23, 20);
            this.textBox6.TabIndex = 6;
            // 
            // FormAplicar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 318);
            this.Controls.Add(this.panelR3);
            this.Controls.Add(this.panelR2);
            this.Controls.Add(this.panelR);
            this.Controls.Add(this.comboBoxEspaco);
            this.Controls.Add(this.graficoAplicar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "FormAplicar";
            this.Text = "Aplicação de Transformação Linear";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormAplicar_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.graficoAplicar)).EndInit();
            this.panelR.ResumeLayout(false);
            this.panelR.PerformLayout();
            this.panelR2.ResumeLayout(false);
            this.panelR2.PerformLayout();
            this.panelR3.ResumeLayout(false);
            this.panelR3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart graficoAplicar;
        private System.Windows.Forms.ComboBox comboBoxEspaco;
        private System.Windows.Forms.Panel panelR;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelR2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panelR3;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
    }
}