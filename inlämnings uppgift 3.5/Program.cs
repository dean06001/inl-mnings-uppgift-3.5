using System;
namespace inlämnings_uppgift_3._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("skriv ett tal");
            double tal1 = double.Parse(Console.ReadLine());
            Console.WriteLine("skriv ett annat tal");
            double tal2 = double.Parse(Console.ReadLine());

            Console.WriteLine("välj ett sätt att räkna på");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraktion");
            Console.WriteLine("3. Multiplikation");
            Console.WriteLine("4. Division");
            string svar = Console.ReadLine();

            if (svar == "1")
            {
                double summa = tal1 + tal2;
                Console.WriteLine(tal1 + "+" + tal2 + " = " + summa);
            }
            else if (svar == "1")
            {
                double diffrens = tal1 - tal2;
                Console.WriteLine(tal1 + "+" + tal2 + " = " + diffrens);
            }
            else if (svar == "1")
            {
                double produkt = tal1 * tal2;
                Console.WriteLine(tal1 + "+" + tal2 + " = " + produkt);
            }
            else if (svar == "1")
            {
                double kvot = tal1 / tal2;
                Console.WriteLine(tal1 + "+" + tal2 + " = " + kvot);
            }
            else
            {
                Console.WriteLine("vänligen skriv in ett tal mellan nummer 1 till 4");
            }
            Console.ReadKey();
        }
    }
}