using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DigitalClassroom.EntityLayer.Concrete
{
    public class Announcement
    {
        public Announcement()
        {
            FileAssociations = new List<FileAssociation>();
        }
        public int Id { get; set; } // Duyuru Id'si
        public int? CourseId { get; set; } // Ders Id'si
        public int? InstitutionId { get; set; } // Kurum Id'si
        public int CreatorId { get; set; } // Oluşturan Kullanıcı Id'si
        public string Title { get; set; } // Duyuru Başlığı
        public string Message { get; set; } // Duyuru Mesajı
        public bool IsDeleted { get; set; } // Silinme Durumu
        public DateTime CreatedAt { get; set; } // Oluşturulma Tarihi
        public DateTime? UpdatedAt { get; set; } // Güncellenme Tarihi
        public DateTime? DeletedAt { get; set; } // Silinme Tarihi

        // Navigation Properties
        public virtual ICollection<FileAssociation> FileAssociations { get; set; } // Duyuruya ait dosyalar
        public virtual Course Course { get; set; } // Duyurunun ait olduğu ders
        public virtual User Creator { get; set; } // Duyuruyu oluşturan kullanıcı
        public virtual Institution Institution { get; set; } // Duyurunun ait olduğu kurum
    }
}
