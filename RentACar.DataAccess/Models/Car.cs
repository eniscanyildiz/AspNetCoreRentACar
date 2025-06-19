using System;
using System.Collections.Generic;

namespace RentACar.DataAccess.Models
{
    public partial class Car
    {
        public Car()
        {
            Rentals = new HashSet<Rental>();
        }

        public int CarId { get; set; }
        public int? BrandId { get; set; }
        public string? Model { get; set; }
        public int? Year { get; set; }
        public decimal? DailyPrice { get; set; }
        public string? Description { get; set; }
        public bool? Available { get; set; }
        public string? ImageUrl { get; set; }

        public virtual Brand? Brand { get; set; }
        public virtual ICollection<Rental> Rentals { get; set; }
    }
}
