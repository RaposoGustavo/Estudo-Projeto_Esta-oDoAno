using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_EstaçãoDoAno
{
    public partial class Frm_Estacoes: Form
    {
        public Frm_Estacoes()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Pic_Image.Image = Properties.Resources.img_primavera;
            Txt_resultado.Text = "Primavera a estação das flores / Set-Dez";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Pic_Image.Image = Properties.Resources.img_verao;
            Txt_resultado.Text = "Verão a estação quente / Dez-Mar";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            Pic_Image.Image = Properties.Resources.img_outono;
            Txt_resultado.Text = "Outono a estação das frutas / Mar-Jun";
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            Pic_Image.Image = Properties.Resources.img_inverno;
            Txt_resultado.Text = "Inverno a estação fria / Jun-Set";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Txt_resultado_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
