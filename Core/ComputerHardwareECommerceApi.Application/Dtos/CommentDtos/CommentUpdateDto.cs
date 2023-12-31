namespace ComputerHardwareECommerceApi.Application.Dtos.CommentDtos
{
    public class CommentUpdateDto:BaseDto
    {
        public Guid Id { get; set; }
        public string CommentContent { get; set; }
    }
}
