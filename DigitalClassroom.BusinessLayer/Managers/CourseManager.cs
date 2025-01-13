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
    public class CourseManager : ICourseService
    {
        private readonly ICourseRepository _courseRepository;

        public CourseManager(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }

        public void Add(Course entity)
        {
            _courseRepository.Add(entity);
        }

        public void Delete(Course entity)
        {
            _courseRepository.Delete(entity);
        }

        public IEnumerable<Course> Find(Expression<Func<Course, bool>> predicate)
        {
            return _courseRepository.Find(predicate);
        }

        public IEnumerable<Course> GetClassesByInstitutionId(int? institutionId)
        {
            if (institutionId == null)
                return _courseRepository.GetAll();
            else
                return _courseRepository.Find(c => c.InstitutionId == institutionId && c.IsActive);
        }

        public IEnumerable<Course> GetAll()
        {
            return _courseRepository.GetAll();
        }

        public Course GetById(int id)
        {
            return _courseRepository.GetById(id);
        }

        public void Update(Course entity)
        {
            _courseRepository.Update(entity);
        }
    }
}
