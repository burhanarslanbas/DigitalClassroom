using System;
using System.Collections.Generic;
using System.Text;

namespace DigitalClassroom.EntityLayer.Concrete
{
    public class MailVerification
    {
        public int Id { get; set; } // Doğrulama Id'si
        public int UserId { get; set; } // Kullanıcı Id'si
        public string VerificationCode { get; set; } // 6 haneli olacak doğrulama kodu
        public bool IsActive { get; set; } // Doğrulama kodunun aktif olup olmadığı 
        public bool IsVerify { get; set; } // Doğrulama kodunun doğrulanıp doğrulanmadığı
        public DateTime VerifiedAt { get; set; } // Doğrulama tarihi
        public DateTime CreatedAt { get; set; } // Doğrulama oluşturulma tarihi
        public DateTime UpdatedAt { get; set; } // Doğrulama kodunun güncellenme tarihi

        // Navigation Property
        public User User { get; set; } // Kullanıcı
    }
}
