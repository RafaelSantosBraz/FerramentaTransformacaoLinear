using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacaoTransformacoesLineares
{
    public class Vetor
    {
        
        private double x;
        private double y;
        private double z;
        public Vetor()
        {
            X = 0.0;
            Y = 0.0;
            Z = 0.0;        
        }

        public Vetor(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public double X { get => x; set => x = value; }
        public double Y { get => y; set => y = value; }
        public double Z { get => z; set => z = value; }
    }
}
