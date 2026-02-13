using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Back_to_School_C_.WilliamLucQuizz;

namespace Back_to_School_C_
{
    public interface ICustomerService
    {
        void AddCustomer(List<Customer> customers);
        void ShowAllCustomers(List<Customer> customers);
        bool RemoveCustomerById(List<Customer> customers, int id);
    }

    public class CustomerService : ICustomerService
    {
        public void AddCustomer(List<Customer> customers)
        {
            Customer customer = new Customer();

            Console.Write("Id: ");
            customer.Id = int.Parse(Console.ReadLine());

            Console.Write("Förnamn: ");
            customer.FirstName = Console.ReadLine();

            Console.Write("Efternamn: ");
            customer.LastName = Console.ReadLine();

            Console.Write("Telefonnummer: ");
            customer.PhoneNumber = Console.ReadLine();

            Console.Write("Email: ");
            customer.Email = Console.ReadLine();

            customers.Add(customer);
            Console.WriteLine("Kund tillagd!\n");
        }

        public void ShowAllCustomers(List<Customer> customers)
        {
            if (customers.Count == 0)
            {
                Console.WriteLine("Inga kunder registrerade.\n");
                return;
            }

            foreach (var c in customers)
            {
                Console.WriteLine($"Id: {c.Id} | {c.FirstName} {c.LastName} | {c.PhoneNumber} | {c.Email}");
            }
            Console.WriteLine();
        }

        public bool RemoveCustomerById(List<Customer> customers, int id)
        {
            return customers.RemoveAll(c => c.Id == id) > 0;
        }
    }
}
