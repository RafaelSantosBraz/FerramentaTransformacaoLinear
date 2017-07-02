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
            int k = 2;
            String fU = "";
            Vetor fDU = new Vetor();
            Vetor fDV = new Vetor();
            Vetor uMaisV = new Vetor(u.X + v.X, u.Y + v.Y, u.Z + v.Z);
            Vetor fDuMaisV = new Vetor();
            Vetor fDKV = new Vetor();
            Vetor kV = new Vetor(k * v.X, k * v.Y, k * v.Z);
            for (int j = 0; j < 4; j++)
            {
                Vetor atual;
                if (j == 0)
                {
                    atual = new Vetor(u.X, u.Y, u.Z);
                }
                else if (j == 1)
                {
                    atual = new Vetor(v.X, v.Y, v.Z);
                }
                else if (j == 2)
                {
                    atual = new Vetor(uMaisV.X, uMaisV.Y, uMaisV.Z);
                }
                else
                {
                    atual = new Vetor(kV.X, kV.Y, kV.Z);
                }
                fU = funcao;
                fU = fU.Replace("x", (atual.X).ToString());
                fU = fU.Replace("y", (atual.Y).ToString());
                fU = fU.Replace("z", (atual.Z).ToString());
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
                                exibir = atual.X.ToString();
                            }
                            else if (d4[0] == "y")
                            {
                                exibir = atual.Y.ToString();
                            }
                            else if (d4[0] == "z")
                            {
                                exibir = atual.Z.ToString();
                            }
                            if (d4[1] == "x")
                            {
                                exibir2 = atual.X.ToString();
                            }
                            else if (d4[1] == "y")
                            {
                                exibir2 = atual.Y.ToString();
                            }
                            else if (d4[1] == "z")
                            {
                                exibir2 = atual.Z.ToString();
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
                                    exibir = atual.X.ToString();
                                }
                                else if (d4[0] == "y")
                                {
                                    exibir = atual.Y.ToString();
                                }
                                else if (d4[0] == "z")
                                {
                                    exibir = atual.Z.ToString();
                                }
                                if (d4[1] == "x")
                                {
                                    exibir2 = atual.X.ToString();
                                }
                                else if (d4[1] == "y")
                                {
                                    exibir2 = atual.Y.ToString();
                                }
                                else if (d4[1] == "z")
                                {
                                    exibir2 = atual.Z.ToString();
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
                String[] d5 = fU.Split('=');
                String[] d6 = d5[1].Split(',');
                if (j == 0)
                {
                    for (int c = 0; c < d6.Length; c++)
                    {
                        if (c == 0)
                        {
                            fDU.X = Convert.ToDouble(new DataTable().Compute(d6[c], null));
                        }
                        else if (c == 1)
                        {
                            fDU.Y = Convert.ToDouble(new DataTable().Compute(d6[c], null));
                        }
                        else if (c == 2)
                        {
                            fDU.Z = Convert.ToDouble(new DataTable().Compute(d6[c], null));
                        }
                    }
                }
                else if (j == 1)
                {
                    for (int c = 0; c < d6.Length; c++)
                    {
                        if (c == 0)
                        {
                            fDV.X = Convert.ToDouble(new DataTable().Compute(d6[c], null));
                        }
                        else if (c == 1)
                        {
                            fDV.Y = Convert.ToDouble(new DataTable().Compute(d6[c], null));
                        }
                        else if (c == 2)
                        {
                            fDV.Z = Convert.ToDouble(new DataTable().Compute(d6[c], null));
                        }
                    }
                }
                else if (j == 2)
                {
                    for (int c = 0; c < d6.Length; c++)
                    {
                        if (c == 0)
                        {
                            fDuMaisV.X = Convert.ToDouble(new DataTable().Compute(d6[c], null));
                        }
                        else if (c == 1)
                        {
                            fDuMaisV.Y = Convert.ToDouble(new DataTable().Compute(d6[c], null));
                        }
                        else if (c == 2)
                        {
                            fDuMaisV.Z = Convert.ToDouble(new DataTable().Compute(d6[c], null));
                        }
                    }
                }
                else
                {
                    for (int c = 0; c < d6.Length; c++)
                    {
                        if (c == 0)
                        {
                            fDKV.X = Convert.ToDouble(new DataTable().Compute(d6[c], null));
                        }
                        else if (c == 1)
                        {
                            fDKV.Y = Convert.ToDouble(new DataTable().Compute(d6[c], null));
                        }
                        else if (c == 2)
                        {
                            fDKV.Z = Convert.ToDouble(new DataTable().Compute(d6[c], null));
                        }
                    }
                }
            }
            Vetor fDUMaisFV = new Vetor(fDU.X + fDV.X, fDU.Y + fDV.Y, fDU.Z + fDV.Z);
            Vetor kVezesFDV = new Vetor(k * fDV.X, k * fDV.Y, k * fDV.Z);
            if (fDUMaisFV.X != fDuMaisV.X || fDUMaisFV.Y != fDuMaisV.Y || fDUMaisFV.Z != fDuMaisV.Z)
            {
                return false;
            }
            if (fDKV.X != kVezesFDV.X || fDKV.Y != kVezesFDV.Y || fDKV.Z != kVezesFDV.Z)
            {
                return false;
            }
            return true;
        }
    }
}

