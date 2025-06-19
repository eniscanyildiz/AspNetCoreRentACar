using System;
using System.Collections.Generic;

namespace RentACar.DataAccess.Models
{
    public partial class Rental
    {
        public int RentalId { get; set; }
        public int? CarId { get; set; }
        public int? CustomerId { get; set; }
        public DateTime? RentDate { get; set; }
        public DateTime? ReturnDate { get; set; }

        public virtual Car? Car { get; set; }
        public virtual Customer? Customer { get; set; }
    }
}
