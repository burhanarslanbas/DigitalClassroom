using System;
using System.Collections.Generic;
using System.Text;

namespace DigitalClassroom.EntityLayer.Concrete
{
    public class StudentSubmission
    {
        public StudentSubmission()
        {
            FileAssociations = new List<FileAssociation>();
        }
        public int Id { get; set; } // Öğrenci Ödev Teslim ID'si
        public int StudentId { get; set; } // Öğrenci ID'si
        public int AssignmentId { get; set; } // Ödev ID'si
        public string Content { get; set; } // Öğrencinin yazdığı içerik
        public string Status { get; set; } // "Tamamlandı", "Notlandırıldı" gibi durumlar
        public double Score { get; set; } // Öğrencinin aldığı puan (isteğe bağlı)
        public DateTime SubmittedAt { get; set; } // Teslim edilme tarihi
        public DateTime UpdatedAt { get; set; } // Güncellenme tarihi

        // Navigation Properties
        public User Student { get; set; } // Öğrenci
        public Assignment Assignment { get; set; } // Ödev
        public ICollection<FileAssociation> FileAssociations { get; set; }

        // Statuslerin bulunacağı bir enum oluştur
        public enum SubmissionStatus
        {
            Tamamlandı = 1,
            Notlandırıldı
        }

    }
}