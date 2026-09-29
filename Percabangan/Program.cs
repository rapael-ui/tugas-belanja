using System;

namespace Percabangan
{
    class Home
    {
        public static void Main(string[] args)
        {
            int buku1 = 100;
            int buku2 = 200;
            int buku3 = 300;
            int pulpen1 = 500;
            int pulpen2 = 500;

            double Diskon = 0;
            double belanja1 = 700;
            double belanja2 = 1000;
            double belanja3 = 1500;

            
            double totalBelanja = buku1 + buku2 + buku3 + pulpen1 + pulpen2;

            
            if (totalBelanja > belanja1)
            {
                if (totalBelanja < belanja2)
                {
                    Diskon = 10;
                }
                if (totalBelanja > belanja2)
                {
                    if (totalBelanja < belanja3)
                    {
                        Diskon = 20; 
                    }
                }
                if (totalBelanja >= belanja3)
                {
                    Diskon = 20;
                }
            }

            
            double nominalDiskon = totalBelanja * (Diskon / 100);
            double totalBayar = totalBelanja - nominalDiskon;

           
            Console.WriteLine("Total Belanja  : Rp " + totalBelanja);
            Console.WriteLine("Diskon (%)     : " + Diskon + "%");
            Console.WriteLine("Nominal Diskon : Rp " + nominalDiskon);
            Console.WriteLine("Total Bayar    : Rp " + totalBayar);
        }
    }
}