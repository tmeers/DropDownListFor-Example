using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DropDownListFor_Example.Models;

namespace DropDownListFor_Example.ViewModels
{
    public class AddProductViewModel
    {
        public string Name { get; set; }
        public Category Category { get; set; }
        public List<Category> Categories { get; set; }

        public AddProductViewModel()
        {
            Categories = new List<Category>();
        }
    }
}