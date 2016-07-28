using AutoMapper;
using BrickManager.Web.DAL;
using BrickManager.Web.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BrickManager.Web.Features.Inventory.Edit
{
    public class QueryHandler : IRequestHandler<Query, Command>
    {
        private readonly BrickstoreContext _db;
        private readonly MapperConfiguration _config;

        public QueryHandler(BrickstoreContext db, MapperConfiguration config)
        {
            _db = db;
            _config = config;
        }


        public Command Handle(Query message)
        {
            var cmd = _db.LegoSets
                .Where(s => s.Id == message.Id)
                .ProjectToSingleOrDefault<Command>(_config);

            return cmd;
        }

    }

}