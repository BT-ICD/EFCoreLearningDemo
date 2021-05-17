using EFCoreLearningDemo.Interfaces;
using EFCoreLearningDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreLearningDemo.Repository
{
    public class CustomerRepository : ICustomer
    {
        public List<Customer> GetList()
        {
            List<Customer> list = new List<Customer>() 
            {
                new Customer(){Id=101,Name="Rajesh"},
                new Customer(){Id=102,Name="Manan"}
            };
            return list;

        }
    }
}
