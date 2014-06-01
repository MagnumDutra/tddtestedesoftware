using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTDConsole
{
    class Program
    {
        static void Main(string[] args)
        { }
    }


   public class MeuPotz
    {
        public int pontos;

        public MeuPotz(string p)
        {
            string[] n = p.Split();

            this.pontos = Convert.ToInt32(n[0]+n[1]+n[3]);
        }
    }

}

