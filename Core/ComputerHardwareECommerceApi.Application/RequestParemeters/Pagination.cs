

namespace ComputerHardwareECommerceApi.Application.RequestParemeters
{
    public record Pagination
    {
        public int Page { get; set; } = 0;
        public int PageSize { get; set; } = 5;
    }
}
