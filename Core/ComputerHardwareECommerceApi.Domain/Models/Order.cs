

using ComputerHardwareECommerceApi.Domain.Models.Common;

namespace ComputerHardwareECommerceApi.Domain.Models
{
    public class Order:BaseEntity
    {
        public DateTime OrderDate { get; set; }
        public double OrderTotal { get; set; }
        public string OrderStatus { get; set; }
        public int AddressId { get; set; }
        public virtual Address Address { get; set; } 
        public IEnumerable<ShoppingCart> ShoppingCarts { get; set; }
        public IEnumerable<Product> Products { get; set; }
        public Guid CreditCardId { get; set; }
        public virtual CreditCard CreditCard { get; set; }
        public int Count { get; set; }
        public double Price { get; set; }
    }
}
