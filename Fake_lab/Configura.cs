using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fake_lab
{
    public partial class Configura : Form
    {
        public Configura()
        {
            InitializeComponent();
            configura();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        public void configura()
        {
            
            Con_caco3.Text = Convert.ToString(Properties.Settings.Default.Con_carbonato);
            Con_hno3.Text = Convert.ToString(Properties.Settings.Default.Con_hno3);
            Con_no3.Text = Convert.ToString(Properties.Settings.Default.Con_nitrato);
                        
            Fat_edta.Text = Convert.ToString(Properties.Settings.Default.Fat_edta);
            Fat_hcl.Text = Convert.ToString(Properties.Settings.Default.Fat_hcl);
            Fat_soda.Text = Convert.ToString(Properties.Settings.Default.Fat_soda);

            Vol_acido.Text = Convert.ToString(Properties.Settings.Default.Vol_acido);
            Vol_coagulante.Text = Convert.ToString(Properties.Settings.Default.Vol_coagulante);
            Vol_composto.Text = Convert.ToString(Properties.Settings.Default.Vol_composto);
            Vol_talco.Text = Convert.ToString(Properties.Settings.Default.Vol_talco);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Con_carbonato = Convert.ToDouble(Con_caco3.Text);
            Properties.Settings.Default.Con_hno3 = Convert.ToDouble(Con_hno3.Text);
            Properties.Settings.Default.Con_nitrato = Convert.ToDouble(Con_no3.Text);

            Properties.Settings.Default.Fat_edta = Convert.ToDouble(Fat_edta.Text);
            Properties.Settings.Default.Fat_hcl = Convert.ToDouble(Fat_hcl.Text);
            Properties.Settings.Default.Fat_soda = Convert.ToDouble(Fat_soda.Text);

            Properties.Settings.Default.Vol_acido = Convert.ToInt16(Vol_acido.Text);
            Properties.Settings.Default.Vol_coagulante = Convert.ToInt16(Vol_coagulante.Text);
            Properties.Settings.Default.Vol_composto = Convert.ToInt16(Vol_composto.Text);
            Properties.Settings.Default.Vol_talco = Convert.ToInt16(Vol_talco.Text);

            MessageBox.Show("Salvo com sucesso!");
        }
    }
}
