using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using task.Models;

namespace task.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPersonRepo _personRepo;

        public HomeController(IPersonRepo personRepo)
        {
            _personRepo= personRepo;
        }

        public IActionResult Index()
        {
            var model = _personRepo.GetAllPerson();
            ViewBag.Person = model;
            return View();
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Person person)
        {
            var model = _personRepo.GetAllPerson();
            ViewData["Person"] = model;
            if (ModelState.IsValid)
            {
                Person newPerson = _personRepo.Add(person);
                return RedirectToAction("index");
            }
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}