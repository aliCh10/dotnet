using System.Collections.Generic;
using firstApp.Models;
using firstApp.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace firstApp.Controllers
{
    public class CustumerController : Controller
    {
        public IActionResult Index()
        {
            Movie m = new Movie { id = 1, name = "movie_1" };  // Corrected property names
            List<Custumer> custumers = GetAll();

            CustumersMovie c = new CustumersMovie
            {
                Movie = m,
                Custumers = custumers
            };

            return View(c);
        }
       

        private List<Custumer> GetAll()
        {
            List<Custumer> Custumers = new List<Custumer>
            {
                new Custumer { id = 1, Name = "cust1" },
                new Custumer { id = 2, Name = "cust2" }
            };

            return Custumers;
        }
    }
}
