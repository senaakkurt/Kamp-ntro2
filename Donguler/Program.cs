using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Kurslar = new string[] { "Java", "C++", "Python" };

            for (int i = 0; i < Kurslar.Length; i++)
            {
                Console.WriteLine(Kurslar[i]);
            }

            Console.WriteLine("for döngüsünün sonu");

            foreach (string kurs in Kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("foreach döngüsünün sonu");

        }
    }
}
