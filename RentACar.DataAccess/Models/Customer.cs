using System;
using System.Collections.Generic;

namespace RentACar.DataAccess.Models
{
    public partial class Customer
    {
        public Customer()
        {
            Rentals = new HashSet<Rental>();
        }

        public int CustomerId { get; set; }
        public string? FullName { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }

        public virtual ICollection<Rental> Rentals { get; set; }
    }
}
