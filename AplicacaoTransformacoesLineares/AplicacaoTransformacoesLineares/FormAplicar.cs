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
            if (comboBoxEspaco.Text == "R")
            {
                panelR.Visible = true;
                //double result = Convert.ToDouble(new DataTable().Compute("1 + 2 * 7", null));
                panelR2.Visible = false;
                panelR3.Visible = false;
            }
            if (comboBoxEspaco.Text == "R²")
            {
                panelR.Visible = false;
                panelR2.Visible = true;
                panelR3.Visible = false;
            }
            if (comboBoxEspaco.Text == "R³")
            {
                panelR.Visible = false;
                panelR2.Visible = false;
                panelR3.Visible = true;
            }
        }
    }
}
