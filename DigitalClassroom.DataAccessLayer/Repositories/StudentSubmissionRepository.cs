using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DigitalClassroom.DataAccessLayer.Interfaces;
using DigitalClassroom.EntityLayer.Concrete;
using System.Data.Entity;

namespace DigitalClassroom.DataAccessLayer.Repositories
{
    public class StudentSubmissionRepository : GenericRepository<StudentSubmission>, IStudentSubmissionRepository
    {
        private readonly DbContext _context;
        public StudentSubmissionRepository(DbContext context) : base(context)
        {
            _context = context;
        }
    }
}