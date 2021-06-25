using EFCoreLearningDemo.Data;
using EFCoreLearningDemo.Entities;
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
            //To Add new 
            //Dept d1 = new Dept() { Id = 90, Name = "sdf", Loc = "dfd" };
            //this.context.Add(d1);
            //this.context.SaveChanges();

            //To edit
            //var data = context.Depts.Where(dept => dept.Id == 90).FirstOrDefault();
            //data.Loc = "CHICAGO1";
            //int result = context.SaveChanges();

            //To delete
            //var data = context.Depts.Where(dept => dept.Id == 90).FirstOrDefault();
            //context.Remove(data);
            //int result = context.SaveChanges();


            return View();
        }
        public IActionResult GetList()
        {
            var result = context.Depts.ToList();
            return View(result);
        }
        [HttpPost]
        public IActionResult Delete(int id)
        {
            var data = context.Depts.Where(dept => dept.Id == id).FirstOrDefault();
            context.Remove(data);
            int result = context.SaveChanges();
            return RedirectToAction("GetList");
        }
        [HttpPost]
        public IActionResult Tempmethod(int id)
        {
           //For reference post call from list of actions
            return RedirectToAction("GetList");
        }
    }
}
