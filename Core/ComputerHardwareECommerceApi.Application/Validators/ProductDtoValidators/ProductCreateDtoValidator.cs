﻿

using ComputerHardwareECommerceApi.Application.Dtos.Product;
using FluentValidation;

namespace ComputerHardwareECommerceApi.Application.Validators.ProductDtoValidators
{
    public class ProductCreateDtoValidator:AbstractValidator<ProductCreateDto>
    {
        public ProductCreateDtoValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Ürün ismi boş geçilemez")
                            .NotNull().WithMessage("Ürün ismi boş geçilemez")
                            .MinimumLength(5).WithMessage("Ürün ismi en az 5 karakter olamaz");

            RuleFor(x => x.Price).NotEmpty().WithMessage("Fiyat bilgisi boş geçilemez")
                                 .NotNull().WithMessage("Fiyat bilgisi boş geçilemez")
                                 .GreaterThan(0).WithMessage("Fiyat 0'dan büyük olmalı");

            RuleFor(x => x.Stock).NotEmpty().WithMessage("Stok sayısı boş geçilemez")
                            .NotNull().WithMessage("Stok sayısı boş geçilemez")
                            .GreaterThanOrEqualTo(0).WithMessage("Stok 0'dan küçük olamaz");

            RuleFor(x => x.Description).NotEmpty().WithMessage("Açıklama kısmı boş geçilemez")
                                       .NotNull().WithMessage("Açıklama kısmı boş geçilemez")
                                       .MinimumLength(10).WithMessage("Açıklama en az 10 karakter olamalı").MaximumLength(150).WithMessage("Açıklama en fazla 150 karakter olmalı");

            RuleFor(x => x.CategoryId).NotEmpty().WithMessage("Kategori ID boş geçilemez")
                            .NotNull().WithMessage("Kategori ID boş geçilemez");
        }
    }
}
