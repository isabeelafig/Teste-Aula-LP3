using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nomes =
            {
                "isabela figueira",
                "daniel luiz de paula",
                "alice figueira",
                "felipe maia",
            };

            foreach (var elements in nomes)
                Console.WriteLine($"O nome é: {nomes}");

            Console.ReadKey();
        }
    }
}
