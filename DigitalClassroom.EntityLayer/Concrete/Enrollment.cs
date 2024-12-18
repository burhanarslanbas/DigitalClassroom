using System;
using System.Collections.Generic;
using System.Text;

namespace DigitalClassroom.EntityLayer.Concrete
{
    public class Enrollment
    {
        public int Id { get; set; } // Kayıt Id'si
        public int StudentId { get; set; } // Öğrenci Id'si 
        public int CourseId { get; set; } // Ders Id'si
        public string EnrollmentWay { get; set; } // Kayıt Yolu (Link,öğretmen,sınıf kodu gibi)
        public bool IsActive { get; set; } // Öğrencinin kaydının aktif olup olmadığı
        public DateTime EnrollmentDate { get; set; } // Kayıt Tarihi
        public DateTime DeactivetedDate { get; set; } // Pasif hale getirilme tarihi
        public string DeactivetedReason { get; set; } // Pasif hale getirilme sebebi

        // Navigation Properties
        public User Student { get; set; } // Öğrenci
        public Course Course { get; set; } // Ders
    }
}
