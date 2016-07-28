using AutoMapper;
using BrickManager.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BrickManager.Web.Features.Inventory.Add
{

    public class MappingProfile : Profile
    {
        protected override void Configure()
        {
            var map = CreateMap<Command, LegoSet>()
                .ForMember(x => x.Id, opt => opt.MapFrom(o => Guid.NewGuid()));
        }
    }
}