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
    public class RoleRepository : GenericRepository<Role>, IRoleRepository
    {
        private readonly DbContext _context;
        public RoleRepository(DbContext context) : base(context)
        {
            _context = context;
        }
    }
}
