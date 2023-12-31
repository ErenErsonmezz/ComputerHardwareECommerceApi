using ComputerHardwareECommerceApi.Application.Dtos.ShoppingCartDtos;

namespace ComputerHardwareECommerceApi.Application.Dtos.OrderDtos
{
    public class OrderDto:BaseDto
    {
        public Guid Id { get; set; }
        public DateTime OrderDate { get; set; }
        public double OrderTotal { get; set; }
        public string OrderStatus { get; set; }
        public int AddressId { get; set; }
        public IEnumerable<ShoppingCartDto> ShoppingCarts { get; set; }
        public Guid CreditCardId { get; set; }
        public int Count { get; set; }
        public double Price { get; set; }
    }
}
