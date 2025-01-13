using DigitalClassroom.DataAccessLayer.Interfaces;
using DigitalClassroom.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalClassroom.DataAccessLayer.Repositories
{
    public class AssignmentRepository : GenericRepository<Assignment>, IAssignmentRepository
    {
        private readonly DbContext _context;
        public AssignmentRepository(DbContext context) : base(context)
        {
            _context = context;
        }

        public void DeleteAssignmentAndStudentSubmissions(int assignmentId)
        {
            // Önce öğrenci gönderimlerini sil
            var submissions = _context.Set<StudentSubmission>().Where(s => s.AssignmentId == assignmentId);
            if (submissions.Count() > 0)
                _context.Set<StudentSubmission>().RemoveRange(submissions);

            // Sonra görevi sil
            var assignment = _context.Set<Assignment>().Find(assignmentId);
            if (assignment != null)
            {
                _context.Set<Assignment>().Remove(assignment);
            }
            _context.SaveChanges();
        }
    }
}