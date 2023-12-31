﻿

using ComputerHardwareECommerceApi.Application.Dtos.ShoppingCartDtos;
using FluentValidation;

namespace ComputerHardwareECommerceApi.Application.Validators.ShoppingCartDtoValidators
{
    public class ShoppingCartUpdateDtoValidator:AbstractValidator<ShoppingCartUpdateDto>
    {
        public ShoppingCartUpdateDtoValidator()
        {

            RuleFor(x => x.Id).NotNull().WithMessage("Sepet ID boş geçilemez")
                          .NotEmpty().WithMessage("Sepet ID boş geçilemez");

            RuleFor(x => x.ProductId).NotNull().WithMessage("Ürün ID boş geçilemez")
                                     .NotEmpty().WithMessage("Ürün ID boş geçilemez");

            RuleFor(x => x.Price).NotNull().WithMessage("Ürün fiyatı boş geçilemez")
                               .NotEmpty().WithMessage("Ürün fiyatı boş geçilemez")
                               .GreaterThanOrEqualTo(0).WithMessage("Ürün fiyatı 0'dan küçük olamaz");

            RuleFor(x => x.Count).NotNull().WithMessage("Ürün miktarı boş geçilemez")
                               .NotEmpty().WithMessage("Ürün miktarı boş geçilemez")
                               .GreaterThanOrEqualTo(0).WithMessage("Ürün miktarı 0'dan küçük olamaz");
        }
    }
}
