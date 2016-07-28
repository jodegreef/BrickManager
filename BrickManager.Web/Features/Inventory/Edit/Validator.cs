using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BrickManager.Web.Features.Inventory.Edit
{
    public class Validator : AbstractValidator<Command>
    {
        public Validator()
        {
            RuleFor(x => x.Number).NotEmpty();
            RuleFor(x => x.Name).NotEmpty();
            RuleFor(x => x.Name).Length(1, 255);
        }
    }
}