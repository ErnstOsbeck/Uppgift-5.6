using System;

namespace uppgift_5._6
{
    class Program
    {
        public static void Main()
        {
            try
            {
                Console.WriteLine("Skriv in tal separerade med \"*\"");
                string[] input = Console.ReadLine().Split("*");
                int[] tal = new int[input.Length];

                for (int i = 0; i < input.Length; i++)
                {
                    tal[i] = int.Parse(input[i]);
                }

                long produkt = 1;

                for (int i = 0; i < tal.Length; i++)
                {
                    produkt *= tal[i];
                }
                Console.WriteLine(produkt);
            }

            catch
            {
                Console.WriteLine("Fel input, vänligen pröva igen");
                Main();
            }
        }
    }
}