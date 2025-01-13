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
    public class RoleManager : IRoleService
    {
        private readonly IRoleRepository _roleRepository;
        public RoleManager(IRoleRepository roleRepository)
        {
            _roleRepository = roleRepository;
        }
        public void Add(Role entity)
        {
            _roleRepository.Add(entity);
        }

        public void Delete(Role entity)
        {
            _roleRepository.Delete(entity);
        }

        public IEnumerable<Role> Find(Expression<Func<Role, bool>> predicate)
        {
            return _roleRepository.Find(predicate);
        }

        public IEnumerable<Role> GetAll()
        {
            return _roleRepository.GetAll();
        }

        public Role GetById(int id)
        {
            return _roleRepository.GetById(id);
        }

        public void Update(Role entity)
        {
            _roleRepository.Update(entity);
        }
    }
}
