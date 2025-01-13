using DigitalClassroom.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalClassroom.DataAccessLayer.Interfaces
{
    public interface IUserRepository : IGenericRepository<User>
    {
        User AuthenticateUser(string email, string password);
        IEnumerable<User> GetTeachersByInstitutionId(int? institutionId);
    }
}
