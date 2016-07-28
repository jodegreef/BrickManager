using AutoMapper;
using BrickManager.Web.DAL;
using BrickManager.Web.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BrickManager.Web.Features.Inventory.Add
{
    public class Handler : RequestHandler<Command>
    {
        private readonly BrickstoreContext _db;
        private readonly IMapper _mapper;

        public Handler(BrickstoreContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        protected override void HandleCore(Command message)
        {
            var legoSet = _mapper.Map<Command, LegoSet>(message);

            _db.LegoSets.Add(legoSet);


            _db.SaveChanges();
        }
    }

}