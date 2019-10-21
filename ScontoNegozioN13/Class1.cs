using System;

namespace ScontoNegozioN13
{
    public class ScontoNegozio
    {
        public static double Negozio(double totale)
        {
            double sconto;
            double scontato;
            if (totale <= 500)
            {
                sconto = totale / 100 * 10;
                scontato = totale - sconto;
            }
            else
            {
                sconto = totale / 100 * 20;
                scontato = totale - sconto;
            }
            return scontato;
        }
    }
        
}
