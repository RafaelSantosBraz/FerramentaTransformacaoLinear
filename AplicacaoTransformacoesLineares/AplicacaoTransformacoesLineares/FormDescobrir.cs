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
            graficoAplicar.Series[0].Points.AddXY(10, 10);
        }

        private void FormDescobrir_FormClosing(object sender, FormClosingEventArgs e)
        {
            Init.Nucleo.TelaDescobrir = new FormDescobrir();
            Init.Nucleo.TelaInicial.Show();
        }

        private void comboBoxEspacoOrigem_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBoxEspacoDestino_SelectedIndexChanged(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
            panel7.Visible = false;
            panel8.Visible = false;
            panel9.Visible = false;
            if (comboBoxEspacoDestino.Text == "R->R")
            {
                panel1.Visible = true;
            }
            else if (comboBoxEspacoDestino.Text == "R->R²")
            {
                panel2.Visible = true;
            }
            else if (comboBoxEspacoDestino.Text == "R->R³")
            {
                panel3.Visible = true;
            }
            else if (comboBoxEspacoDestino.Text == "R²->R")
            {
                panel4.Visible = true;
            }
            else if (comboBoxEspacoDestino.Text == "R²->R²")
            {
                panel5.Visible = true;
            }
            else if (comboBoxEspacoDestino.Text == "R²->R³")
            {
                panel6.Visible = true;
            }
            else if (comboBoxEspacoDestino.Text == "R³->R")
            {
                panel7.Visible = true;
            }
            else if (comboBoxEspacoDestino.Text == "R³->R²")
            {
                panel8.Visible = true;
            }
            else if (comboBoxEspacoDestino.Text == "R³->R³")
            {
                panel9.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            graficoAplicar.Series[0].Points.Clear();
            graficoAplicar.Series[1].Points.Clear();
            graficoAplicar.Series[2].Points.Clear();
            Vetor u = new Vetor(), v = new Vetor(), w = new Vetor();
            String funcaoU = "";
            String funcaoV = "";
            String funcaoW = "";
            String funcao = "";
            if (comboBoxEspacoDestino.Text == "R->R")
            {
                if (textBox7.Text == "")
                {
                    MessageBox.Show("Todos os campos devem ser preenchidos!", "AVISO");
                    return;
                }
                else
                {
                    double aux;
                    if (Double.TryParse(textBox7.Text, out aux))
                    {
                        u = new Vetor(Double.Parse(textBox7.Text), 0, 0);
                    }
                    else
                    {
                        MessageBox.Show("Entrada fora do padrão esperado!", "AVISO");
                        return;
                    }
                }
            }
            else if (comboBoxEspacoDestino.Text == "R->R²")
            {
                if (textBox18.Text == "" || textBox17.Text == "")
                {
                    MessageBox.Show("Todos os campos devem ser preenchidos!", "AVISO");
                    return;
                }
                else
                {
                    double aux, aux2;
                    if (!Double.TryParse(textBox18.Text, out aux) || !Double.TryParse(textBox17.Text, out aux2))
                    {
                        MessageBox.Show("Entrada fora do padrão esperado!", "AVISO");
                        return;
                    }
                    u = new Vetor(Double.Parse(textBox18.Text), Double.Parse(textBox17.Text), 0);
                    graficoAplicar.Series[0].Points.AddXY(0, 0);
                    graficoAplicar.Series[0].Points.AddXY(u.X, u.Y);
                }
            }
            else if (comboBoxEspacoDestino.Text == "R->R³")
            {
                if (textBox25.Text == "" || textBox24.Text == "" || textBox23.Text == "")
                {
                    MessageBox.Show("Todos os campos devem ser preenchidos!", "AVISO");
                    return;
                }
                else
                {
                    double aux, aux2;
                    if (!Double.TryParse(textBox25.Text, out aux) || !Double.TryParse(textBox24.Text, out aux2) || !Double.TryParse(textBox23.Text, out aux2))
                    {
                        MessageBox.Show("Entrada fora do padrão esperado!", "AVISO");
                        return;
                    }
                    u = new Vetor(Double.Parse(textBox25.Text), Double.Parse(textBox24.Text), Double.Parse(textBox23.Text));
                }
            }
            else if (comboBoxEspacoDestino.Text == "R²->R")
            {
                if (textBox15.Text == "" || textBox16.Text == "")
                {
                    MessageBox.Show("Todos os campos devem ser preenchidos!", "AVISO");
                    return;
                }
                else
                {
                    double aux, aux2;
                    if (!Double.TryParse(textBox15.Text, out aux) || !Double.TryParse(textBox16.Text, out aux2))
                    {
                        MessageBox.Show("Entrada fora do padrão esperado!", "AVISO");
                        return;
                    }
                    u = new Vetor(Double.Parse(textBox15.Text), 0, 0);
                    v = new Vetor(Double.Parse(textBox16.Text), 0, 0);
                }
            }
            else if (comboBoxEspacoDestino.Text == "R²->R²")
            {
                if (textBox2.Text == "" || textBox1.Text == "" || textBox8.Text == "" || textBox9.Text == "")
                {
                    MessageBox.Show("Todos os campos devem ser preenchidos!", "AVISO");
                    return;
                }
                else
                {
                    double aux, aux2;
                    if (!Double.TryParse(textBox2.Text, out aux) || !Double.TryParse(textBox1.Text, out aux2) || !Double.TryParse(textBox8.Text, out aux2) || !Double.TryParse(textBox9.Text, out aux2))
                    {
                        MessageBox.Show("Entrada fora do padrão esperado!", "AVISO");
                        return;
                    }
                    u = new Vetor(Double.Parse(textBox2.Text), Double.Parse(textBox1.Text), 0);
                    v = new Vetor(Double.Parse(textBox8.Text), Double.Parse(textBox9.Text), 0);
                }
            }
            else if (comboBoxEspacoDestino.Text == "R²->R³")
            {
                if (textBox30.Text == "" || textBox29.Text == "" || textBox28.Text == "" || textBox27.Text == "" || textBox26.Text == "" || textBox22.Text == "")
                {
                    MessageBox.Show("Todos os campos devem ser preenchidos!", "AVISO");
                    return;
                }
                else
                {
                    double aux, aux2;
                    if (!Double.TryParse(textBox30.Text, out aux) || !Double.TryParse(textBox29.Text, out aux2) || !Double.TryParse(textBox28.Text, out aux2) || !Double.TryParse(textBox27.Text, out aux2) || !Double.TryParse(textBox26.Text, out aux2) || !Double.TryParse(textBox22.Text, out aux2))
                    {
                        MessageBox.Show("Entrada fora do padrão esperado!", "AVISO");
                        return;
                    }
                    u = new Vetor(Double.Parse(textBox30.Text), Double.Parse(textBox29.Text), Double.Parse(textBox28.Text));
                    v = new Vetor(Double.Parse(textBox27.Text), Double.Parse(textBox26.Text), Double.Parse(textBox22.Text));
                }
            }
            else if (comboBoxEspacoDestino.Text == "R³->R")
            {
                if (textBox19.Text == "" || textBox20.Text == "" || textBox21.Text == "")
                {
                    MessageBox.Show("Todos os campos devem ser preenchidos!", "AVISO");
                    return;
                }
                else
                {
                    double aux, aux2;
                    if (!Double.TryParse(textBox19.Text, out aux) || !Double.TryParse(textBox20.Text, out aux2) || !Double.TryParse(textBox21.Text, out aux2))
                    {
                        MessageBox.Show("Entrada fora do padrão esperado!", "AVISO");
                        return;
                    }
                    u = new Vetor(Double.Parse(textBox19.Text), 0, 0);
                    v = new Vetor(Double.Parse(textBox20.Text), 0, 0);
                    w = new Vetor(Double.Parse(textBox21.Text), 0, 0);
                }
            }
            else if (comboBoxEspacoDestino.Text == "R³->R²")
            {
                if (textBox32.Text == "" || textBox31.Text == "" || textBox34.Text == "" || textBox33.Text == "" || textBox36.Text == "" || textBox35.Text == "")
                {
                    MessageBox.Show("Todos os campos devem ser preenchidos!", "AVISO");
                    return;
                }
                else
                {
                    double aux, aux2;
                    if (!Double.TryParse(textBox32.Text, out aux) || !Double.TryParse(textBox31.Text, out aux2) || !Double.TryParse(textBox34.Text, out aux2) || !Double.TryParse(textBox33.Text, out aux2) || !Double.TryParse(textBox36.Text, out aux2) || !Double.TryParse(textBox35.Text, out aux2))
                    {
                        MessageBox.Show("Entrada fora do padrão esperado!", "AVISO");
                        return;
                    }
                    u = new Vetor(Double.Parse(textBox32.Text), Double.Parse(textBox31.Text), 0);
                    v = new Vetor(Double.Parse(textBox34.Text), Double.Parse(textBox33.Text), 0);
                    w = new Vetor(Double.Parse(textBox36.Text), Double.Parse(textBox35.Text), 0);
                }
            }
            else if (comboBoxEspacoDestino.Text == "R³->R³")
            {
                if (textBox14.Text == "" || textBox13.Text == "" || textBox6.Text == "" || textBox10.Text == "" || textBox11.Text == "" || textBox12.Text == "" || textBox5.Text == "" || textBox4.Text == "" || textBox3.Text == "")
                {
                    MessageBox.Show("Todos os campos devem ser preenchidos!", "AVISO");
                    return;
                }
                else
                {
                    double aux, aux2;
                    if (!Double.TryParse(textBox14.Text, out aux) || !Double.TryParse(textBox13.Text, out aux2) || !Double.TryParse(textBox6.Text, out aux2) || !Double.TryParse(textBox10.Text, out aux2) || !Double.TryParse(textBox11.Text, out aux2) || !Double.TryParse(textBox12.Text, out aux2) || !Double.TryParse(textBox5.Text, out aux2) || !Double.TryParse(textBox4.Text, out aux2) || !Double.TryParse(textBox3.Text, out aux2))
                    {
                        MessageBox.Show("Entrada fora do padrão esperado!", "AVISO");
                        return;
                    }
                    u = new Vetor(Double.Parse(textBox14.Text), Double.Parse(textBox13.Text), Double.Parse(textBox6.Text));
                    v = new Vetor(Double.Parse(textBox10.Text), Double.Parse(textBox11.Text), Double.Parse(textBox12.Text));
                    w = new Vetor(Double.Parse(textBox5.Text), Double.Parse(textBox4.Text), Double.Parse(textBox3.Text));
                }
            }
            else
            {
                MessageBox.Show("Selecione os espaços e preencha o(s) vetor(es)!", "AVISO");
                return;
            }
            for (int c = 0; c < 3; c++)
            {
                if (c == 0)
                {
                    for (int i = 0; i < 3; i++)
                    {
                        if (i == 0)
                        {
                            if (u.X == 0)
                            {
                                funcaoU += "0";
                            }
                            else if (u.X == 1)
                            {
                                funcaoU += "x";
                            }
                            else
                            {
                                funcaoU += u.X + "*x";
                            }
                            funcaoU += ",";
                        }
                        else if (i == 1)
                        {
                            if (u.Y == 0)
                            {
                                funcaoU += "0";
                            }
                            else if (u.Y == 1)
                            {
                                funcaoU += "x";
                            }
                            else
                            {
                                funcaoU += u.Y + "*x";
                            }
                            funcaoU += ",";
                        }
                        else
                        {
                            if (u.Z == 0)
                            {
                                funcaoU += "0";
                            }
                            else if (u.Z == 1)
                            {
                                funcaoU += "x";
                            }
                            else
                            {
                                funcaoU += u.Z + "*x";
                            }
                        }
                    }
                }
                else if (c == 1)
                {
                    for (int i = 0; i < 3; i++)
                    {
                        if (i == 0)
                        {
                            if (v.X == 0)
                            {
                                funcaoV += "0";
                            }
                            else if (v.X == 1)
                            {
                                funcaoV += "y";
                            }
                            else
                            {
                                funcaoV += v.X + "*y";
                            }
                            funcaoV += ",";
                        }
                        else if (i == 1)
                        {
                            if (v.Y == 0)
                            {
                                funcaoV += "0";
                            }
                            else if (v.Y == 1)
                            {
                                funcaoV += "y";
                            }
                            else
                            {
                                funcaoV += v.Y + "*y";
                            }
                            funcaoV += ",";
                        }
                        else
                        {
                            if (v.Z == 0)
                            {
                                funcaoV += "0";
                            }
                            else if (v.Z == 1)
                            {
                                funcaoV += "y";
                            }
                            else
                            {
                                funcaoV += v.Z + "*y";
                            }
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < 3; i++)
                    {
                        if (i == 0)
                        {
                            if (w.X == 0)
                            {
                                funcaoW += "0";
                            }
                            else if (w.X == 1)
                            {
                                funcaoW += "z";
                            }
                            else
                            {
                                funcaoW += w.X + "*z";
                            }
                            funcaoW += ",";
                        }
                        else if (i == 1)
                        {
                            if (w.Y == 0)
                            {
                                funcaoW += "0";
                            }
                            else if (w.Y == 1)
                            {
                                funcaoW += "z";
                            }
                            else
                            {
                                funcaoW += w.Y + "*z";
                            }
                            funcaoW += ",";
                        }
                        else
                        {
                            if (w.Z == 0)
                            {
                                funcaoW += "0";
                            }
                            else if (w.Z == 1)
                            {
                                funcaoW += "z";
                            }
                            else
                            {
                                funcaoW += w.Z + "*z";
                            }
                        }
                    }
                }
            }
            String[] fu = funcaoU.Split(',');
            String[] fv = funcaoV.Split(',');
            String[] fw = funcaoW.Split(',');

            if (comboBoxEspacoDestino.Text == "R->R" || comboBoxEspacoDestino.Text == "R²->R" || comboBoxEspacoDestino.Text == "R³->R")
            {
                funcao = "T=(" + fu[0] + "+" + fv[0] + "+" + fw[0] + ")";
            }
            else if (comboBoxEspacoDestino.Text == "R->R²" || comboBoxEspacoDestino.Text == "R²->R²" || comboBoxEspacoDestino.Text == "R³->R²")
            {
                funcao = "T=(";
                for (int c = 0; c < 2; c++)
                {
                    funcao += fu[c] + "+" + fv[c] + "+" + fw[c];
                    if (c == 0)
                    {
                        funcao += ",";
                    }
                }
                funcao += ")";
            }
            else if (comboBoxEspacoDestino.Text == "R->R³" || comboBoxEspacoDestino.Text == "R²->R³" || comboBoxEspacoDestino.Text == "R³->R³")
            {
                funcao = "T=(";
                for (int c = 0; c < 3; c++)
                {
                    funcao += fu[c] + "+" + fv[c] + "+" + fw[c];
                    if (c == 0 || c == 1)
                    {
                        funcao += ",";
                    }
                }
                funcao += ")";
            }
            funcao = funcao.Replace("+0", "");
            funcao = funcao.Replace("0+", "");
            funcao = funcao.Replace("-1*", "-");
            funcao = funcao.Replace("+-", "-");
            funcao = funcao.Replace("*", "");
            textBoxFunc.Text = funcao;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Init.Nucleo.TelaDescobrir = new FormDescobrir();
            Init.Nucleo.TelaDescobrir.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Init.Nucleo.TelaInicial.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Init.Nucleo.TelaInit.Dispose();
        }
    }
}
