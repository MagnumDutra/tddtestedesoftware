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

            if (this.ValidarEntradaNumerica(number))
                this.obterPontos(number);
            else
                this.pontos = 0;

        }

        private void obterPontos(string number)
        {
            string validador = this.ObeterDigitoValidador(number);
            string digitoVereficador = number[number.Length - 1].ToString();

            if (validador == digitoVereficador)
                this.pontos = Convert.ToInt64(number.Substring(0, 3));
            else
            {
                if ((validador == "10" || validador == "11") && digitoVereficador == "0")
                    this.pontos = Convert.ToInt64(number.Substring(0, 3));
                else
                    this.pontos = 0;
            }
        }

        private bool ValidarEntradaNumerica(string number)
        {
            long  retorno;
            return long.TryParse(number, out retorno);
        }

        private string ObeterDigitoValidador(string number)
        {
            int sum = 0;
            int mutiplicador = 2;
            for (int i = number.Length - 2; i >= 0; i--)
            {
                sum += (int)char.GetNumericValue(number[i]) * mutiplicador;
                mutiplicador++;
            }

            return (11 - (sum % 11)).ToString();
        }
    }
}