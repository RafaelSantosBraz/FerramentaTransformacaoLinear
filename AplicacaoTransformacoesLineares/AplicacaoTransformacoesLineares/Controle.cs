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
            fU.Replace("x", (u.X).ToString());
            fU.Replace("y", (u.Y).ToString());
            fU.Replace("z", (u.Z).ToString());
            String[] d1 = funcao.Split('=');
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
                        String aux = "e " + d4[0] + " " + d4[1];
                        fU.Replace(d4[0] + "^" + d4[1], Math.Pow((Double.Parse(d4[0])), Double.Parse(d4[1])).ToString());
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
                            String aux = "e " + d4[0] + " " + d4[1];
                            fU.Replace(d4[0] + "^" + d4[1], Math.Pow((Double.Parse(d4[0])), Double.Parse(d4[1])).ToString());
                        }
                    }
                }
            }
            else
            {
                return false;
            }
            MessageBox.Show(fU, "AVISO");
                        return true;
        }
    }
}
