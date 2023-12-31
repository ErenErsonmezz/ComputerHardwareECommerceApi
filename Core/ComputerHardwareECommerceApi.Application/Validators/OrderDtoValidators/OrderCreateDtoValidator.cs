
using ComputerHardwareECommerceApi.Application.Dtos.OrderDtos;
using ComputerHardwareECommerceApi.Application.Validators.ShoppingCartDtoValidators;
using FluentValidation;

namespace ComputerHardwareECommerceApi.Application.Validators.OrderDtoValidators
{
    public class OrderCreateDtoValidator:AbstractValidator<OrderCreateDto>
    {
        public OrderCreateDtoValidator()
        {
            RuleFor(x => x.AddressId).NotEmpty().WithMessage("Adres ID boş geçilemez")
                          .NotNull().WithMessage("Adres ID boş geçilemez")
                          .GreaterThan(0).WithMessage("Id 0 ve 0'dan küçük olamaz");

            RuleFor(x => x.CreditCardId).NotEmpty().WithMessage("Kredi Kart ID boş geçilemez")
                            .NotNull().WithMessage("Kredi Kart ID boş geçilemez");

            RuleFor(x => x.OrderDate).NotEmpty().WithMessage("Sipariş tarihi boş geçilemez")
                                     .NotNull().WithMessage("Sipariş tarihi boş geçilemez");

            RuleFor(x => x.OrderStatus).NotEmpty().WithMessage("Sipariş tarihi boş geçilemez")
                                     .NotNull().WithMessage("Sipariş tarihi boş geçilemez");

            RuleFor(x => x.OrderTotal).NotEmpty().WithMessage("Sipariş tutarı boş geçilemez")
                                      .NotNull().WithMessage("Sipariş tutarı boş geçilemez")
                                      .GreaterThan(0).WithMessage("Sipariş tutarı 0'dan büyük olmalı");

            RuleForEach(x => x.ShoppingCarts).NotEmpty().WithMessage("Alışveriş sepeti boş geçilemez")
                                           .NotNull().WithMessage("Alışveriş sepeti boş geçilemez")
                                           .SetValidator(new ShoppingCartDtoValidator());

            RuleFor(x => x.Price).NotEmpty().WithMessage("Fiyat bilgisi boş geçilemez")
                                 .NotNull().WithMessage("Fiyat bilgisi boş geçilemez")
                                 .GreaterThanOrEqualTo(0).WithMessage("Fiyat 0'dan küçük olamaz");


            RuleFor(x => x.Count).NotEmpty().WithMessage("Adet bilgisi boş geçilemez")
                               .NotNull().WithMessage("Adet bilgisi boş geçilemez")
                               .GreaterThan(0).WithMessage("Adet 0'dan büyük olmalı");
        }
    }
}
