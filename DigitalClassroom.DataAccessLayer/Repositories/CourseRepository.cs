using DigitalClassroom.DataAccessLayer.Interfaces;
using DigitalClassroom.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DigitalClassroom.DataAccessLayer.Repositories
{
    public class CourseRepository : GenericRepository<Course>, ICourseRepository
    {
        private readonly DbContext _context;
        //Kurucu metot ile aldığımız DbContext nesnesini base sınıfa gönderiyoruz. Bu sayede GenericRepository sınıfının kurucu metotu çalışmış olacak.
        public CourseRepository(DbContext context) : base(context)
        {
            _context = context;
        }
        // Öğretmenin verdiği dersleri getiren metot
        public IEnumerable<Course> GetCoursesByTeacherId(int teacherId)
        {
            // TeacherId si verilen öğretmenin verdiği derslerin listesini getir
            return _context.Set<Course>().Where(c => c.TeacherId == teacherId).ToList();
        }
    }
}