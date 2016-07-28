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
    public class CommandHandler : RequestHandler<Command>
    {
        private readonly BrickstoreContext _db;
        private readonly IMapper _mapper;

        public CommandHandler(BrickstoreContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        protected override void HandleCore(Command message)
        {

            var legoSet = _db.LegoSets.Find(message.Id);

            _mapper.Map(message, legoSet);


            _db.SaveChanges();
        }
    }

}