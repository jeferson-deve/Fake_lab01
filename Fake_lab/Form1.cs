using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
//using System.Text;

namespace Fake_lab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void textBox21_TextChanged(object sender, EventArgs e){}
        private void label3_Click(object sender, EventArgs e){}

        private void confirguraçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Configura tes = new Configura();            
            tes.Show();
        }

        public void salvar(string resultado)
        {
            StreamWriter arquivo = new StreamWriter("calculo.txt", true);
            arquivo.WriteLine(resultado);
            arquivo.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //calculo de Acido..
            Calculos calculo = new Calculos();
            Random sort = new Random();
            double fator = Properties.Settings.Default.Fat_soda;
            Int32 quantidade = Convert.ToInt32(Qtd_acido.Text);

            decimal minimo = Convert.ToDecimal(Min_acido.Text);
            decimal maximo = Convert.ToDecimal(Max_acido.Text);//14

            Int32 num_minimo = Convert.ToInt32(minimo);
            Int32 num_maximo = Convert.ToInt32(maximo); //14

            for (int i = 0; i < quantidade; i++)
            {
                Int32 peso = sort.Next(3501, 3999);                
                
                Int32 num_esperado = sort.Next(num_minimo, num_maximo);
                double esperado = num_esperado / 10;
                double volume = calculo.reverse_ac(esperado, peso, fator);
                double resutado = calculo.analise_acido(volume, peso, fator);

                salvar(Convert.ToString("Analise de Acido - TESTE"));
                salvar(Convert.ToString(peso));
                salvar(Convert.ToString(string.Format("{0:f}", volume)));
                salvar(Convert.ToString(string.Format("{0:f}", resutado)));
                salvar(Convert.ToString(maximo));
                salvar(Convert.ToString(num_maximo));

            }
            
            
            //salvar(Convert.ToString(teste));
        }        


    

    }
}
