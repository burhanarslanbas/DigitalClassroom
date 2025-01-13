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
    public class InstitutionRepository : GenericRepository<Institution>, IInstitutionRepository
    {
        private readonly DbContext _context;
        public InstitutionRepository(DbContext context) : base(context)
        {
            _context = context;
        }

        public void ActivateInstitutionAndUsers(int institutionId)
        {
            // Önce kuruma bağlı tüm kullanıcıların IsActive değerini true olarak değiştir
            var users = _context.Set<User>().Where(u => u.InstitutionId == institutionId);
            if (users.Count() > 0)
            {
                foreach (var user in users)
                {
                    user.IsActive = true;
                    user.UpdatedAt = DateTime.Now;
                }
            }
            // Kuruma bağlı tüm kursların IsActive değerini true olarak değiştir
            var courses = _context.Set<Course>().Where(c => c.InstitutionId == institutionId);
            if (courses.Count() > 0)
            {
                foreach (var course in courses)
                {
                    course.IsActive = true;
                }
            }
            // Ardından kurumun aktiflik durumunu true olarak değiştir.
            var institution = _context.Set<Institution>().Find(institutionId);
            institution.IsActive = true;
            institution.UpdatedAt = DateTime.Now;
            _context.SaveChanges();
        }

        public void DeactivateInstitutionAndUsers(int institutionId, string deactivatedReason)
        {
            // Önce kuruma bağlı tüm kullanıcıların IsActive değerini false olarak değiştir
            var users = _context.Set<User>().Where(u => u.InstitutionId == institutionId);
            if (users.Count() > 0)
            {
                foreach (var user in users)
                {
                    user.IsActive = false;
                    user.DeactivetedReason = "Kurum aktif olmadığı için kullanıcı pasif hale getirilmiştir!";
                    user.DeactivetedDate = DateTime.Now;
                }
            }
            // Kuruma bağlı tüm kursların IsActive değerini false olarak değiştir
            var courses = _context.Set<Course>().Where(c => c.InstitutionId == institutionId);
            if (courses.Count() > 0)
            {
                foreach (var course in courses)
                {
                    course.IsActive = false;
                    course.DeactivetedReason = "Kurum aktif olmadığı için kurs pasif hale getirilmiştir!";
                    course.DeactivetedDate = DateTime.Now;
                }
            }
            // Ardından kurumun aktiflik durumunu false olarak değiştir.
            var institution = _context.Set<Institution>().Find(institutionId);
            institution.DeactivetedReason = deactivatedReason;
            institution.DeactivetedDate = DateTime.Now;
            institution.IsActive = false;
            _context.SaveChanges();
        }

        public void UpdateManagerId(int institutionId, int id)
        {
            var manager = _context.Set<User>().Where(x => x.InstitutionId == institutionId && x.RoleId == (int)Role.RoleNames.Manager).FirstOrDefault();
            // Seçilen müdürün de institutionId'sini bu kurumunki ile aynı yap
            var newManager = _context.Set<User>().Where(x => x.Id == id).FirstOrDefault();
            newManager.InstitutionId = institutionId;

            // Eğer kurumun mevcut müdürü varsa müdürün institutionId'sini boş yap
            // Kurumun managerId'sini kullanıcınınki ile eşitle
            var institution = _context.Set<Institution>().Where(x => x.Id == institutionId).FirstOrDefault();
            institution.ManagerId = newManager.Id;

            manager.InstitutionId = null;
            _context.SaveChanges();
        }
    }
}
