namespace ComputerHardwareECommerceApi.Application.Dtos.IbanDtos
{
    public class IbanDto:BaseDto
    {
        public Guid Id { get; set; }
        public Guid ApplicationUserId { get; set; }
        public string Name { get; set; }
        public string IbanNumber { get; set; }
    }
}
