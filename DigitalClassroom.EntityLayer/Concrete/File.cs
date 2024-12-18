using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace DigitalClassroom.EntityLayer.Concrete
{
    public class File
    {
        public int Id { get; set; } // Dosya ID'si
        public int UploaderId { get; set; } // Dosyayı yükleyen kullanıcının ID'si
        public string Name { get; set; } // Dosyanın adı (örn: "odev1.docx")
        public string Path { get; set; } // Dosyanın fiziksel yolu
        public string Type { get; set; } // Dosya türü (örn: PDF, JPG, DOCX)
        public long Size { get; set; } // Dosya boyutu (byte cinsinden)
        public DateTime UploadedAt { get; set; } // Yükleme tarihi
        public string Metadata { get; set; } // Metadata (isteğe bağlı, detaylı bilgi saklamak için kullanılabilir)

        // Navigation Properties
        public virtual User Uploader { get; set; } // Dosyayı yükleyen kullanıcı
        public virtual ICollection<FileAssociation> FileAssociations { get; set; } // Dosyanın kullanıldığı yerler
    }
}
