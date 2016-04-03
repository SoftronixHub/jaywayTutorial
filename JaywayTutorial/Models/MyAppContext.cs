using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace JaywayTutorial.Models
{
    public class MyAppContext:DBContext
    {
        public MyAppContext()
            : base("MyAppContext")
        {

        }

        public DbSet<Thing> Things { get; set; }
    }
}