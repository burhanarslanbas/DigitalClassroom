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
    public class AssignmentManager : IAssignmentService
    {
        private readonly IAssignmentRepository _assignmentRepository;
        public AssignmentManager(IAssignmentRepository assignmentRepository)
        {
            _assignmentRepository = assignmentRepository;
        }
        public void Add(Assignment entity)
        {
            _assignmentRepository.Add(entity);
        }

        public void Delete(Assignment entity)
        {
            _assignmentRepository.Delete(entity);
        }

        public void DeleteAssignmentAndStudentSubmissions(int assignmentId)
        {
            _assignmentRepository.DeleteAssignmentAndStudentSubmissions(assignmentId);
        }

        public IEnumerable<Assignment> Find(Expression<Func<Assignment, bool>> predicate)
        {
            return _assignmentRepository.Find(predicate);
        }

        public IEnumerable<Assignment> GetAll()
        {
            return _assignmentRepository.GetAll();
        }

        public Assignment GetById(int id)
        {
            return _assignmentRepository.GetById(id);
        }

        public void Update(Assignment entity)
        {
            _assignmentRepository.Update(entity);
        }
    }
}
