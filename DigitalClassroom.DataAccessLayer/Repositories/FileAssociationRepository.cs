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
    public class FileAssociationRepository: GenericRepository<FileAssociation>,IFileAssociationRepository
    {
        private readonly DbContext _context;
        public FileAssociationRepository(DbContext context) : base(context)
        {
            _context = context;
        }
    }
}
