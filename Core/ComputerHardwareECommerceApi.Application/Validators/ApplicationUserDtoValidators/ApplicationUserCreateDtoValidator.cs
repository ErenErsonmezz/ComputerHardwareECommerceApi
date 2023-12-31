

using ComputerHardwareECommerceApi.Application.Dtos.ApplicationUserDtos;
using ComputerHardwareECommerceApi.Application.Validators.AddressDtoValidators;
using ComputerHardwareECommerceApi.Application.Validators.CreditCardDtoValidators;
using ComputerHardwareECommerceApi.Application.Validators.IbanDtoValidators;
using ComputerHardwareECommerceApi.Application.Validators.OrderDtoValidators;
using FluentValidation;

namespace ComputerHardwareECommerceApi.Application.Validators.ApplicationUserDtoValidators
{
    public class ApplicationUserCreateDtoValidator:AbstractValidator<ApplicationUserCreateDto>
    {
        public ApplicationUserCreateDtoValidator()
        {

            RuleFor(x => x.Name).NotEmpty().WithMessage("İsim kısmı boş geçilemez")
                              .NotNull().WithMessage("İsim kısmı boş geçilemez")
                              .MinimumLength(3).WithMessage("İsim en az 5 karakter olmalı")
                              .MaximumLength(50).WithMessage("İsim en fazla 50 karakter olmalı");


            RuleFor(x => x.Surname).NotEmpty().WithMessage("Soyisim kısmı boş geçilemez")
                              .NotNull().WithMessage("Soyisim kısmı boş geçilemez")
                              .MinimumLength(3).WithMessage("Soyisim en az 5 karakter olmalı")
                              .MaximumLength(50).WithMessage("Soyisim en fazla 50 karakter olmalı");

            RuleFor(x => x.Email).NotEmpty().WithMessage("Email kısmı boş geçilemez")
                               .NotNull().WithMessage("Email kısmı boş geçilemez")
                               .EmailAddress().WithMessage("Email kısmını doğru formatta girin");

            RuleFor(x => x.PhoneNumber).NotNull().WithMessage("Telefon numarası boş geçilemez")
                                     .NotEmpty().WithMessage("Telefon numarası boş geçilemez");

        }
    }
}
