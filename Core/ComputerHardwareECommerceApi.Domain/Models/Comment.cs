using ComputerHardwareECommerceApi.Domain.Models.Common;

namespace ComputerHardwareECommerceApi.Domain.Models
{
    public class Comment:BaseEntity
    {
        public string CommentContent { get; set; }
        public Guid ProductId { get; set; }
        public virtual Product Product { get; set; }
    }
}