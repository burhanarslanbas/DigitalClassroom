using System;
using System.Collections.Generic;
using System.Text;

namespace DigitalClassroom.EntityLayer.Concrete
{
    public class Role
    {
        public int Id { get; set; } // Rol Id'si
        public string RoleName { get; set; } // Rol Adı

        // Navigation Property
        public virtual ICollection<User> Users { get; set; } // Bir rolün birden fazla kullanıcısı olabilir
    }
}
