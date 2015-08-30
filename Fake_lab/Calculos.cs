using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fake_lab
{
    class Calculos
    {

        //Analises //
        public double analise_acido(double volume, Int32 peso_amos, double FC)
        {
            return (volume * FC * 63 * 100) / peso_amos;
        }

        public double analise_coag(double result, double reagente)
        {
            return result * reagente;
        }

        public double solido(double valor_a, double valor_b, double valor_c)
        {
            return ((valor_c - valor_a) / valor_b) * 100;
        }


        //Calculos reversos

        public double find_c(double valor_d, double valor_b, double valor_a)
        {
            return ((valor_d / 100) * valor_b) + valor_a;
        }

        public double reverse_ac(double esperado, Int64 peso, double FC)
        {
            return (esperado * peso) / (FC * 6300);

        }


        //Numeros Aleatorios

        



        //Ajustes

        public double ajust_up(double result, Int16 volume, double concentracao, double limite)
        {
            return ((limite - result) * volume) / concentracao;
        }

        public double ajust_down(double result, Int16 volume_TQ, double limite)
        {
            return ((result * volume_TQ) / limite) - volume_TQ;
        }


    }
}
