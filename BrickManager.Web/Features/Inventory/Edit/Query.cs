using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BrickManager.Web.Features.Inventory.Edit
{
    public class Query : IRequest<Command>
    {
        public Guid Id { get; set; }
    }
}