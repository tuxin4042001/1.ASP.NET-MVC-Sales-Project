using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ntpstone.Models;
using ntpstone.Dtos;
using AutoMapper;

namespace ntpstone.Controllers.Api
{
    public class QuartzController : ApiController
    {
        private ApplicationDbContext _context1;

        public QuartzController()
        {
            _context1 = new ApplicationDbContext();
        }

        //GET /api/Quartz
        //public IEnumerable<Quartz> GetQuartzs()
        //{
        //    return _context1.Quartzs.ToList();
        //}

        public IEnumerable<QuartzDto> GetQuartzs()
        {
            return _context1.Quartzs.ToList().Select(Mapper.Map<Quartz, QuartzDto>);
        }

        //GET /api/Quartz/1
        //public Quartz GetQuartz(int id)
        //{
        //    var quartz = _context1.Quartzs.SingleOrDefault(c => c.Id == id);
        //    if (quartz == null)
        //    {
        //        throw new System.Web.Http.HttpResponseException(HttpStatusCode.NotFound);
        //    }
        //    return quartz;
        //}

        public QuartzDto GetQuartz(int id)
        {
            var quartz = _context1.Quartzs.SingleOrDefault(c => c.Id == id);
            if (quartz == null)
            {
                throw new System.Web.Http.HttpResponseException(HttpStatusCode.NotFound);
            }
            return Mapper.Map<Quartz, QuartzDto>(quartz);
        }

        //POST /api/Quartz
        [HttpPost]
        //public Quartz CreateQuartz(Quartz quartz)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        throw new HttpResponseException(HttpStatusCode.BadRequest);
        //    }

        //    _context1.Quartzs.Add(quartz);
        //    _context1.SaveChanges();

        //    return quartz;
        //}

        public IHttpActionResult CreateQuartz(QuartzDto quartzDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var quartz = Mapper.Map<QuartzDto, Quartz>(quartzDto);
            _context1.Quartzs.Add(quartz);
            _context1.SaveChanges();

            quartzDto.Id = quartz.Id;
            return Created(new Uri(Request.RequestUri + "/" + quartz.Id), quartzDto);
        }

        //PUT /api/Quartz/1
        [HttpPut]
        //public void UpdateQuartz(int id, Quartz quartz)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        throw new HttpResponseException(HttpStatusCode.BadRequest);
        //    }

        //    var quartzInDb = _context1.Quartzs.SingleOrDefault(c => c.Id == id);

        //    if (quartzInDb == null)
        //    {
        //        throw new HttpResponseException(HttpStatusCode.NotFound);
        //    }

        //    quartzInDb.Name = quartz.Name;
        //    quartzInDb.ModelNumber = quartz.ModelNumber;
        //    quartzInDb.thickness = quartz.thickness;
        //    quartzInDb.ArrivalQuantity = quartz.ArrivalQuantity;
        //    quartzInDb.SaleQuantity = quartz.SaleQuantity;
        //    quartzInDb.StockQuantity = quartz.StockQuantity;
        //    quartzInDb.ActualStockQuantity = quartz.ActualStockQuantity;

        //    _context1.SaveChanges();

        //}

        public void UpdateQuartz(int id, QuartzDto quartzDto)
        {
            if (!ModelState.IsValid)
            {
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            }

            var quartzInDb = _context1.Quartzs.SingleOrDefault(c => c.Id == id);

            if (quartzInDb == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }

            Mapper.Map(quartzDto, quartzInDb);

            _context1.SaveChanges();

        }

        //DELETE /api/Quartz/1
        [HttpDelete]
        public void DeleteQuartz(int id)
        {
            var quartzInDb = _context1.Quartzs.SingleOrDefault(c => c.Id == id);

            if (quartzInDb == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }

            _context1.Quartzs.Remove(quartzInDb);

            _context1.SaveChanges();
        }
    }
}
