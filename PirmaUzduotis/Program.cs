using System;

namespace PirmaUzduotis
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Iveskite staciakampio ilgi (cm): ");
            double ilgis = double.Parse(Console.ReadLine());

            Console.WriteLine("Iveskite staciakampio ploti (cm): ");
            double plotis = double.Parse(Console.ReadLine());

            double plotas = ilgis * plotis;

            Console.WriteLine($"Staciakampio plotas {plotas}cm" );
        }
    }
}