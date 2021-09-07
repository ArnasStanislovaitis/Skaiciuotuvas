using System;

namespace GitHub_skaiciuotuvas
{
    class Program
    {
        static void Main(string[] args)
        {
            

        }
        static void LyginiuMetodas()
        {
            for (int i = 1; i < 11; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
        static void NelyginiuMetodas()
        {
            for (int i = 1; i < 11; i++)
            {
                if (i%2 !=0)
                {
                    Console.WriteLine(i);
                }
            }
        }
        static int Sudetis()
        {
            Console.WriteLine("Iveskite pirma skaiciu");
            int Pirmas = int.Parse(Console.WriteLine());
            int Antras = int.Parse(Console.WriteLine());
            int Suma = Pirmas + Antras;
            Console.WriteLine(Suma);
            return Suma;
        } 

    }
}
