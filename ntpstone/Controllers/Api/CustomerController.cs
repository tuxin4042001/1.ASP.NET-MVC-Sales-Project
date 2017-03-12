﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AutoMapper;
using ntpstone.Dtos;
using ntpstone.Models;
using System.Data.Entity;

namespace ntpstone.Controllers.Api
{
    public class CustomerController : ApiController
    {
        private ApplicationDbContext _context;

        public CustomerController()
        {
            _context = new ApplicationDbContext();
        }

        //GET /api/customers
        //public IEnumerable<Customer> GetCustomers()
        //{
        //    return _context.Customers.ToList();
        //}

        public IEnumerable<CustomerDto> GetCustomers()
        {
            return _context.Customers.Include(c => c.MembershipType).ToList().Select(Mapper.Map<Customer, CustomerDto>);
        }

        //GET /api/customers/1
        //public Customer GetCustomer(int id)
        //{
        //    var customer = _context.Customers.SingleOrDefault(c => c.Id == id);
        //    if (customer == null)
        //    {
        //        throw new System.Web.Http.HttpResponseException(HttpStatusCode.NotFound);
        //    }
        //    return customer;
        //}

        public CustomerDto GetCustomer(int id)
        {
            var customer = _context.Customers.SingleOrDefault(c => c.Id == id);
            if (customer == null)
            {
                throw new System.Web.Http.HttpResponseException(HttpStatusCode.NotFound);
            }
            return Mapper.Map<Customer, CustomerDto>(customer);
        }

        //POST /api/customers
        [HttpPost]
        //public Customer CreateCustomer(Customer customer)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        throw new HttpResponseException(HttpStatusCode.BadRequest);
        //    }
        //    _context.Customers.Add(customer);
        //    _context.SaveChanges();

        //    return customer;
        //}

        public IHttpActionResult CreateCustomer(CustomerDto customerDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var customer = Mapper.Map<CustomerDto, Customer>(customerDto);
            _context.Customers.Add(customer);
            _context.SaveChanges();

            customerDto.Id = customer.Id;
            return Created(new Uri(Request.RequestUri + "/" +customer.Id), customerDto);
        }

        //PUT /api/customers/1
        [HttpPut]
        //public void UpdateCustomer(int id, Customer customer)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        throw new HttpResponseException(HttpStatusCode.BadRequest);
        //    }

        //    var customerInDb = _context.Customers.SingleOrDefault(c => c.Id == id);

        //    if (customerInDb == null)
        //    {
        //        throw new HttpResponseException(HttpStatusCode.NotFound);
        //    }

        //    customerInDb.Name = customer.Name;
        //    customerInDb.Address = customer.Address;
        //    customerInDb.ZipCode = customer.ZipCode;
        //    customerInDb.CellPhoneNumber = customer.CellPhoneNumber;
        //    customerInDb.OfficeNumber = customer.OfficeNumber;
        //    customerInDb.City = customer.City;
        //    customerInDb.District = customer.District;
        //    customerInDb.WebSite = customer.WebSite;
        //    customerInDb.Email = customer.Email;
        //    customerInDb.isFirstTimeBuyer = customer.isFirstTimeBuyer;
        //    customerInDb.ContactPerson = customer.ContactPerson;
        //    customerInDb.ConsumptionAmount = customer.ConsumptionAmount;
        //    customerInDb.MembershipTypeId = customer.MembershipTypeId;

        //    _context.SaveChanges();

        //}

        public void UpdateCustomer(int id, CustomerDto customerDto)
        {
            if (!ModelState.IsValid)
            {
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            }

            var customerInDb = _context.Customers.SingleOrDefault(c => c.Id == id);

            if (customerInDb == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }

            Mapper.Map(customerDto, customerInDb);

            _context.SaveChanges();

        }

        //DELETE /api/customer/1
        [HttpDelete]
        public void DeleteCustomer(int id)
        {
            var customerInDb = _context.Customers.SingleOrDefault(c => c.Id == id);

            if (customerInDb == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }

            _context.Customers.Remove(customerInDb);

            _context.SaveChanges();
        }

    }
}
