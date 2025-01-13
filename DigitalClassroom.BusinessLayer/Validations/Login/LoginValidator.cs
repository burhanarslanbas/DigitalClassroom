using FluentValidation;
using FluentValidation.Results;
using System;

namespace DigitalClassroom.BusinessLayer.Validations.Login
{
    public class LoginValidator:AbstractValidator<(string Email, string Password)>
    {
        public LoginValidator()
        {
            RuleFor(x => x.Email)
                .NotEmpty().WithMessage("Email alanı boş geçilemez.")
                .EmailAddress().WithMessage("Geçerli bir email adresi giriniz.");

            RuleFor(x => x.Password)
                .NotEmpty().WithMessage("Şifre alanı boş geçilemez.")
                .MinimumLength(6).WithMessage("Şifre en az 6 karakter olmalıdır.");
        }
    }
}
