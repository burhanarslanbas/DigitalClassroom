using DigitalClassroom.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalClassroom.DataAccessLayer.Interfaces
{
    public interface IInstitutionRepository : IGenericRepository<Institution>
    {
        void UpdateManagerId(int institutionId, int id);
        void DeactivateInstitutionAndUsers(int institutionId,string deactivatedReason);
        void ActivateInstitutionAndUsers(int institutionId);
    }
}
