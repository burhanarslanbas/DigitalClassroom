using DigitalClassroom.BusinessLayer.Interfaces;
using DigitalClassroom.DataAccessLayer.Interfaces;
using DigitalClassroom.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DigitalClassroom.BusinessLayer.Managers
{
    public class AnnouncementManager : IAnnouncementService
    {
        private readonly IAnnouncementRepository _announcementRepository;

        public AnnouncementManager(IAnnouncementRepository announcementRepository)
        {
            _announcementRepository = announcementRepository;
        }

        public void Add(Announcement entity)
        {
            _announcementRepository.Add(entity);
        }

        public void Delete(Announcement entity)
        {
            _announcementRepository.Delete(entity);
        }

        public IEnumerable<Announcement> Find(Expression<Func<Announcement, bool>> predicate)
        {
            return _announcementRepository.Find(predicate);
        }

        public IEnumerable<Announcement> GetAll()
        {
            return _announcementRepository.GetAll();
        }

        public Announcement GetById(int id)
        {
            return _announcementRepository.GetById(id);
        }

        public void Update(Announcement entity)
        {
            _announcementRepository.Update(entity);
        }
    }
}
