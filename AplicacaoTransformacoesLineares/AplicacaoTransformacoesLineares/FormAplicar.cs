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
            graficoAplicar.Series[0].Points.AddXY(10, 10);
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
                panelR1.Visible = true;
                panelR2.Visible = false;
                panelR3.Visible = false;
            }
            if (comboBoxEspacoOrigem.Text == "R²")
            {
                panelR1.Visible = false;
                panelR2.Visible = true;
                panelR3.Visible = false;
            }
            if (comboBoxEspacoOrigem.Text == "R³")
            {
                panelR1.Visible = false;
                panelR2.Visible = false;
                panelR3.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Vetor u;
            Vetor v;
            if (comboBoxEspacoOrigem.Text == "R")
            {
                if (textBox1.Text == "" || textBoxFunc.Text == "")
                {
                    MessageBox.Show("Todos os campos devem ser preenchidos!", "AVISO");
                    return;
                }
                else
                {
                    double aux;
                    if (Double.TryParse(textBox1.Text, out aux))
                    {
                        u = new Vetor(aux, 0, 0);
                    }
                    else
                    {
                        MessageBox.Show("Entrada fora do padrão esperado!", "AVISO");
                        return;
                    }
                }
            }
            else if (comboBoxEspacoOrigem.Text == "R²")
            {
                if (textBox2.Text == "" || textBox3.Text == "" || textBoxFunc.Text == "")
                {
                    MessageBox.Show("Todos os campos devem ser preenchidos!", "AVISO");
                    return;
                }
                else
                {
                    double aux, aux2;
                    if (!Double.TryParse(textBox2.Text, out aux) || !Double.TryParse(textBox3.Text, out aux2))
                    {
                        MessageBox.Show("Entrada fora do padrão esperado!", "AVISO");
                        return;
                    }
                    u = new Vetor(aux, aux2, 0);
                }
            }
            else if (comboBoxEspacoOrigem.Text == "R³")
            {
                if (textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "" || textBoxFunc.Text == "")
                {
                    MessageBox.Show("Todos os campos devem ser preenchidos!", "AVISO");
                    return;
                }
                else
                {
                    double aux, aux2, aux3;
                    if (!Double.TryParse(textBox4.Text, out aux) || !Double.TryParse(textBox5.Text, out aux2) || !Double.TryParse(textBox6.Text, out aux3))
                    {
                        MessageBox.Show("Entrada fora do padrão esperado!", "AVISO");
                        return;
                    }
                    u = new Vetor(aux, aux2, aux3);
                }
            }
            else
            {
                MessageBox.Show("Selecione o espaço e preencha o vetor!", "AVISO");
                return;
            }
            Boolean resultado = Init.Nucleo.VerificarTransformacaoLinear(textBoxFunc.Text, u, new Vetor(u.X + 1, u.Y + 1, u.Z + 1));
            if (!resultado)
            {
                MessageBox.Show("A função informada NÃO é Transformação Linear!", "AVISO");
            }
            Vetor resultante = Init.Nucleo.aplicarTransformacaoLinear(textBoxFunc.Text, u);
            if (Init.Nucleo.verificarEspaco(textBoxFunc.Text) == 1)
            {
                textBoxVetorResultante.Text = "f(r)=(" + resultante.X + ")";
            }
            else if (Init.Nucleo.verificarEspaco(textBoxFunc.Text) == 2)
            {
                graficoAplicar.Series[0].Points.Clear();
                textBoxVetorResultante.Text = "f(r)=(" + resultante.X + "," + resultante.Y + ")";
                graficoAplicar.Series[0].Points.AddXY(0, 0);
                graficoAplicar.Series[0].Points.AddXY(u.X, u.Y);
                graficoAplicar.Series.Add("r");
                graficoAplicar.Series[1].ChartType = graficoAplicar.Series[0].ChartType;
                graficoAplicar.Series[1].BorderWidth = 5;
                graficoAplicar.Series[1].Points.AddXY(0, 0);
                graficoAplicar.Series[1].Points.AddXY(resultante.X, resultante.Y);
            }
            else
            {
                textBoxVetorResultante.Text = "f(r)=(" + resultante.X + "," + resultante.Y + "," + resultante.Z + ")";
            }
        }
    }
}
