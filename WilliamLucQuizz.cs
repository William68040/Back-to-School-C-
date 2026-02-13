using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

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

        public static void Fråga3()
        {
            // Deklarera och instansiera en Lista med värdena "Apple", "Orange", "Banana".
            // Hämta ett objekt från listan i taget och gör så att programmet endast skriver ut Orange till konsolen.

            List<string> frukter = new List<string> { "Apple", "Orange", "Banana" };
            foreach (string frukt in frukter)
            {
                if (frukt == "Orange")
                {
                    Console.WriteLine(frukt);
                }
            }

        }

        public static void Fråga4()
        {
           // Använd samma lista men hämta ut värdena baklänges.
           // Skriv endast ut det sista och näst sista värdet(i den "flippade" listan).

            List<string> frukter = new List<string> { "Apple", "Orange", "Banana" };
            for (int i = frukter.Count - 1; i >= 0; i--)
            {
                if (i == frukter.Count - 1 || i == frukter.Count - 2)
                {
                    Console.WriteLine(frukter[i]);
                }
            }

        }

        public static void Fråga5()
        {
            // Skapa en for-loop som räknar ned från 100-0. Skriv ut samtliga siffror en i taget.
            for (int i = 100; i >= 0; i--)
            {
                Console.WriteLine(i);
            }
        }

        public static void Fråga6()
        {
            //Hämta in dagens datum och lägg till 20 år. Skriv ut resultatet. 

            DateTime dagensDatum = DateTime.Now;
            DateTime framtidaDatum = dagensDatum.AddYears(20);
            Console.WriteLine(framtidaDatum);
        }

        public static void Fråga7()
        {
            // Skapa en metod som tar emot ett datum och kollar om det är tidigare än dagens datum.
            // Om det är tidigare, ska metoden returnera false. Annars true. Ge ett passande metodnamn

            {
                DateTime today = DateTime.Today;

                Console.Write("Skriv in ett datum: ");
                string text = Console.ReadLine();

                bool valid = DateTime.TryParse(text, out DateTime date);

                if (valid)
                {
                    bool result = date.Date >= today;

                    if (result)
                        Console.WriteLine("true");
                    else
                        Console.WriteLine("false");
                }
                else
                {
                    Console.WriteLine("Ogiltigt datum");
                }



            }

        }

        public static void Fråga8 ()
        {
            //skapade en klass för customer med properties för namn, efternamn, telefonnummer och email.
        }

        public static void Fråga9()
        {
            //Skapa en ny customer. Ge den relevanta värden och addera sedan till en lista av Customers.

            List<Customer> customers = new List<Customer>();
            Customer customer1 = new Customer
            {
                Name = "William",
                LastName = "Luc",
                PhoneNumber = 0708953936,
                Email = "williamluc888@outlook.com"
            };

        }

        public static void fråga10()
        {
            // Skapa en loop som gör det att möjligt att lägga till oändligt med customers från användarens input.
            // Om användaren vill fortsätta efter varje kund: "y", annars bryt ur loopen.

            List<Customer> customers = new List<Customer>();

            while (true)
            {
                Customer customer = new Customer();
                Console.Write("Ange förnamn: ");
                customer.Name = Console.ReadLine();
                Console.Write("Ange efternamn: ");
                customer.LastName = Console.ReadLine();
                Console.Write("Ange telefonnummer: ");
                customer.PhoneNumber = int.Parse(Console.ReadLine());
                Console.Write("Ange email: ");
                customer.Email = Console.ReadLine();
                Console.Write("Ange ID: ");
                customer.ID = int.Parse(Console.ReadLine());
                customers.Add(customer);
                Console.Write("Vill du lägga till en till kund? (y/n): ");
                string svar = Console.ReadLine();
                if (svar.ToLower() != "y")
                {
                    break;
                }
            }

        }

        public void fråga11(List<Customer> customers, int id)
        {
            //Skapa en metod som tar emot Listan av Customers och en siffra som heter "Id".
            //Om kundlistan innehåller en kund med samma id som skickades in, ta bort kunden från listan.
            //Skapa ett passande metodnamn.
            Customer customerToRemove = customers.FirstOrDefault(c => c.ID == id);
            if (customerToRemove != null)
            {
                customers.Remove(customerToRemove);
                Console.WriteLine($"Kund med ID {id} har tagits bort.");
            }
            else
            {
                Console.WriteLine($"Ingen kund med ID {id} hittades.");
            }


        }


    }
}
