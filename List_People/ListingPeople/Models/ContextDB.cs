using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ListingPeople.Models
{
    public class ContextDB : DbContext
    {
        public DbSet<People> GetPeoples { get; set; }
        
    }
}