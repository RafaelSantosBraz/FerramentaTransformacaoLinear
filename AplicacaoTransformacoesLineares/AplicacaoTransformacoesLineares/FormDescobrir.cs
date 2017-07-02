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
            if (comboBoxEspacoDestino.Text == "R")
            {
                panel1.Visible = true;
                panel2.Visible = false;
                panel22.Visible = false;
                panel3.Visible = false;
                panel32.Visible = false;
                panel33.Visible = false;
            }
            if (comboBoxEspacoDestino.Text == "R²")
            {
                panel1.Visible = false;
                panel2.Visible = true;
                panel22.Visible = true;
                panel3.Visible = false;
                panel32.Visible = false;
                panel33.Visible = false;
            }
            if (comboBoxEspacoDestino.Text == "R³")
            {
                panel1.Visible = false;
                panel2.Visible = false;
                panel22.Visible = false;
                panel3.Visible = true;
                panel32.Visible = true;
                panel33.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Vetor u = new Vetor(), v = new Vetor(), w = new Vetor();
            String funcaoU = "";
            String funcaoV = "";
            String funcaoW = "";
            String funcao = "";
            if (comboBoxEspacoDestino.Text == "R")
            {
                u = new Vetor(Double.Parse(textBox7.Text), 0, 0);
            }
            else if (comboBoxEspacoDestino.Text == "R²")
            {
                u = new Vetor(Double.Parse(textBox2.Text), Double.Parse(textBox1.Text), 0);
                v = new Vetor(Double.Parse(textBox8.Text), Double.Parse(textBox9.Text), 0);
            }
            else if (comboBoxEspacoDestino.Text == "R³")
            {
                u = new Vetor(Double.Parse(textBox14.Text), Double.Parse(textBox13.Text), Double.Parse(textBox6.Text));
                v = new Vetor(Double.Parse(textBox10.Text), Double.Parse(textBox11.Text), Double.Parse(textBox12.Text));
                w = new Vetor(Double.Parse(textBox5.Text), Double.Parse(textBox4.Text), Double.Parse(textBox3.Text));
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
                                funcaoU += "y";
                            }
                            else
                            {
                                funcaoU += u.Y + "*y";
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
                                funcaoU += "z";
                            }
                            else
                            {
                                funcaoU += u.Z + "*Z";
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
                                funcaoV += "x";
                            }
                            else
                            {
                                funcaoV += v.X + "*x";
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
                                funcaoV += "z";
                            }
                            else
                            {
                                funcaoV += v.Z + "*Z";
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
                                funcaoW += "x";
                            }
                            else
                            {
                                funcaoW += w.X + "*x";
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
                                funcaoW += "y";
                            }
                            else
                            {
                                funcaoW += w.Y + "*y";
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
                                funcaoW += w.Z + "*Z";
                            }
                        }
                    }
                }
            }
            String[] fu = funcaoU.Split(',');
            String[] fv = funcaoU.Split(',');
            String[] fw = funcaoU.Split(',');

            if (comboBoxEspacoDestino.Text == "R")
            {
                funcao = "T=(" + fu[0] + ")";
            }
            else if (comboBoxEspacoDestino.Text == "R²")
            {
                funcao = "T=(";
                for (int c = 0; c < 2; c++)
                {
                    funcao += fu[c] + "+" + fv[c];
                    if (c == 0)
                    {
                        funcao += ",";
                    }
                }
                funcao += ")";
            }
            else 
            {
                funcao = "T=(";
                for (int c = 0; c < 2; c++)
                {
                    funcao += fu[c] + "+" + fv[c];
                    if (c == 0)
                    {
                        funcao += ",";
                    }
                }
                funcao += ")";
            }

        }
    }
}
