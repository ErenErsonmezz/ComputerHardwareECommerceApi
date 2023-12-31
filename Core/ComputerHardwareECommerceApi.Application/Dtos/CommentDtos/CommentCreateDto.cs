namespace ComputerHardwareECommerceApi.Application.Dtos.CommentDtos
{
    public class CommentCreateDto:BaseDto
    {
        public string CommentContent { get; set; }
        public int ProductId { get; set; }
    }
}
