using ComputerHardwareECommerceApi.Domain.Models.Common;

namespace ComputerHardwareECommerceApi.Domain.Models
{
    public class Address : BaseEntity
    {
        public Guid ApplicationUserId { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string PostalCode { get; set; }


    }
}
