using DigitalClassroom.BusinessLayer.Interfaces;
using DigitalClassroom.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using DigitalClassroom.DataAccessLayer.Interfaces;

namespace DigitalClassroom.BusinessLayer.Managers
{
    public class InstitutionManager : IInstitutionService
    {
        private readonly IInstitutionRepository _institutionRepository;

        public InstitutionManager(IInstitutionRepository institutionRepository)
        {
            _institutionRepository = institutionRepository;
        }

        public void Add(Institution entity)
        {
            _institutionRepository.Add(entity);
        }

        public void Delete(Institution entity)
        {
            _institutionRepository.Delete(entity);
        }

        public IEnumerable<Institution> Find(Expression<Func<Institution, bool>> predicate)
        {
            return _institutionRepository.Find(predicate);
        }

        public IEnumerable<Institution> GetAll()
        {
            return _institutionRepository.GetAll();
        }

        public Institution GetById(int id)
        {
            return _institutionRepository.GetById(id);
        }

        public void Update(Institution entity)
        {
            _institutionRepository.Update(entity);
        }

        public void UpdateManagerId(int institutionId, int id)
        {
            _institutionRepository.UpdateManagerId(institutionId, id);
        }
        public void ActivateInstitutionAndUsers(int institutionId)
        {
            _institutionRepository.ActivateInstitutionAndUsers(institutionId);
        }
        public void DeactivateInstitutionAndUsers(int institutionId, string deactivatedReason)
        {
            _institutionRepository.DeactivateInstitutionAndUsers(institutionId, deactivatedReason);
        }
    }
}
