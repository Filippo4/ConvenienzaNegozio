using System;
using NegozioEs12;
using ScontoNegozioN13;

namespace Negozio_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserisci il prezzo totale: ");
            double totale = double.Parse(Console.ReadLine());
            double n = ScontoNegozio.Negozio(totale);
            double n12 = ScontoNegozio12.Negozio12(totale);
            if (n < n12)
            {
                Console.WriteLine("conviene il primo negozio");
            }
            else if (n > n12)
            {
                Console.WriteLine("conviene il primo negozio");
            }
            else
            {
                Console.WriteLine("Sono ugualmente convenienti");
            }
            Console.ReadLine();
        }
    }
}
