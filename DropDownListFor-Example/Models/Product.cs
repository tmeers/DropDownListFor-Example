using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DropDownListFor_Example.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual Category Category { get; set; }
    }
}