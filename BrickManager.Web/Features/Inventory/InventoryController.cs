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

        public ActionResult Add()
        {
            return View("Add/Add");
        }

        [HttpPost]
        public ActionResult Add(Add.Command command)
        {
            _mediator.Send(command);
            return RedirectToAction("Index");
        }

        public ActionResult Edit(Edit.Query query)
        {
            var model = _mediator.Send(query);

            return View("Edit/Edit", model);
        }

        [HttpPost]
        public ActionResult Edit(Edit.Command command)
        {
            _mediator.Send(command);
            return RedirectToAction("Index");
        }
    }
}