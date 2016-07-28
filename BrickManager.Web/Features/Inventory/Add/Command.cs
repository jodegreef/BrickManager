using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BrickManager.Web.Features.Inventory.Add
{
    public class Command : IRequest
    {
        public int Number { get; set; }

        public string Name { get; set; }
    }
}