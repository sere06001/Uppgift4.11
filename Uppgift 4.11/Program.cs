using System;
namespace Uppgift4_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv ett ord");
            string ord = Console.ReadLine();
            var lista = new List<char>();
            foreach (var item in ord) 
            {
                int charCount = 0;
                foreach (var chars in ord)
                {
                    if (item == chars)
                    {
                        charCount++;
                    }
                }

                if (charCount > 1 && !lista.Contains(item))
                {
                    lista.Add(item);
                    Console.WriteLine($"'{item}' förekommer mer än 1 gång.");
                }
            }
            bool tomLista = !lista.Any();
            if (tomLista)
            {
                Console.WriteLine("Inget tecken förekommer mer än 1 gång");
            }
            Console.ReadKey();
        }
    }
}