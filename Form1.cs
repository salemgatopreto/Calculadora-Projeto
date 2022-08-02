using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        
        bool Cliquenooperador = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void Numero_Click(object sender, EventArgs e)
        {
           var btnClicado = sender as Button;
            txtTela.Text += btnClicado.Text;

            Cliquenooperador = false;
        }
        private void Operacao_Click(object sender, EventArgs e)
        {
            var btnClicado = sender as Button;
            
            if (Cliquenooperador == false)
            {
                txtTela.Text += btnClicado.Text;
                Cliquenooperador = true;
            }
            
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            if(txtTela.Text.Length == 0)
            {
                MessageBox.Show("O campo está vazio.");
            }
            else
            {
                DataTable dt = new DataTable();
                string expressao = txtTela.Text.ToString().Replace(",", ".");
                var v = dt.Compute(expressao, "");
                txtTela.Text = v.ToString();

            }
            
        }
    }
}
