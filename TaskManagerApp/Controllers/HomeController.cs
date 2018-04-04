using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TaskManagerApp.Models;

namespace TaskManagerApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About(string CompanyName)
        {
            ViewData["Message"] = "Your application description page.";

            Singleton.Instance.List.Add(CompanyName);

            var model = new TaskViewModel();
            model.Count = Singleton.Instance.List.Count();
            model.Name = Singleton.Instance.List;

            return View(model);
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public string VeryImportantMesasge()
        {
            //            decimal zero = 0;
            //            decimal alleluje = 2 / zero;
            try
            {
                string a = null;
                a.Contains("8");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            return "siema8";
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }

    public class TaskViewModel
    {
        public List<string> Name { get; set; }
        public int Count { get; set; }
    }
}