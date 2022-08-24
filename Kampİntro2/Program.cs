using System;

namespace Kampİntro2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            bool sistemKontrol = true;
            double dolarDun = 7.35;
            double dolarBugun = 7.55;
            
            if (dolarDun<dolarBugun) 
            {
                Console.WriteLine("artış butonu");
            }
            else if (dolarDun>dolarBugun)
            {
                Console.WriteLine("azalış butonu");
            }
            else
            {
                Console.WriteLine("değişmemiş butonu");
            }

            if (sistemKontrol == true )  
            {
                Console.WriteLine("Giriş yapılmıştır.");
            }

            else 
            {
                Console.WriteLine("Girilmemiştir.");
            }
        }
    }
}
