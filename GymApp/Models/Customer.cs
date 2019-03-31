using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GymApp.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string CustomerEmail { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }
        public DateTime DateofBirth { get; set; }

        public ICollection<Subscription> Subscriptions { get; set; }
    }
}