using DigitalClassroom.EntityLayer.Concrete;
using FluentValidation;
using FluentValidation.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalClassroom.BusinessLayer.Validations.Announcements
{
    public class CreateAnnouncementValidator:AbstractValidator<Announcement>
    {
        public CreateAnnouncementValidator()
        {
            // Title, minimum 2 haneli, maximum 50 haneli ve boş bırakılamaz
            RuleFor(x => x.Title)
                .NotEmpty().WithMessage("Başlık alanı boş bırakılamaz.")
                .MaximumLength(50).WithMessage("Başlık alanı en fazla 50 karakter olabilir.");

            // Message, boş bırakılamaz
            RuleFor(x => x.Message)
                .NotEmpty().WithMessage("Mesaj alanı boş bırakılamaz.");
        }
    }
}
