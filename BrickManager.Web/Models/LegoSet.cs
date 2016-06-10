using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BrickManager.Web.Models
{
    public class LegoSet
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Number { get; set; }
    }
}