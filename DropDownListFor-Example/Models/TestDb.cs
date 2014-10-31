using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using DropDownListFor_Example.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace DropDownListFor_Example.Models
{
    public class ApplicationUser : IdentityUser
    {
    }

    public class TestDb : IdentityDbContext
	{
        public TestDb() : base("name=TestDb") { }

        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        
        public DbSet<Product> Products { get; set; }
		public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }
	}
}