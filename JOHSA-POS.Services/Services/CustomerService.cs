
using System.Collections.Generic;
using JOHSA_POS.Domain;
using JOHSA_POS.Data.Repositories;

namespace JOHSA_POS.Services.Services
{
    public class CustomerService
    {
        private CustomerRepository customerRepository;

        public CustomerService()
        {
            customerRepository = new CustomerRepository();
        }

        public List<Customer> GetAllCustomers()
        {
            return customerRepository.GetAll();
        }
    }
}
