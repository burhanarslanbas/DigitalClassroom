using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalClassroom.EntityLayer.Concrete
{
    public class FileAssociation
    {
        public int Id { get; set; } // Dosya İlişkilendirme ID'si
        public int FileId { get; set; } // Dosya ID'si
        public int? UserId { get; set; } // Kullanıcı ID'si (isteğe bağlı)
        public int? AssignmentId { get; set; } // Ödev ID'si (isteğe bağlı)
        public int? InstitutionId { get; set; } // Kurum ID'si (isteğe bağlı)
        public int? AnnouncementId { get; set; } // Duyuru ID'si (isteğe bağlı)
        public int? StudentSubmissionId { get; set; } // Öğrenci Ödev Teslim ID'si (isteğe bağlı)
        public int? CourseId { get; set; } // Ders ID'si (isteğe bağlı)

        // Navigation Properties
        public virtual File File { get; set; } // File sınıfı ile ilişkisi
        public virtual Assignment Assignment { get; set; } // Assignment sınıfı ile ilişkisi
        public virtual Institution Institution { get; set; } // Institution sınıfı ile ilişkisi
        public virtual Announcement Announcement { get; set; } // Announcement sınıfı ile ilişkisi
        public virtual StudentSubmission StudentSubmission { get; set; } // StudentSubmission sınıfı ile ilişkisi
        public virtual Course Course { get; set; } // Course sınıfı ile ilişkisi
        public virtual User User { get; set; } // User sınıfı ile ilişkisi
    }
}