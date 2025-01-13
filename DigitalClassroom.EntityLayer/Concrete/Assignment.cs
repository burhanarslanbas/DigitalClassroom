 using System;
using System.Collections.Generic;
using System.Text;

namespace DigitalClassroom.EntityLayer.Concrete
{
    public class Assignment
    {
        public Assignment()
        {
            FileAssociations = new List<FileAssociation>();
            StudentSubmissions = new List<StudentSubmission>();
        }
        public int Id { get; set; } // Ödev Id'si
        public int CourseId { get; set; } // Ders Id'si
        public int CreatorId { get; set; } // Oluşturan Kullanıcı Id'si
        public string Title { get; set; } // Ödev Başlığı
        public string Description { get; set; } // Ödev Açıklaması
        public double MaxScore { get; set; } // Maksimum Puan
        public DateTime DueDate { get; set; } // Teslim Tarihi
        public DateTime CreatedDate { get; set; } // Oluşturulma Tarihi

        // Navigation Properties
        public ICollection<FileAssociation> FileAssociations { get; set; } // Ödev Dosyaları
        public ICollection<StudentSubmission> StudentSubmissions { get; set; } // Öğrenci Teslimleri
        public virtual Course Course { get; set; } // Ödevin ait olduğu ders
        public virtual User Creator { get; set; } // Ödevi oluşturan kullanıcı
    }
}
