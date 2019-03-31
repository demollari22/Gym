using GymApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace GymApp.Data
{
    public class GymAppDb : DbContext
    {
     public DbSet<Customer>   Customers { get; set; }
     public DbSet<Subscription> Subscriptions { get; set; }
    }
}