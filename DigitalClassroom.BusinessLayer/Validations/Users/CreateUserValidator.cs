using DigitalClassroom.EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalClassroom.BusinessLayer.Validations.Users
{
    public class CreateUserValidator : AbstractValidator<User>
    {
        public CreateUserValidator()
        {
            // Name, minimum 2 haneli, maximum 50 haneli ve boş bırakılamaz
            RuleFor(x=>x.Name)
                .NotEmpty().WithMessage("Ad alanı boş bırakılamaz.")
                .MaximumLength(50).WithMessage("Ad alanı en fazla 50 karakter olabilir.")
                .MinimumLength(2).WithMessage("Ad alanı en az 2 karakter olmalıdır.");

            // Surname, minimum 2 haneli, maximum 50 haneli ve boş bırakılamaz
            RuleFor(x => x.Surname)
                .NotEmpty().WithMessage("Soyad alanı boş bırakılamaz.")
                .MaximumLength(50).WithMessage("Soyad alanı en fazla 50 karakter olabilir.")
                .MinimumLength(2).WithMessage("Soyad alanı en az 2 karakter olmalıdır.");

            // Email, boş bırakılamaz ve geçerli bir e-posta adresi olmalı
            RuleFor(x => x.Email)
                .NotEmpty().WithMessage("E-posta alanı boş bırakılamaz.")
                .EmailAddress().WithMessage("Geçerli bir e-posta adresi giriniz.");

            //Password, minimum 6 haneli ve boş bırakılamaz
            RuleFor(x => x.Password)
                .NotEmpty().WithMessage("Şifre alanı boş bırakılamaz.")
                .MinimumLength(6).WithMessage("Şifre en az 6 karakter olmalıdır.");

            // RoleId alanı -1'e eşitse uyarı mesajı ver
            RuleFor(x => x.RoleId)
                .NotEqual(-1).WithMessage("Rol seçimi yapınız.");
        }
    }
}
