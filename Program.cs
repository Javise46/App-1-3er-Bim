using System;

namespace App_1_3er_Bim
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Creado Por Pedro Javier Serrano Ramírez");
            //Variables
            char[] dato = new char[10];
            char buscar;
            int OP = 1;
            int op;
            //Dato=[0]='a'; 
            Console.WriteLine("Vector con 10 posiciones");

            while (OP == 1)

             {
                Console.Clear();
                Console.WriteLine("----------------------------------------------");
                Console.WriteLine("-------Cinta De Opciones-------");
                Console.WriteLine("\n1. Ingresar Valores \n2. Mostrar Valores \n3. Buscar Valores \n4. Salir ");
                Console.WriteLine("Digite el numero de opcion que desea");
                op = int.Parse(Console.ReadLine());

                Console.WriteLine("----------------------------------------------");
                System.Threading.Thread.Sleep(2000);
                Console.Clear();
                if (op == 1)
                {
                    Console.WriteLine("----------------------------------------------");
                    for (int i = 0; i <= 9; i++)
                    {

                        Console.WriteLine("i: " + i);
                        Console.WriteLine("Ingrese una letra: ");
                        dato[i] = char.Parse(Console.ReadLine());
                    }
                    Console.WriteLine("----------------------------------------------");
                    System.Threading.Thread.Sleep(2000);

                }
                if (op == 2)
                {
                    Console.WriteLine("----------------------------------------------");
                    for (int x = 0; x <= 9; x++)
                    {
                        Console.WriteLine("Dato "+dato[x]);
                    }
                    Console.WriteLine("----------------------------------------------");
                    System.Threading.Thread.Sleep(2000);

                }
                if (op == 3)
                {
                    Console.WriteLine("----------------------------------------------");
                    Console.WriteLine("Ingrese el carcter a buscar: ");
                    buscar = char.Parse(Console.ReadLine());
                    for (int z = 0; z <= 9; z++)
                    {
                        if (dato[z] == buscar)
                        {
                            Console.WriteLine("dato " + buscar + " encontrado");
                        }
                    }
                    Console.WriteLine("----------------------------------------------");
                    System.Threading.Thread.Sleep(2000);
                }

                if (op == 4)
                {
                    break;
                }
            }
            Console.Clear();
            Console.WriteLine("\n Todos Los Creditos A: \n Pedro Javier Serrano Ramírez \n Grado:\n 4to. Bach. BACO");
            Console.ReadKey();

        }
    }
}
