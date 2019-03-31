using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GymApp.Models
{
    public class Subscription
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public double Price { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public int CustomerId { get; set; }

        //public virtual Customer Customer { get; set; }

    }
}