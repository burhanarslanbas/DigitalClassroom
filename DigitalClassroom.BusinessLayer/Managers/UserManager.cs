using DigitalClassroom.BusinessLayer.Interfaces;
using DigitalClassroom.DataAccessLayer.Interfaces;
using DigitalClassroom.DataAccessLayer.Repositories;
using DigitalClassroom.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DigitalClassroom.BusinessLayer.Managers
{
    public class UserManager : IUserService
    {
        private readonly IUserRepository _userRepository;
        public UserManager(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public void Add(User entity)
        {
            _userRepository.Add(entity);
        }

        public User AuthenticateUser(string email, string password)
        {
            var user = _userRepository.AuthenticateUser(email, password);
            if (user == null)
            {
                throw new Exception("E-Posta veya şifre hatalı.");
            }
            return user;
        }

        public void Delete(User entity)
        {
            _userRepository.Delete(entity);
        }

        public IEnumerable<User> Find(Expression<Func<User, bool>> predicate)
        {
            return _userRepository.Find(predicate);
        }

        public IEnumerable<User> GetAll()
        {
            return _userRepository.GetAll();
        }

        public User GetById(int id)
        {
            return _userRepository.GetById(id);
        }

        public Role GetRoleById(int roleId)
        {
            Role role = new Role();
            role.Id = roleId;
            switch (roleId)
            {
                case 1:
                    role.RoleName = "Admin";
                    break;
                case 2:
                    role.RoleName = "Manager";
                    break;
                case 3:
                    role.RoleName = "Teacher";
                    break;
                case 4:
                    role.RoleName = "Student";
                    break;
                default:
                    throw new NotImplementedException();
            }
            return role;
        }

        public IEnumerable<User> GetTeachersByInstitutionId(int? institutionId)
        {
            return _userRepository.GetTeachersByInstitutionId(institutionId);
        }

        public void Update(User entity)
        {
            _userRepository.Update(entity);
        }
    }
}
