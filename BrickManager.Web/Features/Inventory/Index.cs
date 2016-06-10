using AutoMapper;
using BrickManager.Web.DAL;
using BrickManager.Web.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BrickManager.Web.Features.Inventory
{
    public class Index
    {
        public class Query : IRequest<Result>
        {
        }

        public class Result
        {
            public List<Set> Sets { get; set; }
        }

        public class MappingProfile : Profile
        {
            protected override void Configure()
            {
                CreateMap<LegoSet, Set>();
            }
        }

        public class Set
        {
            public Guid Id { get; set; }
            [Display(Name = "Name")]
            public string Name { get; set; }
            [Display(Name = "Number")]
            public string Number { get; set; }
        }


        public class QueryHandler : IRequestHandler<Query, Result>
        {
            private readonly BrickstoreContext _db;
            private readonly MapperConfiguration _config;

            public QueryHandler(BrickstoreContext db, MapperConfiguration config)
            {
                _db = db;
                _config = config;
            }

            public Result Handle(Query message)
            {
                var model = new Result
                {
                    Sets = _db.LegoSets.OrderBy(x => x.Number).ProjectToList<Set>(_config)
                };

                return model;

            }
        }

    }
}