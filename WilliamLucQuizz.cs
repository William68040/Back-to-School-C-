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

        public static void Fråga2()
        {
            //Konvertera en strängvariabel till en integer. Gör det omöjligt för appen att krasha.
            //Om appen krashar skriv ut "Det där är inte en siffra!Konvertera en strängvariabel till en integer.
            //Gör det omöjligt för appen att krasha. Om appen krashar skriv ut "Det där är inte en siffra!

            Console.WriteLine("Skriv ett tal");
            string input = Console.ReadLine();

            int tal;
            
            if (int.TryParse(input, out tal))
            {
                Console.WriteLine($"Du skrev talet {tal}");
            }
            else
            {
                Console.WriteLine("Det där är inte en siffra!");
            }
        }
    }
}
