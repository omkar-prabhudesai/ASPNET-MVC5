using System.Collections.Generic;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        private CustomersViewModel vm = new CustomersViewModel()
        {
            Customers = new List<Customer>
            {
                new Customer {Id = 1, Name = "Omkar Prabhudesai"},
                new Customer {Id = 2, Name = "Bhakti Prabhudesai"}
            },
            ViewName = "Customers"
            
        };

        // GET: Customers
        public ActionResult Customers()
        {
            return View(vm);
        }

        //GET: Customer Details
        public ActionResult Details(int id)
        {
            return View(vm.Customers.Find(x=>x.Id == id));
        }
    }
}