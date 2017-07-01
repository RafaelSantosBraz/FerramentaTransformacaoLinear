using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacaoTransformacoesLineares
{
    public partial class FormInicial : Form
    {

        public FormInicial()
        {
            InitializeComponent();
        }

        private void FormInicial_Load(object sender, EventArgs e)
        {

        }

        private void Aplicar_Click(object sender, EventArgs e)
        {
            Init.Nucleo.TelaAplicar.Show();
            this.Visible = false;
        }

        private void botaoDescobrir_Click(object sender, EventArgs e)
        {
            Init.Nucleo.TelaDescobrir.Show();
            this.Visible = false;
        }

        private void FormInicial_FormClosing(object sender, FormClosingEventArgs e)
        {
            Init.Nucleo.TelaInit.Dispose();
        }
    }
}
