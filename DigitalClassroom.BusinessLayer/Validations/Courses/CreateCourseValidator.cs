using DigitalClassroom.EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalClassroom.BusinessLayer.Validations.Courses
{
    public class CreateCourseValidator : AbstractValidator<Course>
    {
        public CreateCourseValidator()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Kurs başlığı boş olamaz");

            RuleFor(x => x.Description).NotEmpty().WithMessage("Kurs açıklaması boş olamaz");

            RuleFor(x => x.TeacherId).NotEmpty().WithMessage("Öğretmen seçimi yapmalısınız!");

            RuleFor(x => x.CourseCapacity).GreaterThan(0).When(x => x.CourseCapacity != null).WithMessage("Kurs kapasitesi 0'dan büyük olmalıdır.");
        }
    }
}
