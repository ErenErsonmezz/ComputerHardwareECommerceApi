namespace ComputerHardwareECommerceApi.Application.Dtos.Address
{
    public class AddressUpdateDto:BaseDto
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string PostalCode { get; set; }
    }
}
