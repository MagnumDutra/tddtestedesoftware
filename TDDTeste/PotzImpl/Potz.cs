using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotzImpl
{
    public class Potz
    {
        public long pontos;

        public Potz(string number)
        {
            string digitoVereficador = number[number.Length - 1].ToString();
            int sum = 0;
            int mutiplicador = 2;
            for (int i = number.Length - 2; i >= 0; i--)
            {
                sum += (int)char.GetNumericValue(number[i]) * mutiplicador;
                mutiplicador++;
            }

            string validator = (11 - (sum % 11)).ToString();

            if (validator == digitoVereficador)
            {
                this.pontos = Convert.ToInt64(number.Substring(0, 3));
                return;
            }
            else
            {
                if ((validator == "10" || validator == "11") && digitoVereficador == "0")
                {
                    this.pontos = Convert.ToInt64(number.Substring(0, 3));
                }
                else
                    this.pontos = 0;
            }

        }
    }
}