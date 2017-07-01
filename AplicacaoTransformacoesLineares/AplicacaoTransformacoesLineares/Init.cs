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
    public partial class Init : Form
    {
        static Controle nucleo;

        public Init()
        {
            Nucleo = new Controle(this);
            InitializeComponent();
            this.Opacity = 0;
            Nucleo.TelaInicial.Show();
        }

        public static Controle Nucleo { get => nucleo; set => nucleo = value; }
    }
}
