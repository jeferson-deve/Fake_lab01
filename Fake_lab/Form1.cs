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
using System.Text;

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
            double result = analise_acido(2900, 3.500, 0.9756);
            salvar(Convert.ToString(result));
        }

        public double analise_acido(double volume, double peso_amos, double FC)
        {
            double resultado = 0;            
            /*volume = 2900;
            FC = 0.9756;
            peso_amos = 3500;*/
            resultado = (volume * FC * 63 * 100) / peso_amos;
            return resultado;

        }


    

    }
}
