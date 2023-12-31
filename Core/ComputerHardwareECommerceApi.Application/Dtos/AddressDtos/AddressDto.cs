using ComputerHardwareECommerceApi.Application.Dtos.ApplicationUser;

namespace ComputerHardwareECommerceApi.Application.Dtos.Address
{
    public class AddressDto:BaseDto
    {
        public Guid Id { get; set; }
        public Guid ApplicationUserId { get; set; }
        public virtual ApplicationUserDto ApplicationUser { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string PostalCode { get; set; }
    }
}
