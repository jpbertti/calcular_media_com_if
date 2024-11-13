using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Deseja realmente sair?", "Sair", MessageBoxButtons.YesNo) == DialogResult.Yes)
                Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtNota1.Clear();
            txtNota2.Clear();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double nota1, nota2, media;
            string aluno;
            aluno = txtNome.Text;
            nota1 = double.Parse(txtNota1.Text);
            nota2 = double.Parse(txtNota2.Text);
            media = (nota1 + nota2) / 2;
            if (media >= 6)
            {
                MessageBox.Show(aluno + " foi aprovado(a) com média " + media);
            }
                else
                MessageBox.Show(aluno + " foi reprovado(a) com média " + media);

        } 
    }
}
