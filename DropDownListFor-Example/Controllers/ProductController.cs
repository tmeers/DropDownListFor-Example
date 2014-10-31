using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DropDownListFor_Example.Models;
using DropDownListFor_Example.ViewModels;

namespace DropDownListFor_Example.Controllers
{
    public class ProductController : Controller
    {
        private TestDb db = new TestDb();

        // GET: /Product/
        public ActionResult Index()
        {
            return View(db.Products.ToList());
        }

        // GET: /Product/Create
        public ActionResult Create()
        {
            ViewModels.AddProductViewModel products = new AddProductViewModel();
            products.Categories.Add(new Category()
            {
                Id = 1,
                Name = "Category 1"
            });
            products.Categories.Add(new Category()
            {
                Id = 2,
                Name = "Category 2"
            });
            products.Categories.Add(new Category()
            {
                Id = 3,
                Name = "Category 3"
            });

            return View(products);
        }

        // POST: /Product/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="Id,Name,Category")] AddProductViewModel product)
        {
            if (ModelState.IsValid)
            {
                Product newProduct = new Product();
                newProduct.Name = product.Name;
                newProduct.Category = product.Category;

                db.Products.Add(newProduct);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(product);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
