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
        bool RemoveCustomerById(List<Customer> customers, int id);
    }

    public class CustomerService : ICustomerService
    {
        public bool RemoveCustomerById(List<Customer> customers, int id)
        {
            return customers.RemoveAll(c => c.Id == id) > 0;
        }
    }
}
