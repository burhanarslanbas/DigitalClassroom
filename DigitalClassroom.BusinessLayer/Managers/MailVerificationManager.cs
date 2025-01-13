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
    public class MailVerificationManager : IMailVerificationService
    {
        private readonly IMailVerificationRepository _mailVerificationRepository;
        public MailVerificationManager(IMailVerificationRepository mailVerificationRepository)
        {
            _mailVerificationRepository = mailVerificationRepository;
        }
        public void Add(MailVerification entity)
        {
            _mailVerificationRepository.Add(entity);
        }

        public void Delete(MailVerification entity)
        {
            _mailVerificationRepository.Delete(entity);
        }

        public IEnumerable<MailVerification> Find(Expression<Func<MailVerification, bool>> predicate)
        {
            return _mailVerificationRepository.Find(predicate);
        }

        public IEnumerable<MailVerification> GetAll()
        {
            return _mailVerificationRepository.GetAll();
        }

        public MailVerification GetById(int id)
        {
            return _mailVerificationRepository.GetById(id);
        }

        public void Update(MailVerification entity)
        {
            _mailVerificationRepository.Update(entity);
        }
    }
}
