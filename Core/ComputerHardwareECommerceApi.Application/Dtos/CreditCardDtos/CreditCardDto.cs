

using ComputerHardwareECommerceApi.Application.Dtos.ApplicationUser;

namespace ComputerHardwareECommerceApi.Application.Dtos.CreditCardDtos
{
    public class CreditCardDto
    {
        public Guid Id { get; set; }
        public Guid ApplicationUserId { get; set; }
        public string CardName { get; set; }
        public string CardNumber { get; set; }
        public int ExpirationDateMonth { get; set; }
        public int ExpirationDateYear { get; set; }
        public string Cvc { get; set; }
    }
}
