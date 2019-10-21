using System;

namespace NegozioEs12
{
    public class ScontoNegozio12
    {
        public static double Negozio12(double totale)
        {
            double scontoprima;
            double scontodopo;
            double sconto;
            double scontato;
            double spesainpiu;
            if (totale <= 300)
            {
                sconto = totale / 100 * 10;
                scontato = totale - sconto;
            }
            else
            {
                scontoprima = 300 / 100 * 10;
                spesainpiu = totale - 300;
                scontodopo = spesainpiu / 100 * 20;
                sconto = scontoprima + scontodopo;
                scontato = totale - sconto;
            }
            return scontato;
        }
    }
}
