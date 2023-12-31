
using ComputerHardwareECommerceApi.Domain.Models.Common;

namespace ComputerHardwareECommerceApi.Domain.Models
{
    public class Product:BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }
        public bool IsHome { get; set; }
        public IEnumerable<Comment> Comments { get; set; }
        public double RatingPoint { get; set; }
        public Guid CategoryId { get; set; }
        public virtual Category Category { get; set; }


    }
}
