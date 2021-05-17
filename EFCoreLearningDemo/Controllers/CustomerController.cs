using EFCoreLearningDemo.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreLearningDemo.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ICustomer customer;
        public CustomerController(ICustomer customer)
        {
            this.customer = customer;
        }
        public IActionResult Index()
        {
            var result = customer.GetList();
            return View(result);
        }
    }
}
