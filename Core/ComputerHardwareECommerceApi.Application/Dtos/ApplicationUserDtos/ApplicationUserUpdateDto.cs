using ComputerHardwareECommerceApi.Application.Dtos.Address;
using ComputerHardwareECommerceApi.Application.Dtos.CreditCardDtos;
using ComputerHardwareECommerceApi.Application.Dtos.IbanDtos;
using ComputerHardwareECommerceApi.Application.Dtos.OrderDtos;

namespace ComputerHardwareECommerceApi.Application.Dtos.ApplicationUserDtos
{
    public class ApplicationUserUpdateDto:BaseDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public string PhoneNumber { get; set; }
        public IEnumerable<AddressDto> Addresses { get; set; }
        public IEnumerable<CreditCardDto> CreditCards { get; set; }
        public IEnumerable<IbanDto> Ibans { get; set; }
        public IEnumerable<OrderDto> Orders { get; set; }
    }
}
