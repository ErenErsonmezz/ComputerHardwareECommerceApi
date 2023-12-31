namespace ComputerHardwareECommerceApi.Application.Dtos.ProductImageFileDtos
{
    public class ProductImageFileCreateDto:BaseDto
    {
        public string FileName { get; set; }
        public string FilePath { get; set; }
        public string Storage { get; set; }
        public Guid ProductId { get; set; }
    }
}
