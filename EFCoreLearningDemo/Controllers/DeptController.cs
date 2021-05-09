using EFCoreLearningDemo.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreLearningDemo.Controllers
{
    public class DeptController : Controller
    {
        private readonly LearningDbContext context;
        private readonly ILogger<DeptController> logger;
        public DeptController(LearningDbContext context, ILogger<DeptController> logger)
        {
            this.context = context;
            this.logger = logger;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult GetList()
        {
            var result = context.Depts.ToList();
            return View(result);
        }
    }
}
