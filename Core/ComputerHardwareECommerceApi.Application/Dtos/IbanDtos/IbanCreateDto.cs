namespace ComputerHardwareECommerceApi.Application.Dtos.IbanDtos
{
    public class IbanCreateDto:BaseDto
    {
        public Guid ApplicationUserId { get; set; }
        public string Name { get; set; }
        public string IbanNumber { get; set; }
    }
}
