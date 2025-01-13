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
    public class StudentSubmissionManager : IStudentSubmissionService
    {
        private readonly IStudentSubmissionRepository _studentSubmissionRepository;
        public StudentSubmissionManager(IStudentSubmissionRepository studentSubmissionRepository)
        {
            _studentSubmissionRepository = studentSubmissionRepository;
        }
        public void Add(StudentSubmission entity)
        {
            _studentSubmissionRepository.Add(entity);
        }

        public void Delete(StudentSubmission entity)
        {
            _studentSubmissionRepository.Delete(entity);
        }

        public IEnumerable<StudentSubmission> Find(Expression<Func<StudentSubmission, bool>> predicate)
        {
            return _studentSubmissionRepository.Find(predicate);
        }

        public IEnumerable<StudentSubmission> GetAll()
        {
            return _studentSubmissionRepository.GetAll();
        }

        public StudentSubmission GetById(int id)
        {
            return _studentSubmissionRepository.GetById(id);
        }

        public void Update(StudentSubmission entity)
        {
           _studentSubmissionRepository.Update(entity); 
        }
    }
}
