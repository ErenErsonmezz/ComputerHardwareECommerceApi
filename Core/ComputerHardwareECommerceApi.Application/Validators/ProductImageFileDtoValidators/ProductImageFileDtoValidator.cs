

using ComputerHardwareECommerceApi.Application.Dtos.ProductImageFile;
using FluentValidation;

namespace ComputerHardwareECommerceApi.Application.Validators.ProductImageFileDtoValidators
{
    public class ProductImageFileDtoValidator:AbstractValidator<ProductImageFileDto>
    {
        public ProductImageFileDtoValidator()
        {
            RuleFor(x => x.Id).NotEmpty().WithMessage("Id boş geçilemez")
                         .NotNull().WithMessage("Id boş geçilemez");

            RuleFor(x => x.FileName).NotEmpty().WithMessage("İsim boş geçilemez")
                         .NotNull().WithMessage("İsim boş geçilemez")
                         .MinimumLength(5).WithMessage("İsim en az 5 karakter olmalı");

            RuleFor(x => x.FilePath).NotEmpty().WithMessage("Dosya yolu boş geçilemez")
                          .NotNull().WithMessage("Dosya yolu boş geçilemez");

            RuleFor(x => x.Storage).NotEmpty().WithMessage("Depolama adı boş geçilemez")
                          .NotNull().WithMessage("Depolama adı boş geçilemez");

            RuleFor(x => x.ProductId).NotEmpty().WithMessage("Ürün Id boş geçilemez")
                       .NotNull().WithMessage("Ürün Id boş geçilemez");
        }
    }
}
