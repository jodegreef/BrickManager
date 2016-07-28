using AutoMapper;
using BrickManager.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BrickManager.Web.Features.Inventory.Edit
{

    public class MappingProfile : Profile
    {
        protected override void Configure()
        {
            var map = CreateMap<Command, LegoSet>().ReverseMap();
        }
    }
}