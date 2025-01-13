using System;
using System.Collections.Generic;
using System.Text;

namespace DigitalClassroom.EntityLayer.Concrete
{
    public class Institution
    {
        public int Id { get; set; } // Kurum Id'si
        public int ManagerId { get; set; } // Yönetici Id'si
        public int CreatorId { get; set; } // Oluşturan kişinin Id'si
        public string Name { get; set; } // Kurum Adı
        public string Address { get; set; } // Kurum Adresi
        public string ContactNumber { get; set; } // Kurum Telefon Numarası
        public string Email { get; set; } // Kurum E-Posta Adresi
        public bool IsActive { get; set; } // Kurumun aktif olup olmadığı
        public DateTime CreatedAt { get; set; } // Kurumun oluşturulma tarihi
        public DateTime? UpdatedAt { get; set; } // Güncellenme Tarihi
        public DateTime? DeactivetedDate { get; set; } // Pasif hale getirilme tarihi
        public string DeactivetedReason { get; set; } // Pasif hale getirilme sebebi

        // Navigation Properties
        public User Manager { get; set; } // Kurum Yöneticisi
        public User Creator { get; set; } // Kurumu oluşturan kullanıcı
        public ICollection<Announcement> Announcements { get; set; } // Kuruma ait duyurular
        public ICollection<FileAssociation> FileAssociations { get; set; } // Kuruma ait dosyalar
    }
}
