using System;
namespace RentACar.Entity.Entities
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

