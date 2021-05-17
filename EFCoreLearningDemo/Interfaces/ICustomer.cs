using EFCoreLearningDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreLearningDemo.Interfaces
{
    public interface ICustomer
    {
        List<Customer> GetList();
    }
}
