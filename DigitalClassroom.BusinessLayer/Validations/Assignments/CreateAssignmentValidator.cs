using DigitalClassroom.EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalClassroom.BusinessLayer.Validations.Assignments
{
    public class CreateAssignmentValidator : AbstractValidator<Assignment>
    {
        public CreateAssignmentValidator()
        {
            RuleFor(x => x.Title)
                .NotEmpty().WithMessage("Başlık boş olamaz");

            RuleFor(x => x.Description)
                .NotEmpty().WithMessage("Açıklama boş olamaz");

            RuleFor(x => x.MaxScore)
                .GreaterThan(0).When(x => x.MaxScore != null).WithMessage("Maksimum puan 0'dan büyük olmalıdır.");

            RuleFor(x => x.DueDate)
                .NotEmpty().WithMessage("Teslim tarihi seçimi yapmalısınız!")
                .GreaterThan(DateTime.Now).WithMessage("Teslim tarihi bugünden ileri bir tarih olmalıdır.");

            RuleFor(x => x.CourseId)
                .NotEmpty().WithMessage("Ders seçimi yapmalısınız!");

            RuleFor(x => x.CreatorId)
                .NotEmpty().WithMessage("Oluşturan kullanıcı seçimi yapmalısınız!");

            RuleFor(x => x.CreatedDate)
                .NotEmpty().WithMessage("Oluşturulma tarihi seçimi yapmalısınız!");
        }
    }
}
