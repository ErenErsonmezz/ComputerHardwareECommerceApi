using ComputerHardwareECommerceApi.Domain.Models.Common;

namespace ComputerHardwareECommerceApi.Domain.Models
{
    public class Iban:BaseEntity
    {
        public Guid ApplicationUserId { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }
        public string Name { get; set; }
        public string IbanNumber { get; set; }
    }
}