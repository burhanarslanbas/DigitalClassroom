using DigitalClassroom.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalClassroom.BusinessLayer.Interfaces
{
    public interface IUserService:IGenericService<User>
    {
        User AuthenticateUser(string email, string password);
        Role GetRoleById(int roleId);
        IEnumerable<User> GetTeachersByInstitutionId(int? institutionId);   
    }
}
