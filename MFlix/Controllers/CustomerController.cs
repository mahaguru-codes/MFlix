using MFlix.Models.Beans;
using MFlix.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace MFlix.Controllers
{
    [Route("api/[Controller]")]
    public class CustomerController : Controller
    {
        [Route("getCustomers")]
        public IActionResult Customer()
        {
            var customers = new List<Customer>()
            {
                new Customer { Id = 1, Name = "Neha" },
                new Customer { Id = 2, Name = "Saurabh" },
                new Customer { Id = 3, Name = "Vibhav" },
                new Customer { Id = 4, Name = "Arun" },
                new Customer { Id = 5, Name = "Aditya" }
            };

            return View(customers);
        }

        [Route("getDetail")]
        public IActionResult Detail(int id)
        {
            var customer = GetCustomers().SingleOrDefault(c => c.Id == id);

            return View(customer);
        }

        private IEnumerable<Customer> GetCustomers()
        {
            return new List<Customer>()
            {
                new Customer { Id = 1, Name = "Neha" },
                new Customer { Id = 2, Name = "Saurabh" },
                new Customer { Id = 3, Name = "Vibhav" },
                new Customer { Id = 4, Name = "Arun" },
                new Customer { Id = 5, Name = "Aditya" }
            };
        }
    }
}
