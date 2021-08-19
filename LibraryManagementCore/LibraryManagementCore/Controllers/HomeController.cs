using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LibraryManagementCore.Models;
using LibraryBusinessComponents;

namespace LibraryManagementCore.Controllers
{
    public class HomeController : Controller
    {
        private IBookBusinessComponent _bookBusinessComponent;

        public HomeController(IBookBusinessComponent bookBusinessComponent)
        {
            _bookBusinessComponent = bookBusinessComponent;
        }
        public IActionResult Index()
        {
           //string BookId = _bookBusinessComponent.InsertBook("Complete Reference of java", "Herbert Shield");

        //   var BookList = _bookBusinessComponent.GetBooks();
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

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
