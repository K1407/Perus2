
// Olio-ohjelmointi: Perustehtävä 2

using System;

namespace perusteht2
{
    class Program
    {
        static void Main(string[] args)
        {
            int pisteet;
            Console.Write("Pisteesi: ");
            string line = Console.ReadLine();
            bool result = Int32.TryParse(line, out pisteet);

            if (result)
            {
                switch (pisteet)
                {
                    case 0:
                    case 1: Console.WriteLine("Arvosanasi on 0"); break;
                    case 2:
                    case 3: Console.WriteLine("Arvosanasi on 1"); break;
                    case 4:
                    case 5: Console.WriteLine("Arvosanasi on 2"); break;
                    case 6:
                    case 7: Console.WriteLine("Arvosanasi on 3"); break;
                    case 8:
                    case 9: Console.WriteLine("Arvosanasi on 4"); break;
                    case 10:
                    case 11:
                    case 12: Console.WriteLine("Arvosanasi on 5"); break;
                }
            }
            else
            {
                Console.WriteLine("Et antanut numeroa.");
            }

            Console.ReadLine();
        }
    }
}