using System;

namespace PirmaPaskaita1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Iveskite sveikaji skaiciu: ");
            int ivestasSkaicius = int.Parse(Console.ReadLine());
            Console.WriteLine($"Ivestas skaicius {ivestasSkaicius}");


            Console.WriteLine("Iveskite sveikaji skaiciu: ");
            bool arIvesta = int.TryParse(Console.ReadLine(), out int saugiaiIvestas);

            Console.WriteLine($"Saugiai ivestas: {saugiaiIvestas}");
        }
    }
}