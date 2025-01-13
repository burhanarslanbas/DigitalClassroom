using DigitalClassroom.EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalClassroom.BusinessLayer.Validations.Institutions
{
    public class CreateInstitutionValidator:AbstractValidator<Institution>
    {
        public CreateInstitutionValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("Kurum adı boş olamaz");

            RuleFor(x => x.Address)
                .NotEmpty().WithMessage("Kurum adresi boş olamaz");

            RuleFor(x => x.ContactNumber)
                .NotEmpty().WithMessage("Kurum telefon numarası boş olamaz");

            RuleFor(x => x.Email)
                .NotEmpty().WithMessage("Kurum e-posta adresi boş olamaz")
                .EmailAddress().WithMessage("Geçerli bir email adresi giriniz.");
        }
    }
}
