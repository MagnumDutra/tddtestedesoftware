using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        ////Antes
        //class Empregado
        //{
        //    public int _tipo;
        //    const int ENGENHEIRO = 0;
        //    const int VENDEDOR = 1;
        //    const int GERENTE = 2;
        //    private int _salarioMensal = 750;
        //    private int _comissao = 250;
        //    private int _bonus = 550;

        //    public Empregado(int tipo)
        //    {
        //        _tipo = tipo;
        //    }

        //    public int quantiAPagar()
        //    {
        //        switch (_tipo)
        //        {
        //            case ENGENHEIRO: return _salarioMensal;
        //            case VENDEDOR: return _salarioMensal * _comissao;
        //            case GERENTE: return _salarioMensal * _bonus;
        //            default: throw new Exception("Tipo Incorreto de empregado");
        //        }
        //    }
        //}



        class Empregado
        {
            public TipoEmpregado _tipo;
            //Decclaração das propiedades da class 
            public Empregado(int tipo)
            {
                gravarTipo(tipo);
            }
            int lerTipo()
            {
                return _tipo.lerCodigo();
            }
            void gravarTipo(int arg)
            {
                switch (arg)
                {
                    case ENGENHEIRO: _tipo = new Engenheiro();
                    case VENDEDOR: _tipo = new Vendedor();
                    case GERENTE: _tipo = new Gerente();
                    default: throw new Exception("Valor invalido de codigo");
                }
            }

            abstract class TipoEmpregado
            {
                public abstract int lerCodigo()
                {
                    return -1;
                }
            }
            class Engenheiro : TipoEmpregado
            {
                int lerCodigo()
                {
                    return Empregado.ENGENHEIRO;
                }
            }
            class Gerente : TipoEmpregado
            {
                int lerCodigo()
                {
                    return Empregado.GERENTE;
                }
            }
            class Vendedor : TipoEmpregado
            {
                int lerCodigo()
                {
                    return Empregado.VENDEDOR;
                }
            }
        }
    }
}
