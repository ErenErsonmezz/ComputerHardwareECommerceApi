namespace ComputerHardwareECommerceApi.Application.Dtos.Comment
{
    public class CommentDto:BaseDto
    {
        public Guid Id { get; set; }
        public string CommentContent { get; set; }
        public int ProductId { get; set; }
    }
}
