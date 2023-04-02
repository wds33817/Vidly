using Microsoft.AspNetCore.Mvc;
using Vidly.Models;
using Microsoft.EntityFrameworkCore;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        private SiteContext _context;
        public CustomersController()
        {
            _context = new SiteContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        
        public ActionResult New()
        {
            return View();
        }

        public ViewResult Index()
        {
            var customers = _context.Customers.Include(c => c.MembershipType).ToList();
            //var customertype = _context.MembershipTypes.ToList();
            return View(customers);
        }

        public ActionResult Details(int id)
        {
            var customer = _context.Customers.Include(c => c.MembershipType).SingleOrDefault(c => c.Id == id);

            if (customer == null)
            {
                return NotFound();
            }

            return View(customer);
        }

        

        
    }
}
