using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaDosAlunos
{
    public partial class Form1 : Form
    {
        CalculoDaMedia calcular = new CalculoDaMedia();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            calcular.setNota1(Convert.ToDouble(nota1.Text));
            calcular.setNota2(Convert.ToDouble(nota2.Text));
            calcular.setNota3(Convert.ToDouble(nota3.Text));
            calcular.setNota4(Convert.ToDouble(nota4.Text));

            calcular.fazerCalculoNotas();
            maiorN.Text = Convert.ToString(calcular.getMaiorNota());
            menorN.Text =Convert.ToString(calcular.getMenorNota());
            media.Text = Convert.ToString(calcular.getMedia());

        }

        private void button2_Click(object sender, EventArgs e)
        {
            nota1.Text = "";
            nota2.Text = "";
            nota3.Text = "";
            nota4.Text = "";
            media.Text = "";
            maiorN.Text = "";
            menorN.Text = "";
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            DialogResult result;
                result = MessageBox.Show("Tem certeza que deseja sair?", "Mensagem do Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
