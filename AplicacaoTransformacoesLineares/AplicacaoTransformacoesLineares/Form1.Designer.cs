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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInicial));
            this.botaoAplicar = new System.Windows.Forms.Button();
            this.botaoDescobrir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // botaoAplicar
            // 
            this.botaoAplicar.Location = new System.Drawing.Point(255, 230);
            this.botaoAplicar.Name = "botaoAplicar";
            this.botaoAplicar.Size = new System.Drawing.Size(141, 62);
            this.botaoAplicar.TabIndex = 0;
            this.botaoAplicar.Text = "Aplicar Transformação";
            this.botaoAplicar.UseVisualStyleBackColor = true;
            this.botaoAplicar.Click += new System.EventHandler(this.Aplicar_Click);
            // 
            // botaoDescobrir
            // 
            this.botaoDescobrir.Location = new System.Drawing.Point(402, 230);
            this.botaoDescobrir.Name = "botaoDescobrir";
            this.botaoDescobrir.Size = new System.Drawing.Size(141, 62);
            this.botaoDescobrir.TabIndex = 1;
            this.botaoDescobrir.Text = "Descobrir Transformação";
            this.botaoDescobrir.UseVisualStyleBackColor = true;
            this.botaoDescobrir.Click += new System.EventHandler(this.botaoDescobrir_Click);
            // 
            // FormInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 318);
            this.Controls.Add(this.botaoDescobrir);
            this.Controls.Add(this.botaoAplicar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "FormInicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ferramenta de Transformações Lineares - Braz e Ricordi";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormInicial_FormClosing);
            this.Load += new System.EventHandler(this.FormInicial_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button botaoAplicar;
        private System.Windows.Forms.Button botaoDescobrir;
    }
}

