using DigitalClassroom.EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalClassroom.BusinessLayer.Validations.StudentSubmissions
{
    public class CreateSubmissionValidator: AbstractValidator<StudentSubmission>
    {
        public CreateSubmissionValidator()
        {
            RuleFor(x => x.StudentId)
                .NotEmpty().WithMessage("Öğrenci seçimi yapmalısınız!");

            RuleFor(x => x.AssignmentId)
                .NotEmpty().WithMessage("Ödev seçimi yapmalısınız!");

            RuleFor(x => x.Content)
                .NotEmpty().WithMessage("Öğrenci içeriği boş olamaz");

            RuleFor(x => x.Status)
                .NotEmpty().WithMessage("Durum seçimi yapmalısınız!");

            RuleFor(x => x.Score)
                .GreaterThan(0).When(x => x.Score != null).WithMessage("Puan 0'dan büyük olmalıdır.");

            RuleFor(x => x.SubmittedAt)
                .NotEmpty().WithMessage("Teslim tarihi seçimi yapmalısınız!");
        }
    }
}
