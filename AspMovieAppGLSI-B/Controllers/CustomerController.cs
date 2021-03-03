using AspMovieAppGLSI_B.Models;
using AspMovieAppGLSI_B.Models.MVVM;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspMovieAppGLSI_B.Controllers
{
    public class CustomerController : Controller
    {
        ApplicationDbContext _db;
        public CustomerController()
        {
            _db = new ApplicationDbContext();
        }
        // GET: Customer
        public ActionResult Index()
        {
            var movie = new Movie() { Name="Movie 1"};
            
            CustomerMovieVM customerMovieVM = new CustomerMovieVM
            {
                movie = movie,
                customers = _db.customers.ToList(),
            };
            return View(customerMovieVM);
        }
        public ActionResult Details(int id)
        {
            var customer = _db.customers.SingleOrDefault(c => c.Id == id);
            return View(customer);
        }
        public ActionResult List()
        {
            var customers = _db.customers.Include(c=>c.membershiptype).ToList();
            return View(customers);
        }

        private List<Customer> GetCustomers()
        {
            return new List<Customer>
            {
                new Customer { Id= 1, Name="Customer 1"},
                new Customer {Id= 2, Name = "Customer 2"},
            };
        }
    }
}