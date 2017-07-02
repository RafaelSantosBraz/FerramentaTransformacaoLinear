using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
            String[] d1 = funcao.Split('=');

            if (d1.Length != 2)
            {
                return false;
            }
            String[] d2 = d1[1].Split(',');
            if (d2.Length == 1)
            {
                if (d2[0].Contains('^'))
                {
                    
                }
            } else if (d2.Length == 2)
            {

            } else if (d2.Length == 3)
            {

            } else
            {
                return false;
            }
            return true;
        }
    }
}
