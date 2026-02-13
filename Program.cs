namespace Back_to_School_C_
{
    internal class Program
    {           
          static void Main()
            {
                List<Customer> customers = new List<Customer>();
                ICustomerService service = new CustomerService();

                bool running = true;

                while (running)
                {
                    Console.WriteLine("1. Lägg till kund");
                    Console.WriteLine("2. Visa alla kunder");
                    Console.WriteLine("3. Ta bort kund via Id");
                    Console.WriteLine("4. Avsluta");
                    Console.Write("Välj: ");

                    string choice = Console.ReadLine();
                    Console.WriteLine();

                    switch (choice)
                    {
                        case "1":
                            service.AddCustomer(customers);
                            break;

                        case "2":
                            service.ShowAllCustomers(customers);
                            break;

                        case "3":
                            Console.Write("Ange Id: ");
                            int id = int.Parse(Console.ReadLine());

                            if (service.RemoveCustomerById(customers, id))
                                Console.WriteLine("Kunden togs bort.\n");
                            else
                                Console.WriteLine("Ingen kund med det Id:t hittades.\n");
                            break;

                        case "4":
                            running = false;
                            break;

                        default:
                            Console.WriteLine("Ogiltigt val.\n");
                            break;
                    }
                }
            }
        }

    }


