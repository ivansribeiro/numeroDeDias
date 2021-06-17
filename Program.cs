using System;

namespace Exerc1
{
    class Program
    {
        static void Main(string[] args)
        {
            int nDias = 0;

            Console.WriteLine("Digite o numero de meses :");
            string meses = Console.ReadLine();
            int intMeses = Convert.ToInt32(meses);

            nDias = intMeses * 30;
            Console.WriteLine("O numero de dias é:" + nDias);

        }
    }
}
