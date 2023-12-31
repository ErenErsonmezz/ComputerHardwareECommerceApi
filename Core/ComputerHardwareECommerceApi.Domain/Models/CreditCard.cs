using ComputerHardwareECommerceApi.Domain.Models.Common;

namespace ComputerHardwareECommerceApi.Domain.Models
{
    public class CreditCard:BaseEntity
    {
        public Guid ApplicationUserId { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }
        public string CardName { get; set; }
        public string CardNumber { get; set; }
        public DateTime ExpirationDateMonth { get; set; }
        public DateTime ExpirationDateYear { get; set; }
        public string Cvc {  get; set; }
    }
}