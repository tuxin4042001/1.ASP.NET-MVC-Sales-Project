using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using ntpstone.Dtos;
using ntpstone.Models;

namespace ntpstone.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Domain to Dto
            Mapper.CreateMap<Customer, CustomerDto>();
            Mapper.CreateMap<Quartz, QuartzDto>();
            Mapper.CreateMap<MembershipType, MembershipTypeDto>();


            // Dto to Domain
            Mapper.CreateMap<CustomerDto, Customer>()
                .ForMember(c => c.Id, opt => opt.Ignore());

            Mapper.CreateMap<QuartzDto, Quartz>()
                .ForMember(c => c.Id, opt => opt.Ignore());
        }
    }
}