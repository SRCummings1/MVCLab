using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVCLab.Models;

namespace MVCLab.Controllers
{
    public class TripController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult MileageForm()//add view here
        {
            return View();
        }
        public IActionResult MileageResult(Tripometer trips)// letters matter to match
        {
            return View(trips);
        }
    }
}