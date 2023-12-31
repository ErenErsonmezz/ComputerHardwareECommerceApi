using ComputerHardwareECommerceApi.Application.Dtos.ApplicationUserDtos;
using ComputerHardwareECommerceApi.Application.Validators.AddressDtoValidators;
using ComputerHardwareECommerceApi.Application.Validators.CreditCardDtoValidators;
using ComputerHardwareECommerceApi.Application.Validators.IbanDtoValidators;
using ComputerHardwareECommerceApi.Application.Validators.OrderDtoValidators;
using FluentValidation;

namespace ComputerHardwareECommerceApi.Application.Validators.ApplicationUserDtoValidators
{
    public class ApplicationUserUpdateDtoValidator:AbstractValidator<ApplicationUserUpdateDto>
    {
        public ApplicationUserUpdateDtoValidator()
        {

            RuleFor(x => x.Id).NotEmpty().WithMessage("Kullanıcı ID boş geçilemez")
                            .NotNull().WithMessage("Kullanıcı ID boş geçilemez");

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

            RuleForEach(x => x.Addresses).NotEmpty().WithMessage("Adres boş geçilemez")
                             .NotNull().WithMessage("Adres boş geçilemez")
                             .SetValidator(new AddressDtoValidator());

            RuleForEach(x => x.CreditCards).NotEmpty().WithMessage("Kredi Kart boş geçilemez")
                              .NotNull().WithMessage("Kredi Kart boş geçilemez")
                              .SetValidator(new CreditCardDtoValidator());

            RuleForEach(x => x.Orders).NotEmpty().WithMessage("Siparişler boş geçilemez")
                            .NotNull().WithMessage("Siparişler boş geçilemez")
                            .SetValidator(new OrderDtoValidator());

            RuleForEach(x => x.Ibans).NotEmpty().WithMessage("Iban boş geçilemez")
                           .NotNull().WithMessage("Iban boş geçilemez")
                           .SetValidator(new IbanDtoValidator());
        }
    }
}
