namespace AplicacaoTransformacoesLineares
{
    partial class FormInicial
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Aplicar = new System.Windows.Forms.Button();
            this.Descobrir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Aplicar
            // 
            this.Aplicar.Location = new System.Drawing.Point(255, 230);
            this.Aplicar.Name = "Aplicar";
            this.Aplicar.Size = new System.Drawing.Size(141, 62);
            this.Aplicar.TabIndex = 0;
            this.Aplicar.Text = "Aplicar Transformação";
            this.Aplicar.UseVisualStyleBackColor = true;
            // 
            // Descobrir
            // 
            this.Descobrir.Location = new System.Drawing.Point(402, 230);
            this.Descobrir.Name = "Descobrir";
            this.Descobrir.Size = new System.Drawing.Size(141, 62);
            this.Descobrir.TabIndex = 1;
            this.Descobrir.Text = "Descobrir Transformação";
            this.Descobrir.UseVisualStyleBackColor = true;
            // 
            // FormInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 318);
            this.Controls.Add(this.Descobrir);
            this.Controls.Add(this.Aplicar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "FormInicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ferramenta de Transformações Lineares - Braz e Ricordi";
            this.Load += new System.EventHandler(this.FormInicial_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Aplicar;
        private System.Windows.Forms.Button Descobrir;
    }
}

