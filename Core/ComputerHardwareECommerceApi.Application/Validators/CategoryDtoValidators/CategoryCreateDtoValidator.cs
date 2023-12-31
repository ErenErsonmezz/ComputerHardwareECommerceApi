

using ComputerHardwareECommerceApi.Application.Dtos.Category;
using FluentValidation;

namespace ComputerHardwareECommerceApi.Application.Validators.CategoryDtoValidators
{
    public class CategoryCreateDtoValidator:AbstractValidator<CategoryCreateDto>
    {
        public CategoryCreateDtoValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Kategori ismi boş geçilemez")
                             .NotNull().WithMessage("Kategori ismi boş geçilemez");
        }
    }
}
