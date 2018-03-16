using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    [RoutePrefix("customers")]
    public class CustomersController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Customers
        [Route()]
        public ActionResult Customers()
        {
            //var customers = _context.Customers.ToList();
            //Eager loading
            var customers = _context.Customers.Include(c => c.MembershipType).ToList();
            return View(customers);
        }

        //GET: Customer Details
        //[Route("{id?}")]
        public ActionResult Details(int id)
        {
            var cust = _context.Customers.Include(c=>c.MembershipType).
                SingleOrDefault(x => x.Id == id);
            if (null == cust)
                return HttpNotFound("Customer Not Found");

            return View(cust);
        }
    }
}