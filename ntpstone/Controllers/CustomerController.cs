using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using ntpstone.Models;
using ntpstone.ViewModels;
using System.Net;
using System.Net.Http;


namespace ntpstone.Controllers
{
    public class CustomerController : Controller
    {
        //定义一个ApplicationDbContext _context,作为读取数据的入口
        private ApplicationDbContext _context;

        public CustomerController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Customer
        public ActionResult Index()
        {
            //If you use the web api, then you don't need transfer the model to the view 
            //var customers = _context.Customers.Include(c => c.MembershipType).ToList();
            ////return View(customers);
            ////if we use dataTable to get the data from web api, then we don't need to transfer the customer data to view
            //return View(); 

            if (User.IsInRole(RoleName.CanManageQuartzs))
            {
                return View("List");
            }
            else
            {
                return View("ReadOnlyList");
            }
        }

        public ActionResult Detail(int id)
        {
            var customer =
                _context.Customers.Include(c => c.MembershipType).SingleOrDefault(c => c.Id == id);
            if (customer == null)
            {
                return HttpNotFound();
            }
            else
            {
                return View(customer);
            }
        }

        [Authorize(Roles = RoleName.CanManageQuartzs)]
        public ActionResult New()
        {
            var membershiptype = _context.MembershipTypes.ToList();
            var viewmodel = new NewCustomerViewModel
            {
                MembershipTypes = membershiptype

            };

            return View(viewmodel);
        }


        [HttpPost]
        public ActionResult Create(Customer customer)
        {
            _context.Customers.Add(customer);
            _context.SaveChanges();

            return RedirectToAction("Index", "Customer");

        }

        [Authorize(Roles = RoleName.CanManageQuartzs)]
        public ActionResult Edit(int id)
        {
            var customer = _context.Customers.SingleOrDefault(c => c.Id == id);
            if (customer == null)
            {
                return HttpNotFound();
            }
            var viewModel = new NewCustomerViewModel
            {
                MembershipTypes = _context.MembershipTypes.ToList(),
                Customer = customer
            };

            return View("Edit", viewModel);
        }

        [HttpPost]
        public ActionResult Update(Customer customer)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new NewCustomerViewModel
                {
                    Customer = customer,
                    MembershipTypes = _context.MembershipTypes.ToList()
                };
                return View("Edit", viewModel);
            }


                var customerInDb = _context.Customers.Single(c => c.Id == customer.Id);
                customerInDb.Name = customer.Name;
                customerInDb.Address = customer.Address;
                customerInDb.ZipCode = customer.ZipCode;
                customerInDb.CellPhoneNumber = customer.CellPhoneNumber;
                customerInDb.OfficeNumber = customer.OfficeNumber;
                customerInDb.City = customer.City;
                customerInDb.District = customer.District;
                customerInDb.WebSite = customer.WebSite;
                customerInDb.Email = customer.Email;
                customerInDb.isFirstTimeBuyer = customer.isFirstTimeBuyer;
                customerInDb.ContactPerson = customer.ContactPerson;
                customerInDb.ConsumptionAmount = customer.ConsumptionAmount;
                customerInDb.MembershipTypeId = customer.MembershipTypeId;
            
            _context.SaveChanges();
            return RedirectToAction("Index", "Customer");
        }

        [Authorize(Roles = RoleName.CanManageQuartzs)]
        public ActionResult Delete(int id)
        {
            var customer = _context.Customers.SingleOrDefault(c => c.Id == id);
            if (customer == null)
            {
                return HttpNotFound();
            }

            _context.Customers.Remove(customer);
            _context.SaveChanges();

            return RedirectToAction("Index", "Customer");
        }
    }
}
