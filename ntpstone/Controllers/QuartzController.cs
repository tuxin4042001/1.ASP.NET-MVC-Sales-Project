using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using System.Net;
using ntpstone.Models;

namespace ntpstone.Controllers
{
    public class QuartzController : Controller
    {
        //定义一个ApplicationDbContext _context,作为读取数据的入口
        private ApplicationDbContext _context1;

        public QuartzController()
        {
            _context1 = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context1.Dispose();
        }

        // GET: Customer
        public ActionResult Index()
        {
            //If you use the web api, then you don't need transfer the model to the view
            //var quartzs = _context1.Quartzs.ToList();
            //return View(quartzs);
            if (User.IsInRole(RoleName.CanManageQuartzs))
            {
                return View("List");
            }else
            {
                return View("ReadOnlyList");
            }
        }

        public ActionResult Detail(int id)
        {
            var quartz =
                _context1.Quartzs.SingleOrDefault(q => q.Id == id);
            if (quartz == null)
            {
                return HttpNotFound();
            }
            else
            {
                return View(quartz);
            }
        }

        [Authorize(Roles = RoleName.CanManageQuartzs)]
        public ActionResult New()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Quartz quartz)
        {
            _context1.Quartzs.Add(quartz);
            _context1.SaveChanges();

            return RedirectToAction("Index", "Quartz");
        }

        [Authorize(Roles = RoleName.CanManageQuartzs)]
        public ActionResult Edit(int id)
        {
            Quartz quartz = _context1.Quartzs.SingleOrDefault(c => c.Id == id);

            return View("Edit", quartz);
        }

        [HttpPost]
        public ActionResult Update(Quartz quartz)
        {
                Quartz quartzInDb = _context1.Quartzs.Single(c => c.Id == quartz.Id);
                quartzInDb.Name = quartz.Name;
                quartzInDb.ModelNumber = quartz.ModelNumber;
                quartzInDb.thickness = quartz.thickness;
                quartzInDb.ArrivalQuantity = quartz.ArrivalQuantity;
                quartzInDb.SaleQuantity = quartz.SaleQuantity;
                quartzInDb.StockQuantity = quartz.StockQuantity;
                quartzInDb.ActualStockQuantity = quartz.ActualStockQuantity;
                quartzInDb.Color = quartz.Color;
            
            _context1.SaveChanges();
            return RedirectToAction("Index","Quartz");
        }

        [Authorize(Roles = RoleName.CanManageQuartzs)]
        public ActionResult Delete(int id)
        {
            Quartz quartzInDb = _context1.Quartzs.Single(c => c.Id == id);
            if (quartzInDb == null)
            {
                return HttpNotFound();
            }


            _context1.Quartzs.Remove(quartzInDb);
            _context1.SaveChanges();
            return RedirectToAction("Index","Quartz");
        }
    }
}