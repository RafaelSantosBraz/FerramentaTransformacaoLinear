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
    public partial class FormAplicar : Form
    {
        public FormAplicar()
        {
            InitializeComponent();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxEspaco_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void FormAplicar_FormClosing(object sender, FormClosingEventArgs e)
        {
            Init.Nucleo.TelaAplicar = new FormAplicar();
            Init.Nucleo.TelaInicial.Show();
        }

        private void comboBoxEspaco_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxEspacoOrigem.Text == "R")
            {
                graficoAplicar.Visible = true;
                label13.Visible = true;
                label11.Visible = true;
                label14.Visible = true;
                textBoxFunc.Visible = true;
                textBoxVetorResultante.Visible = true;
                panelR1.Visible = true;
                panelR2.Visible = false;
                panelR3.Visible = false;
            }
            if (comboBoxEspacoOrigem.Text == "R²")
            {
                graficoAplicar.Visible = true;
                label13.Visible = true;
                label11.Visible = true;
                label14.Visible = true;
                textBoxFunc.Visible = true;
                textBoxVetorResultante.Visible = true;

                panelR1.Visible = false;
                panelR2.Visible = true;
                panelR3.Visible = false;
            }
            if (comboBoxEspacoOrigem.Text == "R³")
            {
                graficoAplicar.Visible = true;
                label13.Visible = true;
                label11.Visible = true;
                label14.Visible = true;
                textBoxFunc.Visible = true;
                textBoxVetorResultante.Visible = true;

                panelR1.Visible = false;
                panelR2.Visible = false;
                panelR3.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Vetor u = new Vetor();
            u.X = 5;
            u.Y = 2;
            Vetor v = new Vetor();
            v.X = 1;
            v.Y = 2;
            Init.Nucleo.VerificarTransformacaoLinear("f(x,y)=2*x^2,x^2,x", u, v);
        }
    }
}
