using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DigitalClassroom.EntityLayer.Concrete;


namespace DigitalClassroom.BusinessLayer.Interfaces
{
    public interface IInstitutionService : IGenericService<Institution>
    {
        void UpdateManagerId(int institutionId, int id);
        void DeactivateInstitutionAndUsers(int institutionId,string deactivatedReason);
        void ActivateInstitutionAndUsers(int institutionId);
    }
}
