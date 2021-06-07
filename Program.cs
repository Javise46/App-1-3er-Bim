using System;

namespace App_1_3er_Bim
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Creado Por Pedro Javier Serrano Ramírez");
            char[] dato = new char[10];


            // dato[0] = 'a';

            for (int i=0; i<=9; i++)
            {
                Console.WriteLine("i:" + i);
                Console.Write("Inggrese una letra");
                dato[i] = char.Parse(Console.ReadLine());
            }

        }
    }
}
