using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back_to_School_C_
{
    internal class WilliamLucQuizz
    {
        public static void Fråga1()
        {
            // Deklarera och instansiera en strängvariabel med användarens input.
            // Om värdet är "y" skriv ut "Du svarade ja". 

            string svar = Console.ReadLine();
            if (svar == "y")
            {
                Console.WriteLine("Du svarade ja");
            }
            else
            {
                Console.WriteLine($"Du svarade {svar}");
            }
        }
    }
}
