using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacaoTransformacoesLineares
{
    public class Controle
    {
        private Form telaAplicar;
        private Form telaDescobrir;
        private Form telaInicial;
        private Form telaInit;

        public Controle(Form i)
        {
            TelaAplicar = new FormAplicar();
            TelaDescobrir = new FormDescobrir();
            TelaInicial = new FormInicial();
            TelaInit = i;
        }

        public Form TelaAplicar { get => telaAplicar; set => telaAplicar = value; }
        public Form TelaDescobrir { get => telaDescobrir; set => telaDescobrir = value; }
        public Form TelaInicial { get => telaInicial; set => telaInicial = value; }
        public Form TelaInit { get => telaInit; set => telaInit = value; }

        public Boolean VerificarTransformacaoLinear(String funcao, Vetor u, Vetor v)
        {
            String fU = funcao;
            fU = fU.Replace("x", (u.X).ToString());
            fU = fU.Replace("y", (u.Y).ToString());
            fU = fU.Replace("z", (u.Z).ToString());
            String[] d1 = fU.Split('=');
            if (d1.Length != 2)
            {
                return false;
            }
            String[] d2 = d1[1].Split(',');
            if (d2.Length == 1)
            {
                String[] d3 = d2[0].Split("+-*/".ToCharArray());
                for (int c = 0; c < d3.Length; c++)
                {
                    if (d3[c].Contains("^"))
                    {
                        String[] d4 = d3[c].Split('^');
                        String exibir = d4[0];
                        String exibir2 = d4[1];
                        if (d4[0] == "x")
                        {
                            exibir = u.X.ToString();
                        }
                        else if (d4[0] == "y")
                        {
                            exibir = u.Y.ToString();
                        }
                        else if (d4[0] == "z")
                        {
                            exibir = u.Z.ToString();
                        }
                        if (d4[1] == "x")
                        {
                            exibir2 = u.X.ToString();
                        }
                        else if (d4[1] == "y")
                        {
                            exibir2 = u.Y.ToString();
                        }
                        else if (d4[1] == "z")
                        {
                            exibir2 = u.Z.ToString();
                        }
                        fU = fU.Replace(d4[0] + "^" + d4[1], Math.Pow((Double.Parse(exibir)), Double.Parse(exibir2)).ToString());
                    }
                }
            }
            else if (d2.Length == 2 || d2.Length == 3)
            {
                for (int i = 0; i < d2.Length; i++)
                {
                    String[] d3 = d2[i].Split("+-*/".ToCharArray());
                    for (int c = 0; c < d3.Length; c++)
                    {
                        if (d3[c].Contains("^"))
                        {
                            String[] d4 = d3[c].Split('^');
                            String exibir = d4[0];
                            String exibir2 = d4[1];
                            if (d4[0] == "x")
                            {
                                exibir = u.X.ToString();
                            }
                            else if (d4[0] == "y")
                            {
                                exibir = u.Y.ToString();
                            }
                            else if (d4[0] == "z")
                            {
                                exibir = u.Z.ToString();
                            }
                            if (d4[1] == "x")
                            {
                                exibir2 = u.X.ToString();
                            }
                            else if (d4[1] == "y")
                            {
                                exibir2 = u.Y.ToString();
                            }
                            else if (d4[1] == "z")
                            {
                                exibir2 = u.Z.ToString();
                            }
                            fU = fU.Replace(d4[0] + "^" + d4[1], Math.Pow((Double.Parse(exibir)), Double.Parse(exibir2)).ToString());
                        }
                    }
                }
            }
            else
            {
                return false;
            }
            String fV = funcao;
            fV = fV.Replace("x", (v.X).ToString());
            fV = fV.Replace("y", (v.Y).ToString());
            fV = fV.Replace("z", (v.Z).ToString());
            String[] d5 = fV.Split('=');
            if (d5.Length != 2)
            {
                return false;
            }
            String[] d6 = d5[1].Split(',');
            if (d6.Length == 1)
            {
                String[] d7 = d6[0].Split("+-*/".ToCharArray());
                for (int c = 0; c < d7.Length; c++)
                {
                    if (d7[c].Contains("^"))
                    {
                        String[] d8 = d7[c].Split('^');
                        String exibir = d8[0];
                        String exibir2 = d8[1];
                        if (d8[0] == "x")
                        {
                            exibir = v.X.ToString();
                        }
                        else if (d8[0] == "y")
                        {
                            exibir = v.Y.ToString();
                        }
                        else if (d8[0] == "z")
                        {
                            exibir = v.Z.ToString();
                        }
                        if (d8[1] == "x")
                        {
                            exibir2 = v.X.ToString();
                        }
                        else if (d8[1] == "y")
                        {
                            exibir2 = v.Y.ToString();
                        }
                        else if (d8[1] == "z")
                        {
                            exibir2 = v.Z.ToString();
                        }
                        fV = fV.Replace(d8[0] + "^" + d8[1], Math.Pow((Double.Parse(exibir)), Double.Parse(exibir2)).ToString());
                    }
                }
            }
            else if (d6.Length == 2 || d6.Length == 3)
            {
                for (int i = 0; i < d6.Length; i++)
                {
                    String[] d7 = d6[i].Split("+-*/".ToCharArray());
                    for (int c = 0; c < d7.Length; c++)
                    {
                        if (d7[c].Contains("^"))
                        {
                            String[] d8 = d7[c].Split('^');
                            String exibir = d8[0];
                            String exibir2 = d8[1];
                            if (d8[0] == "x")
                            {
                                exibir = v.X.ToString();
                            }
                            else if (d8[0] == "y")
                            {
                                exibir = v.Y.ToString();
                            }
                            else if (d8[0] == "z")
                            {
                                exibir = v.Z.ToString();
                            }
                            if (d8[1] == "x")
                            {
                                exibir2 = v.X.ToString();
                            }
                            else if (d8[1] == "y")
                            {
                                exibir2 = v.Y.ToString();
                            }
                            else if (d8[1] == "z")
                            {
                                exibir2 = v.Z.ToString();
                            }
                            fV = fV.Replace(d8[0] + "^" + d8[1], Math.Pow((Double.Parse(exibir)), Double.Parse(exibir2)).ToString());
                        }
                    }
                }
            }
            else
            {
                return false;
            }
            double result = Convert.ToDouble(new DataTable().Compute("", null));
            MessageBox.Show(fU, "AVISO");
            MessageBox.Show(fV, "AVISO");
            return true;
        }
    }
}
