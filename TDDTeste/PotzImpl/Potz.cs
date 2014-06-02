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
            string totalPonto = string.Empty;
            for (int i = 0; i < 3; i++)
            {
                totalPonto += char.GetNumericValue(number[i]);
            }
            this.pontos = Convert.ToInt64(totalPonto);
        }
    }
}


















//public static string AddCheckDigit(string number)
//    {
//        int Sum = 0;
//        for (int i = number.Length - 1, Multiplier = 2; i >= 0; i--)
//        {
//            Sum += (int)char.GetNumericValue(number[i]) * Multiplier;

//            if (++Multiplier == 8) Multiplier = 2;
//        }
//        string Validator = (11 - (Sum % 11)).ToString();

//        if (Validator == "11") Validator = "0";
//        else if (Validator == "10") Validator = "X";

//        return number + Validator;
//    }
