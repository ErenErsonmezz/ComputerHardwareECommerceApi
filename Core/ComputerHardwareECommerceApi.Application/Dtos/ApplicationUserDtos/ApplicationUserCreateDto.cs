namespace ComputerHardwareECommerceApi.Application.Dtos.ApplicationUserDtos
{
    public class ApplicationUserCreateDto:BaseDto
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime BirthDate { get; set; }
        public string Role { get; set; }
    }
}
