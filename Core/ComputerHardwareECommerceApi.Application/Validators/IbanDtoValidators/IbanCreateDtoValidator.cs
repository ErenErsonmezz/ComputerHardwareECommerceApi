

using ComputerHardwareECommerceApi.Application.Dtos.IbanDtos;
using FluentValidation;

namespace ComputerHardwareECommerceApi.Application.Validators.IbanDtoValidators
{
    public class IbanCreateDtoValidator:AbstractValidator<IbanCreateDto>
    {
        public IbanCreateDtoValidator()
        {

            RuleFor(x => x.Name).NotEmpty().NotEmpty().WithMessage("İsim boş geçilemez")
                            .NotNull().WithMessage("İsim boş geçilemez")
                            .MinimumLength(5).WithMessage("İsim en az 5 karakter olmalı");

            RuleFor(x => x.IbanNumber).NotEmpty().NotEmpty().WithMessage("İsim boş geçilemez")
                            .NotNull().WithMessage("İsim boş geçilemez")
                            .Length(26).WithMessage("Iban numarası 26 karakter olmalı");

            RuleFor(x => x.ApplicationUserId).NotEmpty().WithMessage("Kullanıcı ID boş geçilemez")
                           .NotNull().WithMessage("Kullanıcı ID boş geçilemez");
        }
    }
}
