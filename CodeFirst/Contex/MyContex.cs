using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using CodeFirst.Models;


namespace CodeFirst.Contex
{
    public class MyContex : DbContext
    {
        public MyContex()
            :base("connection")
        {

        }

        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<City>Cities { get; set; }
        public virtual DbSet<District>Districts { get; set; }

    }
}
