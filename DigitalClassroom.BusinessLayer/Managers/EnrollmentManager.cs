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
    public class EnrollmentManager : IEnrollmentService
    {
        private readonly IEnrollmentRepository _enrollmentRepository;

        public EnrollmentManager(IEnrollmentRepository enrollmentRepository)
        {
            _enrollmentRepository = enrollmentRepository;
        }
        public void Add(Enrollment entity)
        {
            _enrollmentRepository.Add(entity);
        }

        public void Delete(Enrollment entity)
        {
            _enrollmentRepository.Delete(entity);
        }

        public IEnumerable<Enrollment> Find(Expression<Func<Enrollment, bool>> predicate)
        {
            return _enrollmentRepository.Find(predicate);
        }

        public IEnumerable<Enrollment> GetAll()
        {
             return _enrollmentRepository.GetAll();
        }

        public Enrollment GetById(int id)
        {
            return _enrollmentRepository.GetById(id);
        }

        public void Update(Enrollment entity)
        {
            _enrollmentRepository.Update(entity);
        }
    }
}
