using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BrickManager.Web.Features.Inventory
{
    public class InventoryController : Controller
    {
        public IMediator _mediator;

        public InventoryController(IMediator mediator)
        {
            _mediator = mediator;
        }

        // GET: Inventory
        public ActionResult Index()
        {
            var inventory = _mediator.Send(new Index.Query());

            return View(inventory);
        }
    }
}