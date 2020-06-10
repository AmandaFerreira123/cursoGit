using System;

namespace Pensao
{
    class Program
    {
        static void Main(string[] args)
        {

            Quarto[] vetorQuartos = new Quarto[10];

            for (int i = 0; i < 10; i++)
            {
                vetorQuartos[i] = new Quarto();
            }


            Console.Write("Quantos quartos serão alugados? ");
            int n = int.Parse(Console.ReadLine());
            int aux = 1;
            while (aux <= n)
            {
                Console.WriteLine();
                Console.WriteLine("Aluguel #" + aux + ":");
                Console.Write("Nome: ");
                string nomeInquilino = Console.ReadLine();
                Console.Write("Email: ");
                string emailInquilino = Console.ReadLine();
                Console.Write("Quarto: ");
                int numeroQuarto = int.Parse(Console.ReadLine());
                

                vetorQuartos[numeroQuarto].NomeInquilino = nomeInquilino;
                vetorQuartos[numeroQuarto].EmailInquilino = emailInquilino;
                vetorQuartos[numeroQuarto].NumeroQuarto = numeroQuarto;

                aux++;


            }

            Console.WriteLine("\nQuartos Ocupados: ");

            for (int i = 0; i < 10; i++)
            {
                if (vetorQuartos[i].NumeroQuarto != 0)
                {
                    Console.WriteLine(i + ": " + vetorQuartos[i].NomeInquilino + ", " + vetorQuartos[i].EmailInquilino);
                }
            }


        }
    }
}
