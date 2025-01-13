using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DigitalClassroom.DataAccessLayer.Interfaces;
using DigitalClassroom.EntityLayer.Concrete;
using System.Data.Entity;

namespace DigitalClassroom.DataAccessLayer.Repositories
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        private readonly DbContext _context;
        public UserRepository(DbContext context) : base(context)
        {
            _context = context;
        }

        public User AuthenticateUser(string email, string password)
        {
            return _context.Set<User>()
                .Include(u => u.Role)
                .Include(u => u.Institution)
                .Include(u => u.MailVerifications)
                .Include(u => u.StudentSubmissions)
                .Include(u => u.Announcements)
                .Include(u => u.Enrollments)
                .Include(u => u.FileAssociations)
                .Include(u => u.Files)
                .FirstOrDefault(x => x.Email == email && x.Password == password);
        }

        public IEnumerable<User> GetTeachersByInstitutionId(int? institutionId)
        {
            // InstitutionId'si eşleşen aktif öğretmenleri getir
            // Eğer institutionId null ise tüm öğretmenleri getir
            if (institutionId == null)
            {
                return _context.Set<User>()
                    .Include(u => u.Role)
                    .Include(u => u.Institution)
                    .Include(u => u.MailVerifications)
                    .Include(u => u.StudentSubmissions)
                    .Include(u => u.Announcements)
                    .Include(u => u.Enrollments)
                    .Include(u => u.FileAssociations)
                    .Include(u => u.Files)
                    .Where(x => x.RoleId == (int)Role.RoleNames.Teacher && x.IsActive == true).ToList();
            }
            else
            {
                return _context.Set<User>()
                    .Include(u => u.Role)
                    .Include(u => u.Institution)
                    .Include(u => u.MailVerifications)
                    .Include(u => u.StudentSubmissions)
                    .Include(u => u.Announcements)
                    .Include(u => u.Enrollments)
                    .Include(u => u.FileAssociations)
                    .Include(u => u.Files)
                    .Where(x => x.RoleId == (int)Role.RoleNames.Teacher && x.InstitutionId == institutionId && x.IsActive == true).ToList();
            }
        }
    }
}