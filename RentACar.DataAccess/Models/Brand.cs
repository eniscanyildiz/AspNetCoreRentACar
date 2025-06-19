using System;
using System.Collections.Generic;

namespace RentACar.DataAccess.Models
{
    public partial class Brand
    {
        public Brand()
        {
            Cars = new HashSet<Car>();
        }

        public int BrandId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<Car> Cars { get; set; }
    }
}
