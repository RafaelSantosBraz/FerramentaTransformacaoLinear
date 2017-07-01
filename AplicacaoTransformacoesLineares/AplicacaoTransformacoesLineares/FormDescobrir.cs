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
    public partial class FormDescobrir : Form
    {
        public FormDescobrir()
        {
            InitializeComponent();
        }

        private void FormDescobrir_FormClosing(object sender, FormClosingEventArgs e)
        {
            Init.Nucleo.TelaDescobrir = new FormDescobrir();
            Init.Nucleo.TelaInicial.Show();
        }
    }
}
