namespace ComputerHardwareECommerceApi.Application.Dtos.IbanDtos
{
    public class IbanUpdateDto:BaseDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string IbanNumber { get; set; }
    }
}
